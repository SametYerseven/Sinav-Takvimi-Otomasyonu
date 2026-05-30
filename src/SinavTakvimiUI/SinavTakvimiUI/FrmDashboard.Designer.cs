namespace SinavTakvimiUI
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.dgvYaklasanSinavlar = new System.Windows.Forms.DataGridView();
            this.grpSalon = new System.Windows.Forms.GroupBox();
            this.lblSalon = new System.Windows.Forms.Label();
            this.grpSinav = new System.Windows.Forms.GroupBox();
            this.lblSinav = new System.Windows.Forms.Label();
            this.grpPersonel = new System.Windows.Forms.GroupBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.grpDers = new System.Windows.Forms.GroupBox();
            this.lblDers = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaklasanSinavlar)).BeginInit();
            this.grpSalon.SuspendLayout();
            this.grpSinav.SuspendLayout();
            this.grpPersonel.SuspendLayout();
            this.grpDers.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(800, 52);
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
            this.pnlMenu.Location = new System.Drawing.Point(0, 52);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 398);
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
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlContent.Controls.Add(this.dgvYaklasanSinavlar);
            this.pnlContent.Controls.Add(this.grpSalon);
            this.pnlContent.Controls.Add(this.grpSinav);
            this.pnlContent.Controls.Add(this.grpPersonel);
            this.pnlContent.Controls.Add(this.grpDers);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 52);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 398);
            this.pnlContent.TabIndex = 0;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // dgvYaklasanSinavlar
            // 
            this.dgvYaklasanSinavlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYaklasanSinavlar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvYaklasanSinavlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYaklasanSinavlar.Location = new System.Drawing.Point(259, 224);
            this.dgvYaklasanSinavlar.Name = "dgvYaklasanSinavlar";
            this.dgvYaklasanSinavlar.Size = new System.Drawing.Size(497, 150);
            this.dgvYaklasanSinavlar.TabIndex = 8;
            this.dgvYaklasanSinavlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYaklasanSinavlar_CellContentClick);
            // 
            // grpSalon
            // 
            this.grpSalon.Controls.Add(this.lblSalon);
            this.grpSalon.Location = new System.Drawing.Point(259, 121);
            this.grpSalon.Name = "grpSalon";
            this.grpSalon.Size = new System.Drawing.Size(200, 63);
            this.grpSalon.TabIndex = 0;
            this.grpSalon.TabStop = false;
            this.grpSalon.Text = "Toplam Salon";
            this.grpSalon.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Location = new System.Drawing.Point(67, 26);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(35, 13);
            this.lblSalon.TabIndex = 10;
            this.lblSalon.Text = "label3";
            // 
            // grpSinav
            // 
            this.grpSinav.Controls.Add(this.lblSinav);
            this.grpSinav.Location = new System.Drawing.Point(556, 121);
            this.grpSinav.Name = "grpSinav";
            this.grpSinav.Size = new System.Drawing.Size(200, 63);
            this.grpSinav.TabIndex = 0;
            this.grpSinav.TabStop = false;
            this.grpSinav.Text = "Toplam Sınav";
            // 
            // lblSinav
            // 
            this.lblSinav.AutoSize = true;
            this.lblSinav.Location = new System.Drawing.Point(74, 26);
            this.lblSinav.Name = "lblSinav";
            this.lblSinav.Size = new System.Drawing.Size(35, 13);
            this.lblSinav.TabIndex = 11;
            this.lblSinav.Text = "label4";
            this.lblSinav.Click += new System.EventHandler(this.label4_Click);
            // 
            // grpPersonel
            // 
            this.grpPersonel.Controls.Add(this.lblPersonel);
            this.grpPersonel.Location = new System.Drawing.Point(556, 31);
            this.grpPersonel.Name = "grpPersonel";
            this.grpPersonel.Size = new System.Drawing.Size(200, 61);
            this.grpPersonel.TabIndex = 7;
            this.grpPersonel.TabStop = false;
            this.grpPersonel.Text = "Toplam Personel";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(74, 30);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(35, 13);
            this.lblPersonel.TabIndex = 9;
            this.lblPersonel.Text = "label2";
            // 
            // grpDers
            // 
            this.grpDers.Controls.Add(this.lblDers);
            this.grpDers.Location = new System.Drawing.Point(259, 31);
            this.grpDers.Name = "grpDers";
            this.grpDers.Size = new System.Drawing.Size(200, 61);
            this.grpDers.TabIndex = 6;
            this.grpDers.TabStop = false;
            this.grpDers.Text = "Toplam Ders";
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Location = new System.Drawing.Point(67, 30);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(35, 13);
            this.lblDers.TabIndex = 8;
            this.lblDers.Text = "label1";
            this.lblDers.Click += new System.EventHandler(this.lblDers_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlContent);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaklasanSinavlar)).EndInit();
            this.grpSalon.ResumeLayout(false);
            this.grpSalon.PerformLayout();
            this.grpSinav.ResumeLayout(false);
            this.grpSinav.PerformLayout();
            this.grpPersonel.ResumeLayout(false);
            this.grpPersonel.PerformLayout();
            this.grpDers.ResumeLayout(false);
            this.grpDers.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpSalon;
        private System.Windows.Forms.GroupBox grpSinav;
        private System.Windows.Forms.GroupBox grpPersonel;
        private System.Windows.Forms.GroupBox grpDers;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Label lblSinav;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.DataGridView dgvYaklasanSinavlar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblKullanici;
    }
}