using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavTakvimiUI.Helpers
{
    public static class ThemeHelper
    {
        public static readonly Color FormBackgroundColor = Color.FromArgb(245, 246, 248);
        public static readonly Color PrimaryBlue = Color.FromArgb(0, 122, 204);
        public static readonly Color TextWhite = Color.White;
        public static readonly Color TextDark = Color.FromArgb(45, 52, 54);
        public static readonly Color GridSelectionBg = Color.FromArgb(220, 230, 242);
        public static readonly Color GridAlternatingBg = Color.FromArgb(248, 249, 250);
        public static readonly Color GridLineColor = Color.FromArgb(230, 233, 237);

        public static void ApplyFormTheme(Form form)
        {
            if (form == null) return;

            if (form.Name == "FrmSinavYonetim") form.Text = "Sınav Yönetimi";
            else if (form.Name == "FrmTakvim") form.Text = "Sınav Takvimi";
            else if (form.Name == "FrmRaporlar") form.Text = "Raporlar";
            else if (form.Name == "FrmTanimlamalar") form.Text = "Tanımlamalar";
            else if (form.Name == "FrmGozetmenPanel") form.Text = "Gözetmen Paneli";
            else if (form.Name == "FrmLogin") form.Text = "Giriş";
            else if (form.Name == "FrmDashboard") form.Text = "Dashboard";

            form.BackColor = FormBackgroundColor;
            form.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;

            ApplyControlsThemeRecursively(form.Controls, form);
        }

        public static void ApplySidebarTheme(Panel pnlMenu, Button activeButton)
        {
            if (pnlMenu == null) return;

            pnlMenu.BackColor = Color.FromArgb(28, 40, 51);
            
            pnlMenu.Paint -= Sidebar_Paint;
            pnlMenu.Paint += Sidebar_Paint;

            var buttons = new System.Collections.Generic.List<Button>();
            foreach (Control ctrl in pnlMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    buttons.Add(btn);
                }
            }
            buttons.Sort((a, b) => a.TabIndex.CompareTo(b.TabIndex));

            int buttonHeight = 40;
            int buttonWidth = pnlMenu.Width - 24;
            int spacing = 12;
            int currentY = 30;

            foreach (var btn in buttons)
            {
                btn.Size = new Size(buttonWidth, buttonHeight);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(15, 0, 0, 0);

                if (btn.Name == "btnCikis")
                {
                    btn.Location = new Point(12, pnlMenu.Height - 65);
                    btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    btn.BackColor = Color.FromArgb(217, 83, 79);
                    btn.ForeColor = TextWhite;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 48, 44);
                    
                    btn.Paint -= Button_PaintActiveIndicator;
                    btn.Paint -= Button_PaintBorder;
                    btn.Paint += Button_PaintBorder;
                }
                else
                {
                    btn.Location = new Point(12, currentY);
                    btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    currentY += buttonHeight + spacing;

                    if (btn == activeButton)
                    {
                        btn.BackColor = Color.FromArgb(41, 128, 185);
                        btn.ForeColor = TextWhite;
                        
                        btn.Paint -= Button_PaintBorder;
                        btn.Paint -= Button_PaintActiveIndicator;
                        btn.Paint += Button_PaintActiveIndicator;
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(40, 55, 71);
                        btn.ForeColor = Color.FromArgb(236, 240, 241);
                        
                        btn.Paint -= Button_PaintActiveIndicator;
                        btn.Paint -= Button_PaintBorder;
                        btn.Paint += Button_PaintBorder;
                        
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
                    }
                }
            }
        }

        public static void ApplyButtonTheme(Button button)
        {
            if (button == null) return;

            if (IsInsideControl(button, "pnlMenu") || IsInsideControl(button, "pnlSidebar"))
            {
                return;
            }

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = TextWhite;
            button.Font = new Font("Segoe UI", button.Font.Size, FontStyle.Bold);
            button.Cursor = Cursors.Hand;

            string btnText = button.Text.ToLower();
            if (btnText.Contains("sil") || btnText.Contains("iptal") || btnText.Contains("çıkış") || btnText.Contains("cikis") || btnText.Contains("kapat"))
            {
                button.BackColor = Color.FromArgb(217, 83, 79); // Kırmızı
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 48, 44);
            }
            else if (btnText.Contains("geri") || btnText.Contains("temizle") || btnText.Contains("sıfırla") || btnText.Contains("sifirla"))
            {
                button.BackColor = Color.FromArgb(108, 117, 125); // Gri
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104);
            }
            else
            {
                button.BackColor = PrimaryBlue; // Mavi
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 170);
            }
        }

        public static void ApplyPanelTheme(Panel panel)
        {
            if (panel == null) return;

            string name = panel.Name.ToLower();
            if (name.Contains("top") || name.Contains("header"))
            {
                panel.BackColor = PrimaryBlue;

                // Kullanıcı adı ve rol etiketlerini sağ üst köşeye hizala
                Label lblKullanici = null;
                Label lblRol = null;
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is Label lbl)
                    {
                        if (lbl.Name == "lblKullanici") lblKullanici = lbl;
                        else if (lbl.Name == "lblRol") lblRol = lbl;
                    }
                }

                if (lblKullanici != null)
                {
                    lblKullanici.ForeColor = TextWhite;
                    lblKullanici.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
                    lblKullanici.Location = new Point(panel.Width - 320, 16);
                    lblKullanici.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
                if (lblRol != null)
                {
                    lblRol.ForeColor = Color.FromArgb(200, 230, 255);
                    lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Bold);
                    lblRol.Location = new Point(panel.Width - 150, 17);
                    lblRol.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
            }
            else if (name.Contains("menu") || name.Contains("sidebar"))
            {
                panel.BackColor = Color.FromArgb(28, 40, 51);
            }
            else if (name.Contains("content") || name.Contains("card") || name.Contains("body"))
            {
                panel.BackColor = Color.White;
                panel.Paint -= Control_PaintBorder;
                panel.Paint += Control_PaintBorder;
            }
            else
            {
                if (panel.BackColor == SystemColors.Control)
                {
                    panel.BackColor = FormBackgroundColor;
                }
            }

            if (panel.Font != null && panel.Font.Name != "Segoe UI")
            {
                panel.Font = new Font("Segoe UI", panel.Font.Size, panel.Font.Style);
            }
        }

        public static void ApplyDataGridViewTheme(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.GridColor = GridLineColor;

            // Başlık Stili
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextWhite;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = PrimaryBlue;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextWhite;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);

            // Hücre Stili
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = TextDark;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = GridSelectionBg;
            dgv.DefaultCellStyle.SelectionForeColor = TextDark;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = GridAlternatingBg;

            // İnce kenarlık çizimi
            dgv.Paint -= Control_PaintBorder;
            dgv.Paint += Control_PaintBorder;
        }

        public static void ApplyLabelTitle(Label label)
        {
            if (label == null) return;

            label.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            if (IsInsideControl(label, "pnlTop") || IsInsideControl(label, "pnlHeader"))
            {
                label.ForeColor = TextWhite;
            }
            else
            {
                label.ForeColor = TextDark;
            }
            label.BackColor = Color.Transparent;
        }

        public static void ApplyTextBoxTheme(TextBox textBox)
        {
            if (textBox == null) return;

            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            textBox.ForeColor = TextDark;
            textBox.BackColor = Color.White;
        }

        public static void ApplyComboBoxTheme(ComboBox comboBox)
        {
            if (comboBox == null) return;

            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            comboBox.ForeColor = TextDark;
            comboBox.BackColor = Color.White;
        }

        private static void ApplyControlsThemeRecursively(Control.ControlCollection controls, Form form)
        {
            if (controls == null) return;

            foreach (Control control in controls)
            {
                if (control.Font != null && control.Font.Name != "Segoe UI")
                {
                    control.Font = new Font("Segoe UI", control.Font.Size, control.Font.Style);
                }

                if (control is Button button)
                {
                    ApplyButtonTheme(button);
                }
                else if (control is DataGridView dgv)
                {
                    ApplyDataGridViewTheme(dgv);
                }
                else if (control is Panel panel)
                {
                    ApplyPanelTheme(panel);
                }
                else if (control is TextBox textBox)
                {
                    ApplyTextBoxTheme(textBox);
                }
                else if (control is ComboBox comboBox)
                {
                    ApplyComboBoxTheme(comboBox);
                }
                else if (control is Label label)
                {
                    if (label.Name.ToLower().Contains("baslik") || 
                        label.Name.ToLower().Contains("title") || 
                        (label.Text.ToUpper() == label.Text && label.Text.Length > 10))
                    {
                        ApplyLabelTitle(label);
                    }
                    else
                    {
                        if (IsInsideControl(label, "pnlTop") || IsInsideControl(label, "pnlHeader"))
                        {
                            label.ForeColor = TextWhite;
                        }
                        else
                        {
                            label.ForeColor = TextDark;
                            if (label.BackColor != Color.Transparent)
                            {
                                label.BackColor = Color.Transparent;
                            }
                        }
                    }
                }
                else if (control is GroupBox groupBox)
                {
                    groupBox.BackColor = Color.White;
                    groupBox.ForeColor = TextDark;
                    groupBox.Paint -= Control_PaintBorder;
                    groupBox.Paint += Control_PaintBorder;
                }
                else if (control is TabPage tabPage)
                {
                    tabPage.BackColor = Color.White;
                }
                else if (control is UserControl userControl)
                {
                    userControl.BackColor = FormBackgroundColor;
                }
                if (control.Controls != null && control.Controls.Count > 0)
                {
                    ApplyControlsThemeRecursively(control.Controls, form);
                }
            }
        }

        private static bool IsInsideControl(Control control, string parentName)
        {
            Control parent = control.Parent;
            while (parent != null)
            {
                if (parent.Name == parentName) return true;
                parent = parent.Parent;
            }
            return false;
        }

        private static void Control_PaintBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;
            using (Pen pen = new Pen(Color.FromArgb(218, 223, 230), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, ctrl.Width - 1, ctrl.Height - 1);
            }
        }

        private static void Sidebar_Paint(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;
            using (Pen pen = new Pen(Color.FromArgb(23, 32, 42), 1))
            {
                e.Graphics.DrawLine(pen, ctrl.Width - 1, 0, ctrl.Width - 1, ctrl.Height);
            }
        }

        private static void Button_PaintActiveIndicator(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;
            // Sol vurgu çizgisi (Beyaz)
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(236, 240, 241)))
            {
                e.Graphics.FillRectangle(brush, 0, 0, 4, ctrl.Height);
            }
            
            // Hafif vurgulu kenarlık
            using (Pen pen = new Pen(Color.FromArgb(52, 152, 219), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, ctrl.Width - 1, ctrl.Height - 1);
            }
        }

        private static void Button_PaintBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;
            using (Pen pen = new Pen(Color.FromArgb(52, 73, 94), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, ctrl.Width - 1, ctrl.Height - 1);
            }
        }
    }
}
