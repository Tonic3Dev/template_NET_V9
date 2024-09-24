using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates.POST;

public class StructureUpdateBulkCreationDTO
{
    [Required]
    public int FileNumber { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    [Range(0, 100)]
    public float Amount { get; set; }
}