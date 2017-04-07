using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMA.Disaster.Recovery.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SBAConsolidation()
        {
            return View();
        }

        public ActionResult SBAWorksheetOutput()
        {
            return View();
        }

        public ActionResult IndividualWorksheetOutput()
        {
            return View();
        }
    }
}