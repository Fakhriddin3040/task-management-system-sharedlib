namespace TaskManagementSystem.SharedLib.Abstractions.Interfaces;


public interface IValidPasswordPolicy
{
    bool IsValid(string password);
}