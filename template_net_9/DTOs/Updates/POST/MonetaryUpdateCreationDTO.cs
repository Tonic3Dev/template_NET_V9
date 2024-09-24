using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates.POST
{
    public class MonetaryUpdateCreationDTO : UpdateCreationDTO
    {
        [Required]
        public float Amount { get; set; }
        [Required]
        public int AmountCurrencyId { get; set; }
    }
}
