using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Homepage()
        {
            HttpContext.Session.SetInt32("happinessCount", 20);
            HttpContext.Session.SetInt32("fullnessCount", 20);
            HttpContext.Session.SetInt32("mealsCount", 3);
            HttpContext.Session.SetInt32("energyCount", 50);
            HttpContext.Session.SetString("imgURL", "~/img/startingninja.jpg");
            HttpContext.Session.SetString("text", "");
            HttpContext.Session.SetString("gameOver", "no");
            return RedirectToAction("Index");
        }
        [HttpGet("dojodachi")]
        public IActionResult Index()
        {
            int? happyCount = HttpContext.Session.GetInt32("happinessCount");
            ViewBag.Happiness = happyCount;
            int? fullCount = HttpContext.Session.GetInt32("fullnessCount");
            ViewBag.Fullness = fullCount;
            int? mealCount = HttpContext.Session.GetInt32("mealsCount");
            ViewBag.Meals = mealCount;
            int? energyCount = HttpContext.Session.GetInt32("energyCount");
            ViewBag.Energy = energyCount;
            if (fullCount <= 0 || happyCount <= 0){
                HttpContext.Session.SetString("gameOver", "yes");
                HttpContext.Session.SetString("text", "You lose, your Dojodachi is dead.");
                HttpContext.Session.SetString("imgURL", "~/img/lost.png");
            }
            if (fullCount >= 100 && happyCount >= 100 && energyCount >= 100){
                HttpContext.Session.SetString("gameOver", "yes");
                HttpContext.Session.SetString("text", "You win!!!!!");
                HttpContext.Session.SetString("imgURL", "~/img/Win.png");
            }
            ViewBag.imgURL = Url.Content(HttpContext.Session.GetString("imgURL"));
            ViewBag.Text = HttpContext.Session.GetString("text");
            ViewBag.Game = HttpContext.Session.GetString("gameOver");
            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            Random rand = new Random();
            int fullnessAmt;
            int? fullCount = HttpContext.Session.GetInt32("fullnessCount");
            int? mealCount = HttpContext.Session.GetInt32("mealsCount");
            int notHappy = rand.Next(0,100);
            if (mealCount > 0)
            {
                if (notHappy < 25){
                    fullnessAmt = 0;
                    HttpContext.Session.SetString("text", $"You fed your Dojodachi! They didn't like it. Meals -1, Fullness + {fullnessAmt}");
                }
                else 
                {
                    fullnessAmt = rand.Next(5,11);
                    HttpContext.Session.SetString("text", $"You fed your Dojodachi! Meals -1, Fullness + {fullnessAmt}");
                }
                HttpContext.Session.SetInt32("fullnessCount", (int)fullCount + fullnessAmt);
                HttpContext.Session.SetInt32("mealsCount", (int)mealCount - 1);
            }
            else 
            {
                HttpContext.Session.SetString("text", "You don't have enough meals to feed your DojoDachi");
            }
            HttpContext.Session.SetString("imgURL", "~/img/feed.jpg");
            return RedirectToAction("Index");
        }
        [HttpGet("play")]
        public IActionResult Play()
        {
            Random rand = new Random();
            int happinessAmt; 
            int? energyCount = HttpContext.Session.GetInt32("energyCount");
            int? happyCount = HttpContext.Session.GetInt32("happinessCount");
            int notHappy = rand.Next(0,100);
            if (notHappy < 25)
            {
                happinessAmt = 0;
                HttpContext.Session.SetString("text", $"You played with your Dojodachi! They didn't like it. Energy -5, Happiness + {happinessAmt}");
            }
            else 
            {
                happinessAmt = rand.Next(5,11); 
                HttpContext.Session.SetString("text", $"You played with your Dojodachi! Energy -5, Happiness + {happinessAmt}");
            }
            HttpContext.Session.SetInt32("happinessCount", (int)happyCount + happinessAmt);
            HttpContext.Session.SetInt32("energyCount", (int)energyCount - 5);
            HttpContext.Session.SetString("imgURL", "~/img/play.jpg");
            return RedirectToAction("Index");
        }
        [HttpGet("work")]
        public IActionResult Work()
        {
            Random rand = new Random();
            int? energyCount = HttpContext.Session.GetInt32("energyCount");
            int? mealCount = HttpContext.Session.GetInt32("mealsCount");
            int mealsAmt = rand.Next(1,4); 
            HttpContext.Session.SetInt32("mealsCount", (int)mealCount + mealsAmt);
            HttpContext.Session.SetInt32("energyCount", (int)energyCount - 5);
            HttpContext.Session.SetString("text", $"You went to work! Energy -5, Meals + {mealsAmt}");
            HttpContext.Session.SetString("imgURL", "~/img/work.png");
            return RedirectToAction("Index");
        }
        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            Random rand = new Random();
            int? energyCount = HttpContext.Session.GetInt32("energyCount");
            int? fullCount = HttpContext.Session.GetInt32("fullnessCount");
            int? happyCount = HttpContext.Session.GetInt32("happinessCount");
            HttpContext.Session.SetInt32("fullnessCount", (int)fullCount -5);
            HttpContext.Session.SetInt32("happinessCount", (int)happyCount -5);
            HttpContext.Session.SetInt32("energyCount", (int)energyCount + 15);
            HttpContext.Session.SetString("text", "You slept. Fullness -5, Happiness-5, Energy +15");
            HttpContext.Session.SetString("imgURL", "~/img/sleep.png");
            return RedirectToAction("Index");
        }
        [HttpGet("restart")]
        public IActionResult Restart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("");
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
