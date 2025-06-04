using MySql.Data.MySqlClient;

namespace Restaurant_Management_App
{
    public class Database
    {
        public static string ConnectionString = "server=localhost;user=root;password=Saman;database=restaurant_db;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
