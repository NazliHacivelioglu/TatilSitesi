using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSitesiBlog.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public int Otellerid { get; set; }
        public int Restaurantlarid { get; set; }
        public int Müzelerid { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual Oteller Otel { get; set; }
        public virtual Restaurantlar Restaurant { get; set; }
        public virtual Müzeler Müze { get; set; }
    }
}