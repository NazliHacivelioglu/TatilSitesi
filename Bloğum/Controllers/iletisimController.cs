using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSitesiBlog.Models.Siniflar;

namespace TatilSitesiBlog.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim

        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.iletisims.ToList();
            return View(degerler);
            
        }
    }
}