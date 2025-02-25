using Microsoft.AspNetCore.Mvc;

namespace ControllersAndAction.Controllers
{ 
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
