using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kurumsal1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        
        public ActionResult Urunler()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}