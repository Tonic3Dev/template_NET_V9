using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Tickets;

namespace template_net_9.Entities.Users
{
    [Table("users")]
    public class LegacyUser
    {
        public int Id { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("caption")]
        public string FullName { get; set; }

        [Column("business_unit_id")]
        public int? BusinessUnitId { get; set; }

        public BusinessUnit BusinessUnit { get; set; }
        public List<Training> Trainings { get; set; }

        public List<Ticket> AssignedTickets { get; set; }
        public List<Ticket> FollowedTickets { get; set; }
        public List<Ticket> RequestedTickets { get; set; }
    }
}
