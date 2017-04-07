using System.Web.Mvc;
using EMA.Disaster.Recovery.Models;
using EMA.Disaster.Recovery.DAL;
using System.Linq;
namespace EMA.Disaster.Recovery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult StartClaim()
        {
            return View();
        }

    }

}