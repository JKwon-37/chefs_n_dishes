public class ChefsController : Controller
{
    [HttpGet("chef/new")]
    public IActionResult NewChef()
    {
        return View("AddChef", "Chefs");
    }
}