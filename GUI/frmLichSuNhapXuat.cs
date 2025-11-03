using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;
using ClosedXML.Excel;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmLichSuNhapXuat : Form
    {
        private KhoSachBLL khoSachBLL = new KhoSachBLL();
        private DataTable originalData; // Lưu trữ dữ liệu gốc để lọc và tìm kiếm

        public frmLichSuNhapXuat()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadLichSuNhapXuat();
        }

        private void InitializeDataGridView()
        {
            dgvLichSu.AutoGenerateColumns = false;
            dgvLichSu.Columns.Clear();

            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID"
            };
            dgvLichSu.Columns.Add(colID);

            DataGridViewTextBoxColumn colMaSach = new DataGridViewTextBoxColumn
            {
                Name = "MaSach",
                HeaderText = "Mã Sách",
                DataPropertyName = "MaSach"
            };
            dgvLichSu.Columns.Add(colMaSach);

            DataGridViewTextBoxColumn colTenSach = new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                HeaderText = "Tên Sách",
                DataPropertyName = "TenSach"
            };
            dgvLichSu.Columns.Add(colTenSach);

            DataGridViewTextBoxColumn colLoaiGiaoDich = new DataGridViewTextBoxColumn
            {
                Name = "LoaiGiaoDich",
                HeaderText = "Loại Giao Dịch",
                DataPropertyName = "LoaiGiaoDich"
            };
            dgvLichSu.Columns.Add(colLoaiGiaoDich);

            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "Số Lượng",
                DataPropertyName = "SoLuong"
            };
            dgvLichSu.Columns.Add(colSoLuong);

            DataGridViewTextBoxColumn colNgayGiaoDich = new DataGridViewTextBoxColumn
            {
                Name = "NgayGiaoDich",
                HeaderText = "Ngày Giao Dịch",
                DataPropertyName = "NgayGiaoDich"
            };
            dgvLichSu.Columns.Add(colNgayGiaoDich);

            DataGridViewTextBoxColumn colMaNhanVien = new DataGridViewTextBoxColumn
            {
                Name = "MaNhanVien",
                HeaderText = "Mã Nhân Viên",
                DataPropertyName = "MaNhanVien"
            };
            dgvLichSu.Columns.Add(colMaNhanVien);

            DataGridViewTextBoxColumn colMoTa = new DataGridViewTextBoxColumn
            {
                Name = "MoTa",
                HeaderText = "Mô Tả",
                DataPropertyName = "MoTa"
            };
            dgvLichSu.Columns.Add(colMoTa);

            foreach (DataGridViewColumn column in dgvLichSu.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Tùy chỉnh giao diện DataGridView
            dgvLichSu.BackgroundColor = Color.White;
            dgvLichSu.BorderStyle = BorderStyle.None;
            dgvLichSu.EnableHeadersVisualStyles = false;
            dgvLichSu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 115, 227);
            dgvLichSu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLichSu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvLichSu.ColumnHeadersHeight = 40;
            dgvLichSu.DefaultCellStyle.BackColor = Color.White;
            dgvLichSu.DefaultCellStyle.ForeColor = Color.Black;
            dgvLichSu.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvLichSu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
            dgvLichSu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(135, 171, 255);
            dgvLichSu.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvLichSu.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvLichSu.GridColor = Color.FromArgb(220, 220, 220);

            // Tùy chỉnh giao diện các nút
            Button[] buttons = { btnLoc, btnTimKiem, btnXuatExcel, btnLamMoi };
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(67, 115, 227);
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 149, 237);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 90, 200);
                btn.Size = new Size(100, 40);
                btn.Cursor = Cursors.Hand;
            }

            // Tùy chỉnh giao diện TextBox
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Font = new Font("Segoe UI", 10F);

            // Tùy chỉnh DateTimePicker
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 10F);

            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 10F);

            // Tùy chỉnh Label
            lblTuNgay.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblTuNgay.ForeColor = Color.FromArgb(50, 50, 50);

            lblDenNgay.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblDenNgay.ForeColor = Color.FromArgb(50, 50, 50);
        }

        private void LoadLichSuNhapXuat()
        {
            try
            {
                originalData = khoSachBLL.GetLichSuNhapXuat();
                if (originalData == null || originalData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có lịch sử nhập/xuất để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvLichSu.DataSource = null;
                dgvLichSu.DataSource = originalData;
                dgvLichSu.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (originalData == null || originalData.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable filteredData = originalData.Clone();
            foreach (DataRow row in originalData.Rows)
            {
                DateTime ngayGiaoDich = Convert.ToDateTime(row["NgayGiaoDich"]).Date;
                if (ngayGiaoDich >= tuNgay && ngayGiaoDich <= denNgay)
                {
                    filteredData.ImportRow(row);
                }
            }

            if (filteredData.Rows.Count == 0)
            {
                MessageBox.Show("Không có giao dịch nào trong khoảng thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvLichSu.DataSource = null;
            dgvLichSu.DataSource = filteredData;
            dgvLichSu.Refresh();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadLichSuNhapXuat();
                return;
            }

            if (originalData == null || originalData.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable searchedData = originalData.Clone();
            foreach (DataRow row in originalData.Rows)
            {
                if (row["MaSach"].ToString().ToLower().Contains(keyword) ||
                    row["TenSach"].ToString().ToLower().Contains(keyword) ||
                    row["LoaiGiaoDich"].ToString().ToLower().Contains(keyword))
                {
                    searchedData.ImportRow(row);
                }
            }

            if (searchedData.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy giao dịch nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvLichSu.DataSource = null;
            dgvLichSu.DataSource = searchedData;
            dgvLichSu.Refresh();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadLichSuNhapXuat();
            txtTimKiem.Clear();
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.DataSource == null || ((DataTable)dgvLichSu.DataSource).Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Lưu Báo Cáo Lịch Sử Nhập/Xuất";
                sfd.FileName = $"LichSuNhapXuat_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("LichSuNhapXuat");
                            DataTable dt = (DataTable)dgvLichSu.DataSource;

                            // Thêm tiêu đề cột
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dt.Columns[i].ColumnName;
                                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                                worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightBlue;
                                worksheet.Cell(1, i + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // Thêm dữ liệu
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dt.Rows[i][j]?.ToString();
                                }
                            }

                            // Điều chỉnh độ rộng cột
                            worksheet.Columns().AdjustToContents();

                            // Lưu file
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvLichSu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID của bản ghi được chọn (giả sử cột ID là cột đầu tiên)
            int selectedId = Convert.ToInt32(dgvLichSu.SelectedRows[0].Cells["ID"].Value);

            // Hiển thị thông báo xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bản ghi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                try
                {
                    // Gọi phương thức xóa trong BLL (sẽ gọi xuống DAL)
                    bool isDeleted = khoSachBLL.DeleteLichSuNhapXuat(selectedId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa bản ghi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLichSuNhapXuat(); // Tải lại dữ liệu để cập nhật DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Xóa bản ghi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa bản ghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}