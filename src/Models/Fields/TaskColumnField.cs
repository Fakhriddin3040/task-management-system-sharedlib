using TaskManagementSystem.SharedLib.Abstractions;

namespace TaskManagementSystem.SharedLib.Models.Fields;


public sealed record TaskColumnField(string Value) : ModelField<TaskColumnField>(Value)
{
    public static TaskColumnField Name;
    public static TaskColumnField Description;
    public static TaskColumnField Order;
    public static TaskColumnField Board;

    static TaskColumnField()
    {
        Name = new TaskColumnField("name");
        Description = new TaskColumnField("description");
        Order = new TaskColumnField("order");
        Board = new TaskColumnField("board");
    }

    public override TaskColumnField AsForeignKey()
    {
        return new($"{Value}_id");
    }
}
