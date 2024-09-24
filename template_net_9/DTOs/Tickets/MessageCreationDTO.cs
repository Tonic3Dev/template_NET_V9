namespace template_net_9.DTOs.Tickets
{
    public class MessageCreationDTO
    {
        public int TicketId { get; set; }
        public int AuthorId { get; set; }
        public string Content { get; set; }
        public DateTime Date => DateTime.UtcNow;
    }
}
