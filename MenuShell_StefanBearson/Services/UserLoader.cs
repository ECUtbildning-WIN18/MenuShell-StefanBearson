using MenuShell_StefanBearson.Domain;
using MenuShell_StefanBearson.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MenuShell_StefanBearson.Services
{
    class UserLoader : IUserLoader
    {
        public List<User> LoadUsers()
        {
            var users = new List<User>();

            string connectionString = "Data Source=DESKTOP-K8R731S\\STEFANSQLSERVER;Initial Catalog=MenuShell;Integrated Security=true";

            string queryString = "SELECT * FROM [User]";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(queryString, connection);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User(reader[1].ToString(), reader[3].ToString(), reader[2].ToString(), reader[4].ToString());
                    users.Add(user);
                }

                connection.Close();
            }
            return users;
        }

        public static void LoadSQLTolist()
        {
            string connectionString = "Data Source=DESKTOP-K8R731S\\STEFANSQLSERVER;Initial Catalog=MenuShell;Integrated Security=true";

            string queryString = "SELECT * FROM [User]";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(queryString, connection);

                var reader = command.ExecuteReader();

                Console.Clear();

                Console.WriteLine();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader[1],-20} {reader[2],-10} {reader[3],-15} {reader[4]}");
                }

                Console.ReadKey();

                SystemAdmin.MenuView();

                connection.Close();

            }

        }

        public static void LoadUserNameFromSQL()
        {
            string connectionString = "Data Source=DESKTOP-K8R731S\\STEFANSQLSERVER;Initial Catalog=MenuShell;Integrated Security=true";

            string queryString = "SELECT Username FROM [User]";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(queryString, connection);

                var reader = command.ExecuteReader();

                Console.Clear();

                Console.WriteLine();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]}");
                }

                connection.Close();
            }
        }
    }
}
