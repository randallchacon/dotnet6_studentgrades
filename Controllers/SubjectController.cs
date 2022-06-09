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
        public IActionResult Multiple()
        {
            var SubjectList = new List<Subject>(){
                new Subject{Name="Finance", UniqueId= Guid.NewGuid().ToString()},
                new Subject{Name="Data bases", UniqueId= Guid.NewGuid().ToString()},
                new Subject{Name="Web programming", UniqueId= Guid.NewGuid().ToString()},
                new Subject{Name="HTML and CSS", UniqueId= Guid.NewGuid().ToString()},
                new Subject{Name="Security", UniqueId= Guid.NewGuid().ToString()},
            };

            var subject = new Subject(){
                UniqueId = Guid.NewGuid().ToString(),
                Name = "C# programming",
            };

            ViewBag.DynamicData = "Dynamic information";
            ViewBag.Date = DateTime.Now;

            return View(SubjectList);
        }        
    }
}
