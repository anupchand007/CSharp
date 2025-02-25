using Microsoft.AspNetCore.Mvc;

namespace ControllersAndAction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();  
            //Note: IActionResult is inherited by many child classes  for eg: ViewResult, PartialViewResult, JsonResult etc. So it can return various type of data
        }

        public string DisplayString()
        {
            return "Welcome Beatuiful word";
        }

        public int DisplayId(int id)
        {
            return id;
           
        }


    }
}
