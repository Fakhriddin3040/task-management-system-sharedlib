using Grpc.Core;
using TaskManagementSystem.SharedLib.DTO;
using TaskManagementSystem.SharedLib.Enums.StrEnums;
using TaskManagementSystem.SharedLib.Providers.Interfaces;

namespace TaskManagementSystem.SharedLib.Providers;


public sealed class GrpcExecutionContextProvider : IExecutionContextProvider
{
    private ServerCallContext? _context = null!;

    public void SetContext(ServerCallContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public ExecutionContextDto GetContext()
    {
        if (_context is null)
        {
            throw new InvalidOperationException("Grpc execution context provider is not initialized.");
        }

        var user = _context.RequestHeaders.GetValue(ExecutionContextKeys.User);
        var traceId = _context.RequestHeaders.GetValue(ExecutionContextKeys.TraceId);

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
