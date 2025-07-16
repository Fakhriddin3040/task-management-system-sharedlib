using TaskManagementSystem.SharedLib.Exceptions;


namespace TaskManagementSystem.SharedLib.Handlers;


public sealed class Result<T>
{
    public T Value { get; } = default!;
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public IReadOnlyList<AppExceptionDetail> ErrorDetails { get; }

    private Result(T value)
    {
        Value = value;
        IsSuccess = true;
        ErrorDetails = Array.Empty<AppExceptionDetail>();
    }

    private Result(IEnumerable<AppExceptionDetail> errorDetails)
    {
        IsSuccess = false;
        ErrorDetails = errorDetails.ToList();
    }

    public static Result<T> Empty() => new([]);

    public static Result<T> Success(T value) => new(value);

    public static Result<T> Failure(params AppExceptionDetail[] details) =>
        new(details);

    public static Result<T> Failure(IEnumerable<AppExceptionDetail> details) =>
        new(details);
}
