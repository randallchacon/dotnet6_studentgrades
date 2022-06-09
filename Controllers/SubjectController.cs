using dotnet6_studentgrades.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_studentgrades.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            var subject = new Subject(){
                UniqueId = Guid.NewGuid().ToString(),
                Name = "C# programming",
            };
            ViewBag.DynamicData = "Dynamic information";
            ViewBag.Date = DateTime.Now;

            return View(subject);
        }
    }
}
