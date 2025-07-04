using TaskManagementSystem.SharedLib.Abstractions.Interfaces;

namespace TaskManagementSystem.AuthService.Core.ValueObjects;


public class Timestamps
{
    private readonly IDateTimeService _dateTimeService;

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Timestamps(IDateTimeService dateTimeService)
    {
        _dateTimeService = dateTimeService;
        CreatedAt = _dateTimeService.UtcNow;
    }

    public void Update()
    {
        UpdatedAt = _dateTimeService.UtcNow;
    }
}
