using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;

namespace ModelDataUsingViewData.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //WHEN WE HAVE SINGLE OBJECT

        //Employee emp = new Employee()
        //{
        //    EmpId = 2,
        //    Name = "Anup Chand",
        //    salary = 25000

        //};

        //ViewData["myEmployee"] = emp;

        //ViewBag.myEmployee = emp;

        //TempData["myEmployee"] = emp;


        //WHEN WE HAVE LIST OF OBJECTS

        var employees = new List<Employee> {

          new Employee { EmpId = 1, Name = "Anup", salary = 3456089 },
          new Employee { EmpId = 2, Name = "Bimal", salary = 438905 },
          new Employee { EmpId = 3, Name = "Sumit", salary = 345890 },
          new Employee { EmpId = 4, Name = "Ananta", salary = 652834 },
        };

        ViewData["myEmployees"] = null;
        ViewBag.myEmployee = employees;
        TempData["myEmployee"] = employees;



        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
