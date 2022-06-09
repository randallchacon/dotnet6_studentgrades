using dotnet6_studentgrades.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_studentgrades.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            var subject = new Student(){
                Id = Guid.NewGuid().ToString(),
                Name = "C# programming",
            };

            ViewBag.DynamicData = "Dynamic information";
            ViewBag.Date = DateTime.Now;

            return View(subject);
        }
        public IActionResult Multiple()
        {
            var SubjectList = new List<Student>(){
                new Student{Name="Finance", Id= Guid.NewGuid().ToString()},
                new Student{Name="Data bases", Id= Guid.NewGuid().ToString()},
                new Student{Name="Web programming", Id= Guid.NewGuid().ToString()},
                new Student{Name="HTML and CSS", Id= Guid.NewGuid().ToString()},
                new Student{Name="Security", Id= Guid.NewGuid().ToString()},
            };

            var subject = new Student(){
                Id = Guid.NewGuid().ToString(),
                Name = "C# programming",
            };

            ViewBag.DynamicData = "Dynamic information";
            ViewBag.Date = DateTime.Now;

            return View(SubjectList);
        }        
    }
}
