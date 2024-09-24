namespace template_net_9.DTOs.Updates.PATCH
{
    public class MonetaryUpdatePatchDTO : UpdatesBasePatchDTO
    {
        public float Amount { get; set; }
        public int AmountCurrencyId { get; set; }
    }
}
