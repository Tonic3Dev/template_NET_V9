using template_net_9.Entities.Users;

namespace template_net_9.Entities.Updates
{
    public class UpdatesBase : IUpdatesBase
    {
        public int Id { get; set; }
        public int LegacyUserId { get; set; }
        public LegacyUser LegacyUser { get; set; }
        public int UpdateTypeId { get; set; }
        public UpdateType UpdateType { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
