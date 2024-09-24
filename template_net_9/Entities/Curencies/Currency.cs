using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Curencies
{
    [Table("currencies")]
    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
