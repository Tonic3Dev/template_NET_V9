namespace template_net_9.Entities.Projects
{
    public class ProjectIncomes
    {
        public int Id { get; set; }
        public DateTime IncomeDate { get; set; }
        public float Amount { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}
