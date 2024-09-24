namespace template_net_9.DTOs.Companies
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CountryDTO Country { get; set; }
        public int? StateId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string FiscalId { get; set; }
        public string AfipId { get; set; }
        public int? IvaType { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? ReferredByLegacyUserId { get; set; }
        public int? ResponsibleLegacyUserId { get; set; }
        public string Status { get; set; }
        public LegacyUserPublicDTO CreationLegacyUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool Active { get; set; }
    }
}
