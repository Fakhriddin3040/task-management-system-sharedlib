namespace TaskManagementSystem.SharedLib.Abstractions.Interfaces;


public interface IUserUniqueEmailPolicy
{
    /// <summary>
    /// Checks if the email is unique.
    /// </summary>
    /// <param name="email">The email to check.</param>
    /// <returns>True if the email is unique, otherwise false.</returns>
    Task<bool> IsUniqueEmailAsync(string email, CancellationToken cancellationToken);
}
