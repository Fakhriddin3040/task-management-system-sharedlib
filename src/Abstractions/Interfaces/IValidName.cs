namespace TaskManagementSystem.SharedLib.Abstractions.Interfaces;


public interface IValidNamePolicy
{
    // For example, a valid name for organization or users username...
    bool IsValid(string name);
}
