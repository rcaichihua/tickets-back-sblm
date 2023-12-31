using System.Collections;

public class User
{
    public int Id { get; set; }
    public string Dni { get; set; } // This might be an identification number, consider renaming if there's an equivalent in your context
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public bool IsSuperuser { get; set; }

    // Relationships
    public virtual ICollection<UserRole> UserRoles { get; set; }
    public virtual ICollection<UserPermission> UserPermissions { get; set; }
    public virtual ICollection<Request> Requests { get; set; }
}