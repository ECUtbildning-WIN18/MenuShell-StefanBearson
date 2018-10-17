namespace MenuShell_StefanBearson.Domain
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Role { get; set; }

        public User(string username, string socialSecurityNumber, string password, string role)
        {
            Username = username;
            SocialSecurityNumber = socialSecurityNumber;
            Password = password;
            Role = role;
        }
    }
}
