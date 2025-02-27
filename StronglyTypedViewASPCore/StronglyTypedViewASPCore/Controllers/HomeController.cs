using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewASPCore.Models;

namespace StronglyTypedViewASPCore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        //Employee obj = new Employee()
        //{
        //    Empid = 101,
        //    Name = "Anup Chand",
        //    Salary = 30000
        //};

        var Employees = new List<Employee> { 
        
            new Employee{ Empid = 1, Name="Anup Chand", Salary= 340242},
            new Employee{ Empid = 2, Name="Anp Chand", Salary= 34022132},
            new Employee{ Empid = 3, Name="Fup Chand", Salary= 213440242},
            new Employee{ Empid = 4, Name="Lup Chand", Salary= 530242},

        };

        return View(Employees);
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
