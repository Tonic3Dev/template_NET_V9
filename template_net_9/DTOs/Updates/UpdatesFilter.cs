using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Updates
{
    public class UpdatesFilter : BaseFilter
    {
        [Range(1, 12)]
        public int Month { get; set; }

        public int Year { get; set; }

        public string UserType { get; set; }
    }
}
