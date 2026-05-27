using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SinavTakvimiUI.Database;

namespace SinavTakvimiUI.Services
{
    class GozetmenService
    {
        DatabaseConnection db =
        new DatabaseConnection();

        public DataTable GorevleriGetir(
        int personelID)
        {
            using (SqlConnection conn =
            db.GetConnection())
            {
                conn.Open();

                string query = @"

                SELECT
                S.Tarih,
                D.Ad AS Ders,
                DR.Ad AS Salon,
                O.BaslangicSaat AS Saat

                FROM Gozetmen_Atamalari G

                INNER JOIN Sinav_Salonlari SS
                ON G.AtamaID=SS.AtamaID

                INNER JOIN Sinavlar S
                ON SS.SinavID=S.SinavID

                INNER JOIN Dersler D
                ON S.DersID=D.DersID

                INNER JOIN Derslikler DR
                ON SS.DerslikID=DR.DerslikID

                INNER JOIN Oturumlar O
                ON S.OturumID=O.OturumID

                WHERE G.PersonelID=@id

                ORDER BY S.Tarih";

                SqlCommand cmd =
                new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                "@id", personelID);

                SqlDataAdapter da =
                new SqlDataAdapter(cmd);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
