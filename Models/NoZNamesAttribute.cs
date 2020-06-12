using System.ComponentModel.DataAnnotations;

namespace MvcSurvey.Models
{
    class NoZNamesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (((string)value).ToLower()[0] == 'z')
                return new ValidationResult("No names that start with Z allowed!");
            return ValidationResult.Success;
        }
    }
}