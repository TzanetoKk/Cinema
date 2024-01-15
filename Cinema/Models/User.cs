namespace Cinema.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Create_time { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }

    }
}
