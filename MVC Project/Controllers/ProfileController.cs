using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers;

public class ProfileController : Controller
{
    public IActionResult Index()
    {
        var model = new ProfileViewModel
        {
            FullName = "Hans Matthew Hermida",
            Course = "Bachelor of Science in Computer Science",
            School = "Polytechnic University of the Philippines",
            Bio = "hello.",
            ImagePath = "/images/profile-hans.png"
        };
        return View(model);
    }
}