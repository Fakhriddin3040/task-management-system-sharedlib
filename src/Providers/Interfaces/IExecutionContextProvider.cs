using TaskManagementSystem.SharedLib.DTO;

namespace TaskManagementSystem.SharedLib.Providers.Interfaces;


public interface IExecutionContextProvider
{
    /// <summary>
    /// Retrieves the current context.
    /// </summary>

    ExecutionContextDto GetContext();
}
