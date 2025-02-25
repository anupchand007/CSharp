using Microsoft.AspNetCore.Mvc;

namespace RoutingWihtoutMVC.Controllers
{
    //public class HomeController : Controller
    //{
    //    //For Convention Based Routing
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    public IActionResult About()
    //    {
    //        return View();
    //    }

    //    //{id} to show the id
    //    public int Details(int? id)
    //    {
    //        return id ?? 1;      //?? null operator i.e if the value is not given then it will return 1
    //    }

    //}
//------------------------------------------------------------------//
    //For Attribute Based Routing


    //method 1
    //[Route("Home")] //by decalring home above the controller we dont need to explictilly decaler every time like in [Route("Home/Index")] or [Route("Home/About")], we can directly use [Route("About")]

    //method 2
    [Route("[controller]/[action]")] //usign this the [controller] will be replaced by the HomeController2
    public class HomeController : Controller
    {
        //empty route;
        [Route("")] // it will execute the Index() method
        [Route("~/Home")]       //point the root folder and also if we just provide [Route("~/")] it will so error when we call controller so when have to give: Route("~/Home")]  

        //method 1
        //[Route("Home")]     //it can be removed
        //[Route("Home/Index")]


        //method 2
        //[Route("Index")]

        public IActionResult Index()
        {
            return View();
        }

        //method 1
        //[Route("Home/About")]


        public IActionResult About()
        {
            return View();
        }

        //method 1
        //[Route("Home/Details/{id?}")]        //{id} to show the id


        public int Details(int? id)
        {
            return id ?? 1;      //?? null operator i.e if the value is not given then it will return 1
        }
    }
}
