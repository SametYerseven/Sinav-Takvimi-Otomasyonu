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
    public partial class FrmTakvim : Form
    {
        public FrmTakvim()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgvTakvim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTakvim.ReadOnly = true;
            dgvTakvim.AllowUserToAddRows = false;
            dgvTakvim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTakvim.MultiSelect = false;
            dgvTakvim.BackgroundColor = Color.White;
            dgvTakvim.BorderStyle = BorderStyle.None;
            dgvTakvim.RowHeadersVisible = false;

            dgvTakvim.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTakvim.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);
        }

        private void btnTakvimiYukle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    s.Tarih,
                    o.Tanim AS Oturum,
                    d.DersKodu,
                    d.Ad AS DersAdi,
                    dr.Ad AS Derslik,
                    ISNULL(p.Ad + ' ' + p.Soyad, 'Atanmadı') AS Gozetmen
                FROM Sinavlar s
                INNER JOIN Dersler d ON s.DersID = d.DersID
                INNER JOIN Oturumlar o ON s.OturumID = o.OturumID
                INNER JOIN Sinav_Salonlari ss ON s.SinavID = ss.SinavID
                INNER JOIN Derslikler dr ON ss.DerslikID = dr.DerslikID
                LEFT JOIN Gozetmen_Atamalari ga ON ss.AtamaID = ga.AtamaID
                LEFT JOIN Personel p ON ga.PersonelID = p.PersonelID
                ORDER BY s.Tarih, o.OturumID, dr.Ad";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTakvim.DataSource = dt;
                dgvTakvim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmSinavYonetim frm = new FrmSinavYonetim();
            frm.Show();
            this.Hide();
        }
    }
}
