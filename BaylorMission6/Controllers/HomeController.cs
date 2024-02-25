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

        
        
    }
}
