using Grpc.Core;
using Grpc.Core.Interceptors;
using TaskManagementSystem.SharedLib.Exceptions;

namespace TaskManagementSystem.SharedLib.Api.Grpc.Server.Interceptors;


public class GrpcExceptionInterceptor : Interceptor
{
    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
    {
        try
        {
            return await continuation(request, context);
        }
        catch (AppException e)
        {
            throw new Exception(e.Message);
        }
    }

}
