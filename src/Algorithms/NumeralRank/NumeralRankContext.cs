namespace TaskManagementSystem.SharedLib.Algorithms.NumeralRank;


public readonly struct NumeralRankContext(long PreviousRank, long NextRank)
{
    public long PreviousRank { get; } = PreviousRank;
    public long NextRank { get; } = NextRank;

    public override string ToString() => $"Previous Rank: {PreviousRank}, Next Rank: {NextRank}";

    public bool IsFirstRank => PreviousRank == NumeralRankOptions.Empty && NextRank == NumeralRankOptions.Empty;
    public bool IsToTop => PreviousRank == NumeralRankOptions.Empty && NextRank != NumeralRankOptions.Empty;
    public bool IsToEnd => PreviousRank != NumeralRankOptions.Empty && NextRank == NumeralRankOptions.Empty;
    public bool IsBetween => PreviousRank != NumeralRankOptions.Empty && NextRank != NumeralRankOptions.Empty;
}
