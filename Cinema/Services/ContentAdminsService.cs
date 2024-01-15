using Cinema.Models;
using System.Collections.Generic;

public class ContentAdminsService
{
    private readonly List<Content_admin> _contentAdmins;

    public ContentAdminsService()
    {
        _contentAdmins = new List<Content_admin>
        {
            new Content_admin { Id = 1, Name = "Content Admin 1", User_username = "content_admin1" },
            new Content_admin { Id = 2, Name = "Content Admin 2", User_username = "content_admin2" }
            // Προσθέστε άλλους διαχειριστές περιεχομένου αν χρειάζεται
        };
    }

    public List<Content_admin> GetAllContentAdmins()
    {
        return _contentAdmins;
    }

    // Άλλες λειτουργίες όπως προσθήκη, ενημέρωση, διαγραφή κλπ.
}
