using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SinavTakvimiOtomasyonu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                lblMesaj.ForeColor = System.Drawing.Color.OrangeRed;
                lblMesaj.Text = "Kullanıcı adı ve şifre boş bırakılamaz.";
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"SELECT COUNT(1) FROM Kullanicilar 
                                   WHERE KullaniciAdi = @KullaniciAdi 
                                     AND Sifre = @Sifre 
                                     AND Durum = 1";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@Sifre", sifre);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            FrmAna frmAna = new FrmAna(kullaniciAdi);
                            this.Hide();
                            frmAna.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            lblMesaj.ForeColor = System.Drawing.Color.OrangeRed;
                            lblMesaj.Text = "Kullanıcı adı veya şifre hatalı.";
                            txtSifre.Clear();
                            txtSifre.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMesaj.ForeColor = System.Drawing.Color.OrangeRed;
                lblMesaj.Text = "Bağlantı hatası: " + ex.Message;
            }
        }
    }
}
