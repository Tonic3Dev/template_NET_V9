using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates.POST
{
    public class UpdateCreationDTO : IUpdateCreationDTO
    {
        [Required]
        public int LegacyUserId { get; set; }
        
        [Required]
        public int UpdateTypeId { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        public string Notes { get; set; }
    }
}
