namespace Cinema.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Length { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public int Content_admin_id { get; set; }

    }
}
