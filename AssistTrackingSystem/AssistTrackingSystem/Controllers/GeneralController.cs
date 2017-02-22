using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssistTrackingSystem.Models;

namespace AssistTrackingSystem.Controllers
{
    public class GeneralController : Controller
    {
        // GET: General
        public ActionResult Index ()
        {
            return View();
        }

        public ActionResult Save (General general)
        {
            return View();
        }

    }
}