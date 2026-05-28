namespace SinavTakvimiOtomasyonu
{
    partial class FrmSinavYonetim
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
            this.btnIptalPaneli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDers.ForeColor = System.Drawing.Color.White;
            this.lblDers.Location = new System.Drawing.Point(34, 117);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(44, 18);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(34, 162);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(45, 18);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih:";
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(155, 112);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(300, 24);
            this.cmbDersler.TabIndex = 2;
            // 
            // cmbOturumlar
            // 
            this.cmbOturumlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOturumlar.FormattingEnabled = true;
            this.cmbOturumlar.Location = new System.Drawing.Point(154, 202);
            this.cmbOturumlar.Name = "cmbOturumlar";
            this.cmbOturumlar.Size = new System.Drawing.Size(300, 24);
            this.cmbOturumlar.TabIndex = 3;
            // 
            // lblOturum
            // 
            this.lblOturum.AutoSize = true;
            this.lblOturum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblOturum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOturum.ForeColor = System.Drawing.Color.White;
            this.lblOturum.Location = new System.Drawing.Point(34, 207);
            this.lblOturum.Name = "lblOturum";
            this.lblOturum.Size = new System.Drawing.Size(62, 18);
            this.lblOturum.TabIndex = 4;
            this.lblOturum.Text = "Oturum:";
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnYukle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukle.ForeColor = System.Drawing.Color.White;
            this.btnYukle.Location = new System.Drawing.Point(504, 112);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(140, 35);
            this.btnYukle.TabIndex = 5;
            this.btnYukle.Text = "Verileri Yükle";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnSinavOlustur
            // 
            this.btnSinavOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSinavOlustur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSinavOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavOlustur.ForeColor = System.Drawing.Color.White;
            this.btnSinavOlustur.Location = new System.Drawing.Point(504, 162);
            this.btnSinavOlustur.Name = "btnSinavOlustur";
            this.btnSinavOlustur.Size = new System.Drawing.Size(140, 35);
            this.btnSinavOlustur.TabIndex = 6;
            this.btnSinavOlustur.Text = "Sınav Oluştur";
            this.btnSinavOlustur.UseVisualStyleBackColor = false;
            this.btnSinavOlustur.Click += new System.EventHandler(this.btnSinavOlustur_Click);
            // 
            // dgvSalonlar
            // 
            this.dgvSalonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalonlar.Location = new System.Drawing.Point(34, 243);
            this.dgvSalonlar.Name = "dgvSalonlar";
            this.dgvSalonlar.RowHeadersWidth = 51;
            this.dgvSalonlar.RowTemplate.Height = 24;
            this.dgvSalonlar.Size = new System.Drawing.Size(820, 330);
            this.dgvSalonlar.TabIndex = 7;
            this.dgvSalonlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalonlar_CellClick);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(154, 157);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(300, 22);
            this.dtpTarih.TabIndex = 8;
            // 
            // btnGozetmenAta
            // 
            this.btnGozetmenAta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGozetmenAta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGozetmenAta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGozetmenAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGozetmenAta.ForeColor = System.Drawing.Color.White;
            this.btnGozetmenAta.Location = new System.Drawing.Point(504, 607);
            this.btnGozetmenAta.Name = "btnGozetmenAta";
            this.btnGozetmenAta.Size = new System.Drawing.Size(140, 35);
            this.btnGozetmenAta.TabIndex = 9;
            this.btnGozetmenAta.Text = "Gözetmen Ata";
            this.btnGozetmenAta.UseVisualStyleBackColor = false;
            this.btnGozetmenAta.Click += new System.EventHandler(this.btnGozetmenAta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gözetmenler:";
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(155, 618);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(300, 24);
            this.cmbPersoneller.TabIndex = 11;
            // 
            // btnIptalPaneli
            // 
            this.btnIptalPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnIptalPaneli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnIptalPaneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptalPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalPaneli.ForeColor = System.Drawing.Color.White;
            this.btnIptalPaneli.Location = new System.Drawing.Point(1030, 518);
            this.btnIptalPaneli.Name = "btnIptalPaneli";
            this.btnIptalPaneli.Size = new System.Drawing.Size(186, 55);
            this.btnIptalPaneli.TabIndex = 12;
            this.btnIptalPaneli.Text = "Sınav İptal Paneli";
            this.btnIptalPaneli.UseVisualStyleBackColor = false;
            this.btnIptalPaneli.Click += new System.EventHandler(this.btnIptalPaneli_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1030, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Takvim Paneli";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(413, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "SINAV YÖNETİM PANELİ";
            // 
            // FrmSinavYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1240, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIptalPaneli);
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
            this.Name = "FrmSinavYonetim";
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
        private System.Windows.Forms.Button btnIptalPaneli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

