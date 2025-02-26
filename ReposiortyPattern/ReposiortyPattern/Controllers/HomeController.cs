using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReposiortyPattern.Models;
using ReposiortyPattern.Repository;

namespace ReposiortyPattern.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly StudentRepo _studentrepo;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _studentrepo = new StudentRepo();
    }

    public List<StudentModel> getAll()
    {
        return _studentrepo.getAll();
    }

    public StudentModel getById(int id)
    {
        return _studentrepo.getByID(id);
    }



    public IActionResult Index()
    {
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
