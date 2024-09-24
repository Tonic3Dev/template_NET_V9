using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates.POST
{
    public class DateChangeUpdateCreationDTO : UpdateCreationDTO
    {
        [Required]
        public DateTime NewDate { get; set; }
    }
}
