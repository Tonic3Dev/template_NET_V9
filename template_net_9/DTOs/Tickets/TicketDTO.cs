using template_net_9.Entities.Tickets;
using System.ComponentModel;

namespace template_net_9.DTOs.Tickets
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int RequesterId { get; set; }
        public LegacyUserPublicDTO Requester { get; set; }
        public List<LegacyUserPublicDTO> Followers { get; set; }
        public List<LegacyUserPublicDTO> Assignees { get; set; }
        public TypeEnum Type { get; set; }
        public Priorities Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string Subject { get; set; }

        [DefaultValue(Status.Open)]
        public Status Status { get; set; }
        public List<string> Tags { get; set; }
        public List<MessageDTO> Messages { get; set; }
        public string Description { get; set; }
    }
}
