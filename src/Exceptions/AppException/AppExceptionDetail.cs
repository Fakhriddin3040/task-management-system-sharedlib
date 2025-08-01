using System.Text.Json.Nodes;
using TaskManagementSystem.SharedLib.Abstractions;
using TaskManagementSystem.SharedLib.Enums.Exceptions;

namespace TaskManagementSystem.SharedLib.Exceptions;


public record AppExceptionDetail(AppExceptionStatusCode StatusCode, IModelField Field)
{
    public IModelField Field = Field;
    public AppExceptionStatusCode StatusCode = StatusCode;

    public JsonObject ToJson()
    {
        var json = new JsonObject {
            ["field"] = Field.Value,
            ["statusCode"] = (int)StatusCode
        };
        return json;
    }
}
