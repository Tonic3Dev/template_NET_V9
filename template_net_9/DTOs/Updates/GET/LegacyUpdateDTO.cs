using template_net_9.DTOs.Currencies;

namespace template_net_9.DTOs.Updates.GET
{
    public class LegacyUpdateDTO
    {
        public int Id { get; set; }
        public LegacyUserPublicDTO LegacyUser { get; set; }
        public UpdateTypeDTO UpdateType { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Amount { get; set; }
        public CurrencyDTO AmountCurrency { get; set; }
        public string Motive { get; set; }
        public DateTime? DateTelegram { get; set; }
        public int? ReportNumber { get; set; }
        public int? WeekDay { get; set; }
        public DateTime? NewDate { get; set; }
        public string Notes { get; set; }
        public string FollowUp { get; set; }
        public bool Active { get; set; }
        public string Data { get; set; }
    }
}
