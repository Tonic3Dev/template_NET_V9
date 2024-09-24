namespace template_net_9.DTOs.Updates.PATCH
{
    public class UpdatesBasePatchDTO : IUpdatesBasePatchDTO
    {
        public int LegacyUserId { get; set; }
        public int UpdateTypeId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
