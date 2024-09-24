using template_net_9.DTOs.BusinessUnit;
using template_net_9.DTOs.Companies;

namespace template_net_9.DTOs.Account
{
    public class AccountDTO
    {
        public int Id { get; set; }

        public CompanyDTO Company { get; set; }

        public string Name { get; set; }

        public BusinessUnitDTO BusinessUnit { get; set; }

        public CountryDTO Country { get; set; }

        public int? ResponsibleLegacyUserId { get; set; }

        public string PaymentDelay { get; set; }

        public string PaymentType { get; set; }

        public string PaymentConsiderations { get; set; }

        public int? MainContantId { get; set; }

        public int? BillingContactId { get; set; }

        public LegacyUserPublicDTO CreationLegacyUser { get; set; }
        public LegacyUserPublicDTO ResponsibleLegacyUser { get; set; }

        public DateTime? CreationDate { get; set; }

        public bool Active { get; set; }

        public string Notes { get; set; }
    }
}
