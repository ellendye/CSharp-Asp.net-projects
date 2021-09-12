using System;
using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers     //be sure to use your own project's namespace!
{
    public class Fun : Controller   //remember inheritance??
    {
        // Other code
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}
