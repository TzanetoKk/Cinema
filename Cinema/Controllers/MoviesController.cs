using Microsoft.AspNetCore.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }
    }
}
