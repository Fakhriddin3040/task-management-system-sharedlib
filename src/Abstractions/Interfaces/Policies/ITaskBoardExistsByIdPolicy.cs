namespace TaskManagementSystem.SharedLib.Abstractions.Interfaces.Policies;


public interface ITaskBoardExistsByIdPolicy
{
    /// <summary>
    /// Checks if a task board exists by its ID.
    /// </summary>
    /// <param name="taskBoardId">The ID of the task board to check.</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
    /// <returns>True if the task board exists, otherwise false.</returns>
    Task<bool> ExistsAsync(Guid taskBoardId, CancellationToken cancellationToken);
}
