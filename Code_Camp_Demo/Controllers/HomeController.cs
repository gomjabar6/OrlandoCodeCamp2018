using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Code_Camp_Demo.Models;
using System.Threading;
using Microsoft.ApplicationInsights;

namespace Code_Camp_Demo.Controllers
{
    public class HomeController : Controller
    {
        private TelemetryClient telemetry = new TelemetryClient();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to Orlando Code Camp 2018!";

            return View();
        }

        public IActionResult Contact()
        {
            // Add some delay for this one
            Random rnd = new Random();
            Thread.Sleep(rnd.Next(1, 4) * 1000);
            

            ViewData["Message"] = "Created by CyberMedics, LLC.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult OpenSlides()
        {
            telemetry.TrackEvent("OpenSlides");
            return Redirect(string.Format("https://cybermedics-my.sharepoint.com/:p:/g/personal/garrett_gscurtis_com/ESgK65gUkN9Mt70tM8sk_BoBcxxXx7rugCIZXDp3UMWazQ?e=PWN86w"));
        }
    }
}
