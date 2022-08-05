using Microsoft.AspNetCore.Mvc;

namespace Buoi1_T6_05_08_22_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
