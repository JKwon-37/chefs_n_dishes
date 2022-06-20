#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class Dish
{
    [Key]
    public int DishId {get;set;}

    [Required(ErrorMessage = " is required!")]
    public string Name {get;set;}

    public int Tastiness {get;set;}

    [Required(ErrorMessage = " is required!")]
    [CaloriesValidation]
    public int Calories {get;set;}

    [Required(ErrorMessage = " is required!")]
    public string Description {get;set;}
    
    public DateTime CreatedAt = DateTime.Now;
    public DateTime UpdatedAt = DateTime.Now;

    [Display(Name = "Chef's Name")]
    public int ChefId {get;set;}
    public List<Dish> Dishes = new List<Dish>();

    public Chef? ChefsName {get;set;}
}