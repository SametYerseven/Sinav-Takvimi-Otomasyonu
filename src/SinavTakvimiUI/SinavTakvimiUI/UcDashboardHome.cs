using System;
using System.Windows.Forms;
using SinavTakvimiUI.Services;

namespace SinavTakvimiUI
{
    public partial class UcDashboardHome : UserControl
    {
        private readonly DashboardService _dashboardService = new DashboardService();

        public UcDashboardHome()
        {
            InitializeComponent();
        }

        private void UcDashboardHome_Load(object sender, EventArgs e)
        {
            try
            {
                lblDers.Text = _dashboardService.ToplamDers().ToString();
                lblPersonel.Text = _dashboardService.ToplamPersonel().ToString();
                lblSinav.Text = _dashboardService.ToplamSinav().ToString();
                lblSalon.Text = _dashboardService.ToplamSalon().ToString();

                dgvYaklasanSinavlar.DataSource = _dashboardService.YaklasanSinavlar();
                dgvYaklasanSinavlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvYaklasanSinavlar.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistikler yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
