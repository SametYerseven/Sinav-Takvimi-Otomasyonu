using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SinavTakvimiOtomasyonu
{
    public partial class FrmSinavYonetim : Form
    {
        

        public FrmSinavYonetim()
        {
            InitializeComponent();
            FormTasariminiOlustur();
        }

        private void FormTasariminiOlustur()
        {
            
            
            this.StartPosition = FormStartPosition.CenterScreen;


            dgvSalonlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalonlar.ReadOnly = true;
            dgvSalonlar.AllowUserToAddRows = false;
            dgvSalonlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalonlar.MultiSelect = false;
            dgvSalonlar.BackgroundColor = Color.White;
            dgvSalonlar.BorderStyle = BorderStyle.None;
            dgvSalonlar.RowHeadersVisible = false;

            dgvSalonlar.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvSalonlar.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);




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

                

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sınav oluşturuldu ve salonlar atandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav oluşturulamadı: " + ex.Message);
                }
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
                    ss.AtamaID,
                    s.SinavID,
                    d.DersKodu,
                    d.Ad AS DersAdi,
                    dr.Ad AS Derslik,   
                    dr.Kapasite,
                    s.Tarih,
                    o.Tanim AS Oturum,
                    ISNULL(p.Ad + ' ' + p.Soyad, 'Atanmadı') AS Gozetmen
                FROM Sinavlar s
                INNER JOIN Dersler d ON s.DersID = d.DersID
                INNER JOIN Oturumlar o ON s.OturumID = o.OturumID
                INNER JOIN Sinav_Salonlari ss ON s.SinavID = ss.SinavID
                INNER JOIN Derslikler dr ON ss.DerslikID = dr.DerslikID
                LEFT JOIN Gozetmen_Atamalari ga ON ss.AtamaID = ga.AtamaID
                LEFT JOIN Personel p ON ga.PersonelID = p.PersonelID
                ORDER BY s.SinavID DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSalonlar.DataSource = dt;

                dgvSalonlar.Columns["AtamaID"].Visible = false;
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            DersleriYukle();
            OturumlariYukle();
            MessageBox.Show("Dersler ve oturumlar yüklendi.");

           
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

                

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gözetmen atandı.");

                    SalonlariListele();
                    cmbPersoneller.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gözetmen atanamadı: " + ex.Message);
                }

                SalonlariListele();

                cmbPersoneller.DataSource = null;

            }
        }

        private void dgvSalonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int atamaID = Convert.ToInt32(dgvSalonlar.Rows[e.RowIndex].Cells["AtamaID"].Value);

            UygunGozetmenleriYukle(atamaID);
        }
        private void UygunGozetmenleriYukle(int atamaID)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
        DECLARE @Tarih DATE;
        DECLARE @OturumID INT;

        SELECT 
            @Tarih = s.Tarih,
            @OturumID = s.OturumID
        FROM Sinav_Salonlari ss
        INNER JOIN Sinavlar s ON ss.SinavID = s.SinavID
        WHERE ss.AtamaID = @AtamaID;

        SELECT 
            p.PersonelID,
            p.Unvan + ' ' + p.Ad + ' ' + p.Soyad AS AdSoyad
        FROM Personel p
        WHERE p.PersonelID NOT IN (
            SELECT ga.PersonelID
            FROM Gozetmen_Atamalari ga
            INNER JOIN Sinav_Salonlari ss ON ga.AtamaID = ss.AtamaID
            INNER JOIN Sinavlar s ON ss.SinavID = s.SinavID
            WHERE s.Tarih = @Tarih
              AND s.OturumID = @OturumID
        )
        AND p.PersonelID NOT IN (
            SELECT pd.PersonelID
            FROM Personel_Durum pd
            WHERE pd.Tarih = @Tarih
              AND pd.Uygun = 0
        )
        ORDER BY p.PersonelID;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AtamaID", atamaID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPersoneller.DataSource = dt;
                cmbPersoneller.DisplayMember = "AdSoyad";
                cmbPersoneller.ValueMember = "PersonelID";
            }
        }

        private void btnIptalPaneli_Click(object sender, EventArgs e)
        {
            FrmSinavIptal frm = new FrmSinavIptal();
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTakvim frm = new FrmTakvim();
            frm.Show();
            this.Hide();

        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            FrmRaporlar frm = new FrmRaporlar();
            frm.Show();
            this.Hide();
        }
    }
}