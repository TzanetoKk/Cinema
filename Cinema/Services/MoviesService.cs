using Cinema.Models;
using System.Collections.Generic;

public class MoviesService
{
    private readonly List<Movies> _movies;

    public MoviesService()
    {
        _movies = new List<Movies>
        {
            new Movies
            {
                Id = 1,
                Name = "Movie 1",
                Content = "Movie content...",
                Length = 120,
                Type = "Action",
                Summary = "Summary of Movie 1",
                Director = "Director 1",
                Content_admin_id = 1 // Προσαρμόστε τον διαχειριστή περιεχομένου
            },
            new Movies
            {
                Id = 2,
                Name = "Movie 2",
                Content = "Movie content...",
                Length = 150,
                Type = "Drama",
                Summary = "Summary of Movie 2",
                Director = "Director 2",
                Content_admin_id = 2 // Προσαρμόστε τον διαχειριστή περιεχομένου
            }
            // Προσθέστε άλλες ταινίες αν χρειάζεται
        };
    }

    public List<Movies> GetAllMovies()
    {
        return _movies;
    }

    // Άλλες λειτουργίες όπως προσθήκη, ενημέρωση, διαγραφή κλπ.
}
