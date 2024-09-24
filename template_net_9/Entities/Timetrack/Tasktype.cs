using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Timetrack
{
    [Table("tasktypes")]
    public class Tasktype
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
        public string Caption { get; set; }
        public string Shortname { get; set; }
        public bool Active { get; set; }
    }
}
