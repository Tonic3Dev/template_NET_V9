namespace template_net_9.DTOs.Timetrack
{
    public class TimetrackItemsFilterDTO: BaseFilter
    {
        public string GeneralSearch { get; set; }
        public bool IsGiven { get; set; }
        public string Columns { get; set; }
    }
}
