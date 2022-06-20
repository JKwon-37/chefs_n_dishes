using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChefsNDishes.Models;

public class DishesController : Controller
{
    private ChefsNDishesContext _context;

    public DishesController(ChefsNDishesContext context)
    {
        _context = context;
    }

    [HttpGet("dish")]
    public IActionResult AllDishes()
    {
        List<Dish> allDishes = _context.Dishes.Include(dish => dish.ChefsName).ToList();
        return View("AllDishes", allDishes);
    }

    [HttpGet("dish/new")]
    public IActionResult NewDish()
    {
        List<Chef> allChefs = _context.Chefs.ToList();
        ViewBag.allChefs = allChefs;
        return View("AddDish");
    }

    [HttpPost("dish/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Dishes.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("AllDishes", "Dishes");
        }
        return NewDish();
    }
}