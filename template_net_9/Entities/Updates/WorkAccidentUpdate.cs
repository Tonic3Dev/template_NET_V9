using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Updates
{
    [Table("workaccidentupdates")]
    public class WorkAccidentUpdate : UpdatesBase
    {
        public DateTime EndDate { get; set; }
        public int? ReportNumber { get; set; }
    }
}
