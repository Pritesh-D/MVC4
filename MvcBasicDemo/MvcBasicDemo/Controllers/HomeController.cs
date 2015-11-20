using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasicDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "It Works";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Please Login Here";
            return View();
        }
    }
}
