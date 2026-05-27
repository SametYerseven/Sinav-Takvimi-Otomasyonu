using System.Data.SqlClient;

namespace SinavTakvimiOtomasyonu
{
    public static class DbHelper
    {
        public static string ConnectionString =
            @"Server=localhost;Database=SinavTakvimiOtomasyonuDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}