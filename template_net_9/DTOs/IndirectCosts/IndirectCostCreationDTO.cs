using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.IndirectCosts;

public class IndirectCostCreationDTO
{
    [Required]
    public string Description { get; set; }
    [Required]
    public DateTime Date {get; set;}
    [Required]
    public float Amount { get; set; }
    [Required]
    public int CurrencyId { get; set; }
    [Required]
    public int ProjectId { get; set; }
}