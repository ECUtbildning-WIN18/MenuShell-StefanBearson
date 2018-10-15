using MenuShell_StefanBearson.Domain;
using System.Xml.Linq;

namespace MenuShell_StefanBearson.Services
{
    class UserSaver
    {
        public static void SaveUser(User user)
        {
            var users = XDocument.Load("Users.xml");

            var root = users.Root;

            var userinfo = new XElement("User",
                new XAttribute("username", user.Username),
                new XAttribute("password", user.Password),
                new XAttribute("socialSecurityNumber", user.SocialSecurityNumber),
                new XAttribute("role", user.Role));

            root.Add(userinfo);

            users.Save("Users.xml");
        }
    }
}
