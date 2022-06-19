#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;

public class Chef
{
    [Key]
    public int ChefId {get;set;}
    [Required(ErrorMessage = " is required!")]
    public string FirstName {get;set;}
    [Required(ErrorMessage = " is required!")]
    public string LastName {get;set;}
    [Required(ErrorMessage = " is required!")]
    public string DateOfBirth {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    public List<Dish> Dishes {get;set;} = new List<Dish>();
}