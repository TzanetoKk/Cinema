using Microsoft.AspNetCore.Mvc;

public class CustomersController : Controller
{
    private readonly CustomersService _customersService;

    public CustomersController(CustomersService customersService)
    {
        _customersService = customersService;
    }

    public IActionResult Index()
    {
        var customers = _customersService.GetAllCustomers();
        return View(customers);
    }

    // Άλλες μέθοδοι για τις λειτουργίες των πελατών
}