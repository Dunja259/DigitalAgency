using Projekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekat.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            ViewBag.naslov = "Digital Marketing Agency";
            ViewBag.tekst = "There is no such thing as a great agency, just great people in agencies. We are a team of online marketing experts with background in top - notch companies such as Google, Accenture and Oracle.";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Work()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult Contact(Models.mainModel form)
        {
            return View("ContactFormAnswer", form);
        }

        [HttpGet]
        public ActionResult Services()
        {
            Company[] companies = new Company[]
           {
                new Company("Export","Logo"),
                new Company("Startups", "Logo"),
                new Company("Online trading voucher", "Logo")
           };
            List<string> name = new List<string>();
            foreach (Company c in companies)
            {
                name.Add(c.name);
            }
            ViewBag.name = name;

            return View();
        }

        [HttpPost]
        public ViewResult Services(Models.mainModel services)
        {
            return View("ServiceChoice", services);
            
        }

        [HttpGet]
        public ActionResult Plan()
        {
            Company[] companies = new Company[]
            {
                new Company("WebFX","Logo"),
                new Company("Ignite Visibility", "Logo"),
                new Company("SocialSEO", "Logo"),
                new Company("Victorious", "Logo")
            };

            List<string> name = new List<string>();
            foreach (Company c in companies)
            {
                name.Add(c.name);
            }
            ViewBag.name = name;


            return View();
        }

        [HttpPost]
        public ViewResult Plan(Models.mainModel plan)
        {
            

            return View("YourPlan", plan);
        }

    }
}