using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppSettings.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.WebConfig = ConfigurationManager.AppSettings["test"];
            ViewBag.AppSettings = Startup.AppSettings["test"];
            return View(ViewBag);
        }
    }
}