using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities
{
    [Table("countries")]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
