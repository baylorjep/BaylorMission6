using BaylorMission6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaylorMission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;
      
        public HomeController(MovieFormContext tempForm) // constructor
        {
            _context = tempForm;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult gtkJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Rating response)
        {
            _context.Ratings.Add(response); // add record to DB
            _context.SaveChanges(); // save DB



            return View("confirmation", response);
        }

        
        public IActionResult MovieList ()
        {
            // Linq query
            var ratings = _context.Ratings
                .OrderBy(x => x.title).ToList();

            return View(ratings);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Ratings
                .Single(x => x.ratingID == id);

            return View("MovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Rating updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges(true);
            return RedirectToAction("MovieList");
        }

        public IActionResult Delete()
        {

        }
        
    }
}
