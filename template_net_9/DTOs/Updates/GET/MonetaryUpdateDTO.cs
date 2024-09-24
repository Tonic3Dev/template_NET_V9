using template_net_9.DTOs.Currencies;

namespace template_net_9.DTOs.Updates.GET
{
    public class MonetaryUpdateDTO: UpdatesBaseDTO
    {
        public float Amount { get; set; }
        public CurrencyDTO AmountCurrency { get; set; }
    }
}
