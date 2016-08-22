using System;
using System.Web.Mvc;
using AutoMatedAutomatedTellerMachine.CustomAttributes;

namespace AutoMatedAutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        
        [MyLogginnigFilterAtributte]
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("about-this-atm")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }
        public ActionResult Contact()
        {
            
            ViewBag.TheMessage = "Having Trouble ? Send Us A message";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO : send me to HQ
            ViewBag.TheMessage = "Thanks, we got your message";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETATMMVC1";
            // return Json(new {name = "serial", value = serial}, JsonRequestBehavior.AllowGet);
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            return RedirectToAction("Index");
            
        }
    }
}