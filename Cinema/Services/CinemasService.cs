using Cinema.Models;
using System.Collections.Generic;

public class CinemasService
{
    private readonly List<Cinemas> _cinemas;

    public CinemasService()
    {
        _cinemas = new List<Cinemas>
        {
            new Cinemas { Id = 1, Name = "Cinema 1", Seats = "100", Three_d = "Yes" },
            new Cinemas { Id = 2, Name = "Cinema 2", Seats = "80", Three_d = "No" }
            // Προσθέστε άλλες αίθουσες αν χρειάζεται
        };
    }

    public List<Cinemas> GetAllCinemas()
    {
        return _cinemas;
    }

    // Άλλες λειτουργίες όπως προσθήκη, ενημέρωση, διαγραφή κλπ.
}
