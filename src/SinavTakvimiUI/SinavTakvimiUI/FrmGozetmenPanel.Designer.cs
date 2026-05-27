namespace SinavTakvimiUI
{
    partial class FrmGozetmenPanel
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.grpAdSoyad = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.grpBolum = new System.Windows.Forms.GroupBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.grpToplam = new System.Windows.Forms.GroupBox();
            this.lblToplamGorev = new System.Windows.Forms.Label();
            this.dgvGorevler = new System.Windows.Forms.DataGridView();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpAdSoyad.SuspendLayout();
            this.grpBolum.SuspendLayout();
            this.grpToplam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.lblBaslik);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(28, 24);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(357, 39);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "GÖZETMEN PANELİ";
            // 
            // grpAdSoyad
            // 
            this.grpAdSoyad.Controls.Add(this.lblAdSoyad);
            this.grpAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAdSoyad.Location = new System.Drawing.Point(33, 132);
            this.grpAdSoyad.Name = "grpAdSoyad";
            this.grpAdSoyad.Size = new System.Drawing.Size(200, 100);
            this.grpAdSoyad.TabIndex = 1;
            this.grpAdSoyad.TabStop = false;
            this.grpAdSoyad.Text = "Ad Soyad";
            this.grpAdSoyad.Enter += new System.EventHandler(this.grpAdSoyad_Enter);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(49, 34);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(46, 18);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "label1";
            this.lblAdSoyad.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpBolum
            // 
            this.grpBolum.Controls.Add(this.lblBolum);
            this.grpBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBolum.Location = new System.Drawing.Point(291, 132);
            this.grpBolum.Name = "grpBolum";
            this.grpBolum.Size = new System.Drawing.Size(200, 100);
            this.grpBolum.TabIndex = 0;
            this.grpBolum.TabStop = false;
            this.grpBolum.Text = "Bölüm";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolum.Location = new System.Drawing.Point(64, 34);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(46, 18);
            this.lblBolum.TabIndex = 1;
            this.lblBolum.Text = "label2";
            // 
            // grpToplam
            // 
            this.grpToplam.Controls.Add(this.lblToplamGorev);
            this.grpToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpToplam.Location = new System.Drawing.Point(557, 132);
            this.grpToplam.Name = "grpToplam";
            this.grpToplam.Size = new System.Drawing.Size(200, 100);
            this.grpToplam.TabIndex = 0;
            this.grpToplam.TabStop = false;
            this.grpToplam.Text = "Toplam Görev";
            // 
            // lblToplamGorev
            // 
            this.lblToplamGorev.AutoSize = true;
            this.lblToplamGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGorev.Location = new System.Drawing.Point(46, 34);
            this.lblToplamGorev.Name = "lblToplamGorev";
            this.lblToplamGorev.Size = new System.Drawing.Size(46, 18);
            this.lblToplamGorev.TabIndex = 2;
            this.lblToplamGorev.Text = "label3";
            // 
            // dgvGorevler
            // 
            this.dgvGorevler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGorevler.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGorevler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGorevler.Location = new System.Drawing.Point(0, 300);
            this.dgvGorevler.Name = "dgvGorevler";
            this.dgvGorevler.Size = new System.Drawing.Size(800, 150);
            this.dgvGorevler.TabIndex = 3;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(658, 248);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(75, 23);
            this.btnCikisYap.TabIndex = 3;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // FrmGozetmenPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.dgvGorevler);
            this.Controls.Add(this.grpToplam);
            this.Controls.Add(this.grpBolum);
            this.Controls.Add(this.grpAdSoyad);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmGozetmenPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gözetmen Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGozetmenPanel_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpAdSoyad.ResumeLayout(false);
            this.grpAdSoyad.PerformLayout();
            this.grpBolum.ResumeLayout(false);
            this.grpBolum.PerformLayout();
            this.grpToplam.ResumeLayout(false);
            this.grpToplam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox grpAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.GroupBox grpBolum;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.GroupBox grpToplam;
        private System.Windows.Forms.Label lblToplamGorev;
        private System.Windows.Forms.DataGridView dgvGorevler;
        private System.Windows.Forms.Button btnCikisYap;
    }
}