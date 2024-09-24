using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates.POST
{
    public class MonetaryUpdateBulkCreationDTO
    {
        [Required]
        public int FileNumber { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public float Amount { get; set; }
    }
}
