namespace SinavTakvimiUI
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnTakvim = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTanimlama = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.lblRol);
            this.pnlTop.Controls.Add(this.lblKullanici);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(247, 9);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 13);
            this.lblRol.TabIndex = 1;
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(78, 9);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 13);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Click += new System.EventHandler(this.lblKullanici_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMenu.Controls.Add(this.btnCikis);
            this.pnlMenu.Controls.Add(this.btnRapor);
            this.pnlMenu.Controls.Add(this.btnTakvim);
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.btnTanimlama);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 70);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 380);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(12, 340);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(167, 23);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Location = new System.Drawing.Point(12, 282);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(167, 23);
            this.btnRapor.TabIndex = 4;
            this.btnRapor.Text = "Raporlar ";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnTakvim
            // 
            this.btnTakvim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTakvim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakvim.Location = new System.Drawing.Point(12, 224);
            this.btnTakvim.Name = "btnTakvim";
            this.btnTakvim.Size = new System.Drawing.Size(167, 23);
            this.btnTakvim.TabIndex = 3;
            this.btnTakvim.Text = "Takvim";
            this.btnTakvim.UseVisualStyleBackColor = false;
            this.btnTakvim.Click += new System.EventHandler(this.btnTakvim_Click);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "btnSinav";
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sınav Yönetimi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTanimlama
            // 
            this.btnTanimlama.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTanimlama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanimlama.Location = new System.Drawing.Point(12, 97);
            this.btnTanimlama.Name = "btnTanimlama";
            this.btnTanimlama.Size = new System.Drawing.Size(167, 23);
            this.btnTanimlama.TabIndex = 1;
            this.btnTanimlama.Text = "Tanımlamalar";
            this.btnTanimlama.UseVisualStyleBackColor = false;
            this.btnTanimlama.Click += new System.EventHandler(this.btnTanimlama_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(12, 31);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(167, 23);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(550, 380);
            this.pnlContent.TabIndex = 0;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDashboard_Load_1);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnTakvim;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTanimlama;
        private System.Windows.Forms.Button btnDashboard;

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblKullanici;
    }
}