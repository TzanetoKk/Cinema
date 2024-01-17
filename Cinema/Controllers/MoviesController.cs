using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using Cinema.Services;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesService _moviesService;

        public MoviesController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        public IActionResult Index()
        {
            var movies = _moviesService.GetAllMovies();

            var viewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View("MoviesPage", viewModel);
        }
    }
}