using MenuShell_StefanBearson.Domain;
using System.Data.SqlClient;
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

        public static void SaveToSQL(User user)
        {
            string connectionString = "Data Source=DESKTOP-K8R731S\\STEFANSQLSERVER;Initial Catalog=MenuShell;Integrated Security=true";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var addUser = new SqlCommand(
                    "INSERT INTO [User] " +
                    $"VALUES ('{user.Username}'," +
                    $" '{user.Password}', " +
                    $" '{user.SocialSecurityNumber}', " +
                    $"'{user.Role}')",
                    connection);

                addUser.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
