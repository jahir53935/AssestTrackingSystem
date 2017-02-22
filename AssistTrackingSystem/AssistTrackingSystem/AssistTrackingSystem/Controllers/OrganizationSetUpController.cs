using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssistTrackingSystem.Models;

namespace AssistTrackingSystem.Controllers
{
    public class OrganizationSetUpController : Controller
    {
        // GET: OrganizationSetUp
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Organization organization)
        {
            return View();
        }
    }
}