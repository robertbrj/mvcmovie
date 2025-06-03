using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello" + name;
            ViewData["numTimes"] = numTimes;

            return View();

        }
    }
}