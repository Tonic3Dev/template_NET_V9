using template_net_9.Entities.Projects;
using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Projects
{
    public class ProjectCreationDTO
    {
        [Required]
        public string Name { get; set; }
        public bool Sold { get; set; }
        [Required]
        public int AccountId { get; set; }
        [Required]
        public int LeaderLegacyUserId { get; set; }
        [Range(1, 3)]
        public int ContractType { get; set; }
        public int Hours { get; set; }
        public int CurrencyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        [Required]
        public int BusinessUnitId { get; set; }
        public bool Active { get; set; }
        public float Income { get; set; }
        public List<ProjectIncomes> ProjectIncomes { get; set; }
        public int? SDRId { get; set; }
        public int? AEId { get; set; }
        public int? ReferralUserId { get; set; }
    }
}
