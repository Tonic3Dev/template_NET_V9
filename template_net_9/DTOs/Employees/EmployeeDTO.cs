using template_net_9.DTOs.Currencies;
using template_net_9.Entities.Employees;

namespace template_net_9.DTOs.Employees
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public int FileNumber { get; set; }
        public LegacyUserPublicDTO LegacyUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AfipId { get; set; }
        public DateTime? EntryDate { get; set; }
        public PositionDTO Position { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public CurrencyDTO SalaryCurrency { get; set; }
        public CountryDTO Country { get; set; }
        public string Avatar { get; set; }
        public bool Gender { get; set; }
        public CountryDTO BirthCountry { get; set; }
        public MaritalStatusEnum? MaritalStatus { get; set; }
        public List<ContactDTO> Contact { get; set; }
        public MedicalCoverageDTO MedicalCoverage { get; set; }
        public AddressDTO Address { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }
        public string PostalCode { get; set; }
        public List<ChildDTO> Children { get; set; }
        public int? SalaryAmount { get; set; }
        public WorkTimeEnum WorkTime { get; set; }
        public EmployerEnum Employer { get; set; }
    }

    public enum MaritalStatusEnum
    {
        Single,
        Married,
        Cohabiting,
        Divorced,
        Separated,
        Widowed
    }

}
