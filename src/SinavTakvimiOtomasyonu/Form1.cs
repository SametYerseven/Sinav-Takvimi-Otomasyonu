using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SinavTakvimiOtomasyonu
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            FormTasariminiOlustur();
        }

        private void FormTasariminiOlustur()
        {
            this.Text = "Sınav Yönetim Paneli";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            

           
        

            
        }

        private void DersleriYukle()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT DersID, DersKodu + ' - ' + Ad AS DersAd FROM Dersler";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDersler.DataSource = dt;
                cmbDersler.DisplayMember = "DersAd";
                cmbDersler.ValueMember = "DersID";
            }
        }

        private void OturumlariYukle()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT OturumID, Tanim FROM Oturumlar";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbOturumlar.DataSource = dt;
                cmbOturumlar.DisplayMember = "Tanim";
                cmbOturumlar.ValueMember = "OturumID";
            }
        }

       
        private void btnSinavOlustur_Click(object sender, EventArgs e)
        {
            if (cmbDersler.SelectedValue == null || cmbOturumlar.SelectedValue == null)
            {
                MessageBox.Show("Lütfen ders ve oturum seçiniz.");
                return;
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SinavVeAkilliSalonAtama", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_DersID", Convert.ToInt32(cmbDersler.SelectedValue));
                cmd.Parameters.AddWithValue("@p_Tarih", dtpTarih.Value.Date);
                cmd.Parameters.AddWithValue("@p_OturumID", Convert.ToInt32(cmbOturumlar.SelectedValue));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sınav oluşturuldu ve salonlar atandı.");
            }

            SalonlariListele();
        }

        private void SalonlariListele()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    s.SinavID,
                    d.DersKodu,
                    d.Ad AS DersAdi,
                    dr.Ad AS Derslik,
                    dr.Kapasite,
                    s.Tarih,
                    o.Tanim AS Oturum
                FROM Sinavlar s
                INNER JOIN Dersler d ON s.DersID = d.DersID
                INNER JOIN Oturumlar o ON s.OturumID = o.OturumID
                INNER JOIN Sinav_Salonlari ss ON s.SinavID = ss.SinavID
                INNER JOIN Derslikler dr ON ss.DerslikID = dr.DerslikID
                ORDER BY s.SinavID DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSalonlar.DataSource = dt;
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            DersleriYukle();
            OturumlariYukle();
            PersonelleriYukle();
            MessageBox.Show("Dersler ve oturumlar yüklendi.");

           
        }

        private void PersonelleriYukle()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
        SELECT 
            PersonelID,
            Ad + ' ' + Soyad AS AdSoyad
        FROM Personel";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbPersoneller.DataSource = dt;
                cmbPersoneller.DisplayMember = "AdSoyad";
                cmbPersoneller.ValueMember = "PersonelID";
            }
        }
    

        private void btnGozetmenAta_Click(object sender, EventArgs e)
        {
            if (dgvSalonlar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir salon ataması seçin.");
                return;
            }

            int atamaID = Convert.ToInt32(
                dgvSalonlar.CurrentRow.Cells["AtamaID"].Value);

            int personelID = Convert.ToInt32(cmbPersoneller.SelectedValue);

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GozetmenAta", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_AtamaID", atamaID);
                cmd.Parameters.AddWithValue("@p_PersonelID", personelID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Gözetmen atandı.");
            }
        }
    }
}