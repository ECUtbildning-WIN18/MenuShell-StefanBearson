namespace MenuShell_StefanBearson.Domain
{
    interface IUser
    {
        string Password { get; set; }
        string Role { get; set; }
        string SocialSecurityNumber { get; set; }
        string Username { get; set; }
    }
}