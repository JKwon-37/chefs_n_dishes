using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
public class TastinessValidation : ValidationAttribute{
    protected override ValidationResult? IsValid(object tastiness, ValidationContext validationContext)
        {
            if((int)tastiness < 1 || (int)tastiness > 5)
            {
                return new ValidationResult("Must be a number from 1-5!");
            }
            
            return ValidationResult.Success;
        }
}