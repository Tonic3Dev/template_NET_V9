using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Permissions
{
    [Table("groups")]
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
