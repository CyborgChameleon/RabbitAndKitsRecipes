using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RabbitAndKitsRecipes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitAndKitsRecipes.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //public IActionResult newRecipe()
        //{
        //    var recipe = new recipe()
        //    {
        //        recipeName = "Pizza",
        //        chef = "Monkey"


        //    };
        //    return View(recipe);
        //}
        //test later by adding view for this
        //this was added during this tutorial https://www.youtube.com/watch?v=di2Iv1jvbJ0&ab_channel=MarkDRushton this



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
