namespace TaskManagementSystem.SharedLib.Algorithms.NumeralRank.Interfaces;


public interface INumeralRankValidationStrategy
{
    Task<bool> ValidateAsync(NumeralRankContext numeralRankContext);
    bool CanHandle(NumeralRankContext numeralRankContext);
}
