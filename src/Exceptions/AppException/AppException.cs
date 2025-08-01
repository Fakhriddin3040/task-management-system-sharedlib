using System.Text.Json.Nodes;
using TaskManagementSystem.SharedLib.Enums.Exceptions;

namespace TaskManagementSystem.SharedLib.Exceptions;

public class AppException : Exception
{
    public AppExceptionStatusCode StatusCode { get; }
    public IEnumerable<AppExceptionDetail> Details { get; }

    public AppException(string message, AppExceptionStatusCode statusCode)
        : base(message)
    {
        StatusCode = statusCode;
        Details = [];
    }

    public AppException(
        IEnumerable<AppExceptionDetail> details, string message = AppExceptionErrorMessages.DetailedError)
        : base("Validation failed.")
    {
        StatusCode = AppExceptionStatusCode.DetailedError;
        Details = details;
    }

    public static AppException NotFound()
    {
        return new(message: AppExceptionErrorMessages.NotFound, statusCode: AppExceptionStatusCode.NotFound);
    }

    public static AppException InternalServerError()
    {
        return new(message: AppExceptionErrorMessages.InternalServerError, statusCode: AppExceptionStatusCode.InternalServerError);
    }

    public JsonObject ToJson()
    {
        var json = new JsonObject
        {
            ["message"] = Message,
            ["statusCode"] = (int)StatusCode
        };

        if (!Details.Any())
            return json;

        var detailsJson = new JsonArray(
            Details.Select(d => d.ToJson()).ToArray<JsonNode?>());
        json["details"] = detailsJson;
        json["status_code"] = (int)AppExceptionStatusCode.DetailedError;

        return json;
    }
}
