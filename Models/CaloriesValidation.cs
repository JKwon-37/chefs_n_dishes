#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class CaloriesValidation : ValidationAttribute{
    protected override ValidationResult? IsValid(object calories, ValidationContext validationContext)
        {
            if((int)calories <= 0)
            {
                return new ValidationResult("Must be greater than 0!");
            }
            
            return ValidationResult.Success;
        }
}
