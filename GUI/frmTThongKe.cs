using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using QUANLYTHUVIENC3.BLL;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using ClosedXML.Excel;
using ScottPlot;
using ScottPlot.WinForms;
using Color = System.Drawing.Color;
using ScottPlot.Plottables;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmTThongKe : Form
    {
        private SachBLL sachBLL = new SachBLL();
        private DocGiaBLL docGiaBLL = new DocGiaBLL();
        private TheLoaiSachBLL theLoaiBLL = new TheLoaiSachBLL();
        private MuonTraBLL sachTraBLL = new MuonTraBLL();

        public frmTThongKe()
        {
            InitializeComponent();

            // Gán sự kiện cho các nút
            btnXuatBaoCao.MouseEnter += btnXuatBaoCao_MouseEnter;
            btnXuatBaoCao.MouseLeave += btnXuatBaoCao_MouseLeave;
            btnApDungLoc.MouseEnter += btnApDungLoc_MouseEnter;
            btnApDungLoc.MouseLeave += btnApDungLoc_MouseLeave;

            // Gán sự kiện Click cho lblThongKeSachMuon
            lblThongKeSachMuonValue.Click += lblThongKeSachMuon_Click;
            this.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền form con
            this.Dock = DockStyle.Fill; // Đảm bảo form con lấp đầy khu vực MDI
            this.AutoSize = true; // Tự động điều chỉnh kích thước
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoSize = false;

            // Cấu hình ban đầu cho DataGridView
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // Tắt chỉnh sửa trực tiếp
            dataGridViewThongKe.ReadOnly = true;
            dataGridViewThongKe.AllowUserToAddRows = false;
            dataGridViewThongKe.AllowUserToDeleteRows = false;
            dataGridViewThongKe.AllowUserToResizeRows = false;

            // Cấu hình màu sắc và font cho tiêu đề cột
            dataGridViewThongKe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80); // Màu xanh đậm
            dataGridViewThongKe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewThongKe.EnableHeadersVisualStyles = false; // Tắt style mặc định để áp dụng màu tùy chỉnh

            // Cấu hình màu xen kẽ cho các dòng
            dataGridViewThongKe.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewThongKe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Màu xanh nhạt xen kẽ

            // Cấu hình viền
            dataGridViewThongKe.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewThongKe.GridColor = Color.FromArgb(200, 200, 200); // Màu viền xám nhạt

            // Font cho nội dung
            dataGridViewThongKe.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Tắt chọn toàn bộ hàng
            dataGridViewThongKe.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewThongKe.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Màu xanh nhạt khi chọn
            dataGridViewThongKe.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadThongTinTongQuan();
            LoadBieuDoNhaXuatBan();
            ThietLapCacDieuKhienLoc();
            LoadChart();
        }

        private void LoadChart()
        {
            // Lấy dữ liệu từ BLL
            Dictionary<string, int> duLieu = sachBLL.ThongKeSachTheoTheLoai();

            // Chuyển đổi dữ liệu
            string[] categories = new string[duLieu.Count];
            int[] values = new int[duLieu.Count];
            int index = 0;

            foreach (var item in duLieu)
            {
                categories[index] = item.Key;
                values[index] = item.Value;
                index++;
            }

            // Tạo màu ngẫu nhiên cho từng cột
            var random = new Random();
            var colors = new Color[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                colors[i] = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }

            // Xóa biểu đồ cũ
            formsPlot1.Plot.Clear();

            // Tạo cột với khoảng cách lớn hơn để cột trông mỏng hơn
            double[] positions = new double[categories.Length];
            double spacing = 1.5; // Tăng khoảng cách giữa các cột (giá trị càng lớn, cột càng "mỏng" hơn)
            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = i * spacing; // Tăng khoảng cách giữa các cột
            }

            for (int i = 0; i < positions.Length; i++)
            {
                var bar = formsPlot1.Plot.Add.Bar(position: positions[i], value: values[i]);
                bar.Color = ScottPlot.Color.FromColor(colors[i]);
            }

            // Nhãn trục X
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                positions,
                categories
            );

            // Đảm bảo trục Y chỉ hiển thị số nguyên
            double maxValue = values.Max();
            double[] yTicks = Enumerable.Range(0, (int)maxValue + 1).Select(i => (double)i).ToArray();
            string[] yLabels = yTicks.Select(i => i.ToString("0")).ToArray();
            formsPlot1.Plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericManual(yTicks, yLabels);

            // Giao diện biểu đồ
            formsPlot1.Plot.Axes.Left.Label.Text = "Số lượng sách";
            formsPlot1.Plot.Axes.Bottom.Label.Text = "Thể loại sách";
            formsPlot1.Plot.Title("Thống kê số sách theo thể loại");

            // Hiển thị lưới
            formsPlot1.Plot.ShowAxesAndGrid();

            // Làm mới biểu đồ
            formsPlot1.Refresh();
        }

        public void RefreshChart()
        {
            LoadChart();
        }

        private void LoadThongTinTongQuan()
        {
            int tongDauSach = sachBLL.DemTongDauSach();
            int tongQuyenSach = sachBLL.DemTongSach();
            int tongTheLoai = theLoaiBLL.DemTongTheLoai();
            DataTable dt = sachTraBLL.LayMuonTraTheoTrangThai("Đang mượn");
            int tongSachDangMuon = dt.Rows.Count; // Sẽ trả về 17 nếu chưa sửa JOIN
            lblTongSachDangMuonValue.Text = tongSachDangMuon.ToString();
            // Fetch the count of books borrowed today
            frmThongKeHomNay thongKeHomNay = new frmThongKeHomNay();
            int soSachMuonHomNay = thongKeHomNay.GetSoSachMuonHomNay();

            lblTongSachValue.Text = tongDauSach.ToString();
            lblTongQuyenSachValue.Text = tongQuyenSach.ToString();
            lblTongDocGiaValue.Text = docGiaBLL.DemTongDocGia().ToString();
            lblTongTheLoaiValue.Text = tongTheLoai.ToString();
            lblTongSachDangMuonValue.Text = tongSachDangMuon.ToString();
            lblSachMuonHomNayValue.Text = soSachMuonHomNay.ToString(); // Display the count in the new label
            lblThongKeSachMuonValue.Text = "";
        }

        private void ThietLapCacDieuKhienLoc()
        {
            cboTieuChiLoc.Items.AddRange(new string[] { "Thể loại", "Nhà xuất bản", "Tác giả", "Năm xuất bản", "Tồn kho", "Tình trạng sách" });
            cboTieuChiLoc.SelectedIndex = 0;

            btnApDungLoc.Click += BtnApDungLoc_Click;
            btnXuatBaoCao.Click += BtnXuatBaoCao_Click;
        }

        private void BtnApDungLoc_Click(object sender, EventArgs e)
        {
            string tieuChi = cboTieuChiLoc.SelectedItem?.ToString();
            switch (tieuChi)
            {
                case "Thể loại":
                    LoadThongKeTheoTheLoai();
                    break;
                case "Nhà xuất bản":
                    LoadThongKeTheoNhaXuatBan();
                    break;
                case "Tác giả":
                    LoadThongKeTheoTacGia();
                    break;
                case "Năm xuất bản":
                    LoadThongKeTheoNamXuatBan();
                    break;
                case "Tồn kho":
                    LoadThongKeTonKho();
                    break;
                case "Tình trạng sách":
                    LoadThongKeTinhTrangSach();
                    break;
            }
        }

        private void LoadBieuDoNhaXuatBan()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                Dictionary<string, int> thongKe = sachBLL.ThongKeNhapSachTheoThang();

                // Kiểm tra dữ liệu
                if (thongKe == null || thongKe.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu sách nhập để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sắp xếp dữ liệu theo tháng
                var sortedThongKe = thongKe.OrderBy(x =>
                {
                    if (!int.TryParse(x.Key, out int month))
                    {
                        throw new ArgumentException("Định dạng tháng không hợp lệ: " + x.Key);
                    }
                    return month;
                }).ToDictionary(x => x.Key, x => x.Value);

                // Chuyển đổi dữ liệu
                string[] months = new string[sortedThongKe.Count];
                double[] values = new double[sortedThongKe.Count];
                int index = 0;

                foreach (var item in sortedThongKe)
                {
                    if (index >= months.Length || index >= values.Length)
                    {
                        throw new IndexOutOfRangeException("Chỉ số vượt quá giới hạn mảng khi gán dữ liệu.");
                    }
                    months[index] = item.Key;
                    values[index] = item.Value;
                    index++;
                }

                // Tạo vị trí cho trục X
                double[] positions = new double[months.Length];
                for (int i = 0; i < positions.Length; positions[i] = i++) ;

                // Xóa biểu đồ cũ trên formsPlot2
                if (formsPlot2 == null)
                {
                    throw new NullReferenceException("Control formsPlot2 không được khởi tạo.");
                }
                formsPlot2.Plot.Clear();

                // Tạo biểu đồ đường
                var scatter = formsPlot2.Plot.Add.Scatter(positions, values);
                scatter.Color = ScottPlot.Color.FromColor(Color.FromArgb(0, 120, 215));
                scatter.LineWidth = 2;
                scatter.MarkerSize = 5;
                scatter.Label = "Số sách nhập";

                // Nhãn trục X
                formsPlot2.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(positions, months);

                // Đảm bảo trục Y hiển thị các giá trị chia hết cho 10
                double maxValue = values.Length > 0 ? values.Max() : 0;
                double minValue = values.Length > 0 ? values.Min() : 0;
                maxValue = Math.Ceiling(maxValue / 10.0) * 10;
                minValue = Math.Floor(minValue / 10.0) * 10;
                if (maxValue == minValue) maxValue += 10;

                int step = 10;
                int tickCount = (int)((maxValue - minValue) / step) + 1;
                double[] yTicks = new double[tickCount];
                string[] yLabels = new string[tickCount];
                for (int i = 0; i < tickCount; i++)
                {
                    yTicks[i] = minValue + (i * step);
                    yLabels[i] = yTicks[i].ToString("0");
                }
                formsPlot2.Plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericManual(yTicks, yLabels);

                // Giao diện biểu đồ
                formsPlot2.Plot.Axes.Left.Label.Text = "Số lượng sách nhập";
                formsPlot2.Plot.Axes.Bottom.Label.Text = "Tháng";
                formsPlot2.Plot.Title("Thống kê sách nhập theo tháng");

                // Hiển thị lưới
                formsPlot2.Plot.ShowAxesAndGrid();

                // Làm mới biểu đồ
                formsPlot2.Refresh();

                // Thêm tooltip thủ công bằng sự kiện MouseMove
                ToolTip tooltip = new ToolTip();
                // Tùy chỉnh giao diện tooltip
                tooltip.BackColor = Color.FromArgb(44, 62, 80); // Màu xanh đậm giống tiêu đề DataGridView
                tooltip.ForeColor = Color.White; // Chữ màu trắng
                tooltip.IsBalloon = true; // Sử dụng kiểu tooltip dạng bóng bay
                tooltip.ToolTipTitle = "Thông tin sách nhập"; // Tiêu đề cho tooltip
                tooltip.UseFading = true; // Hiệu ứng mờ dần khi hiện/ẩn
                tooltip.AutoPopDelay = 5000; // Hiển thị trong 5 giây (tăng từ 2 giây)
                tooltip.InitialDelay = 200; // Thời gian chờ trước khi hiển thị (ms)
                tooltip.ReshowDelay = 100; // Thời gian chờ khi di chuột sang điểm khác (ms)

                // Font chữ cho tooltip
                tooltip.OwnerDraw = true; // Cho phép tùy chỉnh vẽ tooltip
                tooltip.Draw += (sender, e) =>
                {
                    e.DrawBackground(); // Vẽ nền
                    e.DrawBorder(); // Vẽ viền

                    using (FontFamily fontFamily = new FontFamily("Segoe UI"))
                    using (Font font = new Font(fontFamily, 9, System.Drawing.FontStyle.Bold))
                    {
                        e.Graphics.DrawString(
                            e.ToolTipText,
                            font,
                            Brushes.White,
                            new PointF(e.Bounds.X + 5, e.Bounds.Y + 5)
                        );
                    }
                };

                // Biến để theo dõi trạng thái tooltip và tránh nhấp nháy
                string lastTooltipText = null;

                formsPlot2.MouseMove += (s, e) =>
                {
                    // Lấy vị trí chuột trong pixel
                    var mousePos = e.Location;

                    // Chuyển đổi vị trí pixel thành tọa độ dữ liệu
                    var coords = formsPlot2.Plot.GetCoordinates(mousePos.X, mousePos.Y);
                    double mouseX = coords.X;
                    double mouseY = coords.Y;

                    // Tìm điểm dữ liệu gần nhất
                    double minDistance = double.MaxValue;
                    int closestIndex = -1;
                    for (int i = 0; i < positions.Length; i++)
                    {
                        double dx = mouseX - positions[i];
                        double dy = mouseY - values[i];
                        double distance = Math.Sqrt(dx * dx + dy * dy);
                        if (distance < minDistance && distance < 0.5) // Ngưỡng khoảng cách
                        {
                            minDistance = distance;
                            closestIndex = i;
                        }
                    }

                    // Hiển thị tooltip nếu tìm thấy điểm gần
                    if (closestIndex >= 0)
                    {
                        string tooltipText = $"Tháng: {months[closestIndex]}\nSố lượng sách nhập: {(int)values[closestIndex]}";
                        if (tooltipText != lastTooltipText) // Tránh nhấp nháy khi cùng nội dung
                        {
                            tooltip.Show(tooltipText, formsPlot2, mousePos.X + 20, mousePos.Y - 30); // Dịch chuyển tooltip lên trên và sang phải
                            lastTooltipText = tooltipText;
                        }
                    }
                    else
                    {
                        tooltip.Hide(formsPlot2); // Ẩn tooltip nếu không gần điểm nào
                        lastTooltipText = null;
                    }
                };
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show($"Lỗi chỉ số vượt giới hạn mảng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Lỗi định dạng dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Lỗi control không tồn tại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải biểu đồ nhập sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongKeTheoTheLoai()
        {
            dataGridViewThongKe.DataSource = sachBLL.GetThongKeSachTheoTheLoai();
            FormatDataGridViewColumns(new[] { "Tên thể loại", "Số lượng sách" }, new[] { 800, 800 });
        }

        private void LoadThongKeTheoNhaXuatBan()
        {
            dataGridViewThongKe.DataSource = sachBLL.GetThongKeSachTheoNhaXuatBan();
            FormatDataGridViewColumns(new[] { "Nhà xuất bản", "Số lượng sách" }, new[] { 800, 800 });
        }

        private void LoadThongKeTheoTacGia()
        {
            dataGridViewThongKe.DataSource = sachBLL.GetThongKeSachTheoTacGia();
            FormatDataGridViewColumns(new[] { "Tác giả", "Số lượng sách" }, new[] { 800, 800 });
        }

        private void LoadThongKeTheoNamXuatBan()
        {
            dataGridViewThongKe.DataSource = sachBLL.GetThongKeSachTheoNamXuatBan();
            FormatDataGridViewColumns(new[] { "Năm xuất bản", "Số lượng sách" }, new[] { 800, 800 });
        }

        private void LoadThongKeTonKho()
        {
            dataGridViewThongKe.DataSource = sachBLL.GetThongKeTonKho();
            FormatDataGridViewColumns(new[] { "Tên sách", "Số lượng tồn kho" }, new[] { 800, 800 });
        }

        private void LoadThongKeTinhTrangSach()
        {
            dataGridViewThongKe.DataSource = sachBLL.GetThongKeTinhTrangSach();
            FormatDataGridViewColumns(new[] { "Tên sách", "Tình trạng" }, new[] { 800, 800 });
        }

        private void FormatDataGridViewColumns(string[] columnNames, int[] columnWidths)
        {
            if (dataGridViewThongKe.Columns.Count == 0) return;

            for (int i = 0; i < dataGridViewThongKe.Columns.Count && i < columnNames.Length; i++)
            {
                dataGridViewThongKe.Columns[i].HeaderText = columnNames[i];
                dataGridViewThongKe.Columns[i].Width = columnWidths[i];

                // Căn chỉnh nội dung tùy theo cột
                if (columnNames[i].Contains("Số lượng"))
                {
                    dataGridViewThongKe.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridViewThongKe.Columns[i].DefaultCellStyle.Format = "N0"; // Định dạng số không thập phân
                }
                else
                {
                    dataGridViewThongKe.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }

                // Thêm padding cho nội dung ô
                dataGridViewThongKe.Columns[i].DefaultCellStyle.Padding = new Padding(5);
            }

            // Tự động điều chỉnh độ rộng cột nếu tổng chiều rộng nhỏ hơn DataGridView
            int totalWidth = 0;
            foreach (DataGridViewColumn col in dataGridViewThongKe.Columns)
            {
                totalWidth += col.Width;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (totalWidth < dataGridViewThongKe.Width)
            {
                dataGridViewThongKe.Columns[dataGridViewThongKe.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BtnXuatBaoCao_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Files|*.xlsx", FileName = "ThongKeSach.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dt = (DataTable)dataGridViewThongKe.DataSource;
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("ThongKeSach");

                            // Thêm tiêu đề cột
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dt.Columns[i].ColumnName;
                                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                                worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                            }

                            // Thêm dữ liệu
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dt.Rows[i][j].ToString();
                                }
                            }

                            // Tự động điều chỉnh độ rộng cột
                            worksheet.Columns().AdjustToContents();

                            // Lưu file
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất báo cáo Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lblTongSach_Click(object sender, EventArgs e) => new frmTongSach().ShowDialog();
        private void lblTongDocGia_Click(object sender, EventArgs e) => new frmTongDocGia().ShowDialog();
        private void lblTongTheLoai_Click(object sender, EventArgs e) => new frmTongTheLoai().ShowDialog();
        private void lblTongSachDangMuon_Click(object sender, EventArgs e) => new frmSachDangMuon().ShowDialog();
        private void lblTongSachMatHong_Click(object sender, EventArgs e) { }

        private void lblThongKeSachMuon_Click(object sender, EventArgs e)
        {
            new frmThongKeHomNay().ShowDialog();
        }

        private void btnXuatBaoCao_MouseEnter(object sender, EventArgs e)
        {
            btnXuatBaoCao.BackColor = Color.FromArgb(0, 224, 0);
        }

        private void btnXuatBaoCao_MouseLeave(object sender, EventArgs e)
        {
            btnXuatBaoCao.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void btnApDungLoc_MouseEnter(object sender, EventArgs e)
        {
            btnApDungLoc.BackColor = Color.FromArgb(0, 150, 255);
        }

        private void btnApDungLoc_MouseLeave(object sender, EventArgs e)
        {
            btnApDungLoc.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // Reload all data on the form
                LoadThongTinTongQuan(); // Refresh overview statistics (labels)
                LoadChart(); // Refresh the category chart (formsPlot1)
                LoadBieuDoNhaXuatBan(); // Refresh the publisher chart (formsPlot2)
                BtnApDungLoc_Click(sender, e); // Reapply the current filter to refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSachMuonHomNayValue_Click(object sender, EventArgs e)
        {
            new frmThongKeHomNay().ShowDialog();
        }

        private void lblTongTheLoaiTitle_Click(object sender, EventArgs e)
        {

        }
    }
}