using Grpc.Core;
using Grpc.Core.Interceptors;
using TaskManagementSystem.SharedLib.Enums.StrEnums;
using TaskManagementSystem.SharedLib.Providers.Interfaces;

namespace TaskManagementSystem.SharedLib.Api.Grpc.Client.Interceptors;


public class AuthenticateUserGrpcClientInterceptor : Interceptor
{
    private readonly IExecutionContextProvider _contextProvider;

    public AuthenticateUserGrpcClientInterceptor(IExecutionContextProvider contextProvider)
    {
        _contextProvider = contextProvider;
    }

    public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
    {
        var headers = context.Options.Headers ?? new Metadata();
        var executionContext = _contextProvider.GetContext();

        headers.Add(ExecutionContextKeys.User, executionContext.User.ToJson());
        headers.Add(ExecutionContextKeys.TraceId, executionContext.TraceId);

        var newOptions = context.Options.WithHeaders(headers);

        var newContext = new ClientInterceptorContext<TRequest, TResponse>(
            context.Method,
            context.Host,
            newOptions
        );

        return base.AsyncUnaryCall(request, newContext, continuation);
    }}
