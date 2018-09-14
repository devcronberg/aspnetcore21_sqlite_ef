using aspnetcore21_sqlite_ef.Models;
using aspnetcore21_sqlite_ef.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace aspnetcore21_sqlite_ef.Controllers
{
    public class HomeController : Controller
    {

        private AppSettings appSetting;

        public HomeController(AppSettings appSetting)
        {
            this.appSetting = appSetting;
        }

        public IActionResult Index()
        {
            ViewBag.Kl = DateTime.Now.ToLongTimeString();
            ViewBag.Setting = appSetting.Setting2;
            using (PersonContext context = new PersonContext())
                return View(context.Personer.ToList());
        }

        [HttpGet]
        public IActionResult OpdaterPerson(int id)
        {
            try
            {
                using (PersonContext context = new PersonContext())
                    return Json(context.Personer.Where(i => i.PersonId == id).First());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        [HttpPost]
        public IActionResult OpdaterPerson(Person p)
        {
            try
            {
                using (PersonContext context = new PersonContext())
                {
                    var tmp = context.Personer.Where(i => i.PersonId == p.PersonId).First();
                    tmp.Navn = p.Navn;
                    // opdater kun navn
                    context.SaveChanges();
                    return Json(new { personid = p.PersonId, opdateringOk = true });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }

    }
}