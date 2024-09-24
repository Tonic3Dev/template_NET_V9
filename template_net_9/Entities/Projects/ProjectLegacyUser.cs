using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Users;

namespace template_net_9.Entities.Projects
{
    [Table("projects_users")]
    public class ProjectLegacyUser
    {
        public int Id { get; set; }

        [Column("project_id")]
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        [Column("user_id")]
        public int LegacyUserId { get; set; }

        public LegacyUser LegacyUser { get; set; }
    }
}
