using TaskManagementSystem.SharedLib.Abstractions;

namespace TaskManagementSystem.SharedLib.Models.Fields;


public record TaskField(string Value) : ModelField<TaskField>(Value)
{

    public static TaskField Id = new("id");
    public static TaskField Name = new("name");
    public static TaskField Description = new("description");
    public static TaskField AssignedTo = new("assigned_to");
    public static TaskField BoardId = new("board_id");
    public static TaskField ColumnId = new("column_id");

    public override IModelField AsForeignKey()
    {
        return new TaskField($"{Value}_id");
    }
}
