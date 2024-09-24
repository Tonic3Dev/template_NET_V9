using template_net_9.DTOs.Employees;
using template_net_9.Entities.Curencies;
using template_net_9.Entities.Users;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Employees
{
    [Table("employees")]
    public class Employee
    {
        public int Id { get; set; }

        [Column("file_number")]
        public int FileNumber { get; set; }

        [Column("user_id")]
        public int LegacyUserId { get; set; }

        public LegacyUser LegacyUser { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("afipid")]
        public string AfipId { get; set; }

        [Column("entry_date")]
        public DateTime? EntryDate { get; set; }

        [Column("position_id")]
        public int? PositionId { get; set; }

        public Position Position { get; set; }

        public string Avatar { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Gender { get; set; }

        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }

        [Column("birth_country_id")]
        public int? BirthCountryId { get; set; }

        public Country BirthCountry { get; set; }

        [Column("marital_status")]
        public MaritalStatusEnum? MaritalStatus { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        [Column("home_phone")]
        public string HomePhone { get; set; }

        [Column("mobile_phone")]
        public string MobilePhone { get; set; }

        [Column("salary_currency_id")]
        public int? SalaryCurrencyId { get; set; }

        public Currency SalaryCurrency { get; set; }

        [Column("medical_coverage_id")]
        public int? MedicalCoverageId { get; set; }

        public MedicalCoverage MedicalCoverage { get; set; }

        [Column("address")]
        public string AddressStore { get; set; }

        public AddressDTO? Address => AddressStore != null ? JsonConvert.DeserializeObject<AddressDTO>(AddressStore) : null;

        [Column("city")]
        public string City { get; set; }

        [Column("country_id")]
        public int? CountryId { get; set; }

        public Country Country { get; set; }

        public bool Active { get; set; }

        [Column("postal_code")]
        public string PostalCode { get; set; }
        public List<Child> Children { get; set; }
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

    public enum WorkTimeEnum
    {
        FullTime,
        PartTime,
    }

    public enum EmployerEnum
    {
        W3AR,
        T3
    }
}
