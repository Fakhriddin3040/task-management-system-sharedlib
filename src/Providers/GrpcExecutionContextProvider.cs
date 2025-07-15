using Grpc.Core;
using TaskManagementSystem.SharedLib.DTO;
using TaskManagementSystem.SharedLib.Enums.StrEnums;
using TaskManagementSystem.SharedLib.Providers.Interfaces;
using ExecutionContext = TaskManagementSystem.SharedLib.DTO.ExecutionContext;

namespace TaskManagementSystem.SharedLib.Providers;


public sealed class GrpcExecutionContextProvider : IExecutionContextProvider
{
    private ExecutionContext _context;

    public void SetContext(ExecutionContext context)
    {
        _context = context;
    }

    public ExecutionContext GetContext()
    {
        if (_context == null)
        {
            throw new RpcException(new Status(StatusCode.Internal, "Execution context is not set."));
        }

        return _context;
    }
}
