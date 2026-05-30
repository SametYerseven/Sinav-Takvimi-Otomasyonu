using System.Data.SqlClient;

namespace SinavTakvimiUI
{
    public static class DbHelper
    {
        private static readonly string connectionString =
            @"Server=DESKTOP-3D472GQ\SQLEXPRESS;
Database=SinavTakvimiOtomasyonuDB;
Trusted_Connection=True;
TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}