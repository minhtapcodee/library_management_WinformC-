using System;
using System.Data;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmMuonTra : Form
    {
        private MuonTraBLL muonTraBLL = new MuonTraBLL();
        private int currentPage = 1;
        private int pageSize = 6;
        private int totalRecords = 0;

        public frmMuonTra()
        {
            InitializeComponent();
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            CustomizeDataGridView();
            LoadFilterStatus();
        }

        private void LoadFilterStatus()
        {
            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.Add("Tất cả");
            cmbFilterStatus.Items.Add("Đang mượn");
            cmbFilterStatus.Items.Add("Đã trả");
            cmbFilterStatus.Items.Add("Quá hạn (chưa trả)");
            cmbFilterStatus.Items.Add("Quá hạn (đã trả)");
            cmbFilterStatus.SelectedIndex = 0; // Default to "Tất cả"
        }

        private void LoadDataToGrid()
        {
            try
            {
                DataTable dt = muonTraBLL.LayTatCaMuonTra();
                totalRecords = dt.Rows.Count;
                int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
                LoadPageData(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi khi tải dữ liệu: {ex.Message}");
            }

            // Định nghĩa header cho các cột
            if (dgvBorrow.Columns.Contains("MaMT")) dgvBorrow.Columns["MaMT"].HeaderText = "Mã mượn trả";
            if (dgvBorrow.Columns.Contains("TenSach")) dgvBorrow.Columns["TenSach"].HeaderText = "Tên sách";
            if (dgvBorrow.Columns.Contains("TacGia")) dgvBorrow.Columns["TacGia"].HeaderText = "Tác giả";
            if (dgvBorrow.Columns.Contains("TenTheLoai")) dgvBorrow.Columns["TenTheLoai"].HeaderText = "Thể loại";
            if (dgvBorrow.Columns.Contains("TenNguoiMuon")) dgvBorrow.Columns["TenNguoiMuon"].HeaderText = "Người mượn";
            if (dgvBorrow.Columns.Contains("MaNguoiMuon_Username")) dgvBorrow.Columns["MaNguoiMuon_Username"].HeaderText = "Tài khoản Người mượn";
            if (dgvBorrow.Columns.Contains("SDTDocGia")) dgvBorrow.Columns["SDTDocGia"].HeaderText = "SĐT người mượn";
            if (dgvBorrow.Columns.Contains("TenNhanVien")) dgvBorrow.Columns["TenNhanVien"].HeaderText = "Nhân viên xử lý";
            if (dgvBorrow.Columns.Contains("MaNhanVien_Username")) dgvBorrow.Columns["MaNhanVien_Username"].HeaderText = "Tài khoản Nhân viên";
            if (dgvBorrow.Columns.Contains("NgayMuon")) dgvBorrow.Columns["NgayMuon"].HeaderText = "Ngày mượn";
            if (dgvBorrow.Columns.Contains("NgayTraDuKien")) dgvBorrow.Columns["NgayTraDuKien"].HeaderText = "Trả dự kiến";
            if (dgvBorrow.Columns.Contains("NgayTraThucTe")) dgvBorrow.Columns["NgayTraThucTe"].HeaderText = "Trả thực tế";
            if (dgvBorrow.Columns.Contains("TienPhat")) dgvBorrow.Columns["TienPhat"].HeaderText = "Tiền phạt";
            if (dgvBorrow.Columns.Contains("TrangThai")) dgvBorrow.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvBorrow.Refresh();
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
            dgvBorrow.DataSource = pageData;
        }

        private void CustomizeDataGridView()
        {
            dgvBorrow.EnableHeadersVisualStyles = false;
            dgvBorrow.ScrollBars = ScrollBars.None; // Tắt cả thanh cuộn ngang và dọc

            // Header
            dgvBorrow.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 192, 0); // xanh lá chuối nhạt
            dgvBorrow.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBorrow.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvBorrow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBorrow.ColumnHeadersHeight = 35;

            // Rows
            dgvBorrow.DefaultCellStyle.BackColor = Color.White;
            dgvBorrow.DefaultCellStyle.ForeColor = Color.Black;
            dgvBorrow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 220, 57); // xanh lá chuối đậm khi chọn
            dgvBorrow.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvBorrow.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Grid
            dgvBorrow.GridColor = Color.LightGray;
            dgvBorrow.BorderStyle = BorderStyle.None;
            dgvBorrow.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Misc
            dgvBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrow.RowTemplate.Height = 30;
            dgvBorrow.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128); // sọc xen kẽ xanh lá nhạt
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = muonTraBLL.TimKiemMuonTra(keyword);
                currentPage = 1; // Reset về trang 1 khi tìm kiếm
                totalRecords = dt.Rows.Count;
                int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
                LoadPageData(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedStatus = cmbFilterStatus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Vui lòng chọn trạng thái để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = muonTraBLL.LayMuonTraTheoTrangThai(selectedStatus);
                currentPage = 1; // Reset về trang 1 khi lọc
                totalRecords = dt.Rows.Count;
                int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
                LoadPageData(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxDelete_Click(object sender, EventArgs e)
        {
            if (dgvBorrow.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maMT = dgvBorrow.SelectedRows[0].Cells["MaMT"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa mã mượn trả: {maMT}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = muonTraBLL.XoaMuonTra(maMT);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGrid();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            try
            {
                DataTable dt = muonTraBLL.TimKiemMuonTra(keyword);
                currentPage = 1; // Reset về trang 1 khi nhập từ khóa
                totalRecords = dt.Rows.Count;
                int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
                LoadPageData(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbFilterStatus.SelectedItem?.ToString();
            try
            {
                DataTable dt = muonTraBLL.LayMuonTraTheoTrangThai(selectedStatus);
                currentPage = 1; // Reset về trang 1 khi thay đổi trạng thái
                totalRecords = dt.Rows.Count;
                int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
                LoadPageData(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMuonTraAdd muonTraAddForm = new frmMuonTraAdd();
            muonTraAddForm.ShowDialog();
            LoadDataToGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBorrow.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = dgvBorrow.SelectedRows[0].Index;
            DataTable dt = (DataTable)dgvBorrow.DataSource;
            DataRow row = dt.Rows[selectedRowIndex];

            string maMT = row["MaMT"].ToString();
            string tenSach = row["TenSach"]?.ToString() ?? "";
            string tenNguoiMuon = row["TenNguoiMuon"]?.ToString() ?? "";
            string tenNhanVien = row["TenNhanVien"]?.ToString() ?? "";
            string ngayMuon = row["NgayMuon"] != DBNull.Value ? Convert.ToDateTime(row["NgayMuon"]).ToString("dd/MM/yyyy") : "";
            string ngayTraDuKien = row["NgayTraDuKien"] != DBNull.Value ? Convert.ToDateTime(row["NgayTraDuKien"]).ToString("dd/MM/yyyy") : "";
            DateTime ngayTraThucTe = row["NgayTraThucTe"] != DBNull.Value ? Convert.ToDateTime(row["NgayTraThucTe"]) : DateTime.Now;
            string tienPhat = row["TienPhat"]?.ToString() ?? "0";
            string trangThai = row["TrangThai"]?.ToString() ?? "Đang mượn";

            frmMuonTraUpdate updateForm = new frmMuonTraUpdate(maMT, tenSach, tenNguoiMuon, tenNhanVien, ngayMuon, ngayTraDuKien, ngayTraThucTe, tienPhat, trangThai);
            updateForm.ShowDialog();
            LoadDataToGrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPageInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvBorrow.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvBorrow.SelectedRows[0];
            string maMT = selectedRow.Cells["MaMT"].Value.ToString();
            string tenSach = selectedRow.Cells["TenSach"].Value?.ToString() ?? "";
            string tacGia = selectedRow.Cells["TacGia"].Value?.ToString() ?? "";
            string theLoai = selectedRow.Cells["TenTheLoai"].Value?.ToString() ?? "";
            string tenNguoiMuon = selectedRow.Cells["TenNguoiMuon"].Value?.ToString() ?? "";
            string sdt = selectedRow.Cells["SDTDocGia"].Value?.ToString() ?? "";
            string tenNhanVien = selectedRow.Cells["TenNhanVien"].Value?.ToString() ?? "";
            string ngayMuon = selectedRow.Cells["NgayMuon"].Value != DBNull.Value ? Convert.ToDateTime(selectedRow.Cells["NgayMuon"].Value).ToString("dd/MM/yyyy") : "";
            string ngayTraDuKien = selectedRow.Cells["NgayTraDuKien"].Value != DBNull.Value ? Convert.ToDateTime(selectedRow.Cells["NgayTraDuKien"].Value).ToString("dd/MM/yyyy") : "";
            string ngayTraThucTe = selectedRow.Cells["NgayTraThucTe"].Value != DBNull.Value ? Convert.ToDateTime(selectedRow.Cells["NgayTraThucTe"].Value).ToString("dd/MM/yyyy") : "";
            string tienPhat = selectedRow.Cells["TienPhat"].Value?.ToString() ?? "0";
            string trangThai = selectedRow.Cells["TrangThai"].Value?.ToString() ?? "";

            frmMuonTraPrint printForm = new frmMuonTraPrint(
                maMT, tenSach, tacGia, theLoai, tenNguoiMuon, sdt, tenNhanVien,
                ngayMuon, ngayTraDuKien, ngayTraThucTe, tienPhat, trangThai);
            printForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbFilterStatus.SelectedIndex = 0;
            LoadDataToGrid();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataToGrid();
            }
        }

        private void lblPageInfo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDataToGrid();
            }
        }

        private void dgvBorrow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}