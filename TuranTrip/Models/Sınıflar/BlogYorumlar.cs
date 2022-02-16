using System;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuranTrip.Models.Sınıflar
{
    public class BlogYorumlar
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
        //public IEnumerable<Blog> Deger4 { get; set; }
        public IEnumerable<Restaurant> restrnt { get; set; }
        public IEnumerable<Otel> otel { get; set; }
        
    }
}