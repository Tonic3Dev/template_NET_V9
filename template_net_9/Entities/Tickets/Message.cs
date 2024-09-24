using template_net_9.Entities.Users;

namespace template_net_9.Entities.Tickets
{
    public class Message
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int AuthorId { get; set; }
        public LegacyUser Author { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
