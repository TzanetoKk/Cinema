using Cinema.Models;
using System.Collections.Generic;

public class ProvolesService
{
    private readonly List<Provoles> _provoles;

    public ProvolesService()
    {
        _provoles = new List<Provoles>
        {
            new Provoles
            {
                Movies_id = 1,
                Movies_name = "Movie 1",
                Cinemas_id = 1,
                Id = "P001",
                Content_admin_id = 1
            },
            new Provoles
            {
                Movies_id = 2,
                Movies_name = "Movie 2",
                Cinemas_id = 2,
                Id = "P002",
                Content_admin_id = 2
            }
            // Προσθέστε άλλες προβολές αν χρειάζεται
        };
    }

    public List<Provoles> GetAllProvoles()
    {
        return _provoles;
    }

    // Άλλες λειτουργίες όπως προσθήκη, ενημέρωση, διαγραφή κλπ.
}
