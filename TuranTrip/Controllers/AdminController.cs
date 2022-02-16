using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuranTrip.Models;
using TuranTrip.Models.Sınıflar;

namespace TuranTrip.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index(int page = 1)
        {
           
            var degerler = c.Blogs.ToList();
            return View(degerler.ToPagedList(page, 8));
        }

        public ActionResult Restaurant(int page = 1)
        {
            var degerler = c.Restaurants.ToList();
            return View(degerler.ToPagedList(page, 5));
        }
        public ActionResult RestaurantGetir(int id)
        {
            var rt = c.Restaurants.Find(id);
            ViewBag.Bloglar = new SelectList(c.Blogs,"ID","Baslik");
            return View("RestaurantGetir", rt);
        }
        public ActionResult RestaurantSil(int id)
        {
            var r = c.Restaurants.Find(id);
            c.Restaurants.Remove(r);
            c.SaveChanges();
            return RedirectToAction("Restaurant");
        }
        public ActionResult RestGuncelle(Restaurant r)
        {
            var rest = c.Restaurants.Find(r.ID);
            rest.Aciklama = r.Aciklama;
            rest.Baslik = r.Baslik;
            rest.Aciklama = r.Aciklama;
            rest.BlogId= r.BlogId;
            rest.RestaurantImage = r.RestaurantImage;
            rest.RestaurantPuan = r.RestaurantPuan;
            rest.ServisHızı = r.ServisHızı;
            c.SaveChanges();
            return RedirectToAction("Restaurant");

        }
        [HttpGet]
        public ActionResult YeniRestaurant()
        {
            ViewBag.Bloglars = new SelectList(c.Blogs, "ID", "Baslik");
            return View();
        }
        [HttpPost]
        public ActionResult YeniRestaurant(Restaurant r)
        {
            //ViewBag.Bloglars = new SelectList(c.Blogs, "ID", "Baslik");

            c.Restaurants.Add(r);
            c.SaveChanges();
            return RedirectToAction("Restaurant");
        }
        public ActionResult Otel(int page = 1)
        {
            var degerler = c.Otels.ToList();
            return View(degerler.ToPagedList(page, 5));
        }
        public ActionResult OtelGetir(int id)
        {
            var ot = c.Otels.Find(id);
            ViewBag.Bloglar = new SelectList(c.Blogs, "ID", "Baslik");
            return View("OtelGetir", ot);
        }
        public ActionResult OtelSil(int id)
        {
            var o = c.Otels.Find(id);
            c.Otels.Remove(o);
            c.SaveChanges();
            return RedirectToAction("Otel");
        }
        public ActionResult OtelGuncelle(Otel o)
        {
            var ot = c.Otels.Find(o.ID);
            ot.Aciklama = o.Aciklama;
            ot.Baslik = o.Baslik;
            ot.Aciklama = o.Aciklama;
            ot.BlogId = o.BlogId;
            ot.OtelImage = o.OtelImage;
            ot.OtelPuan = o.OtelPuan;
            ot.OtelTemizlik = o.OtelTemizlik;
            c.SaveChanges();
            return RedirectToAction("Otel");

        }
        [HttpGet]
        public ActionResult YeniOtel()
        {

            ViewBag.Bloglars = new SelectList(c.Blogs, "ID", "Baslik");
            return View();
            
        }
        [HttpPost]
        public ActionResult YeniOtel(Otel o)
        {

            c.Otels.Add(o);
            c.SaveChanges();
            return RedirectToAction("Otel");
        }


        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult YorumListesi(int page = 1)
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar.ToPagedList(page, 8));
        }

        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
           
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }

        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;           
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

        public ActionResult iletisim()
        {
            var iltsm = c.iletisims.ToList();
            return View(iltsm);
        }

        public ActionResult AboutIndex()
        {
            var deger = c.Hakkimizdas.ToList();
            return View(deger);
        }
        public ActionResult AboutGuncelle(Hakkimizda h)
        {
            var abt = c.Hakkimizdas.Find(h.ID);
            abt.FotoUrl = h.FotoUrl;
            abt.Aciklama = h.Aciklama;           
            c.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
        public ActionResult AboutGetir(int id)
        {
            var deger = c.Hakkimizdas.Find(id);
            return View("AboutGetir", deger);
        }

        public ActionResult AboutSil(int id)
        {
            var abt = c.Hakkimizdas.Find(id);
            c.Hakkimizdas.Remove(abt);
            c.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
        [HttpGet]
        public ActionResult AboutEkle()
        {

           
            return View();
        }
        [HttpPost]
        public ActionResult AboutEkle(Hakkimizda h)
        {

            c.Hakkimizdas.Add(h);
            c.SaveChanges();
            return RedirectToAction("AboutIndex");
        }

        public ActionResult GenelAyarlar()
        {
            var degerler = c.GenelAyarlars.ToList();
            return View(degerler);
        }
        public ActionResult GenelAyarSil(int id)
        {

            var g = c.GenelAyarlars.Find(id);
            c.GenelAyarlars.Remove(g);
            c.SaveChanges();
            return RedirectToAction("GenelAyarlar");
        }
        public ActionResult GenelAyarGetir(int id)
        {
            var gl = c.GenelAyarlars.Find(id);
            return View("GenelAyarGetir", gl);
        }
        public ActionResult GenelAyarGuncelle(GenelAyarlar g)
        {
            var gnl = c.GenelAyarlars.Find(g.ID);
            gnl.Logo = g.Logo;
            gnl.SuperBaslik = g.SuperBaslik;
            gnl.SuperAciklama = g.SuperAciklama;
            gnl.Whatsapp = g.Whatsapp;
            
            c.SaveChanges();
            return RedirectToAction("GenelAyarlar");
        }
        [HttpGet]
        public ActionResult GenelAyarEkle()
        {


            return View();
        }
        [HttpPost]
        public ActionResult GenelAyarEkle(GenelAyarlar g)
        {

            c.GenelAyarlars.Add(g);
            c.SaveChanges();
            return RedirectToAction("GenelAyarlar");
        }



    }
}