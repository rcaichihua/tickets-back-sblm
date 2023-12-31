using System.Collections;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Relationships
    public virtual ICollection<UserRole> UserRoles { get; set; }
    public virtual ICollection<RolePermission> RolePermissions { get; set; }
}
