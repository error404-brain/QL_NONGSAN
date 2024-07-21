using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYNONGSAN_NHOM2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult main()
        {
            return View();
        }
        
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult showroom()
        {
            return View();
        }
    }
}