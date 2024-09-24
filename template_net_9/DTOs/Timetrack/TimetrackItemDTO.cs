using template_net_9.DTOs.Projects;

namespace template_net_9.DTOs.Timetrack
{
    public class TimetrackItemDTO
    {
        public int Id { get; set; }
        public ProjectDTO Project { get; set; }
        public LegacyUserPublicDTO LegacyUser { get; set; }
        public TasktypeDTO Tasktype { get; set; }
        public string Task { get; set; }
        public float Hours { get; set; }
        public DateTime Date { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
