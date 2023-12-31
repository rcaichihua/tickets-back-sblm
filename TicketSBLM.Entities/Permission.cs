
using System.Collections.Generic;

public class Permission
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Relationships
    public virtual ICollection<UserPermission> UserPermissions { get; set; }
    public virtual ICollection<RolePermission> RolePermissions { get; set; }
}