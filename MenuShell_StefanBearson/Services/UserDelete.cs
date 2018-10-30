using System.Data.SqlClient;

namespace MenuShell_StefanBearson.Services
{
    class UserDelete
    {
        public static void Delete(string name)
        {
            string connectionString =
                "Data Source=DESKTOP-K8R731S\\STEFANSQLSERVER;Initial Catalog=MenuShell;Integrated Security=true";

            string queryString = $"DELETE FROM [User] WHERE Username = '{name}'";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(queryString, connection);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
