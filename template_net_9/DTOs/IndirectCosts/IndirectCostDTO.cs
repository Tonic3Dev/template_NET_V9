using template_net_9.DTOs.Currencies;
using template_net_9.DTOs.Projects;

namespace template_net_9.DTOs.IndirectCosts;

public class IndirectCostDTO
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime Date {get; set;}
    public float Amount { get; set; }
    public CurrencyDTO Currency { get; set; }
    public ProjectDTO Project { get; set; }
}