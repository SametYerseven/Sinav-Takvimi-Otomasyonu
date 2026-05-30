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
using SinavTakvimiUI.Helpers;

namespace SinavTakvimiUI
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
            ApplyTheme();

            this.StartPosition = FormStartPosition.CenterScreen;



            dgvRaporlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRaporlar.ReadOnly = true;
            dgvRaporlar.AllowUserToAddRows = false;
            dgvRaporlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRaporlar.MultiSelect = false;
            dgvRaporlar.BackgroundColor = Color.White;
            dgvRaporlar.BorderStyle = BorderStyle.None;
            dgvRaporlar.RowHeadersVisible = false;

            dgvRaporlar.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvRaporlar.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);
        }

        private void ApplyTheme()
        {
            ThemeHelper.ApplyFormTheme(this);
            ApplyThemeToControls(this.Controls);
        }

        private void ApplyThemeToControls(Control.ControlCollection controls)
        {
            if (controls == null) return;
            foreach (Control control in controls)
            {
                if (control is Button button)
                {
                    ThemeHelper.ApplyButtonTheme(button);
                }
                else if (control is Panel panel)
                {
                    ThemeHelper.ApplyPanelTheme(panel);
                }
                else if (control is DataGridView dgv)
                {
                    ThemeHelper.ApplyDataGridViewTheme(dgv);
                }
                else if (control is TextBox textBox)
                {
                    ThemeHelper.ApplyTextBoxTheme(textBox);
                }
                else if (control is ComboBox comboBox)
                {
                    ThemeHelper.ApplyComboBoxTheme(comboBox);
                }
                else if (control is Label label && (label.Name == "label1" || label.Text == "Raporlar"))
                {
                    ThemeHelper.ApplyLabelTitle(label);
                }

                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }

        private void btnGozetmenRaporu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
        SELECT
            p.PersonelID,
            p.Ad + ' ' + p.Soyad AS Gozetmen,
            COUNT(ga.GozetmenAtamaID) AS GorevSayisi,
            dbo.GozetmenUcretiHesapla(p.PersonelID) AS ToplamUcret
        FROM Personel p
        LEFT JOIN Gozetmen_Atamalari ga
            ON p.PersonelID = ga.PersonelID
        GROUP BY
            p.PersonelID,
            p.Ad,
            p.Soyad
        ORDER BY GorevSayisi DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRaporlar.DataSource = dt;
            }
        }

        private void btnDerslikRaporu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        d.Ad AS Derslik,
                        COUNT(ss.AtamaID) AS KullanimSayisi
                    FROM Derslikler d
                    LEFT JOIN Sinav_Salonlari ss
                        ON d.DerslikID = ss.DerslikID
                    GROUP BY d.Ad
                    ORDER BY KullanimSayisi DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRaporlar.DataSource = dt;
            }

        }

        private void btnLogRaporu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
        SELECT *
        FROM IptalEdilenSinavlar_Log
        ORDER BY IptalZamani DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRaporlar.DataSource = dt;
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
