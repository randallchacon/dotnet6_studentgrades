using dotnet6_studentgrades.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dotnet6_studentgrades.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student(){
                Id = Guid.NewGuid().ToString(),
                Name = "Randall",
            };

            ViewBag.DynamicData = "Dynamic information";
            ViewBag.Date = DateTime.Now;

            return View(student);
        }
        public IActionResult Multiple()
        {
            var studentList = GenerateStudents();

            ViewBag.DynamicData = "Dynamic information";
            ViewBag.Date = DateTime.Now;

            return View(studentList);
        }

        private List<Student> GenerateStudents()
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastName = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var studentList = from n1 in name1
                               from n2 in name2
                               from a1 in lastName
                               select new Student { 
                                   Name = $"{n1} {n2} {a1}" ,
                                   Id = Guid.NewGuid().ToString()
                                   };

            return studentList.OrderBy((al) => al.Id).ToList();          
        }        
    }
}
