using System;
using System.Data;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;
using ClosedXML.Excel;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class FrmNhanvienAdmin : Form
    {
        NhanvienBLL nhanvienBLL = new NhanvienBLL();
        private int currentPage = 1;
        private int pageSize = 9;
        private int totalRecords = 0;

        public FrmNhanvienAdmin()
        {
            InitializeComponent();
            CustomizeDataGridView();
            LoadNhanVien();
            // Thêm dữ liệu cho ComboBox
            cboLocTheoGioiTinh.Items.Add("Tất cả");
            cboLocTheoGioiTinh.Items.Add("Nam");
            cboLocTheoGioiTinh.Items.Add("Nữ");
            cboLocTheoGioiTinh.SelectedIndex = 0;
        }

        private void CustomizeDataGridView()
        {
            dgvNhanvien.BackgroundColor = Color.White;
            dgvNhanvien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvNhanvien.EnableHeadersVisualStyles = false;
            dgvNhanvien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 139, 34);
            dgvNhanvien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanvien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvNhanvien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanvien.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNhanvien.DefaultCellStyle.BackColor = Color.White;
            dgvNhanvien.DefaultCellStyle.ForeColor = Color.Black;
            dgvNhanvien.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dgvNhanvien.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanvien.ColumnHeadersHeight = 35;
            dgvNhanvien.BorderStyle = BorderStyle.Fixed3D;
            dgvNhanvien.GridColor = Color.LightGray;
            dgvNhanvien.RowHeadersVisible = true;
            dgvNhanvien.RowHeadersWidth = 50;
            dgvNhanvien.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvNhanvien.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvNhanvien.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dgvNhanvien.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanvien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNhanvien.AutoResizeColumns();
        }

        private void LoadNhanVien()
        {
            if (dgvNhanvien.Columns.Contains("Password"))
            {
                dgvNhanvien.Columns["Password"].Visible = false;
            }
            DataTable dt = nhanvienBLL.GetNhanVienList();
            totalRecords = dt.Rows.Count;
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
            LoadPageData(dt);
        }

        private void LoadPageData(DataTable dt)
        {
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, dt.Rows.Count);
            DataTable pageData = dt.Clone();
            for (int i = startIndex; i < endIndex; i++)
            {
                pageData.ImportRow(dt.Rows[i]);
            }
            dgvNhanvien.DataSource = pageData;
            dgvNhanvien.Columns["ID"].HeaderText = "Mã Nhân Viên";
            dgvNhanvien.Columns["Username"].HeaderText = "Username";
            dgvNhanvien.Columns["HoTen"].HeaderText = "Họ và Tên";
            dgvNhanvien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvNhanvien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanvien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNhanvien.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvNhanvien.Columns["Email"].HeaderText = "Email";
        }

        private void cboLocTheoGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gioiTinh = cboLocTheoGioiTinh.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(gioiTinh))
            {
                try
                {
                    DataTable dt = nhanvienBLL.FilterByGioiTinh(gioiTinh);
                    currentPage = 1;
                    totalRecords = dt.Rows.Count;
                    int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
                    LoadPageData(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    DataTable dt = nhanvienBLL.SearchNhanVien(keyword);
                    currentPage = 1;
                    totalRecords = dt.Rows.Count;
                    int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
                    if (dt.Rows.Count > 0)
                    {
                        LoadPageData(dt);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên nào khớp với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNhanvien.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadNhanVien();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanvienAdminAdd formAdd = new NhanvienAdminAdd();
            formAdd.ShowDialog();
            LoadNhanVien();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNhanvien.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvNhanvien.SelectedRows[0].Cells["ID"].Value);
                string hoTen = dgvNhanvien.SelectedRows[0].Cells["HoTen"].Value.ToString();
                string username = dgvNhanvien.SelectedRows[0].Cells["Username"].Value.ToString();
                string gioiTinh = dgvNhanvien.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(dgvNhanvien.SelectedRows[0].Cells["NgaySinh"].Value);
                string diaChi = dgvNhanvien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string sdt = dgvNhanvien.SelectedRows[0].Cells["SDT"].Value.ToString();
                string email = dgvNhanvien.SelectedRows[0].Cells["Email"].Value.ToString();

                NhanvienAdminEdit formEdit = new NhanvienAdminEdit(id, hoTen, username, gioiTinh, ngaySinh, diaChi, sdt, email);
                formEdit.ShowDialog();
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btxDelete_Click(object sender, EventArgs e)
        {
            if (dgvNhanvien.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvNhanvien.SelectedRows[0].Cells["ID"].Value);
                var result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên với ID {id} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        nhanvienBLL.DeleteNhanVien(id);
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhanVien();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadNhanVien();
            txtSearch.Text = "";
            cboLocTheoGioiTinh.SelectedIndex = 0;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                Title = "Xuất dữ liệu sang Excel",
                FileName = "DanhSachNhanVien.xlsx"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("DanhSachNhanVien");

                        // Thêm tiêu đề cột
                        for (int i = 0; i < dgvNhanvien.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvNhanvien.Columns[i].HeaderText;
                        }

                        // Thêm dữ liệu
                        for (int i = 0; i < dgvNhanvien.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvNhanvien.Columns.Count; j++)
                            {
                                if (dgvNhanvien.Rows[i].Cells[j].Value != null)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgvNhanvien.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }

                        // Tự động điều chỉnh độ rộng cột
                        worksheet.Columns().AdjustToContents();

                        // Lưu file
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadNhanVien();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadNhanVien();
            }
        }
        private void lblPageInfo_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}