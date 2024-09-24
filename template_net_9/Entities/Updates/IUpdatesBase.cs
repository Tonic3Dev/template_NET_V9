using template_net_9.Entities.Users;

namespace template_net_9.Entities.Updates
{
    public interface IUpdatesBase
    {
        int Id { get; set; }
        int LegacyUserId { get; set; }
        LegacyUser LegacyUser { get; set; }
        int UpdateTypeId { get; set; }
        UpdateType UpdateType { get; set; }
        DateTime Date { get; set; }
        string Notes { get; set; }
    }
}
