using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string password = "";
            ViewBag.Password = HttpContext.Session.GetString("Password");
            string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            for (int i = 0; i<14; i++)
            {
                password += chars[random.Next(0,62)];
            }
            ViewBag.Password = password;
            HttpContext.Session.SetString("Password", password);

            int? counter = HttpContext.Session.GetInt32("PWCount");
            if(counter == null)
            {
                HttpContext.Session.SetInt32("PWCount", 1);
            }
            ViewBag.Count = counter;
            
            return View();
        }

        [HttpGet("GeneratePassword")]
        public IActionResult GeneratePassword()
        {
            ViewBag.Password = HttpContext.Session.GetString("Password");
            int? counter = HttpContext.Session.GetInt32("PWCount");
            if(counter == null)
            {
                HttpContext.Session.SetInt32("PWCount", 1);
            }
            HttpContext.Session.SetInt32("PWCount", (int)counter + 1);
            ViewBag.Count = counter;

            string password = "";
            string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            for (int i = 0; i<14; i++)
            {
                password += chars[random.Next(0,62)];
            }
            ViewBag.Password = password;
            
            return RedirectToAction("Index");
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
