using Channel9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Channel9.Controllers
{   [AllowAnonymous]
    [RequireHttps]
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

      

        public ActionResult Contact()
        {
           

            return View();
        }
    }
}