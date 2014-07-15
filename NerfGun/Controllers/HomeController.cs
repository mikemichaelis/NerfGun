using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NerfGun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Data Collector";

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            Guid? userId = null;
            try
            {
                userId = (Guid)Membership.GetUser().ProviderUserKey;
            }
            catch { }

            DataPoint point = new DataPoint() { Created = DateTime.Now, UserId = userId };

            var lat = collection["lat"];
            var lon = collection["lon"];
            var party = collection["party"];
            var strength = collection["strength"];
            var happy = collection["happy"];
            var friendly = collection["friendly"];
            var talk = collection["talk"];
            var political = collection["political"];
            var opinionated = collection["opinionated"];
            var votes = collection["votes"];
            var note = collection["note"];

            try { if (!String.IsNullOrWhiteSpace(lat)) point.Lat = Double.Parse(lat); } 
            catch { }
            
            try { if (!String.IsNullOrWhiteSpace(lon)) point.Lon = Double.Parse(lon); } 
            catch { }

            try { if (!String.IsNullOrWhiteSpace(party)) point.Party = party; }
            catch { }

            try { if (!String.IsNullOrWhiteSpace(strength)) point.Strength = Int32.Parse(strength); }
            catch { }

            try { if (!String.IsNullOrWhiteSpace(happy)) point.Happy = Int32.Parse(happy); }
            catch { }

            try { if (!String.IsNullOrWhiteSpace(friendly)) point.Friendly = Int32.Parse(friendly); }
            catch { }

            try { if (!String.IsNullOrWhiteSpace(talk)) point.Talk = Int32.Parse(talk); }
            catch { }

            try { if (!String.IsNullOrWhiteSpace(political)) point.Political = Int32.Parse(political); }
            catch { }

            try { if (!String.IsNullOrWhiteSpace(opinionated)) point.Opinionated = Int32.Parse(opinionated); }
            catch { }

            try { if (!String.IsNullOrWhiteSpace(votes)) point.Votes = Int32.Parse(votes); }
            catch { }

            try { if (!String.IsNullOrWhiteSpace(note)) point.Note = note; }
            catch { }

            NerfGunEntities ctx = new NerfGunEntities();
            ctx.DataPointSet.Add(point);

            try
            {
                ctx.SaveChanges();
            }
            catch { }

            return Index();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Data Collector provides allows the collection of data with an associated location";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "mike@xsdconsulting.com";

            return View();
        }

        [HttpPost]
        public ActionResult Submit()
        {
            ViewBag.Message = "Data Submit";

            return View();
        }
    }
}
