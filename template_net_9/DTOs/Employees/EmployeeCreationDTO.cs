using template_net_9.Entities.Employees;
using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Employees
{
    public class EmployeeCreationDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string AfipId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? PositionId { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public int SalaryCurrencyId { get; set; }
        public int CountryId { get; set; }
        public string Avatar { get; set; }
        [Required]
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
        [Required]
        public int BusinessUnitId { get; set; }
        public int DNI { get; set; }
        public bool Active { get; set; }
        public string PostalCode { get; set; }
        [Required]
        public int FileNumber { get; set; }
        public List<ChildCreationDTO> Children { get; set; }
        public int SalaryAmount { get; set; }
        [Required]
        public WorkTimeEnum WorkTime { get; set; }
        public EmployerEnum Employer { get; set; }

    }
}
