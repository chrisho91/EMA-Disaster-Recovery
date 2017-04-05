﻿
using System.Web.Mvc;
using EMA.Disaster.Recovery.Models;
using EMA.Disaster.Recovery.DAL;
using System.Linq;
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


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Start global
        public ActionResult ChooseFormType()
        {
            return View(); 
        }
        public ActionResult NewContact()
        {
            Contact tempContact = new Contact();
            var contacts = db.Set<Contact>();
            if(contacts.Count()!=0)
            {
                tempContact.ID = contacts.OrderByDescending(x => x.ID).First().ID+1;
            }
            else
            {
                tempContact.ID = 1;
            }
            
            return View(tempContact);
        }
        [HttpPost]
        public ActionResult NewContact(Contact contact)
        {
            var contactExists = db.Set<Contact>().FirstOrDefault(x => x.ID == contact.ID);
            if(contactExists!=null)
            {
               
                db.Entry(contactExists).CurrentValues.SetValues(contact);
                
            }
            else
            {
                db.Set<Contact>().Add(contact);
            }
            return NewAddress(contact.ID);
        }
        public ActionResult NewAddress(int id)
        {
            Address address = new Address();
            var addresses = db.Set<Address>();
            if (addresses.Count() != 0)
            {
                address.ID = addresses.OrderByDescending(x => x.ID).First().ID + 1;
            }
            else
            {
                address.ID = 1;
            }
            return View(address);
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

        public ActionResult ViewSBAWorksheet()
        {
            SBAWorksheet worksheet = new SBAWorksheet();
            return View(worksheet);
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

        //Start Master Admin Views
        public ActionResult NewSBASummary()
        {
            return View();
        }

        public ActionResult NewIndividualSummary()
        {
            return View();
        }
    }

}