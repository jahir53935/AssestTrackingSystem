using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssistTrackingSystem.Models;

namespace AssistTrackingSystem.Controllers
{
    public class ModelSetupController : Controller
    {
        // GET: ModelSetup
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Model model)
        {
            return View();
        }
    }
}