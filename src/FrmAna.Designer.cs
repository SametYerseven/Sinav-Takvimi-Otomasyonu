namespace SinavTakvimiOtomasyonu
{
    partial class FrmAna
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHosGeldiniz = new System.Windows.Forms.Label();
            this.btnTanimlamalar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblHosGeldiniz
            this.lblHosGeldiniz.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHosGeldiniz.Location = new System.Drawing.Point(150, 60);
            this.lblHosGeldiniz.Name = "lblHosGeldiniz";
            this.lblHosGeldiniz.Size = new System.Drawing.Size(500, 40);
            this.lblHosGeldiniz.TabIndex = 0;
            this.lblHosGeldiniz.Text = "Hoş Geldiniz!";
            this.lblHosGeldiniz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnTanimlamalar
            this.btnTanimlamalar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTanimlamalar.Location = new System.Drawing.Point(300, 160);
            this.btnTanimlamalar.Name = "btnTanimlamalar";
            this.btnTanimlamalar.Size = new System.Drawing.Size(200, 40);
            this.btnTanimlamalar.TabIndex = 1;
            this.btnTanimlamalar.Text = "Tanımlamalar";
            this.btnTanimlamalar.UseVisualStyleBackColor = true;
            this.btnTanimlamalar.Click += new System.EventHandler(this.btnTanimlamalar_Click);

            // btnCikis
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCikis.Location = new System.Drawing.Point(300, 220);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(200, 40);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);

            // FrmAna
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHosGeldiniz);
            this.Controls.Add(this.btnTanimlamalar);
            this.Controls.Add(this.btnCikis);
            this.Name = "FrmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Takvimi Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHosGeldiniz;
        private System.Windows.Forms.Button btnTanimlamalar;
        private System.Windows.Forms.Button btnCikis;
    }
}
