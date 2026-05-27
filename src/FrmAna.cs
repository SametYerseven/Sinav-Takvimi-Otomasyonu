using System;
using System.Windows.Forms;

namespace SinavTakvimiOtomasyonu
{
    public partial class FrmAna : Form
    {
        public FrmAna(string kullaniciAdi)
        {
            InitializeComponent();
            lblHosGeldiniz.Text = "Hoş Geldiniz, " + kullaniciAdi + "!";
        }

        private void btnTanimlamalar_Click(object sender, EventArgs e)
        {
            FrmTanimlamalar frmTanimlamalar = new FrmTanimlamalar();
            frmTanimlamalar.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
