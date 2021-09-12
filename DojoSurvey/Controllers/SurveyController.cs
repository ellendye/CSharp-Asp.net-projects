using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class Survey : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string location, string language, string comment )
        {
            ViewBag.Name = name;
            ViewBag.Location = location; 
            ViewBag.Language = language;
            ViewBag.Comment = comment; 
            return View();
        }
    }
}