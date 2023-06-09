using NDKSkateShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NDKSkateShopMVC.Controllers
{
    public class TimKiemController : Controller
    {
          // GET: TimKiem
            QLSSNDKEntities db = new QLSSNDKEntities();
            public ActionResult KQTimKiem(string search)
            {
                var lstsp = db.SanPhams.Where(n => n.TenSP.Contains(search));
                return View(lstsp.OrderBy(n => n.TenSP));
            }
        
    }
}
