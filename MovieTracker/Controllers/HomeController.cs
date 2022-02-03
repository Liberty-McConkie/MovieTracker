using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieTracker.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTracker.Controllers
{
    public class HomeController : Controller
    {
        
        //Controller
        private MovieContext daContext { get; set; }

        public HomeController(MovieContext x)
        {
            daContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Category = daContext.Category.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieResponse mr)
        {


            if (ModelState.IsValid)
            {
                daContext.Add(mr);
                daContext.SaveChanges();
                return View("MovieSubmittedConfirmation", mr);
            }
            else
            {
                ViewBag.Category = daContext.Category.ToList();
                return View(mr);
            }
            
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        public IActionResult MovieList ()
        {
           var movies = daContext.responses
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Category = daContext.Category.ToList();

            var movie = daContext.responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", movie);
        }
        [HttpPost]
        public IActionResult Edit (MovieResponse x)
        {
            daContext.Update(x);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var movie = daContext.responses.Single(x => x.MovieId == movieid);

            
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete (MovieResponse mr)
        {
            daContext.responses.Remove(mr);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        
    }
}
