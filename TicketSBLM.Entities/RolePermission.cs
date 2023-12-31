public class RolePermission
{
    public int RoleId { get; set; }
    public int PermissionId { get; set; }

    // Relationships
    public virtual Role Role { get; set; }
    public virtual Permission Permission { get; set; }
}