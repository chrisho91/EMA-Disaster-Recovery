using EMA.Disaster.Recovery.DAL;
using EMA.Disaster.Recovery.Models;
using System.Web.Mvc;

namespace EMA.Disaster.Recovery.Controllers
{
    public class SBAWorksheetController : Controller
    {
        public Context db = new Context();

        // GET: SBAWorksheet
        public ActionResult Index()
        {
            return View();
        }

        //Start SBA Worksheet
        public ActionResult Create()
        {
            SBAWorksheet create = new SBAWorksheet();
            return View(create);
        }
    }
}