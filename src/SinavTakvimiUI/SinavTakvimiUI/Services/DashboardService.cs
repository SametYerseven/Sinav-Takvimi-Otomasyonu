using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SinavTakvimiUI.Database;
using System.Data;

namespace SinavTakvimiUI.Services
{
    class DashboardService
    {
        DatabaseConnection db =
        new DatabaseConnection();

        public int ToplamDers()
        {
            using (SqlConnection conn =
            db.GetConnection())
            {
                conn.Open();

                string query =
                "SELECT COUNT(*) FROM Dersler";

                SqlCommand cmd =
                new SqlCommand(query, conn);

                return (int)cmd.ExecuteScalar();
            }
        }

        public int ToplamPersonel()
        {
            using (SqlConnection conn =
            db.GetConnection())
            {
                conn.Open();

                string query =
                "SELECT COUNT(*) FROM Personel";

                SqlCommand cmd =
                new SqlCommand(query, conn);

                return (int)cmd.ExecuteScalar();
            }
        }

        public int ToplamSinav()
        {
            using (SqlConnection conn =
            db.GetConnection())
            {
                conn.Open();

                string query =
                "SELECT COUNT(*) FROM Sinavlar";

                SqlCommand cmd =
                new SqlCommand(query, conn);

                return (int)cmd.ExecuteScalar();
            }
        }

        public int ToplamSalon()
        {
            using (SqlConnection conn =
            db.GetConnection())
            {
                conn.Open();

                string query =
                "SELECT COUNT(*) FROM Derslikler";

                SqlCommand cmd =
                new SqlCommand(query, conn);

                return (int)cmd.ExecuteScalar();
            }
        }
        public DataTable YaklasanSinavlar()
        {
            using (SqlConnection conn =
            db.GetConnection())
            {
                conn.Open();

                string query = @"

                SELECT
                D.Ad AS Ders,
                S.Tarih,
                O.BaslangicSaat AS Saat,
                DR.Ad AS Salon

                FROM Sinavlar S

                INNER JOIN Dersler D
                ON S.DersID=D.DersID

                INNER JOIN Oturumlar O
                ON S.OturumID=O.OturumID

                INNER JOIN Sinav_Salonlari SS
                ON S.SinavID=SS.SinavID

                INNER JOIN Derslikler DR
                ON SS.DerslikID=DR.DerslikID

                ORDER BY S.Tarih";

                SqlDataAdapter da =
                new SqlDataAdapter(query, conn);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}