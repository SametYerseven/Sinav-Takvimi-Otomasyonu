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

        private void FrmDashboard_Load_1(object sender, EventArgs e)
        {
            lblDers.Text =  dashboard.ToplamDers().ToString();

            lblPersonel.Text =
            dashboard.ToplamPersonel().ToString();

            lblSinav.Text =
            dashboard.ToplamSinav().ToString();

            lblSalon.Text =
            dashboard.ToplamSalon().ToString();

            dgvYaklasanSinavlar.DataSource =
            dashboard.YaklasanSinavlar();

            dgvYaklasanSinavlar.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvYaklasanSinavlar.RowHeadersVisible =
            false;
            lblKullanici.Text ="Hoşgeldiniz: " +Session.KullaniciAdi;

            lblRol.Text ="Rol: " +
            Session.Rol;
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

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void lblKullanici_Click(object sender, EventArgs e)
        {

        }
    }
}
