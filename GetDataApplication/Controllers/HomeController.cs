using Microsoft.AspNetCore.Mvc;

namespace GetDataApplication.Controllers
{
    public class HomeController : Controller
    {
       //Get
       public ActionResult Index()
       {
            return View();
       }

       public IActionResult Privacy()
        {
            return View();
        }

    }
}