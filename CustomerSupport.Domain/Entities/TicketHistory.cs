namespace CustomerSupport.Domain.Entities
{
    public sealed class TicketHistory : BaseEntity<int>
    {
        public int SupportTicketId { get; set; }
        public int ChangedByUserId { get; set; }

        // Action tells us what type of business activity has happened to the ticket.
        // StatusChanged, PriorityChanged, Assigned, Resolved
        public string Action { get; set; } = string.Empty;

        // FieldName tells us which specific property of the Support ticket was changed
        // FieldName = "StatusId"
        // OldValue = "Open"
        // NewValue = "InProgress"
        public string? FieldName { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string? Remarks { get; set; }
        public SupportTicket SupportTicket { get; set; } = null!;
        public User ChangedByUser { get; set; } = null!;
    }
}
