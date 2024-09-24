using template_net_9.DTOs.Currencies;

namespace template_net_9.DTOs.Updates.GET
{
    public class UpdateDTO
    {
        public int Id { get; set; }
        public LegacyUserPublicDTO LegacyUser { get; set; }
        public UpdateTypeDTO UpdateType { get; set; }
        public DateTime Date { get; set; }
        public DateTime? NewDate { get; set; }
        public float? Amount { get; set; }
        public CurrencyDTO AmountCurrency { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ReportNumber { get; set; }
        public DateTime? DateTelegram { get; set; }
        public string Notes { get; set; }
    }
}
