namespace TaskManagementSystem.SharedLib.Extensions;


public static class StringExtension
{
    public static string ValueOrEmpty(this string? value)
    {
        return string.IsNullOrEmpty(value) ? string.Empty : value;
    }

    public static Guid ToGuidOrDefault(this string value)
    {
        return string.IsNullOrEmpty(value) ? Guid.Empty : Guid.Parse(value);
    }
}
