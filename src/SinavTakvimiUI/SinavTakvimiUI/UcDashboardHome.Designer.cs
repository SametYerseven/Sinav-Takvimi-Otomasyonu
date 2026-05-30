namespace SinavTakvimiUI
{
    partial class UcDashboardHome
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
            this.dgvYaklasanSinavlar = new System.Windows.Forms.DataGridView();
            this.grpSalon = new System.Windows.Forms.GroupBox();
            this.lblSalon = new System.Windows.Forms.Label();
            this.grpSinav = new System.Windows.Forms.GroupBox();
            this.lblSinav = new System.Windows.Forms.Label();
            this.grpPersonel = new System.Windows.Forms.GroupBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.grpDers = new System.Windows.Forms.GroupBox();
            this.lblDers = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYaklasanSinavlar)).BeginInit();
            this.grpSalon.SuspendLayout();
            this.grpSinav.SuspendLayout();
            this.grpPersonel.SuspendLayout();
            this.grpDers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvYaklasanSinavlar
            // 
            this.dgvYaklasanSinavlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvYaklasanSinavlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYaklasanSinavlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvYaklasanSinavlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYaklasanSinavlar.Location = new System.Drawing.Point(30, 240);
            this.dgvYaklasanSinavlar.Name = "dgvYaklasanSinavlar";
            this.dgvYaklasanSinavlar.Size = new System.Drawing.Size(940, 320);
            this.dgvYaklasanSinavlar.TabIndex = 4;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.Location = new System.Drawing.Point(30, 205);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(147, 21);
            this.lblTableTitle.TabIndex = 5;
            this.lblTableTitle.Text = "Yaklaşan Sınavlar";
            // 
            // grpSalon
            // 
            this.grpSalon.Controls.Add(this.lblSalon);
            this.grpSalon.Location = new System.Drawing.Point(260, 110);
            this.grpSalon.Name = "grpSalon";
            this.grpSalon.Size = new System.Drawing.Size(200, 70);
            this.grpSalon.TabIndex = 2;
            this.grpSalon.TabStop = false;
            this.grpSalon.Text = "Toplam Salon";
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalon.Location = new System.Drawing.Point(20, 30);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(19, 21);
            this.lblSalon.TabIndex = 0;
            this.lblSalon.Text = "0";
            // 
            // grpSinav
            // 
            this.grpSinav.Controls.Add(this.lblSinav);
            this.grpSinav.Location = new System.Drawing.Point(490, 110);
            this.grpSinav.Name = "grpSinav";
            this.grpSinav.Size = new System.Drawing.Size(200, 70);
            this.grpSinav.TabIndex = 3;
            this.grpSinav.TabStop = false;
            this.grpSinav.Text = "Toplam Sınav";
            // 
            // lblSinav
            // 
            this.lblSinav.AutoSize = true;
            this.lblSinav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSinav.Location = new System.Drawing.Point(20, 30);
            this.lblSinav.Name = "lblSinav";
            this.lblSinav.Size = new System.Drawing.Size(19, 21);
            this.lblSinav.TabIndex = 0;
            this.lblSinav.Text = "0";
            // 
            // grpPersonel
            // 
            this.grpPersonel.Controls.Add(this.lblPersonel);
            this.grpPersonel.Location = new System.Drawing.Point(490, 30);
            this.grpPersonel.Name = "grpPersonel";
            this.grpPersonel.Size = new System.Drawing.Size(200, 70);
            this.grpPersonel.TabIndex = 1;
            this.grpPersonel.TabStop = false;
            this.grpPersonel.Text = "Toplam Personel";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonel.Location = new System.Drawing.Point(20, 30);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(19, 21);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "0";
            // 
            // grpDers
            // 
            this.grpDers.Controls.Add(this.lblDers);
            this.grpDers.Location = new System.Drawing.Point(260, 30);
            this.grpDers.Name = "grpDers";
            this.grpDers.Size = new System.Drawing.Size(200, 70);
            this.grpDers.TabIndex = 0;
            this.grpDers.TabStop = false;
            this.grpDers.Text = "Toplam Ders";
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDers.Location = new System.Drawing.Point(20, 30);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(19, 21);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "0";
            // 
            // UcDashboardHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTableTitle);
            this.Controls.Add(this.dgvYaklasanSinavlar);
            this.Controls.Add(this.grpSalon);
            this.Controls.Add(this.grpSinav);
            this.Controls.Add(this.grpPersonel);
            this.Controls.Add(this.grpDers);
            this.Name = "UcDashboardHome";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.UcDashboardHome_Load);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSalon;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.GroupBox grpSinav;
        private System.Windows.Forms.Label lblSinav;
        private System.Windows.Forms.GroupBox grpPersonel;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.GroupBox grpDers;
        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.DataGridView dgvYaklasanSinavlar;
        private System.Windows.Forms.Label lblTableTitle;
    }
}
