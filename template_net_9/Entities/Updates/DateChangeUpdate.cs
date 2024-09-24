using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Updates
{
    [Table("datechangeupdates")]
    public class DateChangeUpdate : UpdatesBase
    {
        public DateTime NewDate { get; set; }
    }
}
