using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Curencies;
using template_net_9.Entities.Users;

namespace template_net_9.Entities.Projects
{
    [Table("projects")]
    public class Project
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        [Column("short_name")]
        public string? ShortName { get; set; }

        [Column("state")]
        public int? Status { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        [Column("proposal_id")]
        public int ProposalId { get; set; }
        public Proposal? Proposal { get; set; }

        [Column("business_unit_id")]
        public int BusinessUnitId { get; set; }
        public BusinessUnit? BusinessUnit { get; set; }

        [Column("contract_type")]
        public int? ContractType { get; set; }

        [Column("start_date")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("leader_user_id")]
        public int? LeaderLegacyUserId { get; set; }
        public LegacyUser? LeaderLegacyUser { get; set; }

        [Column("hours")]
        public int? Hours { get; set; }

        [Column("progress")]
        public int? Progress { get; set; }

        [Column("comments")]
        public string? Comments { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("creation_user_id")]
        public int? CreationLegacyUserId { get; set; }

        public LegacyUser? CreationLegacyUser { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("UI_color")]
        public string? UIColor { get; set; }

        [Column("sold")]
        public bool? Sold { get; set; }

        [Column("currencyId")]
        public int? CurrencyId { get; set; }
        public Currency? Currency { get; set; }

        [Column("notes")]
        public string? Notes { get; set; }

        public float Income { get; set; }
        public List<ProjectIncomes>? ProjectIncomes { get; set; }

        public int? SDRId { get; set; }
        public LegacyUser SDR { get; set; }
        public int? AEId { get; set; }
        public LegacyUser? AE { get; set; }
        public int? ReferralUserId { get; set; }
        public LegacyUser? ReferralUser { get; set; }
    }
}
