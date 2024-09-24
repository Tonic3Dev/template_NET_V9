using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Projects
{
    public class ProjectIncomesCreationDTO
    {
        [Required]
        public DateTime IncomeDate { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public int ProjectId { get; set; }
    }
}
