using Microsoft.AspNetCore.Mvc;

public class ContentAdminsController : Controller
{
    private readonly ContentAdminsService _contentAdminsService;

    public ContentAdminsController(ContentAdminsService contentAdminsService)
    {
        _contentAdminsService = contentAdminsService;
    }

    public IActionResult Index()
    {
        var contentAdmins = _contentAdminsService.GetAllContentAdmins();
        return View(contentAdmins);
    }

    // Άλλες μέθοδοι για τις λειτουργίες των διαχειριστών περιεχομένου
}