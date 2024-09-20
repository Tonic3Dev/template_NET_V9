using System.ComponentModel.DataAnnotations;

namespace template_net_9.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public float Price { get; set; }
    }
}
