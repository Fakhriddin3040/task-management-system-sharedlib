namespace TaskManagementSystem.SharedLib.Exceptions;


public class AppUnexpectedException : Exception
{
    public AppUnexpectedException()
        : base("An unexpected error occurred in the application.")
    {
    }
}
