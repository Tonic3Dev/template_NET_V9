using System.ComponentModel.DataAnnotations;

namespace template_net_9.Attributes
{
    public class EndBiggerOrEqualThanStart: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DTOs.Range range && range.End < range.Start) return new ValidationResult($"Range end should be bigger or equal than range start");
            return ValidationResult.Success;
        }
    }
}
