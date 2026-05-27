namespace SinavTakvimiOtomasyonu
{
    partial class Form1
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
            this.lblDers = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.cmbOturumlar = new System.Windows.Forms.ComboBox();
            this.lblOturum = new System.Windows.Forms.Label();
            this.btnYukle = new System.Windows.Forms.Button();
            this.btnSinavOlustur = new System.Windows.Forms.Button();
            this.dgvSalonlar = new System.Windows.Forms.DataGridView();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGozetmenAta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Location = new System.Drawing.Point(30, 30);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(39, 16);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(30, 75);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(41, 16);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih:";
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(151, 25);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(300, 24);
            this.cmbDersler.TabIndex = 2;
            // 
            // cmbOturumlar
            // 
            this.cmbOturumlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOturumlar.FormattingEnabled = true;
            this.cmbOturumlar.Location = new System.Drawing.Point(150, 115);
            this.cmbOturumlar.Name = "cmbOturumlar";
            this.cmbOturumlar.Size = new System.Drawing.Size(300, 24);
            this.cmbOturumlar.TabIndex = 3;
            // 
            // lblOturum
            // 
            this.lblOturum.AutoSize = true;
            this.lblOturum.Location = new System.Drawing.Point(30, 120);
            this.lblOturum.Name = "lblOturum";
            this.lblOturum.Size = new System.Drawing.Size(52, 16);
            this.lblOturum.TabIndex = 4;
            this.lblOturum.Text = "Oturum:";
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(500, 25);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(140, 35);
            this.btnYukle.TabIndex = 5;
            this.btnYukle.Text = "Verileri Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnSinavOlustur
            // 
            this.btnSinavOlustur.Location = new System.Drawing.Point(500, 75);
            this.btnSinavOlustur.Name = "btnSinavOlustur";
            this.btnSinavOlustur.Size = new System.Drawing.Size(140, 35);
            this.btnSinavOlustur.TabIndex = 6;
            this.btnSinavOlustur.Text = "Sınav Oluştur";
            this.btnSinavOlustur.UseVisualStyleBackColor = true;
            this.btnSinavOlustur.Click += new System.EventHandler(this.btnSinavOlustur_Click);
            // 
            // dgvSalonlar
            // 
            this.dgvSalonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalonlar.Location = new System.Drawing.Point(30, 180);
            this.dgvSalonlar.Name = "dgvSalonlar";
            this.dgvSalonlar.RowHeadersWidth = 51;
            this.dgvSalonlar.RowTemplate.Height = 24;
            this.dgvSalonlar.Size = new System.Drawing.Size(820, 330);
            this.dgvSalonlar.TabIndex = 7;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(150, 70);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(300, 22);
            this.dtpTarih.TabIndex = 8;
            // 
            // btnGozetmenAta
            // 
            this.btnGozetmenAta.Location = new System.Drawing.Point(500, 544);
            this.btnGozetmenAta.Name = "btnGozetmenAta";
            this.btnGozetmenAta.Size = new System.Drawing.Size(140, 35);
            this.btnGozetmenAta.TabIndex = 9;
            this.btnGozetmenAta.Text = "Gözetmen Ata";
            this.btnGozetmenAta.UseVisualStyleBackColor = true;
            this.btnGozetmenAta.Click += new System.EventHandler(this.btnGozetmenAta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gözetmenler:";
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(151, 555);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(300, 24);
            this.cmbPersoneller.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 697);
            this.Controls.Add(this.cmbPersoneller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGozetmenAta);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.dgvSalonlar);
            this.Controls.Add(this.btnSinavOlustur);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.lblOturum);
            this.Controls.Add(this.cmbOturumlar);
            this.Controls.Add(this.cmbDersler);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblDers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalonlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.ComboBox cmbOturumlar;
        private System.Windows.Forms.Label lblOturum;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button btnSinavOlustur;
        private System.Windows.Forms.DataGridView dgvSalonlar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnGozetmenAta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersoneller;
    }
}

