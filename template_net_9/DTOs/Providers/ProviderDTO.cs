using template_net_9.Entities;

namespace template_net_9.DTOs.Providers
{
    public class ProviderDTO
    {
        public int Id { get; set; }
        public LegacyUserPublicDTO LegacyUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AfipId { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Active { get; set; }
        public int? FileNumber { get; set; }
        public ProviderType ProviderType { get; set; }
    }
}
