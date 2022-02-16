using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TuranTrip.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]      
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }  
        [Required]
        [ForeignKey("Blog")]
        public int Blogid { get; set; }  
        
        public  virtual Blog Blog { get; set; }
    }
}