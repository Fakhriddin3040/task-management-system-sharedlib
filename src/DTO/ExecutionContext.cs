namespace TaskManagementSystem.SharedLib.DTO;


public sealed class ExecutionContext
{
    public SystemUserDto User { get; init; }
    public string TraceId { get; init; }

    public ExecutionContext(SystemUserDto user, string traceId)
    {
        User = user;
        TraceId = traceId;
    }
}
