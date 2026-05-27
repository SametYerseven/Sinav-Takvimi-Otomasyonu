using System;
using System.Data.SqlClient;
using SinavTakvimiUI.Database;
using SinavTakvimiUI.Helpers;

namespace SinavTakvimiUI.Services
{
    class LoginService
    {
        DatabaseConnection db =
        new DatabaseConnection();

        public bool GirisYap(
        string kullaniciAdi,
        string sifre,
        string rol)
        {
            using (SqlConnection conn =
            db.GetConnection())
            {
                conn.Open();

                string query = @"

                SELECT
                PersonelID,
                KullaniciAdi,
                Rol

                FROM Kullanicilar

                WHERE KullaniciAdi=@kadi
                AND Sifre=@sifre
                AND Rol=@rol";

                SqlCommand cmd =
                new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                "@kadi", kullaniciAdi);

                cmd.Parameters.AddWithValue(
                "@sifre", sifre);

                cmd.Parameters.AddWithValue(
                "@rol", rol);

                SqlDataReader dr =
                cmd.ExecuteReader();

                if (dr.Read())
                {
                    Session.PersonelID =
                    Convert.ToInt32(
                    dr["PersonelID"]);

                    Session.KullaniciAdi =
                    dr["KullaniciAdi"]
                    .ToString();

                    Session.Rol =
                    dr["Rol"]
                    .ToString();

                    return true;
                }

                return false;
            }
        }
    }
}