using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinavTakvimiUI.Services;
using SinavTakvimiUI.Helpers;

namespace SinavTakvimiUI
{
    public partial class FrmDashboard : Form
    {
        DashboardService dashboard =new DashboardService();

        public FrmDashboard()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            ThemeHelper.ApplyFormTheme(this);
            ThemeHelper.ApplySidebarTheme(this.pnlMenu, this.btnDashboard);
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

                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }
     
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblDers_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadContent(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
            ThemeHelper.ApplyFormTheme(this);

            Button targetButton = null;
            if (control is UcDashboardHome) targetButton = btnDashboard;
            else if (control is UcTanimlamalar) targetButton = btnTanimlama;
            else if (control is UcSinavYonetim) targetButton = button3;
            else if (control is UcTakvim) targetButton = btnTakvim;
            else if (control is UcRaporlar) targetButton = btnRapor;

            if (targetButton != null)
            {
                ThemeHelper.ApplySidebarTheme(this.pnlMenu, targetButton);
            }
        }

        private void FrmDashboard_Load_1(object sender, EventArgs e)
        {
            lblKullanici.Text = "Hoşgeldiniz: " + Session.KullaniciAdi;
            lblRol.Text = "Rol: " + Session.Rol;
            LoadContent(new UcDashboardHome());
        }

        private void dgvYaklasanSinavlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show( "Çıkış yapmak istiyor musunuz?","Çıkış", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                FrmLogin frm =
                new FrmLogin();

                frm.Show();

                this.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadContent(new UcDashboardHome());
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            LoadContent(new UcRaporlar());
        }

        private void btnTakvim_Click(object sender, EventArgs e)
        {
            LoadContent(new UcTakvim());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadContent(new UcSinavYonetim());
        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void lblKullanici_Click(object sender, EventArgs e)
        {

        }

        private void btnTanimlama_Click(object sender, EventArgs e)
        {
            LoadContent(new UcTanimlamalar());
        }
    }
}
