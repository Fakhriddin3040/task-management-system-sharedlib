namespace TaskManagementSystem.SharedLib.Interfaces.Policies;


public interface IOrganizationExistsPolicy
{
    Task<bool> ExistsAsync(Guid organizationId, CancellationToken cancellationToken);
}
