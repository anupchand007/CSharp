using Microsoft.AspNetCore.Mvc;

namespace RoutingWihtoutMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
