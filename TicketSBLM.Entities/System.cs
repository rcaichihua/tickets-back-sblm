using System.Collections;

public class System
{
    public int SystemId { get; set; }
    public string Name { get; set; }
    // Otras propiedades relevantes

    // Relaciones
    public virtual ICollection<Request> Requests { get; set; }
}