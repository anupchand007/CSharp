using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using ModelsInASPCore.Repository;

namespace ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;       //declaring the repo

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
                //creating the instance 
        }

        public List<StudentModel> getAllStudent()
        {
            return _studentRepository.getAllStudents();
        }

        public StudentModel getByAge(int age)
        {
            return _studentRepository.getStudentByAge(age);
        }


        public IActionResult Index()
        {
            //ViewBag.students = new List<StudentModel> {

            //   new StudentModel{ Name = "Anup Chand", Age = 22, Standard = "Bachelor 3rd year", Gender = "Male" },

            //   new StudentModel{ Name = "Puspa Chand", Age = 20, Standard = "Bachelor 1st year", Gender = "Female" },

            //   new StudentModel{ Name = "Aarav Chand", Age = 25, Standard = "Masters", Gender = "Male" }

            //};

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Admins()
        {
            ViewBag.Admins = new List<Admins> {

                new Admins{ AdminName = "Purav", AdminRole= "Database Manage", AdminAccess= "Database Full Access"},
                new Admins{ AdminName = "Shuvam", AdminRole= "HR", AdminAccess= "HR Full Access"},
                new Admins{ AdminName = "Puri", AdminRole= "CEO", AdminAccess= " Full Access"},

            };
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
