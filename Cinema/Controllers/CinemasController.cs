using Microsoft.AspNetCore.Mvc;

public class CinemasController : Controller
{
    private readonly CinemasService _cinemasService;

    public CinemasController(CinemasService cinemasService)
    {
        _cinemasService = cinemasService;
    }

    public IActionResult Index()
    {
        var cinemas = _cinemasService.GetAllCinemas();
        return View(cinemas);
    }

    // Άλλες μέθοδοι για τις λειτουργίες των αιθουσών
}
