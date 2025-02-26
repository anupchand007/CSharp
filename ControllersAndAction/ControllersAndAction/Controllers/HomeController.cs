using Microsoft.AspNetCore.Mvc;

namespace ControllersAndAction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            //To Passes Data from controller to view we can use various methods

            //1. ViewData

            //ViewData["Name"] = "Anup Chand";
            //ViewData["Age"] = 22;
            //ViewData["Time"] = DateTime.Now;

            //string[] arr = { "Anup", "Bimal" };
            //ViewData["Array"] = arr;

            //ViewData["Games"] = new List<string>{
            //    "Valorant", "Alan Wake", "Last of Us"
            //};

            //2. ViewBag

            //ViewBag.data1 = "Learn .Net";
            //ViewBag.data2 = 21;
            //ViewBag.data3 = DateTime.Now.ToShortTimeString();


            //string[] arrs = { "Anup", "Bimal", "Sumit", "Ananta" };
            //ViewBag.data4 = arrs;

            //ViewBag.data5 = new List<string> {

            // "Valorant", "Alan Wake", "Last of Us"

            //};

            //1-2 Interchangable 

            //ViewData["data"] = "This is the data from ViewData[] being accesed by ViewBag";

            //ViewBag.Me = "It me anup chand, Data of ViewBag but being accessed and Printed using ViewData Method";

            //3. TempData

            ViewData["data1"] = "View Data";
            ViewBag.data2 = "View Bag";
            TempData["data3"] = "Temp Data";

            TempData["Games"] = new List<string> { "Valorant", "Alan Wake", "Last of Us" };


            TempData.Keep("data3");        //keeps the value for 2nd or 3rd request
            return View();
            //Note: IActionResult is inherited by many child classes  for eg: ViewResult, PartialViewResult, JsonResult etc. So it can return various type of data
        }

        public IActionResult About()
        {
            TempData.Keep("data3");
            return View();
        }
        public IActionResult Contact()
        {
            TempData.Keep("data3");
            return View();
        }

        //public int DisplayId(int id)
        //{
        //    return id;

        //}


    }
}
