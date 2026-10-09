using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers;

public class ProfileController : Controller
{
    public IActionResult Index()
    {
        var model = new ProfileViewModel
        {
            FullName = "Marvin Celzo Barrios",
            Course = "Bachelor of Science in Computer Science",
            School = "Polytechnic University of the Philippines",
            Bio = "✨hello.✨\n" + "Age: 21\n" + "Height: 5\'4\"\n" + "Hobbies: Designing, Art, Computer, Gaming, Event Management",
            ImagePath = "/images/profile-marvin.jpg",
            Skills    = new List<string> { "C#", "C", "Java", "Python", "CSS" }
        };
        return View(model);
    }
}
