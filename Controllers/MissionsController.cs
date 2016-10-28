using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult Index()
        {
            ViewBag.Message = "Missions";

            return View();
        }

        public ActionResult Faq( string name, string mpName, string address, string language, string climate, string religion, string flag)
        {
            ViewBag.name = name;
            ViewBag.mpName = mpName;
            ViewBag.address = address;
            ViewBag.language = language;
            ViewBag.climate = climate;
            ViewBag.religion = religion;
            ViewBag.flag = flag;

            return View();
        }

        public ActionResult Videos()
        {
            return View();
        }
    }
}