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
            Bio = "✨hello.✨\n" + "Age: 20\n" + "Height: 5\'2\"\n" + "Hobbies: Gaming, Game Dev, Digital Art, Playing Instruments, Music Composition",
            ImagePath = "/images/profile-hans.png",
            Skills    = new List<string> { "C", "C#", "Python", "Java", "CSS" }
        };
        return View(model);
    }
}