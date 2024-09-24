using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Proposals
{
    public class ProposalCreationDTO
    {
        [Required]
        public int AccountId { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime PresentationDate { get; set; }
        public DateTime DefinitionDate { get; set; }
        public int SuccessEstimate { get; set; }

        [Required]
        [Range(1, 8)]
        public int State { get; set; }

        [Required]
        public int LeaderLegacyUserId { get; set; }
    }
}
