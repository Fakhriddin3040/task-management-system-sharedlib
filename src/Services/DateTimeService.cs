using TaskManagementSystem.SharedLib.Abstractions.Interfaces;

namespace TaskManagementSystem.SharedLib.Services;


public class DateTimeService : IDateTimeService
{
    public DateTime Now => DateTime.UtcNow;
    public DateTime UtcNow => DateTime.UtcNow;
    public DateOnly Today => DateOnly.FromDateTime(Now);
    public DateOnly UtcToday => DateOnly.FromDateTime(UtcNow);

    public int UnixEpochSeconds(DateTime dateTime)
    {
        return (int)(dateTime - new DateTime(1970, 1, 1)).TotalSeconds;
    }
    public long UnixEpochMilliseconds(DateTime dateTime)
    {
        return (long)(dateTime - new DateTime(1970, 1, 1)).TotalMilliseconds;
    }
    public long UnixEpochMilliseconds()
    {
        return (long)(Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
    }
}
