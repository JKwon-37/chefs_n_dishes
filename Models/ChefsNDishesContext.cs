#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace ChefsNDishes.Models;
// the ChefsNDishesContext class representing a session with our MySQL database, allowing us to query for or save data
public class ChefsNDishesContext : DbContext 
{ 
    public ChefsNDishesContext(DbContextOptions options) : base(options) { }
    // the "Dish" table name will come from the DbSet property name
    
    public DbSet<Chef> Chefs { get; set; } 
    public DbSet<Dish> Dishes { get; set; } 
}