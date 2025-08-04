
using TaskManagementSystem.SharedLib.Algorithms.NumeralRank.Interfaces;

namespace TaskManagementSystem.SharedLib.Algorithms.NumeralRank.Strategies;


public class FirstNumeralRankStrategy : INumeralRankStrategy
{
    public NumeralRankResult GenerateRank(NumeralRankContext context)
    {
        return new(
            rank: NumeralRankOptions.Default
        );
    }

    public bool CanHandle(NumeralRankContext context)
    {
        return context.IsFirstRank;
    }
}
