using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TuranTrip.Models.Sınıflar
{
    public class Restaurant
    {

        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }      
        public string Aciklama { get; set; }
        public string RestaurantImage { get; set; }
        public int RestaurantPuan { get; set; }
        public int ServisHızı { get; set; }
        [Required]
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        
    }
}