using QUANLYTHUVIENC3.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmDocGia : Form
    {
        private readonly DocGiaBLL docGiaBLL = new DocGiaBLL();
        private DataTable docGiaDataTable;
        private int pageSize = 6;
        private int currentPage = 1;
        private int totalPages;
        private bool isEditMode = false;
        private int selectedDocGiaId = -1;

        public frmDocGia()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(240, 248, 255);
            dataGridViewDocGia.ReadOnly = true;
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            
            cboLocGioiTinh.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cboLocGioiTinh.SelectedIndex = 0;

            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Đã trả", "Quá hạn" });
            cboLocTrangThai.SelectedIndex = 0;

            dataGridViewDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDocGia.MultiSelect = false;

            LoadDocGiaData();
        }

        private void LoadDocGiaData()
        {
            try
            {
                docGiaDataTable = docGiaBLL.GetAllDocGia();
                if (docGiaDataTable == null || docGiaDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có độc giả nào trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewDocGia.DataSource = null;
                    lblPageInfo.Text = "Trang 0/0";
                    btnPreviousPage.Enabled = false;
                    btnNextPage.Enabled = false;
                    return;
                }
                currentPage = 1;
                UpdatePagination();
                DisplayPage(currentPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách độc giả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePagination()
        {
            totalPages = (int)Math.Ceiling((double)docGiaDataTable.Rows.Count / pageSize);
            if (totalPages == 0) totalPages = 1;
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
            btnPreviousPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;
        }

        private void DisplayPage(int page)
        {
            try
            {
                int startIndex = (page - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, docGiaDataTable.Rows.Count);

                DataTable pageTable = docGiaDataTable.Clone();
                for (int i = startIndex; i < endIndex; i++)
                {
                    pageTable.ImportRow(docGiaDataTable.Rows[i]);
                }

                dataGridViewDocGia.DataSource = pageTable;
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDataGridView()
        {
            try
            {
                if (dataGridViewDocGia.Columns.Count > 0)
                {
                    dataGridViewDocGia.Columns["ID"].HeaderText = "ID";
                    dataGridViewDocGia.Columns["Username"].HeaderText = "Tên Đăng Nhập";
                    dataGridViewDocGia.Columns["Password"].HeaderText = "Mật Khẩu";
                    dataGridViewDocGia.Columns["Password"].Visible = false; // Ẩn cột mật khẩu
                    dataGridViewDocGia.Columns["Role"].Visible = false;
                    dataGridViewDocGia.Columns["HoTen"].HeaderText = "Họ Tên";
                    dataGridViewDocGia.Columns["GioiTinh"].HeaderText = "Giới Tính";
                    dataGridViewDocGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                    dataGridViewDocGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    dataGridViewDocGia.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dataGridViewDocGia.Columns["Email"].HeaderText = "Email";

                    dataGridViewDocGia.EnableHeadersVisualStyles = false;
                    dataGridViewDocGia.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 179, 113); // Màu xanh lá
                    dataGridViewDocGia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridViewDocGia.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                    dataGridViewDocGia.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

                    dataGridViewDocGia.DefaultCellStyle.BackColor = Color.White;
                    dataGridViewDocGia.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 245); // Màu xám nhạt
                    dataGridViewDocGia.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridViewDocGia.DefaultCellStyle.Font = new Font("Arial", 9);
                    dataGridViewDocGia.DefaultCellStyle.Padding = new Padding(5);
                    dataGridViewDocGia.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    dataGridViewDocGia.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 230); // Màu xanh nhạt
                    dataGridViewDocGia.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dataGridViewDocGia.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 230); // Đồng bộ màu xanh nhạt
                    dataGridViewDocGia.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

                    dataGridViewDocGia.GridColor = Color.FromArgb(200, 200, 200);
                    dataGridViewDocGia.BackgroundColor = Color.FromArgb(230, 230, 230);
                    dataGridViewDocGia.RowHeadersVisible = false;

                    dataGridViewDocGia.RowTemplate.Height = 50;
                    dataGridViewDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tùy chỉnh DataGridView: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetInputFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgaySinh.Checked = false;
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            isEditMode = false;
            selectedDocGiaId = -1;
            btnLuu.Text = "Lưu (Thêm)";
            btnLuu.BackColor = Color.FromArgb(65, 105, 225);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedDocGiaId == -1)
            {
                MessageBox.Show("Vui lòng chọn một độc giả để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isEditMode = true;
            btnLuu.Text = "Lưu (Sửa)";
            btnLuu.BackColor = Color.FromArgb(50, 205, 50);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedDocGiaId == -1)
            {
                MessageBox.Show("Vui lòng chọn một độc giả để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = docGiaDataTable.AsEnumerable()
                .FirstOrDefault(r => r.Field<int>("ID") == selectedDocGiaId)?["Username"]?.ToString() ?? "Không xác định";
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa độc giả {username}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool deleted = docGiaBLL.DeleteDocGia(selectedDocGiaId);
                    if (deleted)
                    {
                        MessageBox.Show("Xóa độc giả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDocGiaData();
                        ResetInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa độc giả thất bại! Độc giả không tồn tại hoặc có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa độc giả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem?.ToString();
            DateTime ngaySinh = dtpNgaySinh.Value; // Đã kiểm tra dtpNgaySinh.Checked trong ValidateInput
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            try
            {
                bool success;
                if (isEditMode)
                {
                    success = docGiaBLL.UpdateDocGia(selectedDocGiaId, username, password, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email);
                    MessageBox.Show(success ? "Cập nhật độc giả thành công!" : "Cập nhật độc giả thất bại!",
                        success ? "Thành công" : "Lỗi", MessageBoxButtons.OK,
                        success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                }
                else
                {
                    success = docGiaBLL.AddDocGia(username, password, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email);
                    MessageBox.Show(success ? "Thêm độc giả thành công!" : "Thêm độc giả thất bại!",
                        success ? "Thành công" : "Lỗi", MessageBoxButtons.OK,
                        success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                }

                if (success)
                {
                    LoadDocGiaData();
                    ResetInputFields();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu độc giả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            if (cboGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioiTinh.Focus();
                return false;
            }
            if (!dtpNgaySinh.Checked)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return false;
            }
            // Kiểm tra ngày sinh phải nhỏ hơn ngày hiện tại (không bao gồm ngày hiện tại)
            if (dtpNgaySinh.Value >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return false;
            }
            if (dtpNgaySinh.Value < new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Ngày sinh không hợp lệ (quá nhỏ)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if (!IsValidPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (phải có 10 số)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string gioiTinh = cboLocGioiTinh.SelectedItem?.ToString() == "Tất cả" ? "" : cboLocGioiTinh.SelectedItem?.ToString();
            string trangThai = cboLocTrangThai.SelectedItem?.ToString() == "Tất cả" ? "" : cboLocTrangThai.SelectedItem?.ToString();

            try
            {
                docGiaDataTable = docGiaBLL.SearchDocGia(tuKhoa, gioiTinh, trangThai);
                currentPage = 1;
                UpdatePagination();
                DisplayPage(currentPage);
                if (docGiaDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy độc giả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm độc giả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLocGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocGioiTinh.SelectedIndex = 0;
            cboLocTrangThai.SelectedIndex = 0;
            LoadDocGiaData();
            ResetInputFields();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayPage(currentPage);
                UpdatePagination();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayPage(currentPage);
                UpdatePagination();
            }
        }

        private void dataGridViewDocGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDocGia.SelectedRows.Count == 0)
            {
                ResetInputFields();
                return;
            }

            DataGridViewRow row = dataGridViewDocGia.SelectedRows[0];
            selectedDocGiaId = Convert.ToInt32(row.Cells["ID"].Value);

            txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
            txtPassword.Text = row.Cells["Password"].Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            cboGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString();
            if (row.Cells["NgaySinh"].Value != DBNull.Value && DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out DateTime ngaySinh))
            {
                dtpNgaySinh.Value = ngaySinh;
                dtpNgaySinh.Checked = true;
            }
            else
            {
                dtpNgaySinh.Checked = false;
            }
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
        }

        // Sự kiện xuất Excel
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (docGiaDataTable == null || docGiaDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.Title = "Chọn nơi lưu file Excel";
                sfd.FileName = $"DanhSachDocGia_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Danh Sách Độc Giả");

                            worksheet.Cell(1, 1).Value = "Danh Sách Độc Giả Thư Viện";
                            worksheet.Range("A1:I1").Merge();
                            worksheet.Cell(1, 1).Style.Font.Bold = true;
                            worksheet.Cell(1, 1).Style.Font.FontSize = 16;
                            worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.LightBlue;

                            worksheet.Cell(2, 1).Value = $"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
                            worksheet.Range("A2:I2").Merge();
                            worksheet.Cell(2, 1).Style.Font.Italic = true;
                            worksheet.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            string[] headers = { "ID", "Tên Đăng Nhập", "Họ Tên", "Giới Tính", "Ngày Sinh", "Địa Chỉ", "Số Điện Thoại", "Email" };
                            for (int i = 0; i < headers.Length; i++)
                            {
                                worksheet.Cell(4, i + 1).Value = headers[i];
                                worksheet.Cell(4, i + 1).Style.Font.Bold = true;
                                worksheet.Cell(4, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                                worksheet.Cell(4, i + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // Dữ liệu
                            int row = 5;
                            foreach (DataRow dr in docGiaDataTable.Rows)
                            {
                                worksheet.Cell(row, 1).Value = dr["ID"].ToString();
                                worksheet.Cell(row, 2).Value = dr["Username"].ToString();
                                worksheet.Cell(row, 3).Value = dr["HoTen"].ToString();
                                worksheet.Cell(row, 4).Value = dr["GioiTinh"].ToString();
                                worksheet.Cell(row, 5).Value = Convert.ToDateTime(dr["NgaySinh"]).ToString("dd/MM/yyyy");
                                worksheet.Cell(row, 6).Value = dr["DiaChi"].ToString();
                                worksheet.Cell(row, 7).Value = dr["SDT"].ToString();
                                worksheet.Cell(row, 8).Value = dr["Email"].ToString();
                                row++;
                            }

                            var dataRange = worksheet.Range(worksheet.Cell(4, 1), worksheet.Cell(row - 1, 8));
                            dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Hover effects
        private void btnExportExcel_MouseEnter(object sender, EventArgs e) => btnExportExcel.BackColor = Color.FromArgb(0, 128, 0);
        private void btnExportExcel_MouseLeave(object sender, EventArgs e) => btnExportExcel.BackColor = Color.FromArgb(0, 150, 0);
        private void btnSua_MouseEnter(object sender, EventArgs e) => btnSua.BackColor = Color.FromArgb(34, 139, 34);
        private void btnSua_MouseLeave(object sender, EventArgs e) => btnSua.BackColor = Color.FromArgb(50, 205, 50);
        private void btnXoa_MouseEnter(object sender, EventArgs e) => btnXoa.BackColor = Color.FromArgb(220, 20, 60);
        private void btnXoa_MouseLeave(object sender, EventArgs e) => btnXoa.BackColor = Color.FromArgb(255, 69, 0);
        private void btnLuu_MouseEnter(object sender, EventArgs e) => btnLuu.BackColor = isEditMode ? Color.FromArgb(34, 139, 34) : Color.FromArgb(30, 144, 255);
        private void btnLuu_MouseLeave(object sender, EventArgs e) => btnLuu.BackColor = isEditMode ? Color.FromArgb(50, 205, 50) : Color.FromArgb(65, 105, 225);
        private void btnLamMoi_MouseEnter(object sender, EventArgs e) => btnLamMoi.BackColor = Color.FromArgb(255, 165, 0);
        private void btnLamMoi_MouseLeave(object sender, EventArgs e) => btnLamMoi.BackColor = Color.FromArgb(255, 215, 0);
        private void btnTimKiem_MouseEnter(object sender, EventArgs e) => btnTimKiem.BackColor = Color.FromArgb(30, 144, 255);
        private void btnTimKiem_MouseLeave(object sender, EventArgs e) => btnTimKiem.BackColor = Color.FromArgb(65, 105, 225);
        private void btnPreviousPage_MouseEnter(object sender, EventArgs e) => btnPreviousPage.BackColor = Color.FromArgb(30, 144, 255);
        private void btnPreviousPage_MouseLeave(object sender, EventArgs e) => btnPreviousPage.BackColor = Color.FromArgb(65, 105, 225);
        private void btnNextPage_MouseEnter(object sender, EventArgs e) => btnNextPage.BackColor = Color.FromArgb(30, 144, 255);
        private void btnNextPage_MouseLeave(object sender, EventArgs e) => btnNextPage.BackColor = Color.FromArgb(65, 105, 225);

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}