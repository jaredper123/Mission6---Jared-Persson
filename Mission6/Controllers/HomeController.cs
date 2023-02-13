using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieAppContext movContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieAppContext x)
        {
            _logger = logger;
            movContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieCollection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieCollection(Movie entry)
        {
            movContext.Add(entry);
            movContext.SaveChanges();

            return View("Thanks");
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        public IActionResult Thanks()
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
