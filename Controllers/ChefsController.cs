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
        return View("AddChef");
    }

    [HttpPost("chef/create")]
    public IActionResult CreateChef(Chef newChef)
    {
        if(ModelState.IsValid)
        {
            _context.Chefs.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        } else
        {
            return NewChef();
        }
    }
}