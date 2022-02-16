using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TuranTrip.Models.Sınıflar;

namespace TuranTrip.Models
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<GenelAyarlar> GenelAyarlars { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Otel> Otels { get; set; }
    }
}