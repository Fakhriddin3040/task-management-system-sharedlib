using TaskManagementSystem.SharedLib.Algorithms.NumeralRank;

namespace TaskManagementSystem.SharedLib.Algorithms.NumeralRank.Interfaces;


public interface INumeralRankStrategySelector
{
    INumeralRankStrategy GetStrategy(NumeralRankContext context);
}
