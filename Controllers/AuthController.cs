using Microsoft.AspNetCore.Mvc;

namespace LaAdventuresList.Controllers;

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult Login(bool error = false)
    {
        ViewBag.Error = error;
        return View();
    }
}
