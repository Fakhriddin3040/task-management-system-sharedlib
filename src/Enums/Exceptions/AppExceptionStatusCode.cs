namespace TaskManagementSystem.SharedLib.Enums.Exceptions;


public enum AppExceptionStatusCode
{
    // Validation < 100 < 0
    UniqueConstraints = 1,
    ValueError = 2,
    InvalidFormat = 3,
    RequiredField = 4,

    // Authorization < 200 < 100
    InvalidCredentials = 101,

    // COMMON > 999,
    DetailedError = 1000
}
