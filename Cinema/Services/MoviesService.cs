using Cinema.Models;
using System.Collections.Generic;

namespace Cinema.Services
{
    public class MoviesService
    {
        public List<Movies> GetAllMovies()
        {
            // Implement logic to fetch movie data from your database or other sources
            // For now, using static data for demonstration purposes
            return new List<Movies>
            {
                new Movies
                {
                    Id = 1,
                    ImageUrl = "https://via.placeholder.com/300",
                    Name = "Inception",
                    Content = "A mind-bending heist thriller",
                    Length = 148,
                    Type = "Sci-Fi",
                    Summary = "Inception is a 2010 science fiction action film...",
                    Director = "Christopher Nolan",
                    Content_admin_id = 101
                },
                new Movies
                {
                    Id = 2,
                    ImageUrl = "https://via.placeholder.com/300",
                    Name = "The Shawshank Redemption",
                    Content = "Two imprisoned men bond over a number of years...",
                    Length = 142,
                    Type = "Drama",
                    Summary = "The Shawshank Redemption is a 1994 American drama film...",
                    Director = "Frank Darabont",
                    Content_admin_id = 102
                },
                new Movies
                {
                    Id = 3,
                    ImageUrl = "https://via.placeholder.com/300",
                    Name = "The Godfather",
                    Content = "The aging patriarch of an organized crime dynasty...",
                    Length = 175,
                    Type = "Crime",
                    Summary = "The Godfather is a 1972 American crime film directed by...",
                    Director = "Francis Ford Coppola",
                    Content_admin_id = 103
                },
                new Movies
                {
                    Id = 4,
                    ImageUrl = "https://via.placeholder.com/300",
                    Name = "The Dark Knight",
                    Content = "When the menace known as the Joker emerges...",
                    Length = 152,
                    Type = "Action",
                    Summary = "The Dark Knight is a 2008 superhero film directed by...",
                    Director = "Christopher Nolan",
                    Content_admin_id = 104
                },
                new Movies
                {
                    Id = 5,
                    ImageUrl = "https://via.placeholder.com/300",
                    Name = "Pulp Fiction",
                    Content = "The lives of two mob hitmen, a boxer, a gangster's...",
                    Length = 154,
                    Type = "Crime",
                    Summary = "Pulp Fiction is a 1994 American crime film written and directed by...",
                    Director = "Quentin Tarantino",
                    Content_admin_id = 105
                },
                new Movies
                {
                    Id = 6,
                    ImageUrl = "https://via.placeholder.com/300",
                    Name = "Forrest Gump",
                    Content = "The presidencies of Kennedy and Johnson, the Vietnam...",
                    Length = 142,
                    Type = "Drama",
                    Summary = "Forrest Gump is a 1994 American drama film directed by...",
                    Director = "Robert Zemeckis",
                    Content_admin_id = 106
                },
            };
        }
    }
}