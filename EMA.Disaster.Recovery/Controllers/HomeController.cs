
using System.Web.Mvc;
using EMA.Disaster.Recovery.Models;
using EMA.Disaster.Recovery.DAL;

namespace EMA.Disaster.Recovery.Controllers
{
    public class HomeController : Controller
    {
        private Context db = new Context();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Start global
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewAddress()
        {
            return View();
        }

        //Start individual views
        public ActionResult NewCountyMunicipality()
        {
            return View();
        }

        public ActionResult NewIndividualWorksheet()
        {
            return View();
        }

        public ActionResult NewIndividualSystemDamages()
        {
            return View();
        }

        public ActionResult NewIndividualWorksheetDamage()
        {
            return View();
        }

        public ActionResult NewIndividualPhotos()
        {
            return View();
        }

        //Start SBA views
        public ActionResult NewSBAWorksheet()
        {
            return View();
        }

        public ActionResult NewSBALocationType()
        {
            return View();
        }

        public ActionResult NewSBAEconInjurySurvey()
        {
            return View();
        }

        public ActionResult NewSBAPropertyMarketValue()
        {
            return View();
        }

        public ActionResult NewSBAPhotos()
        {
            return View();
        }

    }

}