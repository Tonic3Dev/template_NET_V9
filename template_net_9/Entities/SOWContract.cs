using template_net_9.Entities.Curencies;

namespace template_net_9.Entities
{
    public class SOWContract
    {
        public int Id { get; set; }
        public Provider Provider { get; set; }
        public int ProviderId { get; set; }
        public int SOWNumber { get; set; }
        public DateTime OriginalStartDate { get; set; }
        public DateTime CurrentSOWStartDate { get; set; }
        public DateTime CurrentSOWEndDate { get; set; }
        public TypeOfInvoicingEnum TypeOfInvoicing { get; set; }
        public float AmountPaid { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public T3EntityEnum Tonic3Entity { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public string DocumentURL { get; set; }
    }

    public enum TypeOfInvoicingEnum
    {
        Hourly,
        Monthly,
    }
    public enum T3EntityEnum
    {
        T3,
        W3USA,
        W3AR,
        W3UY,
        W3BR,
    }
    public enum PaymentMethodEnum
    {
        Wire,
        Wise,
        Crypto,
    }
}
