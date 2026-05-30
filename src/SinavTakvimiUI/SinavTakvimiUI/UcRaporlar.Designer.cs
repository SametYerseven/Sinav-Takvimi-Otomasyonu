namespace SinavTakvimiUI
{
    partial class UcRaporlar
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
            this.dgvRaporlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnGozetmenRaporu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGozetmenRaporu.Location = new System.Drawing.Point(46, 458);
            this.btnGozetmenRaporu.Name = "btnGozetmenRaporu";
            this.btnGozetmenRaporu.Size = new System.Drawing.Size(178, 36);
            this.btnGozetmenRaporu.TabIndex = 1;
            this.btnGozetmenRaporu.Text = "Gözetmen Raporu";
            this.btnGozetmenRaporu.UseVisualStyleBackColor = true;
            this.btnGozetmenRaporu.Click += new System.EventHandler(this.btnGozetmenRaporu_Click);
            // 
            // btnLogRaporu
            // 
            this.btnLogRaporu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogRaporu.Location = new System.Drawing.Point(46, 542);
            this.btnLogRaporu.Name = "btnLogRaporu";
            this.btnLogRaporu.Size = new System.Drawing.Size(178, 36);
            this.btnLogRaporu.TabIndex = 2;
            this.btnLogRaporu.Text = "Log Kayıtları";
            this.btnLogRaporu.UseVisualStyleBackColor = true;
            this.btnLogRaporu.Click += new System.EventHandler(this.btnLogRaporu_Click);
            // 
            // btnDerslikRaporu
            // 
            this.btnDerslikRaporu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDerslikRaporu.Location = new System.Drawing.Point(46, 500);
            this.btnDerslikRaporu.Name = "btnDerslikRaporu";
            this.btnDerslikRaporu.Size = new System.Drawing.Size(178, 36);
            this.btnDerslikRaporu.TabIndex = 3;
            this.btnDerslikRaporu.Text = "Derslik Raporu";
            this.btnDerslikRaporu.UseVisualStyleBackColor = true;
            this.btnDerslikRaporu.Click += new System.EventHandler(this.btnDerslikRaporu_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(1030, 619);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(186, 56);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raporlar";
            // 
            // UcRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnDerslikRaporu);
            this.Controls.Add(this.btnLogRaporu);
            this.Controls.Add(this.btnGozetmenRaporu);
            this.Controls.Add(this.dgvRaporlar);
            this.Name = "UcRaporlar";
            this.Size = new System.Drawing.Size(1240, 697);
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
