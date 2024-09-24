using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Updates
{
    [Table("resignationupdates")]
    public class ResignationUpdate : UpdatesBase
    {
        public DateTime? DateTelegram { get; set; }
    }
}
