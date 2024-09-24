using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.BusinessUnit
{
    public class BusinessUnitCreationDTO
    {
        [Required]
        public string Name { get; set; }
        public bool Active { get; set; }

    }
}
