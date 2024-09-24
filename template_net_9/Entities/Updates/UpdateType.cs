using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Updates
{
    [Table("updatetypes")]
    public class UpdateType
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public bool Active { get; set; }
    }
}
