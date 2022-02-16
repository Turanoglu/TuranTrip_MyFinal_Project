using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuranTrip.Models;
using TuranTrip.Models.Sınıflar;

namespace TuranTrip.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();

            return View(degerler);
        }
    }
}