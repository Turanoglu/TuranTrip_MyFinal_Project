using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuranTrip.Models.Sınıflar
{
    public class iletisim
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="bu alan boş geçilemez!")]
        public string AdSoyad { get; set; }
        [Required(ErrorMessage = "bu alan boş geçilemez!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Mail { get; set; }
        public string Mesaj { get; set; }
    }
}