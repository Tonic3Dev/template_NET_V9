using template_net_9.Entities;
using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Providers
{
    public class ProviderCreationDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string AfipId { get; set; }

        public string BusinessName { get; set; }
        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public bool Active { get; set; }

        [Required]
        public int BusinessUnitId { get; set; }
        [Required]
        public int FileNumber { get; set; }
        [Required]
        public ProviderType ProviderType { get; set; }
    }
}
