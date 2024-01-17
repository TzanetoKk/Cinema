using System.Collections.Generic;

namespace Cinema.Models
{
    public class MovieViewModel
    {
        public List<Movies> Movies { get; set; }
    }

    public class Movies
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Length { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public int Content_admin_id { get; set; }

    }
}
