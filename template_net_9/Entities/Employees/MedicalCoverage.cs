using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Employees
{
    [Table("medical_coverages")]
    public class MedicalCoverage
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
