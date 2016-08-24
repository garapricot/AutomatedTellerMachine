using System;
using System.Web.Mvc;
using AutoMatedAutomatedTellerMachine.CustomAttributes;
using System.Linq;
using Microsoft.AspNet.Identity;
using AutoMatedAutomatedTellerMachine.Contexts;
using System.Web;
using Microsoft.AspNet.Identity.Owin;

namespace AutoMatedAutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Authorize]
        public ActionResult Index()
        {         
            var userId = User.Identity.GetUserId();
            var checkingAccountId = db.CheckingAccounts.Where(c => c.ApplicationUserId == userId).First().Id;
            ViewBag.CheckingAccountId = checkingAccountId;
            var manager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = manager.FindById(userId);
            ViewBag.Pin = user.Pin;
            return View();
        }        
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