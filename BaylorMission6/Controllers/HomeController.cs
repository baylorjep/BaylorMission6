using BaylorMission6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaylorMission6.Controllers
{
    public class HomeController : Controller
    {


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
            return View("confirmation", response);
        }

        
        
    }
}
