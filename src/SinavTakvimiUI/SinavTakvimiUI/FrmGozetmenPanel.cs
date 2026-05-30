using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinavTakvimiUI.Helpers;
using SinavTakvimiUI.Services;

namespace SinavTakvimiUI
{

    public partial class FrmGozetmenPanel : Form
    {
        GozetmenService gozetmen = new GozetmenService();
        public FrmGozetmenPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpAdSoyad_Enter(object sender, EventArgs e)
        {

        }

        private void FrmGozetmenPanel_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text =
     Session.KullaniciAdi;

            dgvGorevler.DataSource =
            gozetmen.GorevleriGetir(
            Session.PersonelID);

            dgvGorevler.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvGorevler.RowHeadersVisible =
            false;
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult cevap =
   MessageBox.Show(
   "Çıkış yapmak istiyor musunuz?",
   "Çıkış",
   MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                FrmLogin frm =
                new FrmLogin();

                frm.Show();

                this.Close();
            }
        }
    }
}
