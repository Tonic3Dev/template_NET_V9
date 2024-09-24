using template_net_9.Entities;

namespace template_net_9.DTOs.Contracts
{
    public class SOWContractPatchDTO
    {
        public int ProviderId { get; set; }
        public int SOWNumber { get; set; }
        public DateTime OriginalStartDate { get; set; }
        public DateTime CurrentSOWStartDate { get; set; }
        public DateTime CurrentSOWEndDate { get; set; }
        public TypeOfInvoicingEnum TypeOfInvoicing { get; set; }
        public float AmountPaid { get; set; }
        public int CurrencyId { get; set; }
        public T3EntityEnum Tonic3Entity { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public string DocumentURL { get; set; }
    }
}
