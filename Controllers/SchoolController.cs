using dotnet6_studentgrades.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_studentgrades.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new School(){
                FoundedYear = 2022,
                UniqueId = Guid.NewGuid().ToString(),
                Name = ".NET School",
                City = "San José",
                Country = "Costa Rica",
                Address = "Central Avenue",
                SchoolType = SchoolType.Secondary
            };
            ViewBag.DynamicData = "Dynamic information";

            return View(school);
        }
    }
}
