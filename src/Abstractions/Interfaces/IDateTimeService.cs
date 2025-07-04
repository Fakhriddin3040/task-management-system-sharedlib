namespace TaskManagementSystem.SharedLib.Abstractions.Interfaces;


public interface IDateTimeService
{
    DateTime Now { get; }
    DateTime UtcNow { get; }
    DateOnly Today { get; }
    DateOnly UtcToday { get; }
    int UnixEpochSeconds(DateTime dateTime);
}
