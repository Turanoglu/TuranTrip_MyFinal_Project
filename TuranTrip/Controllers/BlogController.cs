using System;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuranTrip.Models;
using TuranTrip.Models.Sınıflar;

namespace TuranTrip.Controllers
{
    public class BlogController : Controller
    {
        BlogYorumlar by = new BlogYorumlar();
        Context c = new Context();
        // GET: Blog
        public ActionResult Index()
        {
            by.Deger2 = c.Yorumlars.Take(3).OrderByDescending(x=>x.ID).ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(3).ToList();
            return View(by);
        }
        
        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            
            
            if (c.Restaurants.Where(x => x.BlogId == id).ToList().Count >= 3)
            {
                by.restrnt = c.Restaurants.Take(3).Where(x => x.BlogId == id).ToList();
                //return View(by);
            }
            else
            {
                by.restrnt = c.Restaurants.Where(x => x.BlogId == id).ToList();
                
            }
            if (c.Otels.Where(x => x.BlogId == id).ToList().Count >= 3)
            {
                by.otel = c.Otels.Take(3).Where(x => x.BlogId == id).ToList();
                //return View(by);
            }
            else
            {
                by.otel = c.Otels.Where(x => x.BlogId == id).ToList();
            }
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();


            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap( int id)
        {
            ViewBag.deger = id;
            return PartialView();   
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();

        }

    }
}