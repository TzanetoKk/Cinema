using Microsoft.AspNetCore.Mvc;

public class AdminsController : Controller
{
    private readonly AdminsService _adminsService;

    public AdminsController(AdminsService adminsService)
    {
        _adminsService = adminsService;
    }

    public IActionResult Index()
    {
        var admins = _adminsService.GetAllAdmins();
        return View(admins);
    }

    // Άλλες μέθοδοι για τις λειτουργίες των διαχειριστών
}
