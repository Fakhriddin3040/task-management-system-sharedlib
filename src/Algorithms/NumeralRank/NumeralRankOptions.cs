namespace TaskManagementSystem.SharedLib.Algorithms.NumeralRank;


public static class NumeralRankOptions
{
    public const long Default = 1_000_000_000_000L;
    public const long MaxRank = Int64.MaxValue;
    public const long MinRank = 0L;
    public const long DefaultStep = Default;
    public const long MinGap = 10_000L;
    public const long Empty = -1L;
    public const long NeedReordering = -2L;
    public const long ValidAfter = -1L;

    // Shifts for bit manipulation in numeral rank calculations
    public const ushort EmptyShift = 7;
    public const ushort NeedReorderingShift = 6;
}
