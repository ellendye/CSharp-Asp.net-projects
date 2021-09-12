using System;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers     
{
    public class Time : Controller   
    {
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}