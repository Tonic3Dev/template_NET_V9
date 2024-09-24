namespace template_net_9.DTOs.Proposals
{
    public class ProposalPatchDTO
    {
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public int AccountId { get; set; }

        public int LeaderLegacyUserId { get; set; }

        public int ContractType { get; set; }

        public int EstimatedHours { get; set; }

        public int CurrencyId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Notes { get; set; }

        public bool Sold { get; set; }
    }
}
