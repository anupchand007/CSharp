using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TagHelpersDemo.Models;

namespace TagHelpersDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [Route("")] //it represent when URL is empty 
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public string Process(Employee emp)
    {
        return "Name " + emp.Name + ", Empid " + emp.EmpID + ", Gender " + emp.Gender + ", Salary " + emp.Salary + ", DOB Day " + emp.Day + ", Month " + emp.Month + ", Year " + emp.Year + ", Dec" + emp.Description;
    }

    public IActionResult Contact()
    {
        return View();
    }

    public int Edit(int id)
    {
        return id;
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
