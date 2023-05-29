using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSitesiBlog.Models.Siniflar
{
    public class RestaurantYorum
    {
        public IEnumerable<Restaurantlar> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Restaurantlar> Deger3 { get; set; }
    }
}