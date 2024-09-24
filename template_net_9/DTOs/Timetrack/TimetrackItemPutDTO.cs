namespace template_net_9.DTOs.Timetrack
{
    public class TimetrackItemPutDTO
    {
        public int ProjectId { get; set; }
        public int TasktypeId { get; set; }
        public string Task { get; set; }
        public float Hours { get; set; }
        public DateTime Date { get; set; }
    }
}
