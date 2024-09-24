namespace template_net_9.DTOs.Account
{
    public class AccountPatchDTO
    {
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public int CountryId { get; set; }

        public int ResponsibleLegacyUserId { get; set; }

        public string Notes { get; set; }
        public bool Active { get; set; }
    }
}
