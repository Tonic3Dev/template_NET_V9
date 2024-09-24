namespace template_net_9.DTOs.Employees
{
    public class ChildDTO
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public EmployeeDTO Employee { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
}
