using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Employees
{
    [Table("Children")]
    public class Child
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
}
