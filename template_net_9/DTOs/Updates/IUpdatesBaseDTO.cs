namespace template_net_9.DTOs.Updates
{
    public interface IUpdatesBaseDTO
    {
        int Id { get; set; }
        LegacyUserPublicDTO LegacyUser { get; set; }
        UpdateTypeDTO UpdateType { get; set; }
        DateTime Date { get; set; }
        string Notes { get; set; }
    }
}
