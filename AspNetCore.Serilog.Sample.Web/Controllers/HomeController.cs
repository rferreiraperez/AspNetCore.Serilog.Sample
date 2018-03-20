using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Serilog.Sample.Web.Models;
using Microsoft.Extensions.Logging;

namespace AspNetCore.Serilog.Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Your application index page.";

            logger.LogInformation("TEST SERILOG INF. MESSAGE");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            logger.LogWarning("TEST SERILOG WARN. MESSAGE");

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            logger.LogError("TEST SERILOG ERR. MESSAGE");

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
