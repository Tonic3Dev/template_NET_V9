using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Users;

namespace template_net_9.Entities.Tickets
{
    public class Ticket
    {
        public int Id { get; set; }
        public int RequesterId { get; set; }
        [ForeignKey("RequesterId")]
        public LegacyUser Requester { get; set; }
        public List<LegacyUser> Followers { get; set; }
        public List<LegacyUser> Assignees { get; set; }
        public TypeEnum Type { get; set; }
        public Priorities Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string Subject { get; set; }

        [DefaultValue(Status.Open)]
        public Status Status { get; set; }
        public List<string> Tags { get; set; }
        public List<Message> Messages { get; set; }
        public string Description { get; set; }
    }

    public enum TypeEnum { Support, Complaint }
    public enum Priorities { Urgent, High, Medium, Low }
    public enum Status { Solved, Open, OnHold, InRevision, NotSolved }
}
