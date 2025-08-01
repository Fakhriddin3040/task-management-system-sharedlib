using System.Text.Json.Nodes;

namespace TaskManagementSystem.SharedLib.Exceptions;


public static class AppExceptionHandler
{
    public static JsonObject ToJson(AppException exception)
    {
        return exception.ToJson();
    }
}
