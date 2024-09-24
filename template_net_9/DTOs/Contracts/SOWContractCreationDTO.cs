using template_net_9.Entities;
using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Contracts
{
    public class SOWContractCreationDTO
    {
        [Required]
        public int ProviderId { get; set; }
        [Required]
        public int SOWNumber { get; set; }
        [Required]
        public DateTime OriginalStartDate { get; set; }
        [Required]
        public DateTime CurrentSOWStartDate { get; set; }
        [Required]
        public DateTime CurrentSOWEndDate { get; set; }
        [Required]
        public TypeOfInvoicingEnum TypeOfInvoicing { get; set; }
        [Required]
        public float AmountPaid { get; set; }
        [Required]
        public int CurrencyId { get; set; }
        [Required]
        public T3EntityEnum Tonic3Entity { get; set; }
        [Required]
        public PaymentMethodEnum PaymentMethod { get; set; }
        public string DocumentURL { get; set; }
    }
}
