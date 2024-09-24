using template_net_9.Entities.Projects;

namespace template_net_9.DTOs.Projects
{
    public class ProjectPatchDTO
    {
        public string Name { get; set; }
        public bool Sold { get; set; }
        public int CompanyId { get; set; }
        public int AccountId { get; set; }
        public int LeaderLegacyUserId { get; set; }
        public int ContractType { get; set; }
        public int Hours { get; set; }
        public int CurrencyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public float Income { get; set; }
        public int BusinessUnitId { get; set; }
        public List<ProjectIncomes> ProjectIncomes { get; set; }
        public int? SDRId { get; set; }
        public int? AEId { get; set; }
        public int? ReferralUserId { get; set; }
    }
}
