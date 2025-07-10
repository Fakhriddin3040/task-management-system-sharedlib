using TaskManagementSystem.SharedLib.Abstractions.Interfaces;

namespace TaskManagementSystem.AuthService.Core.ValueObjects;


public class Timestamps
{
    private readonly IDateTimeService _dateTimeService;

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    private Timestamps() {}

    public Timestamps(IDateTimeService dateTimeService)
    {
        _dateTimeService = dateTimeService;
        CreatedAt = _dateTimeService.UtcNow;
        UpdatedAt = CreatedAt;
    }

    public Timestamps(DateTime createdAt, DateTime updatedAt)
    {
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    public void Touch()
    {
        UpdatedAt = _dateTimeService.UtcNow;
    }
}
