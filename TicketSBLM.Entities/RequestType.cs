using System.Collections;

public class RequestType
{
    public int RequestTypeId { get; set; }
    public string Name { get; set; }
    // Otras propiedades relevantes
    // Relaciones
    public virtual ICollection<Request> Requests { get; set; }
}