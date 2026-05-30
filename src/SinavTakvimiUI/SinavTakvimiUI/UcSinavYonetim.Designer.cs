namespace SinavTakvimiUI
{
    partial class UcSinavYonetim
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

        #region Component Designer generated code

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
            this.btnRaporlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDers.Location = new System.Drawing.Point(34, 117);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(36, 15);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(34, 162);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 15);
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
            this.lblOturum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOturum.Location = new System.Drawing.Point(34, 207);
            this.lblOturum.Name = "lblOturum";
            this.lblOturum.Size = new System.Drawing.Size(51, 15);
            this.lblOturum.TabIndex = 4;
            this.lblOturum.Text = "Oturum:";
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(504, 112);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(157, 35);
            this.btnYukle.TabIndex = 5;
            this.btnYukle.Text = "Verileri Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnSinavOlustur
            // 
            this.btnSinavOlustur.Location = new System.Drawing.Point(504, 162);
            this.btnSinavOlustur.Name = "btnSinavOlustur";
            this.btnSinavOlustur.Size = new System.Drawing.Size(157, 35);
            this.btnSinavOlustur.TabIndex = 6;
            this.btnSinavOlustur.Text = "Sınav Oluştur";
            this.btnSinavOlustur.UseVisualStyleBackColor = true;
            this.btnSinavOlustur.Click += new System.EventHandler(this.btnSinavOlustur_Click);
            // 
            // dgvSalonlar
            // 
            this.dgvSalonlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnGozetmenAta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGozetmenAta.Location = new System.Drawing.Point(504, 607);
            this.btnGozetmenAta.Name = "btnGozetmenAta";
            this.btnGozetmenAta.Size = new System.Drawing.Size(157, 35);
            this.btnGozetmenAta.TabIndex = 9;
            this.btnGozetmenAta.Text = "Gözetmen Ata";
            this.btnGozetmenAta.UseVisualStyleBackColor = true;
            this.btnGozetmenAta.Click += new System.EventHandler(this.btnGozetmenAta_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gözetmenler:";
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPersoneller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(155, 618);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(300, 24);
            this.cmbPersoneller.TabIndex = 11;
            // 
            // btnIptalPaneli
            // 
            this.btnIptalPaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptalPaneli.Location = new System.Drawing.Point(1030, 518);
            this.btnIptalPaneli.Name = "btnIptalPaneli";
            this.btnIptalPaneli.Size = new System.Drawing.Size(186, 55);
            this.btnIptalPaneli.TabIndex = 12;
            this.btnIptalPaneli.Text = "Sınav İptal Paneli";
            this.btnIptalPaneli.UseVisualStyleBackColor = true;
            this.btnIptalPaneli.Click += new System.EventHandler(this.btnIptalPaneli_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1030, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Takvim Paneli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "SINAV YÖNETİM PANELİ";
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRaporlar.Location = new System.Drawing.Point(1030, 352);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(186, 55);
            this.btnRaporlar.TabIndex = 16;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // UcSinavYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRaporlar);
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
            this.Name = "UcSinavYonetim";
            this.Size = new System.Drawing.Size(1240, 697);
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
        private System.Windows.Forms.Button btnRaporlar;
    }
}
