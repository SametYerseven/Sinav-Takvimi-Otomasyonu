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
            ApplyTheme();
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
                else if (control is Label label && (label.Name == "lblBaslik" || label.Text == "GÖZETMEN PANELİ"))
                {
                    ThemeHelper.ApplyLabelTitle(label);
                }

                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void grpAdSoyad_Enter(object sender, EventArgs e) { }

        private void FrmGozetmenPanel_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = Session.KullaniciAdi;
            dgvGorevler.DataSource = gozetmen.GorevleriGetir(Session.PersonelID);
            dgvGorevler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGorevler.RowHeadersVisible = false;
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Close();
            }
        }
    }
}