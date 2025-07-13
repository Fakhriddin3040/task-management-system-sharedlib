namespace TaskManagementSystem.TaskBoardService.Core.Interfaces.Policies;


public interface IOrganizationExistsPolicy
{
    Task<bool> ExistsAsync(Guid organizationId, CancellationToken cancellationToken);
}
