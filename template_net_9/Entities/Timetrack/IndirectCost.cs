using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Curencies;
using template_net_9.Entities.Projects;

namespace template_net_9.Entities.Timetrack;

[Table("indirect_costs")]
public class IndirectCost
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public float Amount { get; set; }
    [Column("currency_id")]
    public int CurrencyId { get; set; }
    public Currency Currency { get; set; }
    [Column("project_id")]
    public int ProjectId { get; set; }
    public Project Project { get; set; }
}