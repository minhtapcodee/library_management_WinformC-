using QUANLYTHUVIENC3.BLL;
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

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmKhoSach : Form
    {
        private KhoSachBLL bll = new KhoSachBLL();
        private DataTable dtNhanVien;
        private DataTable dtKhoSach; // Lưu trữ dữ liệu gốc để lọc
        private int rowsPerPage = 7; // Số dòng mỗi trang
        private int currentPage = 1; // Trang hiện tại
        private int totalPages = 1; // Tổng số trang

        public frmKhoSach()
        {
            InitializeComponent();
        }

        private void CustomizeDataGridView()
        {
            dgvKhoSach.EnableHeadersVisualStyles = false;
            dgvKhoSach.ScrollBars = ScrollBars.None; // Tắt cả thanh cuộn ngang và dọc

            // Header
            dgvKhoSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 205, 50); // Bright spring green for headers
            dgvKhoSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhoSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKhoSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhoSach.ColumnHeadersHeight = 35;

            // Rows
            dgvKhoSach.DefaultCellStyle.BackColor = Color.White;
            dgvKhoSach.DefaultCellStyle.ForeColor = Color.Black;
            dgvKhoSach.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 225, 80); // Lighter spring green for selection
            dgvKhoSach.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvKhoSach.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Alternating row styles
            dgvKhoSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(204, 230, 204); // Soft mint green for alternating rows

            // Grid
            dgvKhoSach.GridColor = Color.FromArgb(200, 200, 200);
            dgvKhoSach.BorderStyle = BorderStyle.None;
            dgvKhoSach.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Misc
            dgvKhoSach.RowTemplate.Height = 35; // Tăng chiều cao dòng từ 30 lên 40
        }

        private void AlignDataGridViewCells()
        {
            foreach (DataGridViewColumn column in dgvKhoSach.Columns)
            {
                if (column.Name != "Mô tả")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void frmKhoSach_Load(object sender, EventArgs e)
        {
            dgvKhoSach.ColumnCount = 10;
            dgvKhoSach.Columns[0].Name = "Mã kho";
            dgvKhoSach.Columns[1].Name = "Mã sách";
            dgvKhoSach.Columns[2].Name = "Tên sách";
            dgvKhoSach.Columns[3].Name = "Thể loại";
            dgvKhoSach.Columns[4].Name = "Số lượng nhập kho";
            dgvKhoSach.Columns[5].Name = "Số lượng đang mượn";
            dgvKhoSach.Columns[6].Name = "Số lượng còn lại";
            dgvKhoSach.Columns[7].Name = "Tên nhân viên";
            dgvKhoSach.Columns[8].Name = "Ngày nhập";
            dgvKhoSach.Columns[9].Name = "Mô tả";

            // Tự động điều chỉnh độ rộng cột
            dgvKhoSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoSach.AllowUserToAddRows = false;

            // Tải dữ liệu
            LoadKhoSachData();

            // Tùy chỉnh giao diện
            CustomizeDataGridView();
            AlignDataGridViewCells();

            // Yêu cầu chọn toàn bộ hàng
            dgvKhoSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadKhoSachData()
        {
            dtKhoSach = bll.GetKhoSachData();
            dtNhanVien = bll.GetNhanVien();
            ApplyFilters();
            PopulateTenSachComboBox();
        }

        private void PopulateTenSachComboBox()
        {
            cboLocTheoSach.Items.Clear();
            cboLocTheoSach.Items.Add("Tất cả");
            var tenSachList = dtKhoSach.AsEnumerable()
                .Select(row => row["TenSach"].ToString())
                .Distinct()
                .OrderBy(name => name)
                .ToList();
            foreach (var tenSach in tenSachList)
            {
                cboLocTheoSach.Items.Add(tenSach);
            }
            cboLocTheoSach.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            var filteredRows = dtKhoSach.AsEnumerable();

            // Lọc theo tên sách
            string selectedTenSach = cboLocTheoSach.SelectedItem?.ToString();
            if (selectedTenSach != "Tất cả" && !string.IsNullOrEmpty(selectedTenSach))
            {
                filteredRows = filteredRows.Where(row => row["TenSach"].ToString() == selectedTenSach);
            }

            // Lọc theo ngày nhập kho
            if (chkLocTheoNgay.Checked)
            {
                DateTime selectedDate = dtpLocNgayNhapKho.Value.Date;
                filteredRows = filteredRows.Where(row =>
                    Convert.ToDateTime(row["NgayNhap"]).Date == selectedDate);
            }

            // Chuyển dữ liệu đã lọc thành danh sách
            var filteredList = filteredRows.ToList();

            // Tính toán phân trang
            int totalRows = filteredList.Count;
            totalPages = (int)Math.Ceiling((double)totalRows / rowsPerPage);
            if (currentPage > totalPages) currentPage = totalPages > 0 ? totalPages : 1;
            if (currentPage < 1) currentPage = 1;

            // Lấy dữ liệu cho trang hiện tại
            var pageRows = filteredList.Skip((currentPage - 1) * rowsPerPage).Take(rowsPerPage);

            // Hiển thị dữ liệu
            dgvKhoSach.Rows.Clear();
            foreach (var row in pageRows)
            {
                int maNhanVien = Convert.ToInt32(row["MaNhanVien"]);
                string tenNhanVien = dtNhanVien.AsEnumerable()
                    .Where(nv => nv.Field<int>("ID") == maNhanVien)
                    .Select(nv => nv.Field<string>("HoTen"))
                    .FirstOrDefault() ?? maNhanVien.ToString();

                dgvKhoSach.Rows.Add(
                    row["MaKho"],
                    row["MaSach"],
                    row["TenSach"],
                    row["TenTheLoai"],
                    row["SoLuongNhap"],
                    row["SoLuongDangMuon"],
                    row["SoLuongConLai"],
                    tenNhanVien,
                    Convert.ToDateTime(row["NgayNhap"]).ToString("dd/MM/yyyy"),
                    row["MoTa"]
                );
            }

            // Cập nhật nhãn phân trang
            lblPageInfo.Text = $"Trang {currentPage} / {totalPages}";
            btnPreviousPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmKhoSachThem frmAdd = new frmKhoSachThem();
            frmAdd.ShowDialog();
            currentPage = 1; // Reset về trang 1 sau khi thêm
            LoadKhoSachData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKhoSach.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvKhoSach.SelectedRows[0].Index;
                // Calculate the absolute index in the original dtKhoSach
                int absoluteIndex = ((currentPage - 1) * rowsPerPage) + selectedRowIndex;

                if (absoluteIndex >= 0 && absoluteIndex < dtKhoSach.Rows.Count)
                {
                    DataRow row = dtKhoSach.Rows[absoluteIndex];
                    int maKho = Convert.ToInt32(row["MaKho"]);
                    string maSach = row["MaSach"].ToString();
                    string tenSach = row["TenSach"].ToString();
                    int soLuongNhap = Convert.ToInt32(row["SoLuongNhap"]);
                    string ngayNhap = Convert.ToDateTime(row["NgayNhap"]).ToString("dd/MM/yyyy");
                    string moTa = row["MoTa"].ToString();
                    int maNhanVien = Convert.ToInt32(row["MaNhanVien"]);
                    DataTable dtNhanVien = bll.GetNhanVien();
                    string tenNhanVien = dtNhanVien.AsEnumerable()
                        .Where(nv => nv.Field<int>("ID") == maNhanVien)
                        .Select(nv => nv.Field<string>("HoTen"))
                        .FirstOrDefault() ?? maNhanVien.ToString();

                    frmKhoSachSua frmSua = new frmKhoSachSua();
                    frmSua.SetData(maKho, maSach, tenSach, soLuongNhap, ngayNhap, moTa, maNhanVien, tenNhanVien);
                    if (frmSua.ShowDialog() == DialogResult.OK)
                    {
                        currentPage = 1; // Reset về trang 1 sau khi sửa
                        LoadKhoSachData();
                    }
                }
                else
                {
                    MessageBox.Show("Dòng được chọn không hợp lệ!", "Cảnh báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Cảnh báo");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btxDelete_Click(object sender, EventArgs e)
        {
            if (dgvKhoSach.SelectedRows.Count > 0)
            {
                int maKho = Convert.ToInt32(dgvKhoSach.SelectedRows[0].Cells["Mã kho"].Value);
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = bll.DeleteKhoSach(maKho);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo");
                        currentPage = 1; // Reset về trang 1 sau khi xóa
                        LoadKhoSachData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sách. Vui lòng thử lại!", "Lỗi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Cảnh báo");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            dtKhoSach = bll.SearchKhoSach(keyword);
            currentPage = 1; // Reset về trang 1 sau khi tìm kiếm
            ApplyFilters();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            dtKhoSach = bll.SearchKhoSach(keyword);
            currentPage = 1; // Reset về trang 1 khi tìm kiếm
            ApplyFilters();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ApplyFilters();
            }
        }

        private void lblPageInfo_Click(object sender, EventArgs e)
        {
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                ApplyFilters();
            }
        }

        private void dgvKhoSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang 1 khi làm mới
            LoadKhoSachData();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (dgvKhoSach.SelectedRows.Count > 0)
            {
                int maKho = Convert.ToInt32(dgvKhoSach.SelectedRows[0].Cells["Mã kho"].Value);
                string maSach = dgvKhoSach.SelectedRows[0].Cells["Mã sách"].Value.ToString();
                string tenSach = dgvKhoSach.SelectedRows[0].Cells["Tên sách"].Value.ToString();
                string theLoai = dgvKhoSach.SelectedRows[0].Cells["Thể loại"].Value.ToString();
                int soLuongNhapKho = Convert.ToInt32(dgvKhoSach.SelectedRows[0].Cells["Số lượng nhập kho"].Value);
                int soLuongDangMuon = Convert.ToInt32(dgvKhoSach.SelectedRows[0].Cells["Số lượng đang mượn"].Value);
                int soLuongConLai = Convert.ToInt32(dgvKhoSach.SelectedRows[0].Cells["Số lượng còn lại"].Value);
                string tenNhanVien = dgvKhoSach.SelectedRows[0].Cells["Tên nhân viên"].Value.ToString();
                string ngayNhap = dgvKhoSach.SelectedRows[0].Cells["Ngày nhập"].Value.ToString();
                string mieuTa = dgvKhoSach.SelectedRows[0].Cells["Mô tả"].Value.ToString();

                frnKhoSachHienThi frmHienThi = new frnKhoSachHienThi();
                frmHienThi.SetData(maKho, maSach, tenSach, theLoai, soLuongNhapKho, soLuongDangMuon, soLuongConLai, tenNhanVien, ngayNhap, mieuTa);
                frmHienThi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để hiển thị thông tin!", "Cảnh báo");
            }
        }

        private void btnXuatExel_Click(object sender, EventArgs e)
        {
            if (dgvKhoSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.Title = "Chọn vị trí lưu file Excel";
                sfd.FileName = "DanhSachKhoSach.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Kho Sách");
                            for (int i = 0; i < dgvKhoSach.Columns.Count; i++)
                            {
                                if (dgvKhoSach.Columns[i].Visible)
                                {
                                    worksheet.Cell(1, i + 1).Value = dgvKhoSach.Columns[i].HeaderText;
                                    worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                                    worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightBlue;
                                    worksheet.Cell(1, i + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                }
                            }

                            int rowIndex = 2;
                            foreach (DataGridViewRow row in dgvKhoSach.Rows)
                            {
                                int colIndex = 1;
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (dgvKhoSach.Columns[cell.ColumnIndex].Visible)
                                    {
                                        worksheet.Cell(rowIndex, colIndex).Value = cell.Value?.ToString();
                                        worksheet.Cell(rowIndex, colIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                        colIndex++;
                                    }
                                }
                                rowIndex++;
                            }

                            worksheet.Columns().AdjustToContents();
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Xuất file Excel thành công!", "Thông báo");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xuất file Excel: {ex.Message}", "Lỗi");
                    }
                }
            }
        }

        private void cboLocTheoSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang 1 khi thay đổi bộ lọc
            ApplyFilters();
        }

        private void chkLocTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpLocNgayNhapKho.Enabled = chkLocTheoNgay.Checked;
            currentPage = 1; // Reset về trang 1 khi thay đổi bộ lọc
            ApplyFilters();
        }

        private void dtpLocNgayNhapKho_ValueChanged(object sender, EventArgs e)
        {
            if (chkLocTheoNgay.Checked)
            {
                currentPage = 1; // Reset về trang 1 khi thay đổi bộ lọc
                ApplyFilters();
            }
        }

       
    }
}