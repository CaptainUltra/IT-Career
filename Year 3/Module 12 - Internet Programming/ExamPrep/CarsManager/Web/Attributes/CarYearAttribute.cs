using System;
using System.ComponentModel.DataAnnotations;
using Web.Models.Cars;

namespace Web.Attributes
{
    public class CarYearAttribute : ValidationAttribute
    {
        private static readonly int MinYear = 1975;
        private static readonly string ErrorMessage = $"Car can't be created before {MinYear} or after {DateTime.Now.Year + 1}";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            int carYear = (int)value;

            if (carYear < MinYear || carYear > DateTime.Now.Year + 1)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
