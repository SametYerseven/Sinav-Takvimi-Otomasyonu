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
using SinavTakvimiUI.Helpers;


namespace SinavTakvimiUI
{
    public partial class FrmLogin : Form
    {
        LoginService login = new LoginService();
        public FrmLogin()
        {
            InitializeComponent();
            ApplyTheme();

            DatabaseConnection db =
                new DatabaseConnection();

            try
            {
                SqlConnection conn =
                db.GetConnection();

                conn.Open();
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
                else if (control is Label label && (label.Name == "lblBaslik" || label.Text == "SINAV TAKVİM SİSTEMİ"))
                {
                    ThemeHelper.ApplyLabelTitle(label);
                }

                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }
    }
}
