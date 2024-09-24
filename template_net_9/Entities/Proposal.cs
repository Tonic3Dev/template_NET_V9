using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Users;

namespace template_net_9.Entities
{
    [Table("proposals")]
    public class Proposal
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        

        [Column("account_id")]
        public int? AccountId { get; set; }
        public Account Account { get; set; }

        [Column("leader_user_id")]
        public int? LeaderLegacyUserId { get; set; }
        public LegacyUser LeaderLegacyUser { get; set; }

        [Column("state")]
        public int? Status { get; set; }
        
        [Column("sold")]
        public bool? Sold { get; set; }
        
        [Column("proposal_state")]
        public int? ProposalState { get; set; }

        [Column("presentation_date")]
        public DateTime? PresentationDate { get; set; }

        [Column("proposal_document")]
        public string? ProposalDocument { get; set; }

        [Column("approval_document")]
        public string? ApprovalDocument { get; set; }

        [Column("definition_date")]
        public DateTime? DefinitionDate { get; set; }

        [Column("success_estimate")]
        public int? SuccessEstimate { get; set; }

        [Column("sheet_document")]
        public string? SheetDocument { get; set; }

        [Column("creation_user_id")]
        public int? CreationLegacyUserId { get; set; }
        public LegacyUser? CreationLegacyUser { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }






    }
}
