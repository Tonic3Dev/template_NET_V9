using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Projects;
using template_net_9.Entities.Users;

namespace template_net_9.Entities.Timetrack
{
    [Table("timetrac")]
    public class TimetrackItem
    {
        public int Id { get; set; }

        [Column("project_id")]
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        [Column("user_id")]
        public int LegacyUserId { get; set; }

        public LegacyUser LegacyUser { get; set; }

        [Column("tasktype_id")]
        public int? TasktypeId { get; set; }

        public Tasktype Tasktype { get; set; }

        public string Task { get; set; }

        public string Hours { get; set; }

        public DateTime Date { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
