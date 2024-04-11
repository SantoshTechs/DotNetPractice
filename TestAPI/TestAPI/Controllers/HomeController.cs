using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult IndexTest()
        {

            int a = 10; int b = 20;
            ViewBag.Title = "Home Page for siddhika"; 

            return View();
        }
    }
}
