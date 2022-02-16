using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuranTrip.Models;
using TuranTrip.Models.Sınıflar;
using TuranTrip.Models.ViewModel;

namespace TuranTrip.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        // GET: Default
        public ActionResult Index()
        {
            IndexVM model = new IndexVM();
            model.Bloglar = c.Blogs.Take(8).ToList();
            //ViewBag.Logo = c.GenelAyarlars.FirstOrDefault().Logo;
            // model.Ayarlar = 

            return View(model);
        }
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IletisimDefault()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IletisimDefault(iletisim i)
        {
            if (ModelState.IsValid)
            {
                c.iletisims.Add(i);
                c.SaveChanges();
                return RedirectToAction("iletisim","Admin");
            }
            return View();
            
        }



        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Icons()
        {
            return PartialView();
        }

       

    }
}