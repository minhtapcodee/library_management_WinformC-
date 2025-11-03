using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QUANLYTHUVIENC3.DAL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmThongKeTongHop : Form
    {
        private MuonTraDAL dal;
        private System.Windows.Forms.Timer refreshTimer;

        public frmThongKeTongHop()
        {
            InitializeComponent();
            dal = new MuonTraDAL();
            // Đảm bảo DataGridView tự động tạo cột
            dgvTongMuon.AutoGenerateColumns = true;
            LoadData();

            // Thiết lập Timer để làm mới mỗi 30 giây
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 30000; // 30 giây
            refreshTimer.Tick += (s, e) => LoadData();
            refreshTimer.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            refreshTimer.Stop();
            refreshTimer.Dispose();
        }

        private void LoadData()
        {
            LoadThongKeHomNay(); // Đưa thống kê hôm nay lên đầu
            LoadTongSoLanMuon();
            LoadThongKeSach();
            //LoadThongKeDocGia(); // Đưa thống kê độc giả xuống cuối
        }

        // Thống kê số người mượn hôm nay
        private void LoadThongKeHomNay()
        {
            try
            {
                DateTime ngayHomNay = DateTime.Today;
                int soNguoiMuon = dal.DemSoNguoiMuonTheoNgay(ngayHomNay);
                lblSoNguoiMuonHomNay.Text = $"Số người mượn hôm nay: {soNguoiMuon}";

                // Hiển thị danh sách độc giả mượn hôm nay
                DataTable dt = dal.LayDanhSachNguoiMuonTheoNgay(ngayHomNay);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu mượn sách hôm nay để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvNguoiMuonHomNay.DataSource = dt;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception in LoadThongKeHomNay: {ex.Message}, StackTrace: {ex.StackTrace}");
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTongSoLanMuon()
        {
            try
            {
                int tongSoLanMuon = dal.DemTongSoLanMuon();
                lblTongSoLanMuon.Text = $"Tổng số lần mượn: {tongSoLanMuon}";

                // Hiển thị tất cả mượn trả lên dgvTongMuon
                DataTable dt = dal.LayTatCaMuonTra();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu mượn trả để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Debug: Kiểm tra dữ liệu trả về từ LayTatCaMuonTra
                System.Diagnostics.Debug.WriteLine($"Total records in dt (LayTatCaMuonTra): {dt.Rows.Count}");
                foreach (DataRow row in dt.Rows)
                {
                    System.Diagnostics.Debug.WriteLine($"MaMT: {row["MaMT"]}, TenSach: {row["TenSach"]}, TenNguoiMuon: {row["TenNguoiMuon"]}, NgayMuon: {row["NgayMuon"]}, TrangThai: {row["TrangThai"]}");
                }

                // Tắt tự động tạo cột và định nghĩa cột thủ công
                dgvTongMuon.AutoGenerateColumns = false;
                dgvTongMuon.Columns.Clear();

                // Thêm các cột với DataPropertyName
                dgvTongMuon.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TenSach",
                    HeaderText = "Tên sách",
                    DataPropertyName = "TenSach",
                    Width = 200
                });
                dgvTongMuon.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TenNguoiMuon",
                    HeaderText = "Người mượn",
                    DataPropertyName = "TenNguoiMuon",
                    Width = 150
                });
                dgvTongMuon.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "NgayMuon",
                    HeaderText = "Ngày mượn",
                    DataPropertyName = "NgayMuon",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
                });
                dgvTongMuon.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TrangThai",
                    HeaderText = "Trạng thái",
                    DataPropertyName = "TrangThai",
                    Width = 100
                });

                // Gán DataSource để tự động ánh xạ dữ liệu
                dgvTongMuon.DataSource = dt;

                // Kiểm tra xem các bản ghi mượn hôm nay có trong dgvTongMuon không
                DateTime ngayHomNay = DateTime.Today;
                int soNguoiMuonHomNay = dal.DemSoNguoiMuonTheoNgay(ngayHomNay);
                System.Diagnostics.Debug.WriteLine($"Số người mượn hôm nay (DemSoNguoiMuonTheoNgay): {soNguoiMuonHomNay}");

                bool foundToday = false;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["NgayMuon"] != DBNull.Value)
                    {
                        DateTime ngayMuon;
                        if (DateTime.TryParse(row["NgayMuon"].ToString(), out ngayMuon))
                        {
                            System.Diagnostics.Debug.WriteLine($"So sánh: ngayMuon.Date = {ngayMuon.Date}, ngayHomNay = {ngayHomNay}");
                            if (ngayMuon.Date == ngayHomNay)
                            {
                                foundToday = true;
                                System.Diagnostics.Debug.WriteLine($"Tìm thấy bản ghi mượn hôm nay: MaMT = {row["MaMT"]}");
                                break;
                            }
                        }
                    }
                }

                if (!foundToday && soNguoiMuonHomNay > 0)
                {
                    MessageBox.Show("Dữ liệu mượn hôm nay chưa được đồng bộ trong danh sách tổng mượn trả. Vui lòng kiểm tra lại cơ sở dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception in LoadTongSoLanMuon: {ex.Message}, StackTrace: {ex.StackTrace}");
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Thống kê số lần mượn của mỗi quyển sách
        private void LoadThongKeSach()
        {
            try
            {
                // Lấy dữ liệu
                Dictionary<string, int> thongKeSach = dal.ThongKeSoLanMuonCuaSach();

                // Hiển thị trên DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("Tên sách", typeof(string));
                dt.Columns.Add("Số lần mượn", typeof(int));
                foreach (var item in thongKeSach)
                {
                    dt.Rows.Add(item.Key, item.Value);
                }
                dgvThongKeSach.DataSource = dt;

                // Hiển thị trên biểu đồ
                chartThongKeSach.Series.Clear();
                chartThongKeSach.ChartAreas.Clear();
                chartThongKeSach.ChartAreas.Add(new ChartArea("MainArea"));

                chartThongKeSach.ChartAreas["MainArea"].AxisY.LabelStyle.Format = "N0";
                chartThongKeSach.ChartAreas["MainArea"].AxisY.Interval = 1;
                chartThongKeSach.ChartAreas["MainArea"].AxisY.Title = "Số lần mượn";
                chartThongKeSach.ChartAreas["MainArea"].AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chartThongKeSach.ChartAreas["MainArea"].AxisY.LabelStyle.Font = new Font("Arial", 9);

                chartThongKeSach.ChartAreas["MainArea"].AxisX.Title = "Tên sách";
                chartThongKeSach.ChartAreas["MainArea"].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chartThongKeSach.ChartAreas["MainArea"].AxisX.LabelStyle.Font = new Font("Arial", 9);
                chartThongKeSach.ChartAreas["MainArea"].AxisX.LabelStyle.Angle = -45;

                chartThongKeSach.ChartAreas["MainArea"].BackColor = Color.WhiteSmoke;
                chartThongKeSach.ChartAreas["MainArea"].BorderDashStyle = ChartDashStyle.Solid;
                chartThongKeSach.ChartAreas["MainArea"].BorderColor = Color.DarkGray;
                chartThongKeSach.ChartAreas["MainArea"].BorderWidth = 1;

                chartThongKeSach.Titles.Clear();
                chartThongKeSach.Titles.Add("Thống kê số lần mượn của mỗi quyển sách");
                chartThongKeSach.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);
                chartThongKeSach.Titles[0].ForeColor = Color.DarkBlue;

                Series series = new Series("Số lần mượn");
                series.ChartType = SeriesChartType.Column;
                series.ChartArea = "MainArea";
                series.IsValueShownAsLabel = true;
                series["LabelStyle"] = "Top";
                series.Font = new Font("Arial", 9, FontStyle.Bold);
                series["PointWidth"] = "0.7";

                Color[] colors = { Color.SkyBlue, Color.LightGreen, Color.Orange, Color.Red, Color.Purple, Color.Yellow };
                int i = 0;
                foreach (var item in thongKeSach)
                {
                    int pointIndex = series.Points.AddXY(item.Key, item.Value);
                    series.Points[pointIndex].Color = colors[i % colors.Length];
                    i++;
                }

                chartThongKeSach.Series.Add(series);
                chartThongKeSach.Invalidate();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception in LoadThongKeSach: {ex.Message}, StackTrace: {ex.StackTrace}");
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thống kê số lần mượn của một độc giả
        //private void LoadThongKeDocGia()
        //{
        //    try
        //    {
        //        // Lấy danh sách độc giả
        //        DataTable dtDocGia = dal.LayDocGia();
        //        cbDocGia.DataSource = dtDocGia;
        //        cbDocGia.DisplayMember = "HoTen";
        //        cbDocGia.ValueMember = "ID";

        //        // Hiển thị số lần mượn của độc giả đầu tiên
        //        if (cbDocGia.SelectedValue != null)
        //        {
        //            int maDocGia = Convert.ToInt32(cbDocGia.SelectedValue);
        //            int soLanMuon = dal.DemSoLanMuonCuaDocGia(maDocGia);
        //            lblSoLanMuon.Text = $"Số lần mượn: {soLanMuon}";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine($"Exception in LoadThongKeDocGia: {ex.Message}, StackTrace: {ex.StackTrace}");
        //        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void cbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cbDocGia.SelectedValue != null)
        //        {
        //            int maDocGia = Convert.ToInt32(cbDocGia.SelectedValue);
        //            int soLanMuon = dal.DemSoLanMuonCuaDocGia(maDocGia);
        //            lblSoLanMuon.Text = $"Số lần mượn: {soLanMuon}";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine($"Exception in cbDocGia_SelectedIndexChanged: {ex.Message}, StackTrace: {ex.StackTrace}");
        //        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void dgvThongKeSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void chartThongKeSach_Click(object sender, EventArgs e)
        {
        }

        private void dgvTongMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ngayCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichSuNhapXuat frm = new frmLichSuNhapXuat();
            this.ShowDialog();
        }
    }
}