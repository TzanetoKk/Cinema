using Microsoft.AspNetCore.Mvc;

public class ProvolesController : Controller
{
    private readonly ProvolesService _provolesService;

    public ProvolesController(ProvolesService provolesService)
    {
        _provolesService = provolesService;
    }

    public IActionResult Index()
    {
        var provoles = _provolesService.GetAllProvoles();
        return View(provoles);
    }

    // Άλλες μέθοδοι για τις λειτουργίες των προβολών
}
}
