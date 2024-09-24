using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Users;

namespace template_net_9.Entities
{
    [Table("accounts")]
    public class Account
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("business_unit_id")]
        public int? BusinessUnitId { get; set; }
        public BusinessUnit BusinessUnit { get; set; }

        [Column("country_id")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }

        [Column("responsible_user_id")]
        public int? ResponsibleLegacyUserId { get; set; }
        public LegacyUser ResponsibleLegacyUser { get; set; }

        [Column("payment_delay")]
        public string PaymentDelay { get; set; }

        [Column("payment_type")]
        public string PaymentType { get; set; }

        [Column("payment_considerations")]
        public string PaymentConsiderations { get; set; }

        [Column("main_contact_id")]
        public int? MainContantId { get; set; }

        [Column("billing_contact_id")]
        public int? BillingContactId { get; set; }

        [Column("creation_user_id")]
        public int? CreationLegacyUserId { get; set; }
        public LegacyUser CreationLegacyUser { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("notes")]
        public string Notes { get; set; }
    }
}
