using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Currencies;

public class CurrencyExchangeCreationDTO
{
    [Required]
    public int TargetCurrencyId { get; set; }
    [Required]
    public int BaseCurrencyId { get; set; }
    [Required]
    public float Price { get; set; }
    [Required]
    public DateTime Date { get; set; }
}