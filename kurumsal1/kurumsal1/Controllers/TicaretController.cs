using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kurumsal1.Models;

namespace kurumsal1.Controllers
{
    public class TicaretController : Controller
    {
        Kurumsal1_DBEntities db = new Kurumsal1_DBEntities();

        // GET: Ticaret
        public ActionResult Index()
        {
            //List<tbl_urunler> urunler = db.tbl_urunler.ToList();
            List<tbl_urunler> enyeni = db.tbl_urunler.Where(a => a.Encok == 1).ToList();

            return View(enyeni);
        }
    }
}