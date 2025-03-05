using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public void InsertData(Student std)
    {
        using (var context = new SchoolContext())
        {
            context.Students.Add(std);
            context.SaveChanges();
        }
    }

    public void UpdateStudent(int id, string name)
    {
        using (var context = new SchoolContext())
        {
            var student = context.Students.Find(id);
            if (student != null)
            {
                student.Name = name;
                context.SaveChanges();
            }
        }
    }

    public void DeleteStudent(int id)
    {
        using (var context = new SchoolContext())
        {
            var student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }

}
