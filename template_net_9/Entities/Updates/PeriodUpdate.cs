using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Updates
{
    [Table("periodupdates")]
    public class PeriodUpdate : UpdatesBase
    {
        public DateTime EndDate { get; set; }
    }
}
