namespace template_net_9.DTOs.Currencies;

public class CurrencyExchangeDTO
{
    public int Id { get; set; }
    public CurrencyDTO TargetCurrency { get; set; }
    public CurrencyDTO BaseCurrency { get; set; }
    public float Price { get; set; }
    public DateTime Date { get; set; }
}