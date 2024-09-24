using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities
{
    [Table("cities")]
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
