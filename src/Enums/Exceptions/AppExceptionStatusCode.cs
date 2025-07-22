namespace TaskManagementSystem.SharedLib.Enums.Exceptions;


public enum AppExceptionStatusCode
{
    // Validation < 100 < 0
    UniqueConstraints = 1,
    ValueError = 2,
    InvalidFormat = 3,
    RequiredField = 4,
    NotFound = 5,
    InvalidValue = 6,

    // Authorization < 200 < 100
    InvalidCredentials = 101,

    // Internal < 300 < 200
    InternalServerError = 201,

    // COMMON > 999,
    DetailedError = 1000
}
