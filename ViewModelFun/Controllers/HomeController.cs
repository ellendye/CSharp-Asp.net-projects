using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = "This is a message. This is a message. This is a message. This is a message. This is a message. This is a message. This is a message. This is a message. This is a message. This is a message. This is a message. This is a message. ";
            return View(model:message);
        }
        [HttpGet("user")]
        public IActionResult UserDetail()
        {
            User newUser = new User()
            {
                FirstName = "Ellen",
                LastName = "Dye"
            };
            return View(newUser);
        }
        [HttpGet("users")]
        public IActionResult Users()
        {
            string[] names = new string[]
            {
                "Sally Field", 
                "Billy", 
                "Jerry",
                "Moose loose"
            };

            return View(names);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,
                2,
                3,
                4,
                5,
                6
            };

            return View(numbers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
