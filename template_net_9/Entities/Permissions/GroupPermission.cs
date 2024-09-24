using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Permissions
{
    [Table("permissions_groups")]
    public class GroupPermission
    {
        public int Id { get; set; }

        public bool Active { get; set; }

        [Column("permission_id")]
        public int PermissionId { get; set; }

        public Permission Permission { get; set; }

        [Column("group_id")]
        public int GroupId { get; set; }

        public Group Group { get; set; }
    }
}
