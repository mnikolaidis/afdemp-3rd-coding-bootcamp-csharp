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
        private static IEnumerable<Movie> Movies = new Movie[]
        {

            new Movie{
                Id = new Guid("5497cac7-4714-4f8d-9696-1c7388223bba"),
                Title = "Mulholland Drive",
                Description = "After a car wreck on the winding Mulholland Drive renders a woman amnesiac, she and a perky Hollywood-hopeful search for clues and answers across Los Angeles in a twisting venture beyond dreams and reality.",
                ReleaseDateTime = new DateTime(2002, 01, 04),
                Director = "David Lynch",
                //Genre = Genre.Drama | Genre.Mystery | Genre.Thriller
                Genre = "Drama, Myster, Thriller"
            },
            new Movie
            {
                Id = new Guid("c7e64a0f-b94a-4992-b9a0-6068eac5c181"),
                Title = "American History X",
                Description = "A former neo-nazi skinhead tries to prevent his younger brother from going down the same wrong path that he did.",
                ReleaseDateTime = new DateTime(1998, 12, 18),
                Director = "Tony Kaye",
                //Genre =  Genre.Crime | Genre.Drama
                Genre =  "Crime, Drama"
            }
        };

        public IActionResult Index()
        {
            return View(Movies);
        }

        public IActionResult Edit(Guid id)
        {
            // Dummy search
            var movie = Movies.SingleOrDefault(i => i.Id == id);
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
            var m = Movies.SingleOrDefault(i => i.Id == movie.Id);
            m = movie;

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}