using TaskManagementSystem.SharedLib.Algorithms.NumeralRank.Interfaces;

namespace TaskManagementSystem.SharedLib.Algorithms.NumeralRank.Strategies;


public class TopNumeralRankStrategy : INumeralRankStrategy
{
    public NumeralRankResult GenerateRank(NumeralRankContext context)
    {
        return new(
            rank: context.NextRank / 2);
    }
    public bool CanHandle(NumeralRankContext context)
    {
        return context.IsToTop;
    }
}
