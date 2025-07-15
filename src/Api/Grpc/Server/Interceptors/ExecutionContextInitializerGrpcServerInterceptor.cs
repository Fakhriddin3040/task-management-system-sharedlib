using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Logging;
using TaskManagementSystem.SharedLib.DTO;
using TaskManagementSystem.SharedLib.Enums.StrEnums;
using TaskManagementSystem.SharedLib.Providers.Interfaces;
using ExecutionContext = TaskManagementSystem.SharedLib.DTO.ExecutionContext;

namespace TaskManagementSystem.SharedLib.Api.Grpc.Server.Interceptors;


public sealed class ExecutionContextInitializerGrpcServerInterceptor : Interceptor
{
    private readonly IExecutionContextProvider _executionContextProvider;
    private readonly ILogger<ExecutionContextInitializerGrpcServerInterceptor> _logger;

    public ExecutionContextInitializerGrpcServerInterceptor(IExecutionContextProvider executionContextProvider, ILogger<ExecutionContextInitializerGrpcServerInterceptor> logger)
    {
        _executionContextProvider = executionContextProvider;
        _logger = logger;
    }

    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
    {
        _logger.LogDebug("Initializing execution context in gRPC call.. Method: {Method}", context.Method);

        // Initialize the execution context
        var executionContext = ParseExecutionContext(context);

        _executionContextProvider.SetContext(executionContext);

        _logger.LogDebug(
            "Execution context initialized. User: {User}, TraceId: {TraceId}",
            executionContext.User,
            executionContext.TraceId
        );

        return await continuation(request, context);
    }

    private ExecutionContext ParseExecutionContext(ServerCallContext context)
    {
        if (context is null)
        {
            throw new InvalidOperationException("Grpc execution context provider is not initialized.");
        }

        var user = context.RequestHeaders.GetValue(ExecutionContextKeys.User);
        var traceId = context.RequestHeaders.GetValue(ExecutionContextKeys.TraceId);

        if (string.IsNullOrEmpty(user))
        {
            throw new InvalidOperationException("No user claim found.");
        }
        if (string.IsNullOrEmpty(traceId))
        {
            throw new InvalidOperationException("No trace ID found.");
        }

        return new(
            user: SystemUserDto.FromJson(user),
            traceId: traceId
        );
    }
}
