using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavTakvimiOtomasyonu
{
    public partial class FrmSinavIptal : Form
    {
        public FrmSinavIptal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgvSinavlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinavlar.ReadOnly = true;
            dgvSinavlar.AllowUserToAddRows = false;
            dgvSinavlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinavlar.MultiSelect = false;
            dgvSinavlar.BackgroundColor = Color.White;
            dgvSinavlar.BorderStyle = BorderStyle.None;
            dgvSinavlar.RowHeadersVisible = false;

            dgvSinavlar.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvSinavlar.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

        }
        private void SinavlariListele()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
        SELECT 
            s.SinavID,
            d.DersKodu,
            d.Ad AS DersAdi,
            s.Tarih,
            o.Tanim AS Oturum
        FROM Sinavlar s
        INNER JOIN Dersler d ON s.DersID = d.DersID
        INNER JOIN Oturumlar o ON s.OturumID = o.OturumID
        ORDER BY s.Tarih, o.OturumID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSinavlar.DataSource = dt;
            }
        }

        private void btnSinavlariYukle_Click(object sender, EventArgs e)
        {
            SinavlariListele();
        }

        private void btnSinavIptal_Click(object sender, EventArgs e)
        {
            if (dgvSinavlar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iptal edilecek sınavı seçin.");
                return;
            }

            int sinavID = Convert.ToInt32(dgvSinavlar.CurrentRow.Cells["SinavID"].Value);

            DialogResult result = MessageBox.Show(
                "Seçili sınav iptal edilsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SinavIptalEt", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_SinavID", sinavID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Sınav iptal edildi.");
            SinavlariListele();
        }

        private void btnLoglariGetir_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
        SELECT 
            LogID,
            EskiSinavID,
            DersID,
            Tarih,
            OturumID,
            IptalZamani,
            IptalEdenKullanici
        FROM IptalEdilenSinavlar_Log
        ORDER BY IptalZamani DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSinavlar.DataSource = dt;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmSinavYonetim frm =new FrmSinavYonetim();
            frm.Show();
            this.Hide();   
        }
    }
}
