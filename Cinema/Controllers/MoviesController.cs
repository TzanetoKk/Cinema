using Microsoft.AspNetCore.Mvc;

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
        return View(movies);
    }

    // Άλλες μέθοδοι για τις λειτουργίες των ταινιών
}
