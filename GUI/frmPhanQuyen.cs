using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmPhanQuyen : Form
    {
        private PhanQuyenBLL bll = new PhanQuyenBLL();
        private int currentPage = 1;
        private const int pageSize = 9;
        private int totalPages = 0;
        private bool isSearching = false;
        private string currentKeyword = "";
        private string currentRoleFilter = "";
        private int selectedUserId = -1;

        public frmPhanQuyen()
        {
            InitializeComponent();
            // Gán sự kiện SelectionChanged trong code để đảm bảo nó được gọi
            dgvTaiKhoan.SelectionChanged += new EventHandler(dgvTaiKhoan_SelectionChanged);
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            cboPhanQuyen.Items.Clear();
            cboPhanQuyen.Items.Add("ADMIN");
            cboPhanQuyen.Items.Add("Nhân viên");
            cboPhanQuyen.Items.Add("Độc giả");
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                int totalRecords = bll.GetTotalUserCountWithFilter(currentRoleFilter, currentKeyword);
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                if (totalPages == 0) totalPages = 1;

                lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
                btnPreviousPage.Enabled = currentPage > 1;
                btnNextPage.Enabled = currentPage < totalPages;

                DataTable dt = bll.FilterUsersWithPagination(currentRoleFilter, currentKeyword, currentPage, pageSize);
                dgvTaiKhoan.DataSource = dt;

                if (dgvTaiKhoan.Columns.Count > 0)
                {
                    dgvTaiKhoan.Columns["ID"].HeaderText = "Mã Người Dùng";
                    dgvTaiKhoan.Columns["Username"].HeaderText = "Tên Đăng Nhập";
                    dgvTaiKhoan.Columns["Role"].HeaderText = "Vai Trò";
                    dgvTaiKhoan.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvTaiKhoan.Columns["GioiTinh"].HeaderText = "Giới Tính";
                    dgvTaiKhoan.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                    dgvTaiKhoan.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    dgvTaiKhoan.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dgvTaiKhoan.Columns["Email"].HeaderText = "Email";

                    dgvTaiKhoan.Columns["ID"].Width = 80;
                    dgvTaiKhoan.Columns["Username"].Width = 100;
                    dgvTaiKhoan.Columns["Role"].Width = 80;
                    dgvTaiKhoan.Columns["HoTen"].Width = 120;
                    dgvTaiKhoan.Columns["GioiTinh"].Width = 60;
                    dgvTaiKhoan.Columns["NgaySinh"].Width = 80;
                    dgvTaiKhoan.Columns["DiaChi"].Width = 150;
                    dgvTaiKhoan.Columns["SDT"].Width = 100;
                    dgvTaiKhoan.Columns["Email"].Width = 150;

                    dgvTaiKhoan.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTaiKhoan.Columns["Role"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTaiKhoan.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTaiKhoan.Columns["NgaySinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTaiKhoan.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvTaiKhoan.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgvTaiKhoan.EnableHeadersVisualStyles = false;
                    dgvTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 158, 96); // Vibrant green for headers
                    dgvTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvTaiKhoan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    dgvTaiKhoan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 230, 200); // Soft green for alternating rows
                    dgvTaiKhoan.RowsDefaultCellStyle.BackColor = Color.White;

                    dgvTaiKhoan.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 178, 116); // Lighter vibrant green for selection
                    dgvTaiKhoan.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 100, 0); // Deep green for selected text

                    dgvTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                    dgvTaiKhoan.GridColor = Color.FromArgb(200, 200, 200);

                    foreach (DataGridViewColumn column in dgvTaiKhoan.Columns)
                    {
                        column.Resizable = DataGridViewTriState.False;
                    }

                    dgvTaiKhoan.RowHeadersVisible = true;
                    dgvTaiKhoan.RowHeadersWidth = 40;
                    dgvTaiKhoan.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 158, 96); // Vibrant green for row headers
                    dgvTaiKhoan.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvTaiKhoan.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvTaiKhoan.AllowUserToResizeRows = false;

                    dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvTaiKhoan.MultiSelect = false;

                    // Đảm bảo hàng đầu tiên được chọn nếu có dữ liệu
                    if (dgvTaiKhoan.Rows.Count > 0)
                    {
                        dgvTaiKhoan.Rows[0].Selected = true;
                        dgvTaiKhoan_SelectionChanged(dgvTaiKhoan, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataGridView();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDataGridView();
            }
        }

        private void btxExit_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Clear();
            cboPhanQuyen.SelectedIndex = -1;
            selectedUserId = -1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            currentKeyword = txtSearch.Text.Trim();
            isSearching = !string.IsNullOrEmpty(currentKeyword);
            currentPage = 1;
            LoadDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentKeyword = txtSearch.Text.Trim();
            isSearching = !string.IsNullOrEmpty(currentKeyword);
            currentPage = 1;
            LoadDataGridView();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cmbFilter.SelectedItem?.ToString();
            if (selectedFilter == "Tất cả")
            {
                currentRoleFilter = "";
            }
            else
            {
                currentRoleFilter = selectedFilter;
            }
            currentPage = 1;
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Vui lòng chọn một người dùng để sửa quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newRole = cboPhanQuyen.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newRole))
            {
                MessageBox.Show("Vui lòng chọn một vai trò mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = bll.UpdateUserRole(selectedUserId, newRole);
                if (success)
                {
                    MessageBox.Show("Cập nhật quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                    txtTenTaiKhoan.Clear();
                    cboPhanQuyen.SelectedIndex = -1;
                    selectedUserId = -1;
                }
                else
                {
                    MessageBox.Show("Cập nhật quyền thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật quyền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không cần xử lý ở đây vì đã có SelectionMode là FullRowSelect
        }

        private void lblPageInfo_Click(object sender, EventArgs e)
        {
            // Không cần xử lý
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Không cần xử lý
        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            // Để trống, không cần xử lý
        }

        private void cboPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Để trống, không cần xử lý
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTaiKhoan.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvTaiKhoan.SelectedRows[0];
                    selectedUserId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    txtTenTaiKhoan.Text = selectedRow.Cells["Username"].Value.ToString();
                    string role = selectedRow.Cells["Role"].Value.ToString();
                    cboPhanQuyen.SelectedItem = role;
                    if (cboPhanQuyen.SelectedIndex == -1)
                    {
                        MessageBox.Show($"Vai trò '{role}' không hợp lệ. Các vai trò hợp lệ: ADMIN, Nhân viên, Độc giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}