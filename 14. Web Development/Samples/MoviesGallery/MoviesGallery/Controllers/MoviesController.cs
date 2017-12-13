using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesGallery.Models;

namespace MoviesGallery.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesGalleryContext _context;

        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public IActionResult Edit(Guid id)
        {
            var movie = _context.Movies.SingleOrDefault(i => i.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            // Saves changes
            _context.Update(movie);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            var movie = _context.Movies.SingleOrDefault(i => i.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            return RedirectToAction("Index");
        }

        public MoviesController(MoviesGalleryContext context)
        {
            _context = context;
        }
    }
}