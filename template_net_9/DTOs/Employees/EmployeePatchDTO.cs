using template_net_9.Entities.Employees;

namespace template_net_9.DTOs.Employees
{
    public class EmployeePatchDTO
    {
        public int FileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AfipId { get; set; }
        public DateTime EntryDate { get; set; }
        public int PositionId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public int SalaryCurrencyId { get; set; }
        public int CountryId { get; set; }
        public string Avatar { get; set; }
        public bool Gender { get; set; }
        public int BirthCountryId { get; set; }
        public MaritalStatusEnum? MaritalStatus { get; set; }
        public string Contact { get; set; }
        public int MedicalCoverageId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Floor { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }
        public int DNI { get; set; }
        public string PostalCode { get; set; }
        public List<ChildCreationDTO> Children { get; set; }
        public int SalaryAmount { get; set; }
        public WorkTimeEnum WorkTime { get; set; }
        public int BusinessUnitId { get; set; }
        public EmployerEnum Employer { get; set; }
    }
}
