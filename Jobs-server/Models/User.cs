namespace Jobs_server.Models
{
    public class User
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public Fields Field { get; set; }
    }
}
