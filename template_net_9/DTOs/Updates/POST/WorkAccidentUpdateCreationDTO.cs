using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates.POST
{
    public class WorkAccidentUpdateCreationDTO : UpdateCreationDTO
    {
        [Required]
        public DateTime EndDate { get; set; }
        public int? ReportNumber { get; set; }
    }
}
