namespace template_net_9.DTOs.Updates.PATCH
{
    public interface IUpdatesBasePatchDTO
    {
        int LegacyUserId { get; set; }
        int UpdateTypeId { get; set; }
        DateTime Date { get; set; }
        string Notes { get; set; }
    }
}
