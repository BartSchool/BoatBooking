namespace BoatBooking.Class
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
            IsAdmin = false;
        }

        public User(int id, string name, string password, bool isAdmin)
        {
            Id = id;
            Name = name;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
