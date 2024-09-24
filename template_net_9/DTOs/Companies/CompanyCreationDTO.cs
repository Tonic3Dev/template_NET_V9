using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Companies
{
    public class CompanyCreationDTO
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string FiscalId { get; set; }
        public string AfipId { get; set; }
        public int IvaType { get; set; }
        public int ReferredByLegacyUserId { get; set; }
        public bool Active { get; set; }
    }
}
