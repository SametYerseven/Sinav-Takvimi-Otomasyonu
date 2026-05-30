namespace SinavTakvimiUI
{
    partial class FrmRaporlar
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
            this.dgvRaporlar = new System.Windows.Forms.DataGridView();
            this.btnGozetmenRaporu = new System.Windows.Forms.Button();
            this.btnLogRaporu = new System.Windows.Forms.Button();
            this.btnDerslikRaporu = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaporlar
            // 
            this.dgvRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporlar.Location = new System.Drawing.Point(46, 79);
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.RowHeadersWidth = 51;
            this.dgvRaporlar.RowTemplate.Height = 24;
            this.dgvRaporlar.Size = new System.Drawing.Size(820, 330);
            this.dgvRaporlar.TabIndex = 0;
            // 
            // btnGozetmenRaporu
            // 
            this.btnGozetmenRaporu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGozetmenRaporu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGozetmenRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGozetmenRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGozetmenRaporu.ForeColor = System.Drawing.Color.White;
            this.btnGozetmenRaporu.Location = new System.Drawing.Point(46, 458);
            this.btnGozetmenRaporu.Name = "btnGozetmenRaporu";
            this.btnGozetmenRaporu.Size = new System.Drawing.Size(178, 36);
            this.btnGozetmenRaporu.TabIndex = 1;
            this.btnGozetmenRaporu.Text = "Gözetmen Raporu";
            this.btnGozetmenRaporu.UseVisualStyleBackColor = false;
            this.btnGozetmenRaporu.Click += new System.EventHandler(this.btnGozetmenRaporu_Click);
            // 
            // btnLogRaporu
            // 
            this.btnLogRaporu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogRaporu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogRaporu.ForeColor = System.Drawing.Color.White;
            this.btnLogRaporu.Location = new System.Drawing.Point(46, 542);
            this.btnLogRaporu.Name = "btnLogRaporu";
            this.btnLogRaporu.Size = new System.Drawing.Size(178, 36);
            this.btnLogRaporu.TabIndex = 2;
            this.btnLogRaporu.Text = "Log Kayıtları";
            this.btnLogRaporu.UseVisualStyleBackColor = false;
            this.btnLogRaporu.Click += new System.EventHandler(this.btnLogRaporu_Click);
            // 
            // btnDerslikRaporu
            // 
            this.btnDerslikRaporu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDerslikRaporu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDerslikRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerslikRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDerslikRaporu.ForeColor = System.Drawing.Color.White;
            this.btnDerslikRaporu.Location = new System.Drawing.Point(46, 500);
            this.btnDerslikRaporu.Name = "btnDerslikRaporu";
            this.btnDerslikRaporu.Size = new System.Drawing.Size(178, 36);
            this.btnDerslikRaporu.TabIndex = 3;
            this.btnDerslikRaporu.Text = "Derslik Raporu";
            this.btnDerslikRaporu.UseVisualStyleBackColor = false;
            this.btnDerslikRaporu.Click += new System.EventHandler(this.btnDerslikRaporu_Click);
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
            this.btnGeri.Size = new System.Drawing.Size(186, 56);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(557, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raporlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1240, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnDerslikRaporu);
            this.Controls.Add(this.btnLogRaporu);
            this.Controls.Add(this.btnGozetmenRaporu);
            this.Controls.Add(this.dgvRaporlar);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaporlar;
        private System.Windows.Forms.Button btnGozetmenRaporu;
        private System.Windows.Forms.Button btnLogRaporu;
        private System.Windows.Forms.Button btnDerslikRaporu;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
    }
}