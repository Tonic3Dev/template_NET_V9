using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Employees
{
    public class ChildCreationDTO
    {
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required] public string Name { get; set; }

    }
}
