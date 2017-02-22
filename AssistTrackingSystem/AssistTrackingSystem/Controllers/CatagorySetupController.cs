using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssistTrackingSystem.Models;

namespace AssistTrackingSystem.Controllers
{
    public class CatagorySetupController : Controller
    {
        // GET: CatagorySetup
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(Catagory catagory)
        {
            return View();
        }
    }
}