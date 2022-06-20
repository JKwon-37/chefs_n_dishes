// #pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class Chef
{
    [Key]
    public int ChefId {get;set;}
    [Required(ErrorMessage = " is required!")]
    [Display(Name = "First Name")]
    public string? FirstName {get;set;}
    [Required(ErrorMessage = " is required!")]
    [Display(Name = "Last Name")]
    public string? LastName {get;set;}
 
    [DateValidation]
    [Display(Name = "Date of Birth")]
    public DateTime DateOfBirth {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public List<Dish> DishesCreated {get;set;} = new List<Dish>();

    public int? Age()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }
}