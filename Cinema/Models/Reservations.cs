namespace Cinema.Models
{
    public class Reservations
    {
        public int Provoles_movies_id { get; set; }
        public string Provoles_movies_name { get; set; }
        public int Provoles_cinemas_id { get; set; }
        public int Customers_id { get; set; }
        public int Number_of_seats { get; set; }
    }
}
