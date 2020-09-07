using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIStudentSecurity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ViewResult About()
        {
            throw new NotImplementedException();
        }

        public ViewResult Contact()
        {
            throw new NotImplementedException();
        }
    }
}
