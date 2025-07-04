namespace TaskManagementSystem.SharedLib.Exceptions;


public sealed record AppExceptionErrorMessages
{
    // Validation
    public const string UniqueConstraint = "Unique constraint violation.";
    public const string RequiredField = "Required field is missing.";
    public const string InvalidFormat = "Invalid format for the provided value.";


    // Authorization
    public const string InvalidCredentials = "Invalid credentials provided.";
    public const string InvalidLoginCredentials = "Invalid login credentials.";


    // Others
    public const string DetailedError = "Detailed error.";
}
