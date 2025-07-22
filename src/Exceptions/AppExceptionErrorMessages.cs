namespace TaskManagementSystem.SharedLib.Exceptions;


public sealed record AppExceptionErrorMessages
{
    // Validation
    public const string UniqueConstraint = "Unique constraint violation.";
    public const string RequiredField = "Required field is missing.";
    public const string InvalidFormat = "Invalid format for the provided value.";
    public const string NotFound = "The requested resource was not found.";
    public const string InvalidValue = "The invalid value was provided.";


    // Authorization
    public const string InvalidCredentials = "Invalid credentials provided.";
    public const string InvalidLoginCredentials = "Invalid login credentials.";

    // Internal
    public const string InternalServerError = "An internal server error occurred.";

    // Others
    public const string DetailedError = "Detailed error.";
}
