using ASPCoreViewImport.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { StdID = 1,  Name = "Anup Chand", Gender = "Male"},
                new Student { StdID = 2,  Name = "Cnup Chand", Gender = "Male"},
                new Student { StdID = 3,  Name = "Snup Chand", Gender = "FeMale"},
            };
            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>
            {
                new Student { StdID = 1,  Name = "Anup Chand", Gender = "Male"},
                new Student { StdID = 2,  Name = "Cnup Chand", Gender = "Male"},
                new Student { StdID = 3,  Name = "Snup Chand", Gender = "FeMale"},
            };
            return View(students);

        }
        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
            {
                new Student { StdID = 1,  Name = "Anup Chand", Gender = "Male"},
                new Student { StdID = 2,  Name = "Cnup Chand", Gender = "Male"},
                new Student { StdID = 3,  Name = "Snup Chand", Gender = "FeMale"},
            };
            return View(students);
        }
    }
}
