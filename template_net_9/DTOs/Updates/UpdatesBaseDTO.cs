namespace template_net_9.DTOs.Updates
{
    public class UpdatesBaseDTO: IUpdatesBaseDTO
    {
        public int Id { get; set; }
        public LegacyUserPublicDTO LegacyUser { get; set; }
        public UpdateTypeDTO UpdateType { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
