using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore21_sqlite_ef.Models;
using aspnetcore21_sqlite_ef.Models.Configuration;
using Microsoft.AspNetCore.Mvc;

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
    }
}