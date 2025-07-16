using TaskManagementSystem.SharedLib.Abstractions.Interfaces;

namespace TaskManagementSystem.AuthService.Core.ValueObjects;


public class Timestamps
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    private Timestamps() {}

    public static Timestamps FromDateTimeService(IDateTimeService dateTimeService)
    {
        return new Timestamps {
            CreatedAt = dateTimeService.UtcNow,
            UpdatedAt = dateTimeService.UtcNow,
        };
    }

    public Timestamps(DateTime createdAt, DateTime updatedAt)
    {
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    public void Touch(IDateTimeService dateTimeService)
    {
        UpdatedAt = dateTimeService.UtcNow;
    }
}
