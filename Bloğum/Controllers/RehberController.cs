using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSitesiBlog.Models.Siniflar;

namespace TatilSitesiBlog.Controllers
{
    public class RehberController : Controller
    {
        // GET: Rehber

        Context c = new Context();
        OtelYorum ot = new OtelYorum();
        RestaurantYorum ro = new RestaurantYorum();
        MüzelerYorum my = new MüzelerYorum();
        public ActionResult Index3()
        {
            var degerli = c.Otellers.Take(2).ToList();
            //var degerleri = c.Restaurantlars.Take(2).ToList();
            //var degerlerii = c.Müzelers.Take(2).ToList();
            return View(degerli);
        }
        public ActionResult Index()
        {
            ot.Deger1 = c.Otellers.ToList();
            ot.Deger3 = c.Otellers.Take(3);
            return View(ot);
        }

        public ActionResult OtelDetay(int id)
        {
            ot.Deger1 = c.Otellers.Where(a => a.ID == id).ToList();
            ot.Deger2 = c.Yorumlars.Where(a => a.Otellerid == id).ToList();
            return View(ot);

        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.degerli = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        public ActionResult Index1()
        {
            ro.Deger1 = c.Restaurantlars.ToList();
            ro.Deger3 = c.Restaurantlars.Take(1);
            return View(ro);
        }
        public ActionResult RestaurantDetay(int id)
        {
            ro.Deger1 = c.Restaurantlars.Where(r => r.ID == id).ToList();
            ro.Deger2 = c.Yorumlars.Where(r => r.Restaurantlarid == id).ToList();
            return View(ro);

        }
        [HttpGet]
        public PartialViewResult YorumYapRestorant(int id)
        {
            ViewBag.degerlires = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYapRestorant(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        public ActionResult Index2()
        {
            my.Deger1 = c.Müzelers.ToList();
            my.Deger3 = c.Müzelers.Take(3);
            return View(my);
        }
        public ActionResult MüzelerDetay(int id)
        {
            my.Deger1 = c.Müzelers.Where(w => w.ID == id).ToList();
            my.Deger2 = c.Yorumlars.Where(w => w.Müzelerid == id).ToList();
            return View(my);

        }
        public PartialViewResult YorumYapMüzeler(int id)
        {
            ViewBag.degerlimüz = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYapMüzeler(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }

    }
}