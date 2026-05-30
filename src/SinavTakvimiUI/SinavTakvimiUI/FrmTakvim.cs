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
    public partial class FrmTakvim : Form
    {
        public FrmTakvim()
        {
            InitializeComponent();
            ApplyTheme();
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
                else if (control is Label label && (label.Name == "label1" || label.Text == "SINAV TAKVİMİ"))
                {
                    ThemeHelper.ApplyLabelTitle(label);
                }

                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
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
