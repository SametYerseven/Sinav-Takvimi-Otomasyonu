using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SinavTakvimiUI.Database
{
    public class DatabaseConnection
    {
        private string connectionString =
        @"Server=.\SQLEXPRESS;
        Database=SinavTakvimiOtomasyonuDB;
        Trusted_Connection=True;
        TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
