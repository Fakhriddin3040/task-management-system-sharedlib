using TaskManagementSystem.SharedLib.Abstractions;

namespace TaskManagementSystem.SharedLib.Models.Fields;


public sealed record UserFields(string Value) : ModelField<UserFields>(Value)
{
    public static readonly UserFields Email;
    public static readonly UserFields Password;

    static UserFields()
    {
        Password = new UserFields("password");
        Email = new UserFields("email");
    }
}
