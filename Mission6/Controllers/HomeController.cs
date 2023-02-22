using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieAppContext movContext { get; set; }

        public HomeController(MovieAppContext good)
        {
            movContext = good;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Making the record
        [HttpGet]
        public IActionResult MovieCollection()
        {
            ViewBag.stuff = movContext.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieCollection(Movie entry)
        {
            if (ModelState.IsValid)
            {
                movContext.Add(entry);
                movContext.SaveChanges();
            }
            else
            {
                ViewBag.stuff = movContext.categories.ToList();

                return View(entry);
            }

            return View("Thanks");
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        //redirect
        public IActionResult Thanks()
        {
            return View();
        }

        public IActionResult MovieView()
        {
            var movies = movContext.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(movies);
        }
        //Edit instance
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.stuff = movContext.categories.ToList();

            var mov = movContext.Movies.Single( x => x.movieID == id);

            return View("MovieCollection", mov);
        }
        //All of this is intended to separate out when information is given versus not.  They all return views and redirect to places based on what the user does.
        [HttpPost]
        public IActionResult Edit(Movie edits)
        {
            movContext.Update(edits);
            movContext.SaveChanges();
            return RedirectToAction("MovieView");
        }
        [HttpGet]
        //Delete Instance
        public IActionResult Delete(int movid)
        {
            var moovie = movContext.Movies.Single(x => x.movieID == movid);
            return View(moovie);
        }
        [HttpPost]
        public IActionResult Delete(Movie badone)
        {
            movContext.Movies.Remove(badone);
            movContext.SaveChanges();
            return RedirectToAction("MovieView");
        }
    }
}
