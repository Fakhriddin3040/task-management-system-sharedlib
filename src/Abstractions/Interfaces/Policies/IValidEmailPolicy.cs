namespace TaskManagementSystem.SharedLib.Abstractions.Interfaces;


public interface IValidEmailPolicy
{
    bool IsValid(string email);
}
