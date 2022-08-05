using Microsoft.AspNetCore.Mvc;

namespace Buoi1_T6_05_08_22_MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View("Index2");
        }
    }
}
