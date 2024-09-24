using template_net_9.Entities.Tickets;
using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Tickets
{
    public class TicketCreationDTO
    {
        [Required]
        public int RequesterId { get; set; }
        public int[] FollowersIds { get; set; }
        [Required]
        public int[] AssigneesIds { get; set; }
        [Required]
        public TypeEnum Type { get; set; }
        [Required]
        public Priorities Priority { get; set; }
        public DateTime CreatedAt => DateTime.UtcNow;
        [Required]
        public string Subject { get; set; }
        [Required]
        public Status Status { get; set; }
        public List<string> Tags { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
