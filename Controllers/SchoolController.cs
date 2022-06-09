using dotnet6_studentgrades.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_studentgrades.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext _context;
        public IActionResult Index()
        {
            ViewBag.DynamicData = "Dynamic information";
            var school = _context.Schools.FirstOrDefault();
            return View(school);
        }

        public SchoolController(SchoolContext context)
        {
            _context = context;
        }
    }
}
