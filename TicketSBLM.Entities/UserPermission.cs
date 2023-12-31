public class UserPermission
{
    public int UserId { get; set; }
    public int PermissionId { get; set; }

    // Relationships
    public virtual User User { get; set; }
    public virtual Permission Permission { get; set; }
}