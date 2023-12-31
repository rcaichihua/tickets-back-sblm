using System;
namespace TicketSBLM.Entities
{
  public class Approval
  {
      public int ApprovalId { get; set; }
      public int RequestId { get; set; }
      public string ApproverName { get; set; }
      public string ApproverRole { get; set; }
      public DateTime ApprovalDate { get; set; }
      // Relationships
      public virtual Request Request { get; set; }
}
}