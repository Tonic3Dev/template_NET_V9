namespace template_net_9.DTOs.Tickets
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public TicketDTO Ticket { get; set; }
        public int AuthorId { get; set; }
        public LegacyUserPublicDTO Author { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
