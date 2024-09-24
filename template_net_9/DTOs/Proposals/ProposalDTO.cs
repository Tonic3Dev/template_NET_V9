using template_net_9.DTOs.Account;

namespace template_net_9.DTOs.Proposals
{
    public class ProposalDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AccountDTO Account { get; set; }

        public LegacyUserPublicDTO LeaderLegacyUser { get; set; }

        public int? Status { get; set; }

        public bool? Sold { get; set; }
    }
}
