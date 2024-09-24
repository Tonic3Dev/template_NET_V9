using template_net_9.DTOs.BusinessUnit;
using template_net_9.DTOs.Companies;
using template_net_9.DTOs.Currencies;
using template_net_9.DTOs.Proposals;
using template_net_9.Entities.Projects;

namespace template_net_9.DTOs.Projects
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        public CompanyDTO Company { get; set; }
        public ProposalDTO Proposal { get; set; }
        public BusinessUnitDTO BusinessUnit { get; set; }
        public int? ContractType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public LegacyUserPublicDTO LeaderLegacyUser { get; set; }
        public int? Hours { get; set; }
        public int? Progress { get; set; }
        public string? Comments { get; set; }
        public bool Active { get; set; }
        public LegacyUserPublicDTO CreationLegacyUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string UIColor { get; set; }
        public bool? Sold { get; set; }
        public CurrencyDTO Currency { get; set; }
        public string? Notes { get; set; }
        public float Income { get; set; }
        public List<ProjectIncomes> ProjectIncomes { get; set; }
        public LegacyUserPublicDTO SDR { get; set; }
        public LegacyUserPublicDTO AE { get; set; }
        public LegacyUserPublicDTO ReferralUser { get; set; }
    }
}
