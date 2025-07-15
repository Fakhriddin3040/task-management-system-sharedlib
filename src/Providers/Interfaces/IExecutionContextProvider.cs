using TaskManagementSystem.SharedLib.DTO;
using ExecutionContext = TaskManagementSystem.SharedLib.DTO.ExecutionContext;

namespace TaskManagementSystem.SharedLib.Providers.Interfaces;


public interface IExecutionContextProvider
{
    /// <summary>
    /// Retrieves the current context.
    /// </summary>
    void SetContext(ExecutionContext context);
    ExecutionContext GetContext();
}
