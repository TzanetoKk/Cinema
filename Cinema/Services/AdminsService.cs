using Cinema.Models;
using System.Collections.Generic;

public class AdminsService
{
    private readonly List<Admins> _admins;

    public AdminsService()
    {
        _admins = new List<Admins>
        {
            new Admins { Id = 1, Name = "Admin 1", User_username = "admin1" },
            new Admins { Id = 2, Name = "Admin 2", User_username = "admin2" }
            // Προσθέστε άλλους διαχειριστές αν χρειάζεται
        };
    }

    public List<Admins> GetAllAdmins()
    {
        return _admins;
    }

    // Άλλες λειτουργίες όπως προσθήκη, ενημέρωση, διαγραφή κλπ.
}
