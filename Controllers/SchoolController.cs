using dotnet6_studentgrades.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_studentgrades.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new School(){
                SchoolId = Guid.NewGuid().ToString(),
                Name = ".NET School",
                FoundedYear = 2022
            };
            return View(school);
        }
    }
}
