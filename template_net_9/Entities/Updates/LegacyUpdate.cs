using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Curencies;
using template_net_9.Entities.Users;

namespace template_net_9.Entities.Updates
{
    [Table("updates")]
    public class LegacyUpdate
    {
        public int Id { get; set; }

        [Column("user_id")]
        public int LegacyUserId { get; set; }

        public LegacyUser LegacyUser { get; set; }

        [Column("updatetype_id")]
        public int UpdateTypeId { get; set; }

        public UpdateType UpdateType { get; set; }

        public DateTime? Date { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("nro_denuncia")]
        public int? ReportNumber { get; set; }

        public decimal? Amount { get; set; }

        [Column("amount_currency_id")]
        public int? AmountCurrencyId { get; set; }

        public Currency AmountCurrency { get; set; }

        public string Motive { get; set; }

        [Column("date_telegrama")]
        public DateTime? DateTelegram { get; set; }

        [Column("week_day")]
        public int? WeekDay { get; set; }

        [Column("new_date")]
        public DateTime? NewDate { get; set; }

        public string Notes { get; set; }

        [Column("seguimiento")]
        public string FollowUp { get; set; }

        public bool Active { get; set; }

        public string Data { get; set; }
    }
}
