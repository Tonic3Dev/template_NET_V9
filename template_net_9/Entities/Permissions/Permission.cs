using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Permissions
{
    [Table("permissions")]
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
    }
}
