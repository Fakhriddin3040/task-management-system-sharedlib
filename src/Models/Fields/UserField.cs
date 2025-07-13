using TaskManagementSystem.SharedLib.Abstractions;

namespace TaskManagementSystem.SharedLib.Models.Fields;


public sealed record UserField(string Value) : ModelField<UserField>(Value)
{
    public static readonly UserField Email;
    public static readonly UserField Password;

    static UserField()
    {
        Password = new UserField("password");
        Email = new UserField("email");
    }

    public override UserField AsForeignKey() => new($"{Value}_id");
}
