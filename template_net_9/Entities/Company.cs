
using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Users;

namespace template_net_9.Entities
{
    [Table("companies")]
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Column("country_id")]
        public int? CountryId { get; set; }
        public Country? Country { get; set; }

        [Column("state_id")]
        public int? StateId { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("fiscal_ID")]
        public string? FiscalId { get; set; }

        [Column("afipid")]
        public string? AfipId { get; set; }

        [Column("IVA_type")]
        public int? IvaType { get; set; }

        [Column("business_unit_id")]
        public int? BusinessUnitId { get; set; }

        [Column("referred_by_user_id")]
        public int? ReferredByLegacyUserId { get; set; }

        [Column("responsible_user_id")]
        public int? ResponsibleLegacyUserId { get; set; }

        [Column("state")]
        public string? Status { get; set; }

        [Column("creation_user_id")]
        public int? CreationLegacyUserId { get; set; }
        public LegacyUser? CreationLegacyUser { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
