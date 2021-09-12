using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using quotingDojo.Models;

namespace quotingDojo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("quotes")]
        public IActionResult Create(Quotes formdata)
        {
            if(!ModelState.IsValid)
            {
                return View("Index");
            }
            string query = $"INSERT INTO quotes (name, quote) VALUES ('{formdata.name}', '{formdata.userquote}')";
            DbConnector.Execute(query);
            return RedirectToAction("Quotes");
        }

        [HttpGet]
        [Route("quotes")]
        public IActionResult Quotes()
        {
    	    ViewBag.Quotes = DbConnector.Query("SELECT * FROM quotes");
            // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
