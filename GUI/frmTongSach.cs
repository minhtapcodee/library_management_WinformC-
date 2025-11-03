using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using QUANLYTHUVIENC3.BLL;
using System.IO;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmTongSach : Form
    {
        private SachBLL sachBLL;
        private DataTable duLieuGoc;

        public frmTongSach()
        {
            InitializeComponent();
            sachBLL = new SachBLL();
            ThietLapGiaoDien();
        }

        private void ThietLapGiaoDien()
        {
            // Thiết lập giao diện form hiện đại
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.MaximizeBox = false;
            this.Text = "Quản Lý Sách";

            // Tùy chỉnh DataGridView
            dgvTongSach.BackgroundColor = Color.White;
            dgvTongSach.BorderStyle = BorderStyle.None;
            dgvTongSach.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTongSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTongSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvTongSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTongSach.EnableHeadersVisualStyles = false;
            dgvTongSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvTongSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm bảng điều khiển bộ lọc
            var panelLoc = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(10),
                BackColor = Color.FromArgb(230, 230, 230)
            };

            var lblTuNgay = new Label
            {
                Text = "Từ ngày:",
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Margin = new Padding(10, 15, 5, 0)
            };

            var dtpTuNgay = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Width = 120,
                Font = new Font("Segoe UI", 10),
                Margin = new Padding(0, 10, 10, 0)
            };

            var lblDenNgay = new Label
            {
                Text = "Đến ngày:",
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Margin = new Padding(10, 15, 5, 0)
            };

            var dtpDenNgay = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Width = 120,
                Font = new Font("Segoe UI", 10),
                Margin = new Padding(0, 10, 10, 0)
            };

            var btnLoc = new Button
            {
                Text = "Lọc",
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 80,
                Height = 30,
                Margin = new Padding(10, 10, 0, 0)
            };

            var btnXoaLoc = new Button
            {
                Text = "Xóa bộ lọc",
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 100,
                Height = 30,
                Margin = new Padding(5, 10, 0, 0)
            };

            var btnXuatExcel = new Button
            {
                Text = "Xuất Excel",
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 100,
                Height = 30,
                Margin = new Padding(5, 10, 0, 0)
            };

            var btnThoat = new Button
            {
                Text = "Thoát",
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 80,
                Height = 30,
                Margin = new Padding(5, 10, 10, 0)
            };

            // Thêm các điều khiển vào bảng điều khiển
            panelLoc.Controls.AddRange(new Control[] { lblTuNgay, dtpTuNgay, lblDenNgay, dtpDenNgay, btnLoc, btnXoaLoc, btnXuatExcel, btnThoat });

            // Thêm bảng điều khiển vào form
            this.Controls.Add(panelLoc);

            // Thiết lập DataGridView
            dgvTongSach.Dock = DockStyle.Fill;

            // Gắn sự kiện
            btnLoc.Click += (s, e) => LocDuLieu(dtpTuNgay.Value, dtpDenNgay.Value);
            btnXoaLoc.Click += (s, e) => XoaBoLoc();
            btnXuatExcel.Click += (s, e) => XuatDataGridViewRaExcel(dgvTongSach, "DanhSachSach.xlsx");
            btnThoat.Click += (s, e) => this.Close();
        }

        private void XuatDataGridViewRaExcel(DataGridView dgv, string tenFile)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Tệp Excel (*.xlsx)|*.xlsx",
                FileName = tenFile
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("DanhSachSach");

                    // Định dạng tiêu đề
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                        worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                        worksheet.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.FromArgb(0, 120, 215);
                        worksheet.Cell(1, col + 1).Style.Font.FontColor = XLColor.White;
                        worksheet.Cell(1, col + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    }

                    // Dữ liệu
                    for (int row = 0; row < dgv.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            if (dgv.Rows[row].Cells[col].Value != null)
                            {
                                worksheet.Cell(row + 2, col + 1).Value = dgv.Rows[row].Cells[col].Value.ToString();
                            }
                        }
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(saveDialog.FileName);
                }

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmTongSach_Load(object sender, EventArgs e)
        {
            duLieuGoc = sachBLL.GetAllSach();
            dgvTongSach.DataSource = duLieuGoc;
        }

        private void LocDuLieu(DateTime tuNgay, DateTime denNgay)
        {
            if (denNgay < tuNgay)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Sử dụng phương thức mới từ SachBLL để lọc theo ngày nhập
                DataTable duLieuLoc = sachBLL.GetSachByNgayNhap(tuNgay, denNgay);
                if (duLieuLoc == null || duLieuLoc.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách trong khoảng thời gian đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvTongSach.DataSource = duLieuLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaBoLoc()
        {
            dgvTongSach.DataSource = duLieuGoc;
        }

        private void dgvTongSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý khi người dùng nhấp vào ô trong DataGridView
            if (e.RowIndex >= 0 && e.RowIndex < dgvTongSach.Rows.Count)
            {
                DataGridViewRow row = dgvTongSach.Rows[e.RowIndex];
                StringBuilder thongTin = new StringBuilder("Thông tin sách:\n");

                // Lấy thông tin từ các cột
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string header = dgvTongSach.Columns[cell.ColumnIndex].HeaderText;
                    string value = cell.Value?.ToString() ?? "N/A";
                    thongTin.AppendLine($"{header}: {value}");
                }

                MessageBox.Show(thongTin.ToString(), "Chi tiết sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}