using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Employees
{
    [Table("positions")]
    public class Position
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
