namespace SinavTakvimiUI
{
    partial class FrmSinavIptal
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
            this.dgvSinavlar = new System.Windows.Forms.DataGridView();
            this.btnSinavIptal = new System.Windows.Forms.Button();
            this.btnLoglariGetir = new System.Windows.Forms.Button();
            this.btnSinavlariYukle = new System.Windows.Forms.Button();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinavlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinavlar
            // 
            this.dgvSinavlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinavlar.Location = new System.Drawing.Point(43, 86);
            this.dgvSinavlar.Name = "dgvSinavlar";
            this.dgvSinavlar.RowHeadersWidth = 51;
            this.dgvSinavlar.RowTemplate.Height = 24;
            this.dgvSinavlar.Size = new System.Drawing.Size(820, 330);
            this.dgvSinavlar.TabIndex = 0;
            // 
            // btnSinavIptal
            // 
            this.btnSinavIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSinavIptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSinavIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavIptal.ForeColor = System.Drawing.Color.White;
            this.btnSinavIptal.Location = new System.Drawing.Point(43, 503);
            this.btnSinavIptal.Name = "btnSinavIptal";
            this.btnSinavIptal.Size = new System.Drawing.Size(178, 36);
            this.btnSinavIptal.TabIndex = 1;
            this.btnSinavIptal.Text = "İptal Et";
            this.btnSinavIptal.UseVisualStyleBackColor = false;
            this.btnSinavIptal.Click += new System.EventHandler(this.btnSinavIptal_Click);
            // 
            // btnLoglariGetir
            // 
            this.btnLoglariGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoglariGetir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoglariGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoglariGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoglariGetir.ForeColor = System.Drawing.Color.White;
            this.btnLoglariGetir.Location = new System.Drawing.Point(43, 554);
            this.btnLoglariGetir.Name = "btnLoglariGetir";
            this.btnLoglariGetir.Size = new System.Drawing.Size(178, 36);
            this.btnLoglariGetir.TabIndex = 2;
            this.btnLoglariGetir.Text = "Loglari Getir";
            this.btnLoglariGetir.UseVisualStyleBackColor = false;
            this.btnLoglariGetir.Click += new System.EventHandler(this.btnLoglariGetir_Click);
            // 
            // btnSinavlariYukle
            // 
            this.btnSinavlariYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSinavlariYukle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSinavlariYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavlariYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavlariYukle.ForeColor = System.Drawing.Color.White;
            this.btnSinavlariYukle.Location = new System.Drawing.Point(43, 452);
            this.btnSinavlariYukle.Name = "btnSinavlariYukle";
            this.btnSinavlariYukle.Size = new System.Drawing.Size(178, 36);
            this.btnSinavlariYukle.TabIndex = 3;
            this.btnSinavlariYukle.Text = "Sınavları Yükle";
            this.btnSinavlariYukle.UseVisualStyleBackColor = false;
            this.btnSinavlariYukle.Click += new System.EventHandler(this.btnSinavlariYukle_Click);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.ForeColor = System.Drawing.Color.White;
            this.lblBaslık.Location = new System.Drawing.Point(488, 28);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(290, 32);
            this.lblBaslık.TabIndex = 4;
            this.lblBaslık.Text = "SINAV İPTAL PANELİ";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(1030, 619);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(186, 55);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmSinavIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1240, 697);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.btnSinavlariYukle);
            this.Controls.Add(this.btnLoglariGetir);
            this.Controls.Add(this.btnSinavIptal);
            this.Controls.Add(this.dgvSinavlar);
            this.Name = "FrmSinavIptal";
            this.Text = "FrmSinavIptal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinavlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinavlar;
        private System.Windows.Forms.Button btnSinavIptal;
        private System.Windows.Forms.Button btnLoglariGetir;
        private System.Windows.Forms.Button btnSinavlariYukle;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Button btnGeri;
    }
}