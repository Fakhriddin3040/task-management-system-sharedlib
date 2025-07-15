using System.Text.Json;

namespace TaskManagementSystem.SharedLib.DTO;

public class SystemUserDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }

    public static SystemUserDto FromJson(string json)
    {
        var result = JsonSerializer.Deserialize<SystemUserDto>(json, new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true
        });

        if (result is null || result.Id == Guid.Empty || string.IsNullOrEmpty(result.Email))
        {
            throw new InvalidOperationException("Deserialization failed. One or more properties are invalid.");
        }

        return result;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
}
