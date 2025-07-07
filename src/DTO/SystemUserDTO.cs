using System.Text.Json;

namespace TaskManagementSystem.SharedLib.DTO;

public class SystemUserDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }

    public static SystemUserDto FromJson(string json)
    {
        var result = JsonSerializer.Deserialize<SystemUserDto>(json);
        if (result == null)
        {
            throw new InvalidOperationException("Deserialization failed, result is null.");
        }

        return result;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
}
