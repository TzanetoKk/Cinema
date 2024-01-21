using Cinema.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Cinema.Services
{
    public class MoviesService
    {
        public List<Movies> GetAllMovies()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Movies.ToList();
            }
        }
    }
}
