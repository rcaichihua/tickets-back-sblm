using System;

public class Request
{
    public int RequestId { get; set; }
    public int UserId { get; set; }
    public string RequestType { get; set; }
    public string Description { get; set; }
    public string SystemInvolved { get; set; }
    public string EstimatedImpact { get; set; }
    public DateTime RequestDate { get; set; }

    // Relationships
    public virtual User User { get; set; }
    public virtual Approval Approval { get; set; }
}
