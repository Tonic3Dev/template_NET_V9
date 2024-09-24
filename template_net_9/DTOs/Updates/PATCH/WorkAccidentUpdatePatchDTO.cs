namespace template_net_9.DTOs.Updates.PATCH
{
    public class WorkAccidentUpdatePatchDTO : UpdatesBasePatchDTO 
    {
        public DateTime EndDate { get; set; }
        public int? ReportNumber { get; set; }
    }
}
