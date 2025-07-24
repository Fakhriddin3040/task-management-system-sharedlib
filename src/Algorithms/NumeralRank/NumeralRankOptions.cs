namespace TaskManagementSystem.SharedLib.Algorithms.NumeralRank;


public static class NumeralRankOptions
{
    public const long Default = 1_000_000_000_000L;
    public const long Max = Int64.MaxValue;
    public const long Min = 0L;
    public const long DefaultStep = Default;
    public const long MinStep = 10_000L;
    public const long Empty = -1L;
    public const long NeedReordering = -2L;
    public const long ValidAfter = -1L;
}
