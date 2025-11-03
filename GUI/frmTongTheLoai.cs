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
    public partial class frmTongTheLoai : Form
    {
        private TheLoaiSachBLL theLoaiBLL;
        private DataTable duLieuGoc;

        public frmTongTheLoai()
        {
            InitializeComponent();
            theLoaiBLL = new TheLoaiSachBLL();
            ThietLapGiaoDien();
        }

        private void ThietLapGiaoDien()
        {
            // Thiết lập giao diện form hiện đại
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.MaximizeBox = false;
            this.Text = "Quản Lý Thể Loại Sách";

            // Tùy chỉnh DataGridView
            dgvTheLoai.BackgroundColor = Color.White;
            dgvTheLoai.BorderStyle = BorderStyle.None;
            dgvTheLoai.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTheLoai.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTheLoai.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvTheLoai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTheLoai.EnableHeadersVisualStyles = false;
            dgvTheLoai.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm bảng điều khiển bộ lọc
            var panelLoc = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(10),
                BackColor = Color.FromArgb(230, 230, 230)
            };

            var lblTimKiem = new Label
            {
                Text = "Tìm kiếm:",
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Margin = new Padding(10, 15, 5, 0)
            };

            var txtTimKiem = new TextBox
            {
                Width = 200,
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
            panelLoc.Controls.AddRange(new Control[] { lblTimKiem, txtTimKiem, btnLoc, btnXoaLoc, btnXuatExcel, btnThoat });

            // Thêm bảng điều khiển vào form
            this.Controls.Add(panelLoc);

            // Thiết lập DataGridView
            dgvTheLoai.Dock = DockStyle.Fill;

            // Gắn sự kiện
            btnLoc.Click += (s, e) => LocDuLieu(txtTimKiem.Text);
            btnXoaLoc.Click += (s, e) => XoaBoLoc();
            btnXuatExcel.Click += (s, e) => XuatDataGridViewRaExcel(dgvTheLoai, "DanhSachTheLoaiSach.xlsx");
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
                    var worksheet = workbook.Worksheets.Add("DanhSachTheLoaiSach");

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

        private void frmTongTheLoai_Load(object sender, EventArgs e)
        {
            duLieuGoc = theLoaiBLL.GetAllTheLoaiSach();
            dgvTheLoai.DataSource = duLieuGoc;
        }

        private void LocDuLieu(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                XoaBoLoc();
                return;
            }

            try
            {
                // Lọc dữ liệu theo mã hoặc tên thể loại
                DataTable duLieuLoc = duLieuGoc.Clone();
                tuKhoa = tuKhoa.Trim().ToLower();
                foreach (DataRow row in duLieuGoc.Rows)
                {
                    string maTheLoai = row["MaTL"]?.ToString().ToLower() ?? "";
                    string tenTheLoai = row["TenTheLoai"]?.ToString().ToLower() ?? "";
                    if (maTheLoai.Contains(tuKhoa) || tenTheLoai.Contains(tuKhoa))
                    {
                        duLieuLoc.ImportRow(row);
                    }
                }
                dgvTheLoai.DataSource = duLieuLoc;

                if (duLieuLoc.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thể loại phù hợp với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaBoLoc()
        {
            dgvTheLoai.DataSource = duLieuGoc;
        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý khi người dùng nhấp vào ô trong DataGridView
            if (e.RowIndex >= 0 && e.RowIndex < dgvTheLoai.Rows.Count)
            {
                DataGridViewRow row = dgvTheLoai.Rows[e.RowIndex];
                StringBuilder thongTin = new StringBuilder("Thông tin thể loại:\n");

                // Lấy thông tin từ các cột
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string header = dgvTheLoai.Columns[cell.ColumnIndex].HeaderText;
                    string value = cell.Value?.ToString() ?? "N/A";
                    thongTin.AppendLine($"{header}: {value}");
                }

                MessageBox.Show(thongTin.ToString(), "Chi tiết thể loại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}