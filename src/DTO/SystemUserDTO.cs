namespace TaskManagementSystem.SharedLib.DTO;

public class SystemUserDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public bool Verified { get; set; }
    public bool? IsAdmin { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
