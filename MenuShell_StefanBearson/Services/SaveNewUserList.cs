using MenuShell_StefanBearson.Domain;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MenuShell_StefanBearson.Services
{
    class SaveNewUserList
    {
        public static void Save(List<User> users)
        {
            var usersTemp = XDocument.Load("Users.xml");

            var root = usersTemp.Root;
            root.RemoveAll();

            foreach (var user in users)
            {
                var userinfo = new XElement("User",
                    new XAttribute("username", user.Username),
                    new XAttribute("password", user.Password),
                    new XAttribute("socialSecurityNumber", user.SocialSecurityNumber),
                    new XAttribute("role", user.Role));

                root.Add(userinfo);
            }

            usersTemp.Save("Users.xml");
        }
    }
}
