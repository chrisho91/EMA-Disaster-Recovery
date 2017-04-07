using System.Web.Mvc;
using EMA.Disaster.Recovery.Models;
using EMA.Disaster.Recovery.DAL;

namespace EMA.Disaster.Recovery.Controllers
{
    public class IndividualWorksheetController : Controller
    {
        public Context db = new Context();

        // GET: IndividualWorksheet
        public ActionResult Index()
        {
            return View();
        }

        //Start individual worksheet
        public ActionResult Create()
        {
            IndividualWorksheet create = db.IndividualWorksheet.Find(1);
            //IndividualWorksheet test = new IndividualWorksheet();
            return View(create);
        }
    }
}