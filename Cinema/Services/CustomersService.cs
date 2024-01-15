using Cinema.Models;
using System.Collections.Generic;

public class CustomersService
{
    private readonly List<Customers> _customers;

    public CustomersService()
    {
        _customers = new List<Customers>
        {
            new Customers { Id = 1, Name = "Customer 1", User_username = "customer1" },
            new Customers { Id = 2, Name = "Customer 2", User_username = "customer2" }
            // Προσθέστε άλλους πελάτες αν χρειάζεται
        };
    }

    public List<Customers> GetAllCustomers()
    {
        return _customers;
    }

    // Άλλες λειτουργίες όπως προσθήκη, ενημέρωση, διαγραφή κλπ.
}
