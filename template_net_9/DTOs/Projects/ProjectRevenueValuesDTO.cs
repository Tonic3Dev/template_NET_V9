using template_net_9.Entities.Projects;

namespace template_net_9.DTOs.Projects;

public class ProjectRevenueValuesDTO
{
    public ProjectDTO Project { get; set; }
    public float ResourcesCost { get; set; }
    public float HoursReported { get; set; }
    public float IndirectCost { get; set; }
    public float Profit { get; set; }
    public float? Income { get; set; }
    public List<ProjectIncomes> ProjectIncomes { get; set; }
}