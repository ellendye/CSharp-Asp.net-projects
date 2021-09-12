using System;
using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers     //be sure to use your own project's namespace!
{
    public class Portfolio : Controller   //remember inheritance??
    {
        // Other code
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }


    }
}

