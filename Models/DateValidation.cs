using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
public class DateValidation : ValidationAttribute
{
    protected bool UnderEighteen(DateTime dob)
    {  
        DateTime eighteenthBday = dob.AddYears(18);
        if (eighteenthBday <= DateTime.Now)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    protected override ValidationResult? IsValid(object dob, ValidationContext validationContext)
    {
        if((DateTime)dob > DateTime.Now)
        {
            return new ValidationResult("Must be a past date!");
        }
        else if(this.UnderEighteen((DateTime)dob))
        {
            return new ValidationResult("Must be over 18!");
        }
        return ValidationResult.Success;
    }
}