namespace TaskManagementSystem.SharedLib.ValueObjects;


public class AuthorInfo
{
    public Guid CreatedById { get; set; }
    public Guid? UpdatedById { get; set; }

    public AuthorInfo(Guid createdById, Guid updatedById)
    {
        CreatedById = createdById;
        UpdatedById = updatedById;
    }

    public void Update(Guid updatedById)
    {
        UpdatedById = updatedById;
    }
}
