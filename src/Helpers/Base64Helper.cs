namespace TaskManagementSystem.SharedLib.Helpers;


public static class Base64Helper
{
    public static string ToBase64String(this byte[] bytes)
    {
        if (bytes == null || bytes.Length == 0)
        {
            throw new ArgumentNullException(nameof(bytes), "Input byte array cannot be null or empty.");
        }
        return Convert.ToBase64String(bytes);
    }

    public static string Base64UrlToBase64(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException(nameof(input), "Input string cannot be null or empty.");
        }

        var base64 = input
            .Replace('-', '+')
            .Replace('_', '/');

        int padding = (4 - base64.Length % 4) % 4;
        base64 = base64.PadRight(base64.Length + padding, '=');

        return base64;
    }
}
