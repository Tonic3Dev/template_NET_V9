using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Curencies;

namespace template_net_9.Entities.Updates
{
    [Table("monetaryupdates")]
    public class MonetaryUpdate : UpdatesBase
    {
        public float Amount { get; set; }
        public int AmountCurrencyId { get; set; }
        public Currency AmountCurrency { get; set; }
    }
}
