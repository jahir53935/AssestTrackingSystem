using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssistTrackingSystem.Models;

namespace AssistTrackingSystem.Controllers
{
    public class AssestLocationSetupController : Controller
    {
        // GET: AssestLocationSetup
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Location location)
        {
            return View();
        }
    }
}