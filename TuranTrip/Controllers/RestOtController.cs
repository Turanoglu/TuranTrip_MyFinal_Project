using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuranTrip.Models;
using TuranTrip.Models.Sınıflar;

namespace TuranTrip.Controllers
{
    public class RestOtController : Controller
    {

        Context c = new Context();
        RestOt rstotl = new RestOt();
        // GET: RestOt
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RestaurantList()
        {
            rstotl.Rest = c.Restaurants.ToList();
            //var rst = c.Restaurants.ToList();
            //var degerler = c.Restaurants.ToList();
            //return View(degerler);
            return View(rstotl);
        }
        public ActionResult OtelList()
        {
            rstotl.Otl = c.Otels.ToList();
            //var degerler = c.Otels.ToList();
            return View(rstotl);
        }
        
        public ActionResult RestaurantListele(int id)
        {
            
            var rst = c.Restaurants.Where(x => x.BlogId == id).ToList();
            return View(rst);
            
        }
        public ActionResult OtelListele(int id)
        {
            var otl = c.Otels.Where(x => x.BlogId == id).ToList();
            return View(otl);
        }
        public ActionResult RestaurantDetay(int id)
        {
            var rest = c.Restaurants.Where(x => x.ID == id).ToList();
            return View(rest);
        }
         public ActionResult OtelDetay(int id)
        {
            var otel = c.Otels.Where(x => x.ID == id).ToList();
            return View(otel);
        }

    }
}