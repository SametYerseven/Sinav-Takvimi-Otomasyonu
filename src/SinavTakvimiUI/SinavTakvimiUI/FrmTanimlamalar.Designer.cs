namespace SinavTakvimiUI
{
    partial class FrmTanimlamalar
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
            this.lblFormBaslik = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpBolumler = new System.Windows.Forms.TabPage();
            this.dgvBolumler = new System.Windows.Forms.DataGridView();
            this.colBolumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBolumAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBolumAra = new System.Windows.Forms.Label();
            this.txtBolumAra = new System.Windows.Forms.TextBox();
            this.lblBolumAd = new System.Windows.Forms.Label();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.btnBolumGuncelle = new System.Windows.Forms.Button();
            this.btnBolumSil = new System.Windows.Forms.Button();
            this.btnBolumTemizle = new System.Windows.Forms.Button();
            this.tpDerslikler = new System.Windows.Forms.TabPage();
            this.dgvDerslikler = new System.Windows.Forms.DataGridView();
            this.colDerslikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDerslikAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDerslikKapasite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDerslikTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDerslikAktif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblDerslikAra = new System.Windows.Forms.Label();
            this.txtDerslikAra = new System.Windows.Forms.TextBox();
            this.lblDerslikAd = new System.Windows.Forms.Label();
            this.txtDerslikAd = new System.Windows.Forms.TextBox();
            this.lblDerslikKapasite = new System.Windows.Forms.Label();
            this.nudDerslikKapasite = new System.Windows.Forms.NumericUpDown();
            this.lblDerslikTip = new System.Windows.Forms.Label();
            this.cmbDerslikTip = new System.Windows.Forms.ComboBox();
            this.chkDerslikAktif = new System.Windows.Forms.CheckBox();
            this.btnDerslikEkle = new System.Windows.Forms.Button();
            this.btnDerslikGuncelle = new System.Windows.Forms.Button();
            this.btnDerslikSil = new System.Windows.Forms.Button();
            this.btnDerslikTemizle = new System.Windows.Forms.Button();
            this.tpOturumlar = new System.Windows.Forms.TabPage();
            this.dgvOturumlar = new System.Windows.Forms.DataGridView();
            this.colOturumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOturumTanim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOturumBaslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOturumBitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOturumAra = new System.Windows.Forms.Label();
            this.txtOturumAra = new System.Windows.Forms.TextBox();
            this.lblOturumTanim = new System.Windows.Forms.Label();
            this.txtOturumTanim = new System.Windows.Forms.TextBox();
            this.lblOturumBaslangic = new System.Windows.Forms.Label();
            this.dtpBaslangicSaat = new System.Windows.Forms.DateTimePicker();
            this.lblOturumBitis = new System.Windows.Forms.Label();
            this.dtpBitisSaat = new System.Windows.Forms.DateTimePicker();
            this.btnOturumEkle = new System.Windows.Forms.Button();
            this.btnOturumGuncelle = new System.Windows.Forms.Button();
            this.btnOturumSil = new System.Windows.Forms.Button();
            this.btnOturumTemizle = new System.Windows.Forms.Button();
            this.tpDersler = new System.Windows.Forms.TabPage();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.colDersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersOgrenciSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersYariyil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersBolumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersBolumAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDersAra = new System.Windows.Forms.Label();
            this.txtDersAra = new System.Windows.Forms.TextBox();
            this.lblDersKodu = new System.Windows.Forms.Label();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.lblDersAd = new System.Windows.Forms.Label();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.lblDersTuru = new System.Windows.Forms.Label();
            this.cmbDersTuru = new System.Windows.Forms.ComboBox();
            this.lblOgrenciSayisi = new System.Windows.Forms.Label();
            this.nudOgrenciSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblYariyil = new System.Windows.Forms.Label();
            this.nudYariyil = new System.Windows.Forms.NumericUpDown();
            this.lblDersBolum = new System.Windows.Forms.Label();
            this.cmbDersBolum = new System.Windows.Forms.ComboBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersTemizle = new System.Windows.Forms.Button();
            this.tpPersoneller = new System.Windows.Forms.TabPage();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.colPersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonelUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonelAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonelSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonelBolumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonelBolumAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPersonelAra = new System.Windows.Forms.Label();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.lblPersonelUnvan = new System.Windows.Forms.Label();
            this.cmbPersonelUnvan = new System.Windows.Forms.ComboBox();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.lblPersonelSoyad = new System.Windows.Forms.Label();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.lblPersonelBolum = new System.Windows.Forms.Label();
            this.cmbPersonelBolum = new System.Windows.Forms.ComboBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelTemizle = new System.Windows.Forms.Button();
            this.tpMazeretler = new System.Windows.Forms.TabPage();
            this.dgvMazeretler = new System.Windows.Forms.DataGridView();
            this.colMazeretDurumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMazeretPersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMazeretPersonelAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMazeretTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMazeretTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMazeretUygun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblMazeretAra = new System.Windows.Forms.Label();
            this.txtMazeretAra = new System.Windows.Forms.TextBox();
            this.lblMazeretPersonel = new System.Windows.Forms.Label();
            this.cmbMazeretPersonel = new System.Windows.Forms.ComboBox();
            this.lblMazeretTarih = new System.Windows.Forms.Label();
            this.dtpMazeretTarih = new System.Windows.Forms.DateTimePicker();
            this.lblMazeretTuru = new System.Windows.Forms.Label();
            this.cmbMazeretTuru = new System.Windows.Forms.ComboBox();
            this.chkMazeretUygun = new System.Windows.Forms.CheckBox();
            this.btnMazeretEkle = new System.Windows.Forms.Button();
            this.btnMazeretGuncelle = new System.Windows.Forms.Button();
            this.btnMazeretSil = new System.Windows.Forms.Button();
            this.btnMazeretTemizle = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tpBolumler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolumler)).BeginInit();
            this.tpDerslikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDerslikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDerslikKapasite)).BeginInit();
            this.tpOturumlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOturumlar)).BeginInit();
            this.tpDersler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOgrenciSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYariyil)).BeginInit();
            this.tpPersoneller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.tpMazeretler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMazeretler)).BeginInit();
            this.SuspendLayout();

            // lblFormBaslik
            this.lblFormBaslik.AutoSize = true;
            this.lblFormBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormBaslik.Location = new System.Drawing.Point(15, 15);
            this.lblFormBaslik.Name = "lblFormBaslik";
            this.lblFormBaslik.Size = new System.Drawing.Size(288, 30);
            this.lblFormBaslik.TabIndex = 99;
            this.lblFormBaslik.Text = "Tanımlamalar Modülü";

            // tabControl
            this.tabControl.Controls.Add(this.tpBolumler);
            this.tabControl.Controls.Add(this.tpDerslikler);
            this.tabControl.Controls.Add(this.tpOturumlar);
            this.tabControl.Controls.Add(this.tpDersler);
            this.tabControl.Controls.Add(this.tpPersoneller);
            this.tabControl.Controls.Add(this.tpMazeretler);
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(12, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 595);
            this.tabControl.TabIndex = 0;

            // tpBolumler
            this.tpBolumler.Controls.Add(this.dgvBolumler);
            this.tpBolumler.Controls.Add(this.lblBolumAra);
            this.tpBolumler.Controls.Add(this.txtBolumAra);
            this.tpBolumler.Controls.Add(this.lblBolumAd);
            this.tpBolumler.Controls.Add(this.txtBolumAd);
            this.tpBolumler.Controls.Add(this.btnBolumEkle);
            this.tpBolumler.Controls.Add(this.btnBolumGuncelle);
            this.tpBolumler.Controls.Add(this.btnBolumSil);
            this.tpBolumler.Controls.Add(this.btnBolumTemizle);
            this.tpBolumler.Location = new System.Drawing.Point(4, 24);
            this.tpBolumler.Name = "tpBolumler";
            this.tpBolumler.Padding = new System.Windows.Forms.Padding(3);
            this.tpBolumler.Size = new System.Drawing.Size(952, 567);
            this.tpBolumler.TabIndex = 0;
            this.tpBolumler.Text = "Bölümler";
            this.tpBolumler.UseVisualStyleBackColor = true;

            // dgvBolumler
            this.dgvBolumler.AllowUserToAddRows = false;
            this.dgvBolumler.AllowUserToDeleteRows = false;
            this.dgvBolumler.AutoGenerateColumns = false;
            this.dgvBolumler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBolumler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBolumID, this.colBolumAd });
            this.dgvBolumler.Location = new System.Drawing.Point(15, 50);
            this.dgvBolumler.MultiSelect = false;
            this.dgvBolumler.Name = "dgvBolumler";
            this.dgvBolumler.ReadOnly = true;
            this.dgvBolumler.RowHeadersVisible = false;
            this.dgvBolumler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBolumler.Size = new System.Drawing.Size(922, 330);
            this.dgvBolumler.TabIndex = 0;
            this.dgvBolumler.SelectionChanged += new System.EventHandler(this.dgvBolumler_SelectionChanged);
            this.dgvBolumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // colBolumID
            this.colBolumID.DataPropertyName = "BolumID";
            this.colBolumID.HeaderText = "ID";
            this.colBolumID.Name = "colBolumID";
            this.colBolumID.ReadOnly = true;
            this.colBolumID.Width = 60;

            // colBolumAd
            this.colBolumAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBolumAd.DataPropertyName = "BolumAd";
            this.colBolumAd.HeaderText = "Bölüm Adı";
            this.colBolumAd.Name = "colBolumAd";
            this.colBolumAd.ReadOnly = true;

            // lblBolumAra
            this.lblBolumAra.AutoSize = true;
            this.lblBolumAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBolumAra.Location = new System.Drawing.Point(15, 18);
            this.lblBolumAra.Name = "lblBolumAra";
            this.lblBolumAra.TabIndex = 1;
            this.lblBolumAra.Text = "Bölüm Ara:";

            // txtBolumAra
            this.txtBolumAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBolumAra.Location = new System.Drawing.Point(110, 15);
            this.txtBolumAra.Name = "txtBolumAra";
            this.txtBolumAra.Size = new System.Drawing.Size(250, 25);
            this.txtBolumAra.TabIndex = 2;
            this.txtBolumAra.TextChanged += new System.EventHandler(this.txtBolumAra_TextChanged);

            // lblBolumAd
            this.lblBolumAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBolumAd.AutoSize = true;
            this.lblBolumAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBolumAd.Location = new System.Drawing.Point(15, 403);
            this.lblBolumAd.Name = "lblBolumAd";
            this.lblBolumAd.TabIndex = 3;
            this.lblBolumAd.Text = "Bölüm Adı:";

            // txtBolumAd
            this.txtBolumAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBolumAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBolumAd.Location = new System.Drawing.Point(110, 400);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(300, 25);
            this.txtBolumAd.TabIndex = 4;

            // btnBolumEkle
            this.btnBolumEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBolumEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBolumEkle.Location = new System.Drawing.Point(427, 515);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(120, 35);
            this.btnBolumEkle.TabIndex = 5;
            this.btnBolumEkle.Text = "Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);

            // btnBolumGuncelle
            this.btnBolumGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBolumGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBolumGuncelle.Location = new System.Drawing.Point(557, 515);
            this.btnBolumGuncelle.Name = "btnBolumGuncelle";
            this.btnBolumGuncelle.Size = new System.Drawing.Size(120, 35);
            this.btnBolumGuncelle.TabIndex = 6;
            this.btnBolumGuncelle.Text = "Güncelle";
            this.btnBolumGuncelle.UseVisualStyleBackColor = true;
            this.btnBolumGuncelle.Click += new System.EventHandler(this.btnBolumGuncelle_Click);

            // btnBolumSil
            this.btnBolumSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBolumSil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBolumSil.Location = new System.Drawing.Point(687, 515);
            this.btnBolumSil.Name = "btnBolumSil";
            this.btnBolumSil.Size = new System.Drawing.Size(120, 35);
            this.btnBolumSil.TabIndex = 7;
            this.btnBolumSil.Text = "Sil";
            this.btnBolumSil.UseVisualStyleBackColor = true;
            this.btnBolumSil.Click += new System.EventHandler(this.btnBolumSil_Click);

            // btnBolumTemizle
            this.btnBolumTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBolumTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBolumTemizle.Location = new System.Drawing.Point(817, 515);
            this.btnBolumTemizle.Name = "btnBolumTemizle";
            this.btnBolumTemizle.Size = new System.Drawing.Size(120, 35);
            this.btnBolumTemizle.TabIndex = 8;
            this.btnBolumTemizle.Text = "Temizle";
            this.btnBolumTemizle.UseVisualStyleBackColor = true;
            this.btnBolumTemizle.Click += new System.EventHandler(this.btnBolumTemizle_Click);

            // tpDerslikler
            this.tpDerslikler.Controls.Add(this.dgvDerslikler);
            this.tpDerslikler.Controls.Add(this.lblDerslikAra);
            this.tpDerslikler.Controls.Add(this.txtDerslikAra);
            this.tpDerslikler.Controls.Add(this.lblDerslikAd);
            this.tpDerslikler.Controls.Add(this.txtDerslikAd);
            this.tpDerslikler.Controls.Add(this.lblDerslikKapasite);
            this.tpDerslikler.Controls.Add(this.nudDerslikKapasite);
            this.tpDerslikler.Controls.Add(this.lblDerslikTip);
            this.tpDerslikler.Controls.Add(this.cmbDerslikTip);
            this.tpDerslikler.Controls.Add(this.chkDerslikAktif);
            this.tpDerslikler.Controls.Add(this.btnDerslikEkle);
            this.tpDerslikler.Controls.Add(this.btnDerslikGuncelle);
            this.tpDerslikler.Controls.Add(this.btnDerslikSil);
            this.tpDerslikler.Controls.Add(this.btnDerslikTemizle);
            this.tpDerslikler.Location = new System.Drawing.Point(4, 24);
            this.tpDerslikler.Name = "tpDerslikler";
            this.tpDerslikler.Padding = new System.Windows.Forms.Padding(3);
            this.tpDerslikler.Size = new System.Drawing.Size(952, 567);
            this.tpDerslikler.TabIndex = 1;
            this.tpDerslikler.Text = "Derslikler";
            this.tpDerslikler.UseVisualStyleBackColor = true;

            // dgvDerslikler
            this.dgvDerslikler.AllowUserToAddRows = false;
            this.dgvDerslikler.AllowUserToDeleteRows = false;
            this.dgvDerslikler.AutoGenerateColumns = false;
            this.dgvDerslikler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDerslikler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDerslikID,
            this.colDerslikAd,
            this.colDerslikKapasite,
            this.colDerslikTip,
            this.colDerslikAktif});
            this.dgvDerslikler.Location = new System.Drawing.Point(15, 50);
            this.dgvDerslikler.MultiSelect = false;
            this.dgvDerslikler.Name = "dgvDerslikler";
            this.dgvDerslikler.ReadOnly = true;
            this.dgvDerslikler.RowHeadersVisible = false;
            this.dgvDerslikler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDerslikler.Size = new System.Drawing.Size(922, 330);
            this.dgvDerslikler.TabIndex = 0;
            this.dgvDerslikler.SelectionChanged += new System.EventHandler(this.dgvDerslikler_SelectionChanged);
            this.dgvDerslikler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // colDerslikID
            this.colDerslikID.DataPropertyName = "DerslikID";
            this.colDerslikID.HeaderText = "ID";
            this.colDerslikID.Name = "colDerslikID";
            this.colDerslikID.ReadOnly = true;
            this.colDerslikID.Width = 60;

            // colDerslikAd
            this.colDerslikAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDerslikAd.DataPropertyName = "Ad";
            this.colDerslikAd.HeaderText = "Derslik Adı";
            this.colDerslikAd.Name = "colDerslikAd";
            this.colDerslikAd.ReadOnly = true;

            // colDerslikKapasite
            this.colDerslikKapasite.DataPropertyName = "Kapasite";
            this.colDerslikKapasite.HeaderText = "Kapasite";
            this.colDerslikKapasite.Name = "colDerslikKapasite";
            this.colDerslikKapasite.ReadOnly = true;
            this.colDerslikKapasite.Width = 100;

            // colDerslikTip
            this.colDerslikTip.DataPropertyName = "Tip";
            this.colDerslikTip.HeaderText = "Tip";
            this.colDerslikTip.Name = "colDerslikTip";
            this.colDerslikTip.ReadOnly = true;
            this.colDerslikTip.Width = 120;

            // colDerslikAktif
            this.colDerslikAktif.DataPropertyName = "Aktif";
            this.colDerslikAktif.HeaderText = "Aktif";
            this.colDerslikAktif.Name = "colDerslikAktif";
            this.colDerslikAktif.ReadOnly = true;
            this.colDerslikAktif.Width = 80;

            // lblDerslikAra
            this.lblDerslikAra.AutoSize = true;
            this.lblDerslikAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDerslikAra.Location = new System.Drawing.Point(15, 18);
            this.lblDerslikAra.Name = "lblDerslikAra";
            this.lblDerslikAra.Size = new System.Drawing.Size(73, 17);
            this.lblDerslikAra.TabIndex = 1;
            this.lblDerslikAra.Text = "Derslik Ara:";

            // txtDerslikAra
            this.txtDerslikAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDerslikAra.Location = new System.Drawing.Point(110, 15);
            this.txtDerslikAra.Name = "txtDerslikAra";
            this.txtDerslikAra.Size = new System.Drawing.Size(250, 25);
            this.txtDerslikAra.TabIndex = 2;
            this.txtDerslikAra.TextChanged += new System.EventHandler(this.txtDerslikAra_TextChanged);

            // lblDerslikAd
            this.lblDerslikAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDerslikAd.AutoSize = true;
            this.lblDerslikAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDerslikAd.Location = new System.Drawing.Point(15, 403);
            this.lblDerslikAd.Name = "lblDerslikAd";
            this.lblDerslikAd.Size = new System.Drawing.Size(72, 17);
            this.lblDerslikAd.TabIndex = 3;
            this.lblDerslikAd.Text = "Derslik Adı:";

            // txtDerslikAd
            this.txtDerslikAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDerslikAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDerslikAd.Location = new System.Drawing.Point(110, 400);
            this.txtDerslikAd.Name = "txtDerslikAd";
            this.txtDerslikAd.Size = new System.Drawing.Size(150, 25);
            this.txtDerslikAd.TabIndex = 4;

            // lblDerslikKapasite
            this.lblDerslikKapasite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDerslikKapasite.AutoSize = true;
            this.lblDerslikKapasite.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDerslikKapasite.Location = new System.Drawing.Point(280, 403);
            this.lblDerslikKapasite.Name = "lblDerslikKapasite";
            this.lblDerslikKapasite.Size = new System.Drawing.Size(61, 17);
            this.lblDerslikKapasite.TabIndex = 5;
            this.lblDerslikKapasite.Text = "Kapasite:";

            // nudDerslikKapasite
            this.nudDerslikKapasite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudDerslikKapasite.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudDerslikKapasite.Location = new System.Drawing.Point(360, 400);
            this.nudDerslikKapasite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDerslikKapasite.Name = "nudDerslikKapasite";
            this.nudDerslikKapasite.Size = new System.Drawing.Size(80, 25);
            this.nudDerslikKapasite.TabIndex = 6;
            this.nudDerslikKapasite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});

            // lblDerslikTip
            this.lblDerslikTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDerslikTip.AutoSize = true;
            this.lblDerslikTip.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDerslikTip.Location = new System.Drawing.Point(460, 403);
            this.lblDerslikTip.Name = "lblDerslikTip";
            this.lblDerslikTip.Size = new System.Drawing.Size(30, 17);
            this.lblDerslikTip.TabIndex = 7;
            this.lblDerslikTip.Text = "Tip:";

            // cmbDerslikTip
            this.cmbDerslikTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDerslikTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDerslikTip.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbDerslikTip.FormattingEnabled = true;
            this.cmbDerslikTip.Items.AddRange(new object[] {
            "Amfi",
            "Sınıf",
            "Laboratuvar"});
            this.cmbDerslikTip.Location = new System.Drawing.Point(510, 400);
            this.cmbDerslikTip.Name = "cmbDerslikTip";
            this.cmbDerslikTip.Size = new System.Drawing.Size(120, 25);
            this.cmbDerslikTip.TabIndex = 8;

            // chkDerslikAktif
            this.chkDerslikAktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDerslikAktif.AutoSize = true;
            this.chkDerslikAktif.Checked = true;
            this.chkDerslikAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDerslikAktif.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkDerslikAktif.Location = new System.Drawing.Point(650, 402);
            this.chkDerslikAktif.Name = "chkDerslikAktif";
            this.chkDerslikAktif.Size = new System.Drawing.Size(53, 21);
            this.chkDerslikAktif.TabIndex = 9;
            this.chkDerslikAktif.Text = "Aktif";
            this.chkDerslikAktif.UseVisualStyleBackColor = true;

            // btnDerslikEkle
            this.btnDerslikEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDerslikEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDerslikEkle.Location = new System.Drawing.Point(427, 515);
            this.btnDerslikEkle.Name = "btnDerslikEkle";
            this.btnDerslikEkle.Size = new System.Drawing.Size(120, 35);
            this.btnDerslikEkle.TabIndex = 10;
            this.btnDerslikEkle.Text = "Ekle";
            this.btnDerslikEkle.UseVisualStyleBackColor = true;
            this.btnDerslikEkle.Click += new System.EventHandler(this.btnDerslikEkle_Click);

            // btnDerslikGuncelle
            this.btnDerslikGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDerslikGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDerslikGuncelle.Location = new System.Drawing.Point(557, 515);
            this.btnDerslikGuncelle.Name = "btnDerslikGuncelle";
            this.btnDerslikGuncelle.Size = new System.Drawing.Size(120, 35);
            this.btnDerslikGuncelle.TabIndex = 11;
            this.btnDerslikGuncelle.Text = "Güncelle";
            this.btnDerslikGuncelle.UseVisualStyleBackColor = true;
            this.btnDerslikGuncelle.Click += new System.EventHandler(this.btnDerslikGuncelle_Click);

            // btnDerslikSil
            this.btnDerslikSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDerslikSil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDerslikSil.Location = new System.Drawing.Point(687, 515);
            this.btnDerslikSil.Name = "btnDerslikSil";
            this.btnDerslikSil.Size = new System.Drawing.Size(120, 35);
            this.btnDerslikSil.TabIndex = 12;
            this.btnDerslikSil.Text = "Sil";
            this.btnDerslikSil.UseVisualStyleBackColor = true;
            this.btnDerslikSil.Click += new System.EventHandler(this.btnDerslikSil_Click);

            // btnDerslikTemizle
            this.btnDerslikTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDerslikTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDerslikTemizle.Location = new System.Drawing.Point(817, 515);
            this.btnDerslikTemizle.Name = "btnDerslikTemizle";
            this.btnDerslikTemizle.Size = new System.Drawing.Size(120, 35);
            this.btnDerslikTemizle.TabIndex = 13;
            this.btnDerslikTemizle.Text = "Temizle";
            this.btnDerslikTemizle.UseVisualStyleBackColor = true;
            this.btnDerslikTemizle.Click += new System.EventHandler(this.btnDerslikTemizle_Click);

            // tpOturumlar
            this.tpOturumlar.Controls.Add(this.dgvOturumlar);
            this.tpOturumlar.Controls.Add(this.lblOturumAra);
            this.tpOturumlar.Controls.Add(this.txtOturumAra);
            this.tpOturumlar.Controls.Add(this.lblOturumTanim);
            this.tpOturumlar.Controls.Add(this.txtOturumTanim);
            this.tpOturumlar.Controls.Add(this.lblOturumBaslangic);
            this.tpOturumlar.Controls.Add(this.dtpBaslangicSaat);
            this.tpOturumlar.Controls.Add(this.lblOturumBitis);
            this.tpOturumlar.Controls.Add(this.dtpBitisSaat);
            this.tpOturumlar.Controls.Add(this.btnOturumEkle);
            this.tpOturumlar.Controls.Add(this.btnOturumGuncelle);
            this.tpOturumlar.Controls.Add(this.btnOturumSil);
            this.tpOturumlar.Controls.Add(this.btnOturumTemizle);
            this.tpOturumlar.Location = new System.Drawing.Point(4, 24);
            this.tpOturumlar.Name = "tpOturumlar";
            this.tpOturumlar.Padding = new System.Windows.Forms.Padding(3);
            this.tpOturumlar.Size = new System.Drawing.Size(952, 567);
            this.tpOturumlar.TabIndex = 2;
            this.tpOturumlar.Text = "Oturumlar";
            this.tpOturumlar.UseVisualStyleBackColor = true;

            // dgvOturumlar
            this.dgvOturumlar.AllowUserToAddRows = false;
            this.dgvOturumlar.AllowUserToDeleteRows = false;
            this.dgvOturumlar.AutoGenerateColumns = false;
            this.dgvOturumlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOturumlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOturumID,
            this.colOturumTanim,
            this.colOturumBaslangic,
            this.colOturumBitis});
            this.dgvOturumlar.Location = new System.Drawing.Point(15, 50);
            this.dgvOturumlar.MultiSelect = false;
            this.dgvOturumlar.Name = "dgvOturumlar";
            this.dgvOturumlar.ReadOnly = true;
            this.dgvOturumlar.RowHeadersVisible = false;
            this.dgvOturumlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOturumlar.Size = new System.Drawing.Size(922, 330);
            this.dgvOturumlar.TabIndex = 0;
            this.dgvOturumlar.SelectionChanged += new System.EventHandler(this.dgvOturumlar_SelectionChanged);
            this.dgvOturumlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // colOturumID
            this.colOturumID.DataPropertyName = "OturumID";
            this.colOturumID.HeaderText = "ID";
            this.colOturumID.Name = "colOturumID";
            this.colOturumID.ReadOnly = true;
            this.colOturumID.Width = 60;

            // colOturumTanim
            this.colOturumTanim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOturumTanim.DataPropertyName = "Tanim";
            this.colOturumTanim.HeaderText = "Oturum Tanımı";
            this.colOturumTanim.Name = "colOturumTanim";
            this.colOturumTanim.ReadOnly = true;

            // colOturumBaslangic
            this.colOturumBaslangic.DataPropertyName = "BaslangicSaat";
            this.colOturumBaslangic.HeaderText = "Başlangıç Saati";
            this.colOturumBaslangic.Name = "colOturumBaslangic";
            this.colOturumBaslangic.ReadOnly = true;
            this.colOturumBaslangic.Width = 150;

            // colOturumBitis
            this.colOturumBitis.DataPropertyName = "BitisSaat";
            this.colOturumBitis.HeaderText = "Bitiş Saati";
            this.colOturumBitis.Name = "colOturumBitis";
            this.colOturumBitis.ReadOnly = true;
            this.colOturumBitis.Width = 150;

            // lblOturumAra
            this.lblOturumAra.AutoSize = true;
            this.lblOturumAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOturumAra.Location = new System.Drawing.Point(15, 18);
            this.lblOturumAra.Name = "lblOturumAra";
            this.lblOturumAra.Size = new System.Drawing.Size(78, 17);
            this.lblOturumAra.TabIndex = 1;
            this.lblOturumAra.Text = "Oturum Ara:";

            // txtOturumAra
            this.txtOturumAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOturumAra.Location = new System.Drawing.Point(110, 15);
            this.txtOturumAra.Name = "txtOturumAra";
            this.txtOturumAra.Size = new System.Drawing.Size(250, 25);
            this.txtOturumAra.TabIndex = 2;
            this.txtOturumAra.TextChanged += new System.EventHandler(this.txtOturumAra_TextChanged);

            // lblOturumTanim
            this.lblOturumTanim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOturumTanim.AutoSize = true;
            this.lblOturumTanim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOturumTanim.Location = new System.Drawing.Point(15, 403);
            this.lblOturumTanim.Name = "lblOturumTanim";
            this.lblOturumTanim.Size = new System.Drawing.Size(97, 17);
            this.lblOturumTanim.TabIndex = 3;
            this.lblOturumTanim.Text = "Oturum Tanımı:";

            // txtOturumTanim
            this.txtOturumTanim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOturumTanim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOturumTanim.Location = new System.Drawing.Point(120, 400);
            this.txtOturumTanim.Name = "txtOturumTanim";
            this.txtOturumTanim.Size = new System.Drawing.Size(150, 25);
            this.txtOturumTanim.TabIndex = 4;

            // lblOturumBaslangic
            this.lblOturumBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOturumBaslangic.AutoSize = true;
            this.lblOturumBaslangic.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOturumBaslangic.Location = new System.Drawing.Point(290, 403);
            this.lblOturumBaslangic.Name = "lblOturumBaslangic";
            this.lblOturumBaslangic.Size = new System.Drawing.Size(95, 17);
            this.lblOturumBaslangic.TabIndex = 5;
            this.lblOturumBaslangic.Text = "Başlangıç Saati:";

            // dtpBaslangicSaat
            this.dtpBaslangicSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpBaslangicSaat.CustomFormat = "HH:mm";
            this.dtpBaslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangicSaat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpBaslangicSaat.Location = new System.Drawing.Point(400, 400);
            this.dtpBaslangicSaat.Name = "dtpBaslangicSaat";
            this.dtpBaslangicSaat.ShowUpDown = true;
            this.dtpBaslangicSaat.Size = new System.Drawing.Size(100, 25);
            this.dtpBaslangicSaat.TabIndex = 6;

            // lblOturumBitis
            this.lblOturumBitis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOturumBitis.AutoSize = true;
            this.lblOturumBitis.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOturumBitis.Location = new System.Drawing.Point(520, 403);
            this.lblOturumBitis.Name = "lblOturumBitis";
            this.lblOturumBitis.Size = new System.Drawing.Size(65, 17);
            this.lblOturumBitis.TabIndex = 7;
            this.lblOturumBitis.Text = "Bitiş Saati:";

            // dtpBitisSaat
            this.dtpBitisSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpBitisSaat.CustomFormat = "HH:mm";
            this.dtpBitisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitisSaat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpBitisSaat.Location = new System.Drawing.Point(600, 400);
            this.dtpBitisSaat.Name = "dtpBitisSaat";
            this.dtpBitisSaat.ShowUpDown = true;
            this.dtpBitisSaat.Size = new System.Drawing.Size(100, 25);
            this.dtpBitisSaat.TabIndex = 8;

            // btnOturumEkle
            this.btnOturumEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOturumEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnOturumEkle.Location = new System.Drawing.Point(427, 515);
            this.btnOturumEkle.Name = "btnOturumEkle";
            this.btnOturumEkle.Size = new System.Drawing.Size(120, 35);
            this.btnOturumEkle.TabIndex = 9;
            this.btnOturumEkle.Text = "Ekle";
            this.btnOturumEkle.UseVisualStyleBackColor = true;
            this.btnOturumEkle.Click += new System.EventHandler(this.btnOturumEkle_Click);

            // btnOturumGuncelle
            this.btnOturumGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOturumGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnOturumGuncelle.Location = new System.Drawing.Point(557, 515);
            this.btnOturumGuncelle.Name = "btnOturumGuncelle";
            this.btnOturumGuncelle.Size = new System.Drawing.Size(120, 35);
            this.btnOturumGuncelle.TabIndex = 10;
            this.btnOturumGuncelle.Text = "Güncelle";
            this.btnOturumGuncelle.UseVisualStyleBackColor = true;
            this.btnOturumGuncelle.Click += new System.EventHandler(this.btnOturumGuncelle_Click);

            // btnOturumSil
            this.btnOturumSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOturumSil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnOturumSil.Location = new System.Drawing.Point(687, 515);
            this.btnOturumSil.Name = "btnOturumSil";
            this.btnOturumSil.Size = new System.Drawing.Size(120, 35);
            this.btnOturumSil.TabIndex = 11;
            this.btnOturumSil.Text = "Sil";
            this.btnOturumSil.UseVisualStyleBackColor = true;
            this.btnOturumSil.Click += new System.EventHandler(this.btnOturumSil_Click);

            // btnOturumTemizle
            this.btnOturumTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOturumTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnOturumTemizle.Location = new System.Drawing.Point(817, 515);
            this.btnOturumTemizle.Name = "btnOturumTemizle";
            this.btnOturumTemizle.Size = new System.Drawing.Size(120, 35);
            this.btnOturumTemizle.TabIndex = 12;
            this.btnOturumTemizle.Text = "Temizle";
            this.btnOturumTemizle.UseVisualStyleBackColor = true;
            this.btnOturumTemizle.Click += new System.EventHandler(this.btnOturumTemizle_Click);

            // tpDersler
            this.tpDersler.Controls.Add(this.dgvDersler);
            this.tpDersler.Controls.Add(this.lblDersAra);
            this.tpDersler.Controls.Add(this.txtDersAra);
            this.tpDersler.Controls.Add(this.lblDersKodu);
            this.tpDersler.Controls.Add(this.txtDersKodu);
            this.tpDersler.Controls.Add(this.lblDersAd);
            this.tpDersler.Controls.Add(this.txtDersAd);
            this.tpDersler.Controls.Add(this.lblDersTuru);
            this.tpDersler.Controls.Add(this.cmbDersTuru);
            this.tpDersler.Controls.Add(this.lblOgrenciSayisi);
            this.tpDersler.Controls.Add(this.nudOgrenciSayisi);
            this.tpDersler.Controls.Add(this.lblYariyil);
            this.tpDersler.Controls.Add(this.nudYariyil);
            this.tpDersler.Controls.Add(this.lblDersBolum);
            this.tpDersler.Controls.Add(this.cmbDersBolum);
            this.tpDersler.Controls.Add(this.btnDersEkle);
            this.tpDersler.Controls.Add(this.btnDersGuncelle);
            this.tpDersler.Controls.Add(this.btnDersSil);
            this.tpDersler.Controls.Add(this.btnDersTemizle);
            this.tpDersler.Location = new System.Drawing.Point(4, 24);
            this.tpDersler.Name = "tpDersler";
            this.tpDersler.Padding = new System.Windows.Forms.Padding(3);
            this.tpDersler.Size = new System.Drawing.Size(952, 567);
            this.tpDersler.TabIndex = 3;
            this.tpDersler.Text = "Dersler";
            this.tpDersler.UseVisualStyleBackColor = true;

            // dgvDersler
            this.dgvDersler.AllowUserToAddRows = false;
            this.dgvDersler.AllowUserToDeleteRows = false;
            this.dgvDersler.AutoGenerateColumns = false;
            this.dgvDersler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDersID,
            this.colDersKodu,
            this.colDersTuru,
            this.colDersAd,
            this.colDersOgrenciSayisi,
            this.colDersYariyil,
            this.colDersBolumID,
            this.colDersBolumAd});
            this.dgvDersler.Location = new System.Drawing.Point(15, 50);
            this.dgvDersler.MultiSelect = false;
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.ReadOnly = true;
            this.dgvDersler.RowHeadersVisible = false;
            this.dgvDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersler.Size = new System.Drawing.Size(922, 330);
            this.dgvDersler.TabIndex = 0;
            this.dgvDersler.SelectionChanged += new System.EventHandler(this.dgvDersler_SelectionChanged);
            this.dgvDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // colDersID
            this.colDersID.DataPropertyName = "DersID";
            this.colDersID.HeaderText = "ID";
            this.colDersID.Name = "colDersID";
            this.colDersID.ReadOnly = true;
            this.colDersID.Width = 60;

            // colDersKodu
            this.colDersKodu.DataPropertyName = "DersKodu";
            this.colDersKodu.HeaderText = "Ders Kodu";
            this.colDersKodu.Name = "colDersKodu";
            this.colDersKodu.ReadOnly = true;
            this.colDersKodu.Width = 100;

            // colDersTuru
            this.colDersTuru.DataPropertyName = "DersTuru";
            this.colDersTuru.HeaderText = "Ders Türü";
            this.colDersTuru.Name = "colDersTuru";
            this.colDersTuru.ReadOnly = true;
            this.colDersTuru.Width = 90;

            // colDersAd
            this.colDersAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDersAd.DataPropertyName = "Ad";
            this.colDersAd.HeaderText = "Ders Adı";
            this.colDersAd.Name = "colDersAd";
            this.colDersAd.ReadOnly = true;

            // colDersOgrenciSayisi
            this.colDersOgrenciSayisi.DataPropertyName = "OgrenciSayisi";
            this.colDersOgrenciSayisi.HeaderText = "Öğrenci Sayısı";
            this.colDersOgrenciSayisi.Name = "colDersOgrenciSayisi";
            this.colDersOgrenciSayisi.ReadOnly = true;
            this.colDersOgrenciSayisi.Width = 100;

            // colDersYariyil
            this.colDersYariyil.DataPropertyName = "Yariyil";
            this.colDersYariyil.HeaderText = "Yarıyıl";
            this.colDersYariyil.Name = "colDersYariyil";
            this.colDersYariyil.ReadOnly = true;
            this.colDersYariyil.Width = 80;

            // colDersBolumID
            this.colDersBolumID.DataPropertyName = "BolumID";
            this.colDersBolumID.HeaderText = "Bölüm ID";
            this.colDersBolumID.Name = "colDersBolumID";
            this.colDersBolumID.ReadOnly = true;
            this.colDersBolumID.Visible = false;

            // colDersBolumAd
            this.colDersBolumAd.DataPropertyName = "BolumAd";
            this.colDersBolumAd.HeaderText = "Bölüm";
            this.colDersBolumAd.Name = "colDersBolumAd";
            this.colDersBolumAd.ReadOnly = true;
            this.colDersBolumAd.Width = 150;

            // lblDersAra
            this.lblDersAra.AutoSize = true;
            this.lblDersAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDersAra.Location = new System.Drawing.Point(15, 18);
            this.lblDersAra.Name = "lblDersAra";
            this.lblDersAra.Size = new System.Drawing.Size(61, 17);
            this.lblDersAra.TabIndex = 1;
            this.lblDersAra.Text = "Ders Ara:";

            // txtDersAra
            this.txtDersAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDersAra.Location = new System.Drawing.Point(110, 15);
            this.txtDersAra.Name = "txtDersAra";
            this.txtDersAra.Size = new System.Drawing.Size(250, 25);
            this.txtDersAra.TabIndex = 2;
            this.txtDersAra.TextChanged += new System.EventHandler(this.txtDersAra_TextChanged);

            // lblDersKodu
            this.lblDersKodu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDersKodu.AutoSize = true;
            this.lblDersKodu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDersKodu.Location = new System.Drawing.Point(15, 403);
            this.lblDersKodu.Name = "lblDersKodu";
            this.lblDersKodu.Size = new System.Drawing.Size(72, 17);
            this.lblDersKodu.TabIndex = 3;
            this.lblDersKodu.Text = "Ders Kodu:";

            // txtDersKodu
            this.txtDersKodu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDersKodu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDersKodu.Location = new System.Drawing.Point(100, 400);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(100, 25);
            this.txtDersKodu.TabIndex = 4;

            // lblDersAd
            this.lblDersAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDersAd.AutoSize = true;
            this.lblDersAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDersAd.Location = new System.Drawing.Point(220, 403);
            this.lblDersAd.Name = "lblDersAd";
            this.lblDersAd.Size = new System.Drawing.Size(61, 17);
            this.lblDersAd.TabIndex = 5;
            this.lblDersAd.Text = "Ders Adı:";

            // txtDersAd
            this.txtDersAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDersAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDersAd.Location = new System.Drawing.Point(290, 400);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(250, 25);
            this.txtDersAd.TabIndex = 6;

            // lblDersTuru
            this.lblDersTuru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDersTuru.AutoSize = true;
            this.lblDersTuru.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDersTuru.Location = new System.Drawing.Point(560, 403);
            this.lblDersTuru.Name = "lblDersTuru";
            this.lblDersTuru.Size = new System.Drawing.Size(68, 17);
            this.lblDersTuru.TabIndex = 7;
            this.lblDersTuru.Text = "Ders Türü:";

            // cmbDersTuru
            this.cmbDersTuru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDersTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersTuru.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbDersTuru.FormattingEnabled = true;
            this.cmbDersTuru.Items.AddRange(new object[] {
            "Zorunlu",
            "Seçmeli"});
            this.cmbDersTuru.Location = new System.Drawing.Point(640, 400);
            this.cmbDersTuru.Name = "cmbDersTuru";
            this.cmbDersTuru.Size = new System.Drawing.Size(120, 25);
            this.cmbDersTuru.TabIndex = 8;

            // lblOgrenciSayisi
            this.lblOgrenciSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOgrenciSayisi.AutoSize = true;
            this.lblOgrenciSayisi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOgrenciSayisi.Location = new System.Drawing.Point(15, 443);
            this.lblOgrenciSayisi.Name = "lblOgrenciSayisi";
            this.lblOgrenciSayisi.Size = new System.Drawing.Size(92, 17);
            this.lblOgrenciSayisi.TabIndex = 9;
            this.lblOgrenciSayisi.Text = "Öğrenci Sayısı:";

            // nudOgrenciSayisi
            this.nudOgrenciSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudOgrenciSayisi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudOgrenciSayisi.Location = new System.Drawing.Point(120, 440);
            this.nudOgrenciSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOgrenciSayisi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudOgrenciSayisi.Name = "nudOgrenciSayisi";
            this.nudOgrenciSayisi.Size = new System.Drawing.Size(80, 25);
            this.nudOgrenciSayisi.TabIndex = 10;
            this.nudOgrenciSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});

            // lblYariyil
            this.lblYariyil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYariyil.AutoSize = true;
            this.lblYariyil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblYariyil.Location = new System.Drawing.Point(220, 443);
            this.lblYariyil.Name = "lblYariyil";
            this.lblYariyil.Size = new System.Drawing.Size(43, 17);
            this.lblYariyil.TabIndex = 11;
            this.lblYariyil.Text = "Yarıyıl:";

            // nudYariyil
            this.nudYariyil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudYariyil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudYariyil.Location = new System.Drawing.Point(280, 440);
            this.nudYariyil.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYariyil.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudYariyil.Name = "nudYariyil";
            this.nudYariyil.Size = new System.Drawing.Size(60, 25);
            this.nudYariyil.TabIndex = 12;
            this.nudYariyil.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});

            // lblDersBolum
            this.lblDersBolum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDersBolum.AutoSize = true;
            this.lblDersBolum.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDersBolum.Location = new System.Drawing.Point(360, 443);
            this.lblDersBolum.Name = "lblDersBolum";
            this.lblDersBolum.Size = new System.Drawing.Size(47, 17);
            this.lblDersBolum.TabIndex = 13;
            this.lblDersBolum.Text = "Bölüm:";

            // cmbDersBolum
            this.cmbDersBolum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDersBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersBolum.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbDersBolum.FormattingEnabled = true;
            this.cmbDersBolum.Location = new System.Drawing.Point(420, 440);
            this.cmbDersBolum.Name = "cmbDersBolum";
            this.cmbDersBolum.Size = new System.Drawing.Size(200, 25);
            this.cmbDersBolum.TabIndex = 14;

            // btnDersEkle
            this.btnDersEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDersEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDersEkle.Location = new System.Drawing.Point(427, 515);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(120, 35);
            this.btnDersEkle.TabIndex = 15;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);

            // btnDersGuncelle
            this.btnDersGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDersGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDersGuncelle.Location = new System.Drawing.Point(557, 515);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(120, 35);
            this.btnDersGuncelle.TabIndex = 16;
            this.btnDersGuncelle.Text = "Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);

            // btnDersSil
            this.btnDersSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDersSil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDersSil.Location = new System.Drawing.Point(687, 515);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(120, 35);
            this.btnDersSil.TabIndex = 17;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);

            // btnDersTemizle
            this.btnDersTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDersTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDersTemizle.Location = new System.Drawing.Point(817, 515);
            this.btnDersTemizle.Name = "btnDersTemizle";
            this.btnDersTemizle.Size = new System.Drawing.Size(120, 35);
            this.btnDersTemizle.TabIndex = 18;
            this.btnDersTemizle.Text = "Temizle";
            this.btnDersTemizle.UseVisualStyleBackColor = true;
            this.btnDersTemizle.Click += new System.EventHandler(this.btnDersTemizle_Click);

            // tpPersoneller
            this.tpPersoneller.Controls.Add(this.dgvPersoneller);
            this.tpPersoneller.Controls.Add(this.lblPersonelAra);
            this.tpPersoneller.Controls.Add(this.txtPersonelAra);
            this.tpPersoneller.Controls.Add(this.lblPersonelUnvan);
            this.tpPersoneller.Controls.Add(this.cmbPersonelUnvan);
            this.tpPersoneller.Controls.Add(this.lblPersonelAd);
            this.tpPersoneller.Controls.Add(this.txtPersonelAd);
            this.tpPersoneller.Controls.Add(this.lblPersonelSoyad);
            this.tpPersoneller.Controls.Add(this.txtPersonelSoyad);
            this.tpPersoneller.Controls.Add(this.lblPersonelBolum);
            this.tpPersoneller.Controls.Add(this.cmbPersonelBolum);
            this.tpPersoneller.Controls.Add(this.btnPersonelEkle);
            this.tpPersoneller.Controls.Add(this.btnPersonelGuncelle);
            this.tpPersoneller.Controls.Add(this.btnPersonelSil);
            this.tpPersoneller.Controls.Add(this.btnPersonelTemizle);
            this.tpPersoneller.Location = new System.Drawing.Point(4, 24);
            this.tpPersoneller.Name = "tpPersoneller";
            this.tpPersoneller.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersoneller.Size = new System.Drawing.Size(952, 567);
            this.tpPersoneller.TabIndex = 4;
            this.tpPersoneller.Text = "Personeller";
            this.tpPersoneller.UseVisualStyleBackColor = true;

            // dgvPersoneller
            this.dgvPersoneller.AllowUserToAddRows = false;
            this.dgvPersoneller.AllowUserToDeleteRows = false;
            this.dgvPersoneller.AutoGenerateColumns = false;
            this.dgvPersoneller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersoneller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersonelID,
            this.colPersonelUnvan,
            this.colPersonelAd,
            this.colPersonelSoyad,
            this.colPersonelBolumID,
            this.colPersonelBolumAd});
            this.dgvPersoneller.Location = new System.Drawing.Point(15, 50);
            this.dgvPersoneller.MultiSelect = false;
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.ReadOnly = true;
            this.dgvPersoneller.RowHeadersVisible = false;
            this.dgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoneller.Size = new System.Drawing.Size(922, 330);
            this.dgvPersoneller.TabIndex = 0;
            this.dgvPersoneller.SelectionChanged += new System.EventHandler(this.dgvPersoneller_SelectionChanged);
            this.dgvPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // colPersonelID
            this.colPersonelID.DataPropertyName = "PersonelID";
            this.colPersonelID.HeaderText = "ID";
            this.colPersonelID.Name = "colPersonelID";
            this.colPersonelID.ReadOnly = true;
            this.colPersonelID.Width = 60;

            // colPersonelUnvan
            this.colPersonelUnvan.DataPropertyName = "Unvan";
            this.colPersonelUnvan.HeaderText = "Unvan";
            this.colPersonelUnvan.Name = "colPersonelUnvan";
            this.colPersonelUnvan.ReadOnly = true;
            this.colPersonelUnvan.Width = 100;

            // colPersonelAd
            this.colPersonelAd.DataPropertyName = "Ad";
            this.colPersonelAd.HeaderText = "Ad";
            this.colPersonelAd.Name = "colPersonelAd";
            this.colPersonelAd.ReadOnly = true;
            this.colPersonelAd.Width = 120;

            // colPersonelSoyad
            this.colPersonelSoyad.DataPropertyName = "Soyad";
            this.colPersonelSoyad.HeaderText = "Soyad";
            this.colPersonelSoyad.Name = "colPersonelSoyad";
            this.colPersonelSoyad.ReadOnly = true;
            this.colPersonelSoyad.Width = 120;

            // colPersonelBolumID
            this.colPersonelBolumID.DataPropertyName = "BolumID";
            this.colPersonelBolumID.HeaderText = "Bölüm ID";
            this.colPersonelBolumID.Name = "colPersonelBolumID";
            this.colPersonelBolumID.ReadOnly = true;
            this.colPersonelBolumID.Visible = false;

            // colPersonelBolumAd
            this.colPersonelBolumAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPersonelBolumAd.DataPropertyName = "BolumAd";
            this.colPersonelBolumAd.HeaderText = "Bölüm";
            this.colPersonelBolumAd.Name = "colPersonelBolumAd";
            this.colPersonelBolumAd.ReadOnly = true;

            // lblPersonelAra
            this.lblPersonelAra.AutoSize = true;
            this.lblPersonelAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPersonelAra.Location = new System.Drawing.Point(15, 18);
            this.lblPersonelAra.Name = "lblPersonelAra";
            this.lblPersonelAra.Size = new System.Drawing.Size(83, 17);
            this.lblPersonelAra.TabIndex = 1;
            this.lblPersonelAra.Text = "Personel Ara:";

            // txtPersonelAra
            this.txtPersonelAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPersonelAra.Location = new System.Drawing.Point(110, 15);
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(250, 25);
            this.txtPersonelAra.TabIndex = 2;
            this.txtPersonelAra.TextChanged += new System.EventHandler(this.txtPersonelAra_TextChanged);

            // lblPersonelUnvan
            this.lblPersonelUnvan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPersonelUnvan.AutoSize = true;
            this.lblPersonelUnvan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPersonelUnvan.Location = new System.Drawing.Point(15, 403);
            this.lblPersonelUnvan.Name = "lblPersonelUnvan";
            this.lblPersonelUnvan.Size = new System.Drawing.Size(47, 17);
            this.lblPersonelUnvan.TabIndex = 3;
            this.lblPersonelUnvan.Text = "Unvan:";

            // cmbPersonelUnvan
            this.cmbPersonelUnvan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPersonelUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelUnvan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbPersonelUnvan.FormattingEnabled = true;
            this.cmbPersonelUnvan.Items.AddRange(new object[] {
            "Prof. Dr.",
            "Doç. Dr.",
            "Dr. Öğr. Üyesi",
            "Öğr. Gör.",
            "Arş. Gör."});
            this.cmbPersonelUnvan.Location = new System.Drawing.Point(70, 400);
            this.cmbPersonelUnvan.Name = "cmbPersonelUnvan";
            this.cmbPersonelUnvan.Size = new System.Drawing.Size(100, 25);
            this.cmbPersonelUnvan.TabIndex = 4;

            // lblPersonelAd
            this.lblPersonelAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPersonelAd.Location = new System.Drawing.Point(190, 403);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(27, 17);
            this.lblPersonelAd.TabIndex = 5;
            this.lblPersonelAd.Text = "Ad:";

            // txtPersonelAd
            this.txtPersonelAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPersonelAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPersonelAd.Location = new System.Drawing.Point(230, 400);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(120, 25);
            this.txtPersonelAd.TabIndex = 6;

            // lblPersonelSoyad
            this.lblPersonelSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPersonelSoyad.AutoSize = true;
            this.lblPersonelSoyad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPersonelSoyad.Location = new System.Drawing.Point(380, 403);
            this.lblPersonelSoyad.Name = "lblPersonelSoyad";
            this.lblPersonelSoyad.Size = new System.Drawing.Size(47, 17);
            this.lblPersonelSoyad.TabIndex = 7;
            this.lblPersonelSoyad.Text = "Soyad:";

            // txtPersonelSoyad
            this.txtPersonelSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPersonelSoyad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPersonelSoyad.Location = new System.Drawing.Point(430, 400);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(120, 25);
            this.txtPersonelSoyad.TabIndex = 8;

            // lblPersonelBolum
            this.lblPersonelBolum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPersonelBolum.AutoSize = true;
            this.lblPersonelBolum.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPersonelBolum.Location = new System.Drawing.Point(570, 403);
            this.lblPersonelBolum.Name = "lblPersonelBolum";
            this.lblPersonelBolum.Size = new System.Drawing.Size(47, 17);
            this.lblPersonelBolum.TabIndex = 9;
            this.lblPersonelBolum.Text = "Bölüm:";

            // cmbPersonelBolum
            this.cmbPersonelBolum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPersonelBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelBolum.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbPersonelBolum.FormattingEnabled = true;
            this.cmbPersonelBolum.Location = new System.Drawing.Point(630, 400);
            this.cmbPersonelBolum.Name = "cmbPersonelBolum";
            this.cmbPersonelBolum.Size = new System.Drawing.Size(150, 25);
            this.cmbPersonelBolum.TabIndex = 10;

            // btnPersonelEkle
            this.btnPersonelEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonelEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPersonelEkle.Location = new System.Drawing.Point(427, 515);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(120, 35);
            this.btnPersonelEkle.TabIndex = 11;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);

            // btnPersonelGuncelle
            this.btnPersonelGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonelGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(557, 515);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(120, 35);
            this.btnPersonelGuncelle.TabIndex = 12;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);

            // btnPersonelSil
            this.btnPersonelSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonelSil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPersonelSil.Location = new System.Drawing.Point(687, 515);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(120, 35);
            this.btnPersonelSil.TabIndex = 13;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);

            // btnPersonelTemizle
            this.btnPersonelTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonelTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPersonelTemizle.Location = new System.Drawing.Point(817, 515);
            this.btnPersonelTemizle.Name = "btnPersonelTemizle";
            this.btnPersonelTemizle.Size = new System.Drawing.Size(120, 35);
            this.btnPersonelTemizle.TabIndex = 14;
            this.btnPersonelTemizle.Text = "Temizle";
            this.btnPersonelTemizle.UseVisualStyleBackColor = true;
            this.btnPersonelTemizle.Click += new System.EventHandler(this.btnPersonelTemizle_Click);

            // tpMazeretler
            this.tpMazeretler.Controls.Add(this.dgvMazeretler);
            this.tpMazeretler.Controls.Add(this.lblMazeretAra);
            this.tpMazeretler.Controls.Add(this.txtMazeretAra);
            this.tpMazeretler.Controls.Add(this.lblMazeretPersonel);
            this.tpMazeretler.Controls.Add(this.cmbMazeretPersonel);
            this.tpMazeretler.Controls.Add(this.lblMazeretTarih);
            this.tpMazeretler.Controls.Add(this.dtpMazeretTarih);
            this.tpMazeretler.Controls.Add(this.lblMazeretTuru);
            this.tpMazeretler.Controls.Add(this.cmbMazeretTuru);
            this.tpMazeretler.Controls.Add(this.chkMazeretUygun);
            this.tpMazeretler.Controls.Add(this.btnMazeretEkle);
            this.tpMazeretler.Controls.Add(this.btnMazeretGuncelle);
            this.tpMazeretler.Controls.Add(this.btnMazeretSil);
            this.tpMazeretler.Controls.Add(this.btnMazeretTemizle);
            this.tpMazeretler.Location = new System.Drawing.Point(4, 24);
            this.tpMazeretler.Name = "tpMazeretler";
            this.tpMazeretler.Padding = new System.Windows.Forms.Padding(3);
            this.tpMazeretler.Size = new System.Drawing.Size(952, 567);
            this.tpMazeretler.TabIndex = 5;
            this.tpMazeretler.Text = "Mazeretler";
            this.tpMazeretler.UseVisualStyleBackColor = true;

            // dgvMazeretler
            this.dgvMazeretler.AllowUserToAddRows = false;
            this.dgvMazeretler.AllowUserToDeleteRows = false;
            this.dgvMazeretler.AutoGenerateColumns = false;
            this.dgvMazeretler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMazeretler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMazeretDurumID,
            this.colMazeretPersonelID,
            this.colMazeretPersonelAdSoyad,
            this.colMazeretTarih,
            this.colMazeretTuru,
            this.colMazeretUygun});
            this.dgvMazeretler.Location = new System.Drawing.Point(15, 50);
            this.dgvMazeretler.MultiSelect = false;
            this.dgvMazeretler.Name = "dgvMazeretler";
            this.dgvMazeretler.ReadOnly = true;
            this.dgvMazeretler.RowHeadersVisible = false;
            this.dgvMazeretler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMazeretler.Size = new System.Drawing.Size(922, 330);
            this.dgvMazeretler.TabIndex = 0;
            this.dgvMazeretler.SelectionChanged += new System.EventHandler(this.dgvMazeretler_SelectionChanged);
            this.dgvMazeretler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // colMazeretDurumID
            this.colMazeretDurumID.DataPropertyName = "DurumID";
            this.colMazeretDurumID.HeaderText = "Durum ID";
            this.colMazeretDurumID.Name = "colMazeretDurumID";
            this.colMazeretDurumID.ReadOnly = true;
            this.colMazeretDurumID.Visible = false;

            // colMazeretPersonelID
            this.colMazeretPersonelID.DataPropertyName = "PersonelID";
            this.colMazeretPersonelID.HeaderText = "Personel ID";
            this.colMazeretPersonelID.Name = "colMazeretPersonelID";
            this.colMazeretPersonelID.ReadOnly = true;
            this.colMazeretPersonelID.Visible = false;

            // colMazeretPersonelAdSoyad
            this.colMazeretPersonelAdSoyad.DataPropertyName = "PersonelAdSoyad";
            this.colMazeretPersonelAdSoyad.HeaderText = "Personel";
            this.colMazeretPersonelAdSoyad.Name = "colMazeretPersonelAdSoyad";
            this.colMazeretPersonelAdSoyad.ReadOnly = true;
            this.colMazeretPersonelAdSoyad.Width = 250;

            // colMazeretTarih
            this.colMazeretTarih.DataPropertyName = "Tarih";
            this.colMazeretTarih.HeaderText = "Tarih";
            this.colMazeretTarih.Name = "colMazeretTarih";
            this.colMazeretTarih.ReadOnly = true;
            this.colMazeretTarih.Width = 150;

            // colMazeretTuru
            this.colMazeretTuru.DataPropertyName = "MazeretTuru";
            this.colMazeretTuru.HeaderText = "Mazeret Türü";
            this.colMazeretTuru.Name = "colMazeretTuru";
            this.colMazeretTuru.ReadOnly = true;
            this.colMazeretTuru.Width = 150;

            // colMazeretUygun
            this.colMazeretUygun.DataPropertyName = "Uygun";
            this.colMazeretUygun.HeaderText = "Uygun";
            this.colMazeretUygun.Name = "colMazeretUygun";
            this.colMazeretUygun.ReadOnly = true;
            this.colMazeretUygun.Width = 100;

            // lblMazeretAra
            this.lblMazeretAra.AutoSize = true;
            this.lblMazeretAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMazeretAra.Location = new System.Drawing.Point(15, 18);
            this.lblMazeretAra.Name = "lblMazeretAra";
            this.lblMazeretAra.Size = new System.Drawing.Size(83, 17);
            this.lblMazeretAra.TabIndex = 1;
            this.lblMazeretAra.Text = "Mazeret Ara:";

            // txtMazeretAra
            this.txtMazeretAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMazeretAra.Location = new System.Drawing.Point(110, 15);
            this.txtMazeretAra.Name = "txtMazeretAra";
            this.txtMazeretAra.Size = new System.Drawing.Size(250, 25);
            this.txtMazeretAra.TabIndex = 2;
            this.txtMazeretAra.TextChanged += new System.EventHandler(this.txtMazeretAra_TextChanged);

            // lblMazeretPersonel
            this.lblMazeretPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMazeretPersonel.AutoSize = true;
            this.lblMazeretPersonel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMazeretPersonel.Location = new System.Drawing.Point(15, 403);
            this.lblMazeretPersonel.Name = "lblMazeretPersonel";
            this.lblMazeretPersonel.Size = new System.Drawing.Size(61, 17);
            this.lblMazeretPersonel.TabIndex = 3;
            this.lblMazeretPersonel.Text = "Personel:";

            // cmbMazeretPersonel
            this.cmbMazeretPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbMazeretPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMazeretPersonel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbMazeretPersonel.FormattingEnabled = true;
            this.cmbMazeretPersonel.Location = new System.Drawing.Point(85, 400);
            this.cmbMazeretPersonel.Name = "cmbMazeretPersonel";
            this.cmbMazeretPersonel.Size = new System.Drawing.Size(200, 25);
            this.cmbMazeretPersonel.TabIndex = 4;

            // lblMazeretTarih
            this.lblMazeretTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMazeretTarih.AutoSize = true;
            this.lblMazeretTarih.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMazeretTarih.Location = new System.Drawing.Point(300, 403);
            this.lblMazeretTarih.Name = "lblMazeretTarih";
            this.lblMazeretTarih.Size = new System.Drawing.Size(39, 17);
            this.lblMazeretTarih.TabIndex = 5;
            this.lblMazeretTarih.Text = "Tarih:";

            // dtpMazeretTarih
            this.dtpMazeretTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpMazeretTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMazeretTarih.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpMazeretTarih.Location = new System.Drawing.Point(350, 400);
            this.dtpMazeretTarih.Name = "dtpMazeretTarih";
            this.dtpMazeretTarih.Size = new System.Drawing.Size(120, 25);
            this.dtpMazeretTarih.TabIndex = 6;

            // lblMazeretTuru
            this.lblMazeretTuru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMazeretTuru.AutoSize = true;
            this.lblMazeretTuru.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMazeretTuru.Location = new System.Drawing.Point(490, 403);
            this.lblMazeretTuru.Name = "lblMazeretTuru";
            this.lblMazeretTuru.Size = new System.Drawing.Size(87, 17);
            this.lblMazeretTuru.TabIndex = 7;
            this.lblMazeretTuru.Text = "Mazeret Türü:";

            // cmbMazeretTuru
            this.cmbMazeretTuru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbMazeretTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMazeretTuru.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbMazeretTuru.FormattingEnabled = true;
            this.cmbMazeretTuru.Items.AddRange(new object[] {
            "İzinli",
            "Danışmanlık",
            "Görevli",
            "Raporlu",
            "Diğer"});
            this.cmbMazeretTuru.Location = new System.Drawing.Point(580, 400);
            this.cmbMazeretTuru.Name = "cmbMazeretTuru";
            this.cmbMazeretTuru.Size = new System.Drawing.Size(120, 25);
            this.cmbMazeretTuru.TabIndex = 8;

            // chkMazeretUygun
            this.chkMazeretUygun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkMazeretUygun.AutoSize = true;
            this.chkMazeretUygun.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkMazeretUygun.Location = new System.Drawing.Point(720, 402);
            this.chkMazeretUygun.Name = "chkMazeretUygun";
            this.chkMazeretUygun.Size = new System.Drawing.Size(64, 21);
            this.chkMazeretUygun.TabIndex = 9;
            this.chkMazeretUygun.Text = "Uygun";
            this.chkMazeretUygun.UseVisualStyleBackColor = true;

            // btnMazeretEkle
            this.btnMazeretEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMazeretEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMazeretEkle.Location = new System.Drawing.Point(427, 515);
            this.btnMazeretEkle.Name = "btnMazeretEkle";
            this.btnMazeretEkle.Size = new System.Drawing.Size(120, 35);
            this.btnMazeretEkle.TabIndex = 10;
            this.btnMazeretEkle.Text = "Ekle";
            this.btnMazeretEkle.UseVisualStyleBackColor = true;
            this.btnMazeretEkle.Click += new System.EventHandler(this.btnMazeretEkle_Click);

            // btnMazeretGuncelle
            this.btnMazeretGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMazeretGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMazeretGuncelle.Location = new System.Drawing.Point(557, 515);
            this.btnMazeretGuncelle.Name = "btnMazeretGuncelle";
            this.btnMazeretGuncelle.Size = new System.Drawing.Size(120, 35);
            this.btnMazeretGuncelle.TabIndex = 11;
            this.btnMazeretGuncelle.Text = "Güncelle";
            this.btnMazeretGuncelle.UseVisualStyleBackColor = true;
            this.btnMazeretGuncelle.Click += new System.EventHandler(this.btnMazeretGuncelle_Click);

            // btnMazeretSil
            this.btnMazeretSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMazeretSil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMazeretSil.Location = new System.Drawing.Point(687, 515);
            this.btnMazeretSil.Name = "btnMazeretSil";
            this.btnMazeretSil.Size = new System.Drawing.Size(120, 35);
            this.btnMazeretSil.TabIndex = 12;
            this.btnMazeretSil.Text = "Sil";
            this.btnMazeretSil.UseVisualStyleBackColor = true;
            this.btnMazeretSil.Click += new System.EventHandler(this.btnMazeretSil_Click);

            // btnMazeretTemizle
            this.btnMazeretTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMazeretTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMazeretTemizle.Location = new System.Drawing.Point(817, 515);
            this.btnMazeretTemizle.Name = "btnMazeretTemizle";
            this.btnMazeretTemizle.Size = new System.Drawing.Size(120, 35);
            this.btnMazeretTemizle.TabIndex = 13;
            this.btnMazeretTemizle.Text = "Temizle";
            this.btnMazeretTemizle.UseVisualStyleBackColor = true;
            this.btnMazeretTemizle.Click += new System.EventHandler(this.btnMazeretTemizle_Click);

            // FrmTanimlamalar
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lblFormBaslik);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmTanimlamalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanımlamalar Modülü";
            this.Load += new System.EventHandler(this.FrmTanimlamalar_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBolumler)).EndInit();
            this.tpBolumler.ResumeLayout(false);
            this.tpBolumler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDerslikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDerslikKapasite)).EndInit();
            this.tpDerslikler.ResumeLayout(false);
            this.tpDerslikler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOturumlar)).EndInit();
            this.tpOturumlar.ResumeLayout(false);
            this.tpOturumlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOgrenciSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYariyil)).EndInit();
            this.tpDersler.ResumeLayout(false);
            this.tpDersler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.tpPersoneller.ResumeLayout(false);
            this.tpPersoneller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMazeretler)).EndInit();
            this.tpMazeretler.ResumeLayout(false);
            this.tpMazeretler.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpBolumler;
        private System.Windows.Forms.DataGridView dgvBolumler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBolumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBolumAd;
        private System.Windows.Forms.Label lblBolumAra;
        private System.Windows.Forms.TextBox txtBolumAra;
        private System.Windows.Forms.Label lblBolumAd;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Button btnBolumGuncelle;
        private System.Windows.Forms.Button btnBolumSil;
        private System.Windows.Forms.Button btnBolumTemizle;
        private System.Windows.Forms.TabPage tpDerslikler;
        private System.Windows.Forms.DataGridView dgvDerslikler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDerslikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDerslikAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDerslikKapasite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDerslikTip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDerslikAktif;
        private System.Windows.Forms.Label lblDerslikAra;
        private System.Windows.Forms.TextBox txtDerslikAra;
        private System.Windows.Forms.Label lblDerslikAd;
        private System.Windows.Forms.TextBox txtDerslikAd;
        private System.Windows.Forms.Label lblDerslikKapasite;
        private System.Windows.Forms.NumericUpDown nudDerslikKapasite;
        private System.Windows.Forms.Label lblDerslikTip;
        private System.Windows.Forms.ComboBox cmbDerslikTip;
        private System.Windows.Forms.CheckBox chkDerslikAktif;
        private System.Windows.Forms.Button btnDerslikEkle;
        private System.Windows.Forms.Button btnDerslikGuncelle;
        private System.Windows.Forms.Button btnDerslikSil;
        private System.Windows.Forms.Button btnDerslikTemizle;
        private System.Windows.Forms.TabPage tpOturumlar;
        private System.Windows.Forms.DataGridView dgvOturumlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOturumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOturumTanim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOturumBaslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOturumBitis;
        private System.Windows.Forms.Label lblOturumAra;
        private System.Windows.Forms.TextBox txtOturumAra;
        private System.Windows.Forms.Label lblOturumTanim;
        private System.Windows.Forms.TextBox txtOturumTanim;
        private System.Windows.Forms.Label lblOturumBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBaslangicSaat;
        private System.Windows.Forms.Label lblOturumBitis;
        private System.Windows.Forms.DateTimePicker dtpBitisSaat;
        private System.Windows.Forms.Button btnOturumEkle;
        private System.Windows.Forms.Button btnOturumGuncelle;
        private System.Windows.Forms.Button btnOturumSil;
        private System.Windows.Forms.Button btnOturumTemizle;
        private System.Windows.Forms.TabPage tpDersler;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersOgrenciSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersYariyil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersBolumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersBolumAd;
        private System.Windows.Forms.Label lblDersAra;
        private System.Windows.Forms.TextBox txtDersAra;
        private System.Windows.Forms.Label lblDersKodu;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.Label lblDersAd;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label lblDersTuru;
        private System.Windows.Forms.ComboBox cmbDersTuru;
        private System.Windows.Forms.Label lblOgrenciSayisi;
        private System.Windows.Forms.NumericUpDown nudOgrenciSayisi;
        private System.Windows.Forms.Label lblYariyil;
        private System.Windows.Forms.NumericUpDown nudYariyil;
        private System.Windows.Forms.Label lblDersBolum;
        private System.Windows.Forms.ComboBox cmbDersBolum;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersTemizle;
        private System.Windows.Forms.TabPage tpPersoneller;
        private System.Windows.Forms.DataGridView dgvPersoneller;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonelUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonelAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonelSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonelBolumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonelBolumAd;
        private System.Windows.Forms.Label lblPersonelAra;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.Label lblPersonelUnvan;
        private System.Windows.Forms.ComboBox cmbPersonelUnvan;
        private System.Windows.Forms.Label lblPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label lblPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.Label lblPersonelBolum;
        private System.Windows.Forms.ComboBox cmbPersonelBolum;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelTemizle;
        private System.Windows.Forms.TabPage tpMazeretler;
        private System.Windows.Forms.DataGridView dgvMazeretler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMazeretDurumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMazeretPersonelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMazeretPersonelAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMazeretTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMazeretTuru;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMazeretUygun;
        private System.Windows.Forms.Label lblMazeretAra;
        private System.Windows.Forms.TextBox txtMazeretAra;
        private System.Windows.Forms.Label lblMazeretPersonel;
        private System.Windows.Forms.ComboBox cmbMazeretPersonel;
        private System.Windows.Forms.Label lblMazeretTarih;
        private System.Windows.Forms.DateTimePicker dtpMazeretTarih;
        private System.Windows.Forms.Label lblMazeretTuru;
        private System.Windows.Forms.ComboBox cmbMazeretTuru;
        private System.Windows.Forms.CheckBox chkMazeretUygun;
        private System.Windows.Forms.Button btnMazeretEkle;
        private System.Windows.Forms.Button btnMazeretGuncelle;
        private System.Windows.Forms.Button btnMazeretSil;
        private System.Windows.Forms.Button btnMazeretTemizle;
        private System.Windows.Forms.Label lblFormBaslik;
    }
}
