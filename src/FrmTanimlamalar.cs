using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SinavTakvimiOtomasyonu
{
    public partial class FrmTanimlamalar : Form
    {
        private int _secilenBolumID = -1;
        private int _secilenDerslikID = -1;
        private int _secilenOturumID = -1;
        private int _secilenDersID = -1;
        private int _secilenPersonelID = -1;
        private int _secilenMazeretID = -1;

        public FrmTanimlamalar()
        {
            InitializeComponent();
        }

        private void FrmTanimlamalar_Load(object sender, EventArgs e)
        {
            TumListeleriYenile();
        }

        private void LoadBolumler(string arama = "")
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "SELECT BolumID, BolumAd FROM Bolumler WHERE BolumAd LIKE @Arama ORDER BY BolumAd";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Arama", "%" + arama + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvBolumler.DataSource = dt;
                        }
                    }
                }
                BolumComboBoxlariniYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBolumAra_TextChanged(object sender, EventArgs e)
        {
            LoadBolumler(txtBolumAra.Text.Trim());
        }

        private void dgvBolumler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBolumler.CurrentRow == null || dgvBolumler.SelectedRows.Count == 0) return;

            DataGridViewRow satir = dgvBolumler.SelectedRows[0];
            if (satir.Cells["colBolumID"] == null || satir.Cells["colBolumID"].Value == null || satir.Cells["colBolumID"].Value == DBNull.Value)
                return;

            _secilenBolumID = Convert.ToInt32(satir.Cells["colBolumID"].Value);
            txtBolumAd.Text = satir.Cells["colBolumAd"]?.Value?.ToString() ?? "";
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            string bolumAd = txtBolumAd.Text.Trim();

            if (string.IsNullOrEmpty(bolumAd))
            {
                MessageBox.Show("Bölüm adı boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "INSERT INTO Bolumler (BolumAd) VALUES (@BolumAd)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@BolumAd", bolumAd);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadBolumler(txtBolumAra.Text.Trim());
                _secilenBolumID = -1;
                dgvBolumler.ClearSelection();
                txtBolumAd.Clear();
                MessageBox.Show("Bölüm başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBolumGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenBolumID == -1)
            {
                MessageBox.Show("Güncellemek için listeden bir bölüm seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bolumAd = txtBolumAd.Text.Trim();

            if (string.IsNullOrEmpty(bolumAd))
            {
                MessageBox.Show("Bölüm adı boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "UPDATE Bolumler SET BolumAd = @BolumAd WHERE BolumID = @BolumID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@BolumAd", bolumAd);
                        cmd.Parameters.AddWithValue("@BolumID", _secilenBolumID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadBolumler(txtBolumAra.Text.Trim());
                _secilenBolumID = -1;
                dgvBolumler.ClearSelection();
                txtBolumAd.Clear();
                MessageBox.Show("Bölüm başarıyla güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBolumSil_Click(object sender, EventArgs e)
        {
            if (_secilenBolumID == -1)
            {
                MessageBox.Show("Silmek için listeden bir bölüm seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili bölümü silmek istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "DELETE FROM Bolumler WHERE BolumID = @BolumID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@BolumID", _secilenBolumID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadBolumler(txtBolumAra.Text.Trim());
                _secilenBolumID = -1;
                dgvBolumler.ClearSelection();
                txtBolumAd.Clear();
                MessageBox.Show("Bölüm başarıyla silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBolumTemizle_Click(object sender, EventArgs e)
        {
            txtBolumAra.Clear();
            _secilenBolumID = -1;
            dgvBolumler.ClearSelection();
            txtBolumAd.Clear();
        }

        private void LoadDerslikler(string arama = "")
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "SELECT DerslikID, Ad, Kapasite, Tip, Aktif FROM Derslikler WHERE Ad LIKE @Arama OR Tip LIKE @Arama ORDER BY Ad";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Arama", "%" + arama + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvDerslikler.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDerslikAra_TextChanged(object sender, EventArgs e)
        {
            LoadDerslikler(txtDerslikAra.Text.Trim());
        }

        private void dgvDerslikler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDerslikler.CurrentRow == null || dgvDerslikler.SelectedRows.Count == 0) return;

            DataGridViewRow satir = dgvDerslikler.SelectedRows[0];
            if (satir.Cells["colDerslikID"] == null || satir.Cells["colDerslikID"].Value == null || satir.Cells["colDerslikID"].Value == DBNull.Value)
                return;

            _secilenDerslikID = Convert.ToInt32(satir.Cells["colDerslikID"].Value);
            txtDerslikAd.Text = satir.Cells["colDerslikAd"]?.Value?.ToString() ?? "";
            
            object valKapasite = satir.Cells["colDerslikKapasite"]?.Value;
            if (valKapasite != null && valKapasite != DBNull.Value)
            {
                decimal kapasite = Convert.ToDecimal(valKapasite);
                if (kapasite < nudDerslikKapasite.Minimum)
                    kapasite = nudDerslikKapasite.Minimum;
                if (kapasite > nudDerslikKapasite.Maximum)
                    nudDerslikKapasite.Maximum = kapasite;

                nudDerslikKapasite.Value = kapasite;
            }
            else
            {
                nudDerslikKapasite.Value = nudDerslikKapasite.Minimum;
            }
            
            string tip = satir.Cells["colDerslikTip"]?.Value?.ToString();
            cmbDerslikTip.SelectedItem = tip;

            chkDerslikAktif.Checked = Convert.ToBoolean(satir.Cells["colDerslikAktif"]?.Value ?? false);
        }

        private void btnDerslikEkle_Click(object sender, EventArgs e)
        {
            string ad = txtDerslikAd.Text.Trim();
            int kapasite = (int)nudDerslikKapasite.Value;
            string tip = cmbDerslikTip.SelectedItem?.ToString();
            bool aktif = chkDerslikAktif.Checked;

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Derslik adı boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kapasite < 1)
            {
                MessageBox.Show("Kapasite 1'den küçük olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "INSERT INTO Derslikler (Ad, Kapasite, Tip, Aktif) VALUES (@Ad, @Kapasite, @Tip, @Aktif)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Kapasite", kapasite);
                        cmd.Parameters.AddWithValue("@Tip", string.IsNullOrEmpty(tip) ? (object)DBNull.Value : tip);
                        cmd.Parameters.AddWithValue("@Aktif", aktif);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDerslikler(txtDerslikAra.Text.Trim());
                btnDerslikTemizle_Click(null, null);
                MessageBox.Show("Derslik başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDerslikGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenDerslikID == -1)
            {
                MessageBox.Show("Güncellemek için listeden bir derslik seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ad = txtDerslikAd.Text.Trim();
            int kapasite = (int)nudDerslikKapasite.Value;
            string tip = cmbDerslikTip.SelectedItem?.ToString();
            bool aktif = chkDerslikAktif.Checked;

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Derslik adı boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kapasite < 1)
            {
                MessageBox.Show("Kapasite 1'den küçük olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "UPDATE Derslikler SET Ad = @Ad, Kapasite = @Kapasite, Tip = @Tip, Aktif = @Aktif WHERE DerslikID = @DerslikID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Kapasite", kapasite);
                        cmd.Parameters.AddWithValue("@Tip", string.IsNullOrEmpty(tip) ? (object)DBNull.Value : tip);
                        cmd.Parameters.AddWithValue("@Aktif", aktif);
                        cmd.Parameters.AddWithValue("@DerslikID", _secilenDerslikID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDerslikler(txtDerslikAra.Text.Trim());
                btnDerslikTemizle_Click(null, null);
                MessageBox.Show("Derslik başarıyla güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDerslikSil_Click(object sender, EventArgs e)
        {
            if (_secilenDerslikID == -1)
            {
                MessageBox.Show("Silmek için listeden bir derslik seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili dersliği silmek (pasifleştirmek) istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "UPDATE Derslikler SET Aktif = 0 WHERE DerslikID = @DerslikID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DerslikID", _secilenDerslikID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDerslikler(txtDerslikAra.Text.Trim());
                btnDerslikTemizle_Click(null, null);
                MessageBox.Show("Derslik başarıyla silindi (pasifleştirildi).", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDerslikTemizle_Click(object sender, EventArgs e)
        {
            txtDerslikAra.Clear();
            _secilenDerslikID = -1;
            dgvDerslikler.ClearSelection();
            txtDerslikAd.Clear();
            nudDerslikKapasite.Value = 1;
            cmbDerslikTip.SelectedIndex = -1;
            chkDerslikAktif.Checked = true;
        }

        private void LoadOturumlar(string arama = "")
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "SELECT OturumID, Tanim, BaslangicSaat, BitisSaat FROM Oturumlar WHERE Tanim LIKE @Arama ORDER BY BaslangicSaat";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Arama", "%" + arama + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvOturumlar.DataSource = dt;
                        }
                    }
                }
                OturumComboBoxlariniYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOturumAra_TextChanged(object sender, EventArgs e)
        {
            LoadOturumlar(txtOturumAra.Text.Trim());
        }

        private void dgvOturumlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOturumlar.CurrentRow == null || dgvOturumlar.SelectedRows.Count == 0) return;

            DataGridViewRow satir = dgvOturumlar.SelectedRows[0];
            if (satir.Cells["colOturumID"] == null || satir.Cells["colOturumID"].Value == null || satir.Cells["colOturumID"].Value == DBNull.Value)
                return;

            _secilenOturumID = Convert.ToInt32(satir.Cells["colOturumID"].Value);
            txtOturumTanim.Text = satir.Cells["colOturumTanim"]?.Value?.ToString() ?? "";

            if (satir.Cells["colOturumBaslangic"] != null && satir.Cells["colOturumBaslangic"].Value != null && satir.Cells["colOturumBaslangic"].Value != DBNull.Value)
            {
                TimeSpan start = (TimeSpan)satir.Cells["colOturumBaslangic"].Value;
                dtpBaslangicSaat.Value = DateTime.Today.Add(start);
            }
            if (satir.Cells["colOturumBitis"] != null && satir.Cells["colOturumBitis"].Value != null && satir.Cells["colOturumBitis"].Value != DBNull.Value)
            {
                TimeSpan end = (TimeSpan)satir.Cells["colOturumBitis"].Value;
                dtpBitisSaat.Value = DateTime.Today.Add(end);
            }
        }

        private void btnOturumEkle_Click(object sender, EventArgs e)
        {
            string tanim = txtOturumTanim.Text.Trim();
            TimeSpan baslangic = dtpBaslangicSaat.Value.TimeOfDay;
            TimeSpan bitis = dtpBitisSaat.Value.TimeOfDay;

            if (string.IsNullOrEmpty(tanim))
            {
                MessageBox.Show("Oturum tanımı boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (baslangic >= bitis)
            {
                MessageBox.Show("Başlangıç saati bitiş saatinden küçük olmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "INSERT INTO Oturumlar (Tanim, BaslangicSaat, BitisSaat) VALUES (@Tanim, @BaslangicSaat, @BitisSaat)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tanim", tanim);
                        cmd.Parameters.AddWithValue("@BaslangicSaat", baslangic);
                        cmd.Parameters.AddWithValue("@BitisSaat", bitis);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadOturumlar(txtOturumAra.Text.Trim());
                btnOturumTemizle_Click(null, null);
                MessageBox.Show("Oturum başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOturumGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenOturumID == -1)
            {
                MessageBox.Show("Güncellemek için listeden bir oturum seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tanim = txtOturumTanim.Text.Trim();
            TimeSpan baslangic = dtpBaslangicSaat.Value.TimeOfDay;
            TimeSpan bitis = dtpBitisSaat.Value.TimeOfDay;

            if (string.IsNullOrEmpty(tanim))
            {
                MessageBox.Show("Oturum tanımı boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (baslangic >= bitis)
            {
                MessageBox.Show("Başlangıç saati bitiş saatinden küçük olmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "UPDATE Oturumlar SET Tanim = @Tanim, BaslangicSaat = @BaslangicSaat, BitisSaat = @BitisSaat WHERE OturumID = @OturumID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tanim", tanim);
                        cmd.Parameters.AddWithValue("@BaslangicSaat", baslangic);
                        cmd.Parameters.AddWithValue("@BitisSaat", bitis);
                        cmd.Parameters.AddWithValue("@OturumID", _secilenOturumID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadOturumlar(txtOturumAra.Text.Trim());
                btnOturumTemizle_Click(null, null);
                MessageBox.Show("Oturum başarıyla güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOturumSil_Click(object sender, EventArgs e)
        {
            if (_secilenOturumID == -1)
            {
                MessageBox.Show("Silmek için listeden bir oturum seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili oturumu silmek istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            bool kullaniliyor = false;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string checkSql = "SELECT COUNT(*) FROM Sinavlar WHERE OturumID = @OturumID";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@OturumID", _secilenOturumID);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0) kullaniliyor = true;
                    }
                }
            }
            catch { /* Sinavlar tablosu yoksa veya kolon bulunamadıysa burayı atla, FK hatası yakalanır. */ }

            if (kullaniliyor)
            {
                MessageBox.Show("Bu oturum sınavlarda kullanıldığı için silinemez.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "DELETE FROM Oturumlar WHERE OturumID = @OturumID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@OturumID", _secilenOturumID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadOturumlar(txtOturumAra.Text.Trim());
                btnOturumTemizle_Click(null, null);
                MessageBox.Show("Oturum başarıyla silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu oturum sınavlarda kullanıldığı için silinemez.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOturumTemizle_Click(object sender, EventArgs e)
        {
            txtOturumAra.Clear();
            _secilenOturumID = -1;
            dgvOturumlar.ClearSelection();
            txtOturumTanim.Clear();
            dtpBaslangicSaat.Value = DateTime.Today.AddHours(9);
            dtpBitisSaat.Value = DateTime.Today.AddHours(10);
        }

        private void BolumComboBoxlariniYenile()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "SELECT BolumID, BolumAd FROM Bolumler ORDER BY BolumAd";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt1 = new DataTable();
                            da.Fill(dt1);
                            
                            DataTable dt2 = dt1.Copy();

                            cmbDersBolum.DataSource = dt1;
                            cmbDersBolum.DisplayMember = "BolumAd";
                            cmbDersBolum.ValueMember = "BolumID";
                            cmbDersBolum.SelectedIndex = -1;

                            cmbPersonelBolum.DataSource = dt2;
                            cmbPersonelBolum.DisplayMember = "BolumAd";
                            cmbPersonelBolum.ValueMember = "BolumID";
                            cmbPersonelBolum.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bölümler yüklenirken hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDersler(string arama = "")
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                        SELECT d.DersID, d.DersKodu, d.DersTuru, d.Ad, d.OgrenciSayisi, d.Yariyil, d.BolumID, b.BolumAd 
                        FROM Dersler d
                        INNER JOIN Bolumler b ON d.BolumID = b.BolumID
                        WHERE d.DersKodu LIKE @Arama 
                           OR d.Ad LIKE @Arama 
                           OR d.DersTuru LIKE @Arama 
                           OR b.BolumAd LIKE @Arama
                        ORDER BY d.DersKodu";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Arama", "%" + arama + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvDersler.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dersler yüklenirken hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDersAra_TextChanged(object sender, EventArgs e)
        {
            LoadDersler(txtDersAra.Text.Trim());
        }

        private void dgvDersler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDersler.CurrentRow == null || dgvDersler.SelectedRows.Count == 0) return;

            DataGridViewRow satir = dgvDersler.SelectedRows[0];
            if (satir.Cells["colDersID"] == null || satir.Cells["colDersID"].Value == null || satir.Cells["colDersID"].Value == DBNull.Value)
                return;

            _secilenDersID = Convert.ToInt32(satir.Cells["colDersID"].Value);
            txtDersKodu.Text = satir.Cells["colDersKodu"]?.Value?.ToString() ?? "";
            txtDersAd.Text = satir.Cells["colDersAd"]?.Value?.ToString() ?? "";
            
            string dersTuru = satir.Cells["colDersTuru"]?.Value?.ToString();
            cmbDersTuru.SelectedItem = dersTuru;

            object valOgrenci = satir.Cells["colDersOgrenciSayisi"]?.Value;
            if (valOgrenci != null && valOgrenci != DBNull.Value)
            {
                decimal ogrenci = Convert.ToDecimal(valOgrenci);
                if (ogrenci < nudOgrenciSayisi.Minimum)
                    ogrenci = nudOgrenciSayisi.Minimum;
                if (ogrenci > nudOgrenciSayisi.Maximum)
                    nudOgrenciSayisi.Maximum = ogrenci;
                
                nudOgrenciSayisi.Value = ogrenci;
            }
            else
            {
                nudOgrenciSayisi.Value = nudOgrenciSayisi.Minimum;
            }

            object valYariyil = satir.Cells["colDersYariyil"]?.Value;
            if (valYariyil != null && valYariyil != DBNull.Value)
            {
                decimal yariyil = Convert.ToDecimal(valYariyil);
                if (yariyil < nudYariyil.Minimum)
                    yariyil = nudYariyil.Minimum;
                if (yariyil > nudYariyil.Maximum)
                    nudYariyil.Maximum = yariyil;

                nudYariyil.Value = yariyil;
            }
            else
            {
                nudYariyil.Value = nudYariyil.Minimum;
            }

            if (satir.Cells["colDersBolumID"] != null && satir.Cells["colDersBolumID"].Value != null && satir.Cells["colDersBolumID"].Value != DBNull.Value)
            {
                cmbDersBolum.SelectedValue = satir.Cells["colDersBolumID"].Value;
            }
            else
            {
                cmbDersBolum.SelectedIndex = -1;
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            string dersKodu = txtDersKodu.Text.Trim();
            string ad = txtDersAd.Text.Trim();
            string dersTuru = cmbDersTuru.SelectedItem?.ToString();
            int ogrenciSayisi = (int)nudOgrenciSayisi.Value;
            int yariyil = (int)nudYariyil.Value;

            if (string.IsNullOrEmpty(dersKodu))
            {
                MessageBox.Show("Ders kodu boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ders adı boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ogrenciSayisi < 1)
            {
                MessageBox.Show("Öğrenci sayısı 1'den küçük olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yariyil < 1 || yariyil > 8)
            {
                MessageBox.Show("Yarıyıl 1 ile 8 arasında olmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDersBolum.SelectedValue == null || cmbDersBolum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir bölüm seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bolumID = Convert.ToInt32(cmbDersBolum.SelectedValue);

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "INSERT INTO Dersler (DersKodu, DersTuru, Ad, OgrenciSayisi, Yariyil, BolumID) VALUES (@DersKodu, @DersTuru, @Ad, @OgrenciSayisi, @Yariyil, @BolumID)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DersKodu", dersKodu);
                        cmd.Parameters.AddWithValue("@DersTuru", string.IsNullOrEmpty(dersTuru) ? (object)DBNull.Value : dersTuru);
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@OgrenciSayisi", ogrenciSayisi);
                        cmd.Parameters.AddWithValue("@Yariyil", yariyil);
                        cmd.Parameters.AddWithValue("@BolumID", bolumID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDersler(txtDersAra.Text.Trim());
                btnDersTemizle_Click(null, null);
                MessageBox.Show("Ders başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenDersID == -1)
            {
                MessageBox.Show("Güncellemek için listeden bir ders seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dersKodu = txtDersKodu.Text.Trim();
            string ad = txtDersAd.Text.Trim();
            string dersTuru = cmbDersTuru.SelectedItem?.ToString();
            int ogrenciSayisi = (int)nudOgrenciSayisi.Value;
            int yariyil = (int)nudYariyil.Value;

            if (string.IsNullOrEmpty(dersKodu))
            {
                MessageBox.Show("Ders kodu boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ders adı boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ogrenciSayisi < 1)
            {
                MessageBox.Show("Öğrenci sayısı 1'den küçük olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yariyil < 1 || yariyil > 8)
            {
                MessageBox.Show("Yarıyıl 1 ile 8 arasında olmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDersBolum.SelectedValue == null || cmbDersBolum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir bölüm seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bolumID = Convert.ToInt32(cmbDersBolum.SelectedValue);

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "UPDATE Dersler SET DersKodu = @DersKodu, DersTuru = @DersTuru, Ad = @Ad, OgrenciSayisi = @OgrenciSayisi, Yariyil = @Yariyil, BolumID = @BolumID WHERE DersID = @DersID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DersKodu", dersKodu);
                        cmd.Parameters.AddWithValue("@DersTuru", string.IsNullOrEmpty(dersTuru) ? (object)DBNull.Value : dersTuru);
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@OgrenciSayisi", ogrenciSayisi);
                        cmd.Parameters.AddWithValue("@Yariyil", yariyil);
                        cmd.Parameters.AddWithValue("@BolumID", bolumID);
                        cmd.Parameters.AddWithValue("@DersID", _secilenDersID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDersler(txtDersAra.Text.Trim());
                btnDersTemizle_Click(null, null);
                MessageBox.Show("Ders başarıyla güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (_secilenDersID == -1)
            {
                MessageBox.Show("Silmek için listeden bir ders seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili dersi silmek istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            bool kullaniliyor = false;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string checkSql = "SELECT COUNT(*) FROM Sinavlar WHERE DersID = @DersID";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@DersID", _secilenDersID);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0) kullaniliyor = true;
                    }
                }
            }
            catch { }

            if (kullaniliyor)
            {
                MessageBox.Show("Bu ders sınavlarda kullanıldığı için silinemez.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "DELETE FROM Dersler WHERE DersID = @DersID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DersID", _secilenDersID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDersler(txtDersAra.Text.Trim());
                btnDersTemizle_Click(null, null);
                MessageBox.Show("Ders başarıyla silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu ders sınavlarda kullanıldığı için silinemez.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDersTemizle_Click(object sender, EventArgs e)
        {
            txtDersAra.Clear();
            _secilenDersID = -1;
            dgvDersler.ClearSelection();
            txtDersKodu.Clear();
            txtDersAd.Clear();
            cmbDersTuru.SelectedIndex = -1;
            nudOgrenciSayisi.Value = 1;
            nudYariyil.Value = 1;
            cmbDersBolum.SelectedIndex = -1;
        }

        private void OturumComboBoxlariniYenile()
        {
        }

        private void TumListeleriYenile()
        {
            LoadBolumler();
            LoadDerslikler();
            LoadOturumlar();
            LoadDersler();
            LoadPersoneller();
            LoadMazeretler();
        }

        private void LoadPersoneller(string arama = "")
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                        SELECT p.PersonelID, p.Unvan, p.Ad, p.Soyad, p.BolumID, b.BolumAd 
                        FROM Personel p
                        INNER JOIN Bolumler b ON p.BolumID = b.BolumID
                        WHERE ISNULL(p.Unvan, '') LIKE @Arama 
                           OR p.Ad LIKE @Arama 
                           OR p.Soyad LIKE @Arama 
                           OR b.BolumAd LIKE @Arama
                        ORDER BY p.Ad, p.Soyad";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Arama", "%" + arama + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvPersoneller.DataSource = dt;
                        }
                    }
                }
                PersonelComboBoxlariniYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personeller yüklenirken hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            LoadPersoneller(txtPersonelAra.Text.Trim());
        }

        private void dgvPersoneller_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersoneller.CurrentRow == null || dgvPersoneller.SelectedRows.Count == 0) return;

            DataGridViewRow satir = dgvPersoneller.SelectedRows[0];
            if (satir.Cells["colPersonelID"] == null || satir.Cells["colPersonelID"].Value == null || satir.Cells["colPersonelID"].Value == DBNull.Value)
                return;

            _secilenPersonelID = Convert.ToInt32(satir.Cells["colPersonelID"].Value);
            txtPersonelAd.Text = satir.Cells["colPersonelAd"]?.Value?.ToString() ?? "";
            txtPersonelSoyad.Text = satir.Cells["colPersonelSoyad"]?.Value?.ToString() ?? "";
            
            string unvan = satir.Cells["colPersonelUnvan"]?.Value?.ToString();
            cmbPersonelUnvan.SelectedItem = unvan;

            if (satir.Cells["colPersonelBolumID"] != null && satir.Cells["colPersonelBolumID"].Value != null && satir.Cells["colPersonelBolumID"].Value != DBNull.Value)
            {
                cmbPersonelBolum.SelectedValue = satir.Cells["colPersonelBolumID"].Value;
            }
            else
            {
                cmbPersonelBolum.SelectedIndex = -1;
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            string ad = txtPersonelAd.Text.Trim();
            string soyad = txtPersonelSoyad.Text.Trim();
            string unvan = cmbPersonelUnvan.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ad boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Soyad boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPersonelBolum.SelectedValue == null || cmbPersonelBolum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir bölüm seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bolumID = Convert.ToInt32(cmbPersonelBolum.SelectedValue);

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "INSERT INTO Personel (Unvan, Ad, Soyad, BolumID) VALUES (@Unvan, @Ad, @Soyad, @BolumID)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Unvan", string.IsNullOrEmpty(unvan) ? (object)DBNull.Value : unvan);
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@BolumID", bolumID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadPersoneller(txtPersonelAra.Text.Trim());
                btnPersonelTemizle_Click(null, null);
                MessageBox.Show("Personel başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenPersonelID == -1)
            {
                MessageBox.Show("Güncellemek için listeden bir personel seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ad = txtPersonelAd.Text.Trim();
            string soyad = txtPersonelSoyad.Text.Trim();
            string unvan = cmbPersonelUnvan.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ad boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Soyad boş bırakılamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPersonelBolum.SelectedValue == null || cmbPersonelBolum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir bölüm seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bolumID = Convert.ToInt32(cmbPersonelBolum.SelectedValue);

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "UPDATE Personel SET Unvan = @Unvan, Ad = @Ad, Soyad = @Soyad, BolumID = @BolumID WHERE PersonelID = @PersonelID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Unvan", string.IsNullOrEmpty(unvan) ? (object)DBNull.Value : unvan);
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@BolumID", bolumID);
                        cmd.Parameters.AddWithValue("@PersonelID", _secilenPersonelID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadPersoneller(txtPersonelAra.Text.Trim());
                btnPersonelTemizle_Click(null, null);
                MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (_secilenPersonelID == -1)
            {
                MessageBox.Show("Silmek için listeden bir personel seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili personeli silmek istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            bool kullaniliyor = false;
            string kullanilanTablo = "";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sqlKullanici = "SELECT COUNT(*) FROM Kullanicilar WHERE PersonelID = @PersonelID";
                    using (SqlCommand cmd = new SqlCommand(sqlKullanici, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonelID", _secilenPersonelID);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                        {
                            kullaniliyor = true;
                            kullanilanTablo = "Kullanıcılar";
                        }
                    }

                    if (!kullaniliyor)
                    {
                        string sqlDurum = "SELECT COUNT(*) FROM Personel_Durum WHERE PersonelID = @PersonelID";
                        using (SqlCommand cmd = new SqlCommand(sqlDurum, conn))
                        {
                            cmd.Parameters.AddWithValue("@PersonelID", _secilenPersonelID);
                            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                            {
                                kullaniliyor = true;
                                kullanilanTablo = "Personel Durum";
                            }
                        }
                    }

                    if (!kullaniliyor)
                    {
                        string sqlGozetmen = "SELECT COUNT(*) FROM Gozetmen_Atamalari WHERE PersonelID = @PersonelID";
                        using (SqlCommand cmd = new SqlCommand(sqlGozetmen, conn))
                        {
                            cmd.Parameters.AddWithValue("@PersonelID", _secilenPersonelID);
                            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                            {
                                kullaniliyor = true;
                                kullanilanTablo = "Gözetmen Atamaları";
                            }
                        }
                    }
                }
            }
            catch { }

            if (kullaniliyor)
            {
                MessageBox.Show($"Bu personel {kullanilanTablo} tablosunda kullanıldığı için silinemez.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "DELETE FROM Personel WHERE PersonelID = @PersonelID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonelID", _secilenPersonelID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadPersoneller(txtPersonelAra.Text.Trim());
                btnPersonelTemizle_Click(null, null);
                MessageBox.Show("Personel başarıyla silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu personel başka bir tabloda kullanıldığı için silinemez.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonelTemizle_Click(object sender, EventArgs e)
        {
            txtPersonelAra.Clear();
            _secilenPersonelID = -1;
            dgvPersoneller.ClearSelection();
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            cmbPersonelUnvan.SelectedIndex = -1;
            cmbPersonelBolum.SelectedIndex = -1;
        }

        private void PersonelComboBoxlariniYenile()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "SELECT PersonelID, LTRIM(RTRIM(ISNULL(Unvan, '') + ' ' + Ad + ' ' + Soyad)) AS PersonelAdSoyad FROM Personel ORDER BY Ad, Soyad";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            cmbMazeretPersonel.DataSource = dt;
                            cmbMazeretPersonel.DisplayMember = "PersonelAdSoyad";
                            cmbMazeretPersonel.ValueMember = "PersonelID";
                            cmbMazeretPersonel.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mazeret personelleri yüklenirken hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMazeretler(string arama = "")
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                        SELECT pd.DurumID, pd.PersonelID, LTRIM(RTRIM(ISNULL(p.Unvan, '') + ' ' + p.Ad + ' ' + p.Soyad)) AS PersonelAdSoyad, pd.Tarih, pd.MazeretTuru, pd.Uygun 
                        FROM Personel_Durum pd
                        INNER JOIN Personel p ON pd.PersonelID = p.PersonelID
                        WHERE p.Ad LIKE @Arama 
                           OR p.Soyad LIKE @Arama 
                           OR pd.MazeretTuru LIKE @Arama
                        ORDER BY pd.Tarih DESC, p.Ad, p.Soyad";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Arama", "%" + arama + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvMazeretler.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mazeretler yüklenirken hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMazeretAra_TextChanged(object sender, EventArgs e)
        {
            LoadMazeretler(txtMazeretAra.Text.Trim());
        }

        private void dgvMazeretler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMazeretler.CurrentRow == null || dgvMazeretler.SelectedRows.Count == 0) return;

            DataGridViewRow satir = dgvMazeretler.SelectedRows[0];
            if (satir.Cells["colMazeretDurumID"] == null || satir.Cells["colMazeretDurumID"].Value == null || satir.Cells["colMazeretDurumID"].Value == DBNull.Value)
                return;

            _secilenMazeretID = Convert.ToInt32(satir.Cells["colMazeretDurumID"].Value);

            if (satir.Cells["colMazeretPersonelID"] != null && satir.Cells["colMazeretPersonelID"].Value != null && satir.Cells["colMazeretPersonelID"].Value != DBNull.Value)
            {
                cmbMazeretPersonel.SelectedValue = satir.Cells["colMazeretPersonelID"].Value;
            }
            else
            {
                cmbMazeretPersonel.SelectedIndex = -1;
            }

            if (satir.Cells["colMazeretTarih"] != null && satir.Cells["colMazeretTarih"].Value != null && satir.Cells["colMazeretTarih"].Value != DBNull.Value)
            {
                dtpMazeretTarih.Value = Convert.ToDateTime(satir.Cells["colMazeretTarih"].Value);
            }
            else
            {
                dtpMazeretTarih.Value = DateTime.Today;
            }

            string mazeretTuru = satir.Cells["colMazeretTuru"]?.Value?.ToString();
            cmbMazeretTuru.SelectedItem = mazeretTuru;

            chkMazeretUygun.Checked = Convert.ToBoolean(satir.Cells["colMazeretUygun"]?.Value ?? false);
        }

        private void btnMazeretEkle_Click(object sender, EventArgs e)
        {
            if (cmbMazeretPersonel.SelectedValue == null || cmbMazeretPersonel.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir personel seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMazeretTuru.SelectedItem == null || cmbMazeretTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen mazeret türünü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int personelID = Convert.ToInt32(cmbMazeretPersonel.SelectedValue);
            DateTime tarih = dtpMazeretTarih.Value.Date;
            string mazeretTuru = cmbMazeretTuru.SelectedItem.ToString();
            bool uygun = chkMazeretUygun.Checked;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "INSERT INTO Personel_Durum (PersonelID, Tarih, MazeretTuru, Uygun) VALUES (@PersonelID, @Tarih, @MazeretTuru, @Uygun)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonelID", personelID);
                        cmd.Parameters.AddWithValue("@Tarih", tarih);
                        cmd.Parameters.AddWithValue("@MazeretTuru", mazeretTuru);
                        cmd.Parameters.AddWithValue("@Uygun", uygun);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadMazeretler(txtMazeretAra.Text.Trim());
                btnMazeretTemizle_Click(null, null);
                MessageBox.Show("Mazeret kaydı başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMazeretGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenMazeretID == -1)
            {
                MessageBox.Show("Güncellemek için listeden bir mazeret kaydı seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMazeretPersonel.SelectedValue == null || cmbMazeretPersonel.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir personel seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMazeretTuru.SelectedItem == null || cmbMazeretTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen mazeret türünü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int personelID = Convert.ToInt32(cmbMazeretPersonel.SelectedValue);
            DateTime tarih = dtpMazeretTarih.Value.Date;
            string mazeretTuru = cmbMazeretTuru.SelectedItem.ToString();
            bool uygun = chkMazeretUygun.Checked;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "UPDATE Personel_Durum SET PersonelID = @PersonelID, Tarih = @Tarih, MazeretTuru = @MazeretTuru, Uygun = @Uygun WHERE DurumID = @DurumID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonelID", personelID);
                        cmd.Parameters.AddWithValue("@Tarih", tarih);
                        cmd.Parameters.AddWithValue("@MazeretTuru", mazeretTuru);
                        cmd.Parameters.AddWithValue("@Uygun", uygun);
                        cmd.Parameters.AddWithValue("@DurumID", _secilenMazeretID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadMazeretler(txtMazeretAra.Text.Trim());
                btnMazeretTemizle_Click(null, null);
                MessageBox.Show("Mazeret kaydı başarıyla güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMazeretSil_Click(object sender, EventArgs e)
        {
            if (_secilenMazeretID == -1)
            {
                MessageBox.Show("Silmek için listeden bir mazeret kaydı seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili mazeret kaydını silmek istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "DELETE FROM Personel_Durum WHERE DurumID = @DurumID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DurumID", _secilenMazeretID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadMazeretler(txtMazeretAra.Text.Trim());
                btnMazeretTemizle_Click(null, null);
                MessageBox.Show("Mazeret kaydı başarıyla silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMazeretTemizle_Click(object sender, EventArgs e)
        {
            txtMazeretAra.Clear();
            _secilenMazeretID = -1;
            dgvMazeretler.ClearSelection();
            cmbMazeretPersonel.SelectedIndex = -1;
            dtpMazeretTarih.Value = DateTime.Today;
            cmbMazeretTuru.SelectedIndex = -1;
            chkMazeretUygun.Checked = false;
        }
    }
}
