using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSitesiBlog.Models.Siniflar;

namespace TatilSitesiBlog.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);          
            return View("BlogGetir",bl);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir( int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail= y.Mail;
            yrm.Yorum= y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
        public ActionResult Index1()
        {
            var degerler = c.Otellers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniOtel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniOtel(Oteller o)
        {
            c.Otellers.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index1");
        }
        public ActionResult OtelSil(int id)
        {
            var o = c.Otellers.Find(id);
            c.Otellers.Remove(o);
            c.SaveChanges();
            return RedirectToAction("Index1");
        }
        public ActionResult OtelGetir(int id)
        {
            var og = c.Otellers.Find(id);
            return View("OtelGetir", og);
        }
        public ActionResult OtelGuncelle(Oteller o)
        {
            var otg = c.Otellers.Find(o.ID);
            otg.Aciklama = o.Aciklama;
            otg.Baslik = o.Baslik;
            otg.BlogImage = o.BlogImage;
            otg.Tarih = o.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index1");

        }

        public ActionResult Index2()
        {
            var restaurant = c.Restaurantlars.ToList();
            return View(restaurant);
        }
        [HttpGet]
        public ActionResult YeniRestaurant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniRestaurant(Restaurantlar re)
        {
            c.Restaurantlars.Add(re);
            c.SaveChanges();
            return RedirectToAction("Index2");
        }
        public ActionResult RestaurantSil(int id)
        {
            var re = c.Restaurantlars.Find(id);
            c.Restaurantlars.Remove(re);
            c.SaveChanges();
            return RedirectToAction("Index2");
        }
        public ActionResult RestaurantGetir(int id)
        {
            var res = c.Restaurantlars.Find(id);
            return View("RestaurantGetir", res);
        }
        public ActionResult RestaurantGuncelle(Restaurantlar r)
        {
            var rese = c.Restaurantlars.Find(r.ID);
            rese.Aciklama = r.Aciklama;
            rese.Baslik = r.Baslik;
            rese.BlogImage = r.BlogImage;
            rese.Tarih = r.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index2");

        }
        public ActionResult Index3()
        {
            var müzeler = c.Müzelers.ToList();
            return View(müzeler);
        }
        [HttpGet]
        public ActionResult YeniMüze()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMüze(Müzeler mü)
        {
            c.Müzelers.Add(mü);
            c.SaveChanges();
            return RedirectToAction("Index3");
        }
        public ActionResult MüzeSil(int id)
        {
            var müz = c.Müzelers.Find(id);
            c.Müzelers.Remove(müz);
            c.SaveChanges();
            return RedirectToAction("Index3");
        }
        public ActionResult MüzeGetir(int id)
        {
            var müzel = c.Müzelers.Find(id);
            return View("MüzeGetir", müzel);
        }
        public ActionResult MüzeGuncelle(Müzeler m)
        {
            var müzele = c.Restaurantlars.Find(m.ID);
            müzele.Aciklama = m.Aciklama;
            müzele.Baslik = m.Baslik;
            müzele.BlogImage = m.BlogImage;
            müzele.Tarih = m.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index3");
            
        }
    }
}