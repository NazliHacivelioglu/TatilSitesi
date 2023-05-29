using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TatilSitesiBlog.Models.Siniflar;

namespace TatilSitesiBlog.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Oteller> Otellers { get; set; }
        public DbSet<Restaurantlar> Restaurantlars { get; set; }
        public DbSet<Müzeler> Müzelers { get; set; }

    }
}