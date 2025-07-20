using TaskManagementSystem.SharedLib.Abstractions.Interfaces;

namespace TaskManagementSystem.AuthService.Core.ValueObjects;


public class Timestamps
{
    public Int64 CreatedAt { get; set; }
    public Int64 UpdatedAt { get; set; }

    private Timestamps() {}

    public static Timestamps FromDateTimeService(IDateTimeService dateTimeService)
    {
        return new Timestamps {
            CreatedAt = dateTimeService.UnixEpochMilliseconds(),
            UpdatedAt = dateTimeService.UnixEpochMilliseconds()
        };
    }

    public Timestamps(Int64 createdAt, Int64 updatedAt)
    {
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    public void Touch(IDateTimeService dateTimeService)
    {
        UpdatedAt = dateTimeService.UnixEpochMilliseconds();
    }
}
