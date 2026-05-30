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
using SinavTakvimiUI.Database;
using SinavTakvimiUI.Services;


namespace SinavTakvimiUI
{
    public partial class FrmLogin : Form
    {
        LoginService login = new LoginService();
        public FrmLogin()
        {
            InitializeComponent();

            DatabaseConnection db =
                new DatabaseConnection();

            try
            {
                SqlConnection conn =
                db.GetConnection();

                conn.Open();

                MessageBox.Show(
                "Veritabanı bağlantısı başarılı");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbRol.Items.Add("Yonetici");
            cmbRol.Items.Add("Gozetmen");

            cmbRol.SelectedIndex = 0;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRol_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool giris =login.GirisYap(txtKullaniciAdi.Text,txtSifre.Text,cmbRol.Text);
            if (txtKullaniciAdi.Text == ""
|| txtSifre.Text == "")
            {
                MessageBox.Show(
                "Boş alan bırakmayınız");

                return;
            }

            if (giris)
            {
                if (cmbRol.Text == "Yonetici")
                {
                    FrmDashboard frm =
                    new FrmDashboard();

                    frm.Show();
                }
                else
                {
                    FrmGozetmenPanel frm =
                    new FrmGozetmenPanel();

                    frm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                "Hatalı giriş");
            }
        }
    }
}
