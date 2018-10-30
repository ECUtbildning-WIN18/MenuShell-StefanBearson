using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell_StefanBearson.Services
{
    class UserSearch
    {
        public static void Search(string name)
        {
            string connectionString = "Data Source=DESKTOP-K8R731S\\STEFANSQLSERVER;Initial Catalog=MenuShell;Integrated Security=true";

            string queryString = $"SELECT * FROM [User] WHERE Username LIKE '%{name}%'";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(queryString, connection);
                var reader = command.ExecuteReader();
                Console.Clear();
                Console.WriteLine();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[1], -20} {reader[2], -20} {reader[3], -20}");
                }

                Console.ReadKey();

            }
        }
    }
}
