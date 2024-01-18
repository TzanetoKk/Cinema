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
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg   ",
                    Name = "Inception",
                    Length = 148,
                    Type = "Sci-Fi",
                    Summary = "Inception is a 2010 science fiction action film...",
                    Director = "Christopher Nolan",
                    Content_admin_id = 101
                },
                new Movies
                {
                    Id = 2,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg",
                    Name = "The Shawshank Redemption",
                    Length = 142,
                    Type = "Drama",
                    Summary = "The Shawshank Redemption is a 1994 American drama film...",
                    Director = "Frank Darabont",
                    Content_admin_id = 102
                },
                new Movies
                {
                    Id = 3,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                    Name = "The Godfather",
                    Length = 175,
                    Type = "Crime",
                    Summary = "The Godfather is a 1972 American crime film directed by...",
                    Director = "Francis Ford Coppola",
                    Content_admin_id = 103
                },
                new Movies
                {
                    Id = 4,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg",
                    Name = "The Dark Knight",
                    Length = 152,
                    Type = "Action",
                    Summary = "The Dark Knight is a 2008 superhero film directed by...",
                    Director = "Christopher Nolan",
                    Content_admin_id = 104
                },
                new Movies
                {
                    Id = 5,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                    Name = "Pulp Fiction",
                    Length = 154,
                    Type = "Crime",
                    Summary = "Pulp Fiction is a 1994 American crime film written and directed by...",
                    Director = "Quentin Tarantino",
                    Content_admin_id = 105
                },
                new Movies
                {
                    Id = 6,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_FMjpg_UX1000_.jpg",
                    Name = "Forrest Gump",
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