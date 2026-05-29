namespace SinavTakvimiOtomasyonu
{
    partial class FrmTakvim
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
            this.dgvTakvim = new System.Windows.Forms.DataGridView();
            this.btnTakvimiYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakvim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakvim
            // 
            this.dgvTakvim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakvim.Location = new System.Drawing.Point(46, 79);
            this.dgvTakvim.Name = "dgvTakvim";
            this.dgvTakvim.RowHeadersWidth = 51;
            this.dgvTakvim.RowTemplate.Height = 24;
            this.dgvTakvim.Size = new System.Drawing.Size(820, 330);
            this.dgvTakvim.TabIndex = 0;
            // 
            // btnTakvimiYukle
            // 
            this.btnTakvimiYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTakvimiYukle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTakvimiYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakvimiYukle.ForeColor = System.Drawing.Color.White;
            this.btnTakvimiYukle.Location = new System.Drawing.Point(46, 465);
            this.btnTakvimiYukle.Name = "btnTakvimiYukle";
            this.btnTakvimiYukle.Size = new System.Drawing.Size(178, 36);
            this.btnTakvimiYukle.TabIndex = 1;
            this.btnTakvimiYukle.Text = "Takvimi Yükle";
            this.btnTakvimiYukle.UseVisualStyleBackColor = false;
            this.btnTakvimiYukle.Click += new System.EventHandler(this.btnTakvimiYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(506, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "SINAV TAKVİMİ";
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
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmTakvim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1240, 697);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTakvimiYukle);
            this.Controls.Add(this.dgvTakvim);
            this.Name = "FrmTakvim";
            this.Text = "FrmTakvim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakvim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTakvim;
        private System.Windows.Forms.Button btnTakvimiYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
    }
}