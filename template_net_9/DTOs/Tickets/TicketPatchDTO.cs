using template_net_9.Entities.Tickets;

namespace template_net_9.DTOs.Tickets
{
    public class TicketPatchDTO
    {
        public int RequesterId { get; set; }
        public int[] FollowersIds { get; set; }
        public int[] AssigneesIds { get; set; }
        public TypeEnum Type { get; set; }
        public Priorities Priority { get; set; }
        public DateTime UpdatedAt => DateTime.UtcNow;
        public Status Status { get; set; }
        public List<string> Tags { get; set; }
    }
}
