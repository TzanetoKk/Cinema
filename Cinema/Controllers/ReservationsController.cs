using Microsoft.AspNetCore.Mvc;

public class ReservationsController : Controller
{
    private readonly ReservationsService _reservationsService;

    public ReservationsController(ReservationsService reservationsService)
    {
        _reservationsService = reservationsService;
    }

    public IActionResult Index()
    {
        var reservations = _reservationsService.GetAllReservations();
        return View(reservations);
    }

    // Άλλες μέθοδοι για τις λειτουργίες των κρατήσεων
}
