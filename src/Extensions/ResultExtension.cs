using TaskManagementSystem.SharedLib.Exceptions;
using TaskManagementSystem.SharedLib.Handlers;

namespace TaskManagementSystem.SharedLib.Extensions;



public static class ResultExtension
{
    public static T GetValueOrThrow<T>(this Result<T> result)
    {
        if (result.IsSuccess)
        {
            if (result.Value is null)
            {
                throw new InvalidOperationException("Result was successful but the value is null.");
            }
            return result.Value;
        }

        throw CreateExceptionFrom(result);
    }

    public static void EnsureSuccessOrThrow<T>(this Result<T> result)
    {
        if (result.IsFailure)
        {
            throw CreateExceptionFrom(result);
        }
    }

    public static Exception CreateExceptionFrom<T>(this Result<T> result)
    {
        if (result.ErrorDetails.Any())
        {
            return new AppException(
                details: result.ErrorDetails
            );
        }
        return new ArgumentException(
            "Result is not successful and no exception details are provided.");
    }

    public static string ErrorDetailsToJson<T>(this Result<T> result)
    {
        return "[" + string.Join("\n", result.ErrorDetails.Select(d => d.ToJson().ToString()).ToArray()) + "]";
    }
}
