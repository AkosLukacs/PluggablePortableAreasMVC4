using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PluggablePortableAreasMVC4.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to PluggablePortableAreasMVC4.Web!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
