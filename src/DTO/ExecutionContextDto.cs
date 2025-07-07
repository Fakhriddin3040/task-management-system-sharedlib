namespace TaskManagementSystem.SharedLib.DTO;


public sealed class ExecutionContextDto
{
    public SystemUserDto User { get; init; }
    public string TraceId { get; init; }

    public ExecutionContextDto(SystemUserDto user, string traceId)
    {
        User = user;
        TraceId = traceId;
    }
}
