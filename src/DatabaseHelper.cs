using System.Data.SqlClient;

namespace SinavTakvimiOtomasyonu
{
    public static class DatabaseHelper
    {
        private const string ConnectionString =
            "Server=DESKTOP-3D472GQ\\SQLEXPRESS;" +
            "Database=SinavTakvimiOtomasyonuDB;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
