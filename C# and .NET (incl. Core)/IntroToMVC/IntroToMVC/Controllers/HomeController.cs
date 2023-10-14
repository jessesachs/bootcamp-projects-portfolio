using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IntroToMVC.Models.User user = new IntroToMVC.Models.User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Sachs";
            user.Age = 27;


            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}