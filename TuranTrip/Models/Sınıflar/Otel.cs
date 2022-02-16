using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuranTrip.Models.Sınıflar
{
    public class Otel
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string OtelImage { get; set; }
        public int OtelPuan{ get; set; }
        public int OtelTemizlik{ get; set; }

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}