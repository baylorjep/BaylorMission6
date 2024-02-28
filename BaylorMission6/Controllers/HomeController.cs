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
            return View("MovieForm", new Rating());
        }

        [HttpPost]
        public IActionResult MovieForm(Rating response)
        {
            if (ModelState.IsValid)
            {
                _context.Ratings.Add(response); // add record to DB
                _context.SaveChanges(); // save DB

                return View("confirmation", response);
            }
            else //invalid data
            {
                return View(response);
            }
                

            
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
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Ratings
                .Single(x => x.ratingID == id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Rating app)
        {
            _context.Ratings.Remove(app);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
        
    }
}
