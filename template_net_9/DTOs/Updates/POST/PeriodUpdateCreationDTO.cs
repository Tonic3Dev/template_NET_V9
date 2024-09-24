using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates.POST
{
    public class PeriodUpdateCreationDTO : UpdateCreationDTO
    {
        [Required]
        public DateTime EndDate { get; set; }
    }
}
