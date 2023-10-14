using Microsoft.AspNetCore.Mvc;

namespace Core_Web_App_MVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
