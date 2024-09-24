using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Users;

namespace template_net_9.Entities.Permissions
{
    [Table("groups_users")]
    public class GroupLegacyUser
    {
        public int Id { get; set; }

        [Column("group_id")]
        public int? GroupId { get; set; }

        public Group Group { get; set; }

        [Column("user_id")]
        public int? LegacyUserId { get; set; }

        public LegacyUser LegacyUser { get; set; }
    }
}
