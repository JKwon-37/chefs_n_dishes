using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;

public class ChefsController : Controller
{
    private ChefsNDishesContext _context;

    public ChefsController(ChefsNDishesContext context)
    {
        _context = context;
    }
    
    [HttpGet("chef/new")]
    public IActionResult NewChef()
    {
        return View("AddChef", "Chefs");
    }
}