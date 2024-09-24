using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Curencies;

[Table("currencies_exchange")]
public class CurrencyExchange
{
    public int Id { get; set; }
    [Column("source_currency_id")]
    public int TargetCurrencyId { get; set; }
    public Currency TargetCurrency { get; set; }
    [Column("base_currency_id")]
    public int BaseCurrencyId { get; set; }
    public Currency BaseCurrency { get; set; }
    public float Price { get; set; }
    public DateTime Date { get; set; }
}