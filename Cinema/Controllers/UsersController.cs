using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    private readonly UserService _userService;

    public UsersController(UserService userService)
    {
        _userService = userService;
    }

    public IActionResult Index()
    {
        var users = _userService.GetAllUsers();
        return View(users);
    }

    // Άλλες μέθοδοι για τις λειτουργίες των χρηστών
}
