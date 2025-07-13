using TaskManagementSystem.SharedLib.Abstractions;

namespace TaskManagementSystem.SharedLib.Models.Fields;


public sealed record TaskBoardField(string Value) : ModelField<TaskBoardField>(Value)
{
    public static readonly TaskBoardField Name;
    public static readonly TaskBoardField Description;
    public static readonly TaskBoardField Organization;

    static TaskBoardField()
    {
        Name = new TaskBoardField("name");
        Description = new TaskBoardField("description");
        Organization = new TaskBoardField("organization");
    }

    public override TaskBoardField AsForeignKey() => new($"{Value}_id");
}
