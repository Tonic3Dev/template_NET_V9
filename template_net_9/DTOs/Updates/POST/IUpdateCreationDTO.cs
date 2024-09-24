
namespace template_net_9.DTOs.Updates.POST
{
    public interface IUpdateCreationDTO
    {
        int LegacyUserId { get; set; }
        int UpdateTypeId { get; set; }
        DateTime Date { get; set; }
        string Notes { get; set; }
    }
}
