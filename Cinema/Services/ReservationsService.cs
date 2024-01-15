using Cinema.Models;
using System.Collections.Generic;

public class ReservationsService
{
    private readonly List<Reservations> _reservations;

    public ReservationsService()
    {
        _reservations = new List<Reservations>
        {
            new Reservations
            {
                Provoles_movies_id = 1,
                Provoles_movies_name = "Movie 1",
                Provoles_cinemas_id = 1,
                Customers_id = 1,
                Number_of_seats = 2
            },
            new Reservations
            {
                Provoles_movies_id = 2,
                Provoles_movies_name = "Movie 2",
                Provoles_cinemas_id = 2,
                Customers_id = 2,
                Number_of_seats = 3
            }
            // Προσθέστε άλλες κρατήσεις αν χρειάζεται
        };
    }
    public List<Reservations> GetAllReservations()
    {
        return _reservations;
    }

    // Άλλες λειτουργίες όπως προσθήκη, ενημέρωση, διαγραφή κλπ.
}