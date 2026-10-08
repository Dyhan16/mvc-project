using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers;

public class MenuController : Controller
{
    public IActionResult Index() => View();
}