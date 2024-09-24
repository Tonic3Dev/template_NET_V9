using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities
{
    [Table("business_units")]
    public class BusinessUnit
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
