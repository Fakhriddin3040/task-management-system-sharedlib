using TaskManagementSystem.SharedLib.Algorithms.NumeralRank;
using TaskManagementSystem.SharedLib.Algorithms.NumeralRank.Interfaces;


namespace TaskManagementSystem.SharedLib.Algorithms.NumeralRank;


public class NumeralRankStrategySelector : INumeralRankStrategySelector
{
    private readonly IEnumerable<INumeralRankStrategy> _strategies;

    public NumeralRankStrategySelector(IEnumerable<INumeralRankStrategy> strategies)
    {
        _strategies = strategies;
    }

    public INumeralRankStrategy GetStrategy(NumeralRankContext context)
    {
        return _strategies.First(s => s.CanHandle(context));
    }
}
