using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuranTrip.Models.Sınıflar
{
    public class GenelAyarlar
    {
        [Key]
        public int ID { get; set; }
        public string Logo { get; set; }
        public string SuperBaslik { get; set; }
        public string SuperAciklama { get; set; }
        public int Whatsapp { get; set; }


    }
}