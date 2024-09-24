using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Users;

namespace template_net_9.Entities
{
    [Table("providers")]
    public class Provider
    {
        public int Id { get; set; }
        
        [Column("user_id")]
        public int? LegacyUserId { get; set; }

        public LegacyUser LegacyUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AfipId { get; set; }

        [Column("business_name")]
        public string BusinessName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string? Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        public bool? Active { get; set; }

        [Column("file_number")]
        public int? FileNumber { get; set; }

        public ProviderType ProviderType { get; set; }
    }

    public enum ProviderType
    {
        OnDemand,
        Dedicated
    }
}
