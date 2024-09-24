using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates.POST;

public class StructureUpdateCreationDTO: UpdateCreationDTO
{
    [Required]
    [Range(0, 100)]
    public float Amount { get; set; }
}