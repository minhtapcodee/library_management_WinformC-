using System;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;
using System.Data;
using System.Drawing;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmSachDangMuon : Form
    {
        private MuonTraBLL sachTraBLL = new MuonTraBLL();
        private const string PLACEHOLDER_TEXT = "Nhập tên sách hoặc người mượn";

        public frmSachDangMuon()
        {
            InitializeComponent();
            SetupPlaceholder();
            LoadData();
        }

        private void SetupPlaceholder()
        {
            // Thiết lập placeholder cho txtTimKiem
            txtTimKiem.Text = PLACEHOLDER_TEXT;
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Enter += (s, e) =>
            {
                if (txtTimKiem.Text == PLACEHOLDER_TEXT)
                {
                    txtTimKiem.Text = "";
                    txtTimKiem.ForeColor = Color.Black;
                }
            };
            txtTimKiem.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    txtTimKiem.Text = PLACEHOLDER_TEXT;
                    txtTimKiem.ForeColor = Color.Gray;
                }
            };
        }

        private void LoadData()
        {
            try
            {
                // Lấy danh sách sách đang mượn
                DataTable dt = sachTraBLL.LayMuonTraTheoTrangThai("Đang mượn");
                // Gán dữ liệu cho DataGridView
                dgvSachDangMuon.DataSource = null; // Xóa nguồn dữ liệu cũ
                dgvSachDangMuon.DataSource = dt;

                // Cập nhật tổng số sách đang mượn dựa trên DataTable
                int tongSachDangMuon = dt.Rows.Count;
                lblTongSachDangMuon.Text = $"Tổng số sách đang mượn: {tongSachDangMuon}";

                // Tùy chỉnh các cột hiển thị
                dgvSachDangMuon.Columns["MaMT"].HeaderText = "Mã Mượn Trả";
                dgvSachDangMuon.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvSachDangMuon.Columns["TenNguoiMuon"].HeaderText = "Người Mượn";
                dgvSachDangMuon.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                dgvSachDangMuon.Columns["NgayTraDuKien"].HeaderText = "Ngày Trả Dự Kiến";

                // Ẩn các cột không cần thiết
                if (dgvSachDangMuon.Columns.Contains("TacGia")) dgvSachDangMuon.Columns["TacGia"].Visible = false;
                if (dgvSachDangMuon.Columns.Contains("TenTheLoai")) dgvSachDangMuon.Columns["TenTheLoai"].Visible = false;
                if (dgvSachDangMuon.Columns.Contains("SDTDocGia")) dgvSachDangMuon.Columns["SDTDocGia"].Visible = false;
                if (dgvSachDangMuon.Columns.Contains("MaNguoiMuon_Username")) dgvSachDangMuon.Columns["MaNguoiMuon_Username"].Visible = false;
                if (dgvSachDangMuon.Columns.Contains("TenNhanVien")) dgvSachDangMuon.Columns["TenNhanVien"].Visible = false;
                if (dgvSachDangMuon.Columns.Contains("MaNhanVien_Username")) dgvSachDangMuon.Columns["MaNhanVien_Username"].Visible = false;
                if (dgvSachDangMuon.Columns.Contains("NgayTraThucTe")) dgvSachDangMuon.Columns["NgayTraThucTe"].Visible = false;
                if (dgvSachDangMuon.Columns.Contains("TienPhat")) dgvSachDangMuon.Columns["TienPhat"].Visible = false;
                if (dgvSachDangMuon.Columns.Contains("TrangThai")) dgvSachDangMuon.Columns["TrangThai"].Visible = false;

                // Tùy chỉnh giao diện DataGridView
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDataGridView()
        {
            // Disable visual styles for custom styling
            dgvSachDangMuon.EnableHeadersVisualStyles = false;

            // Header customization
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215); // Deep blue for headers
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSachDangMuon.ColumnHeadersHeight = 40;

            // Row customization
            dgvSachDangMuon.DefaultCellStyle.BackColor = Color.White;
            dgvSachDangMuon.DefaultCellStyle.ForeColor = Color.Black;
            dgvSachDangMuon.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSachDangMuon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Selection style
            dgvSachDangMuon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 255); // Light blue for selection
            dgvSachDangMuon.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternating row style
            dgvSachDangMuon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Light cyan for alternating rows

            // Grid and borders
            dgvSachDangMuon.GridColor = Color.FromArgb(200, 200, 200); // Light gray grid lines
            dgvSachDangMuon.BorderStyle = BorderStyle.FixedSingle;
            dgvSachDangMuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Row height
            dgvSachDangMuon.RowTemplate.Height = 40;

            // Disable adding new rows
            dgvSachDangMuon.AllowUserToAddRows = false;

            // Enable full row selection
            dgvSachDangMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Chỉ tìm kiếm nếu TextBox không chứa placeholder
            string keyword = txtTimKiem.Text == PLACEHOLDER_TEXT ? "" : txtTimKiem.Text;
            TimKiemSachDangMuon(keyword);
        }

        private void TimKiemSachDangMuon(string keyword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    // Nếu không có từ khóa, tải lại toàn bộ danh sách
                    LoadData();
                }
                else
                {
                    // Tìm kiếm với từ khóa
                    DataTable dt = sachTraBLL.TimKiemMuonTra(keyword);
                    // Lọc chỉ các bản ghi có trạng thái "Đang mượn"
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = "TrangThai = 'Đang mượn'";
                    dgvSachDangMuon.DataSource = dv;

                    // Cập nhật tổng số sách đang mượn sau khi tìm kiếm
                    int tongSachDangMuon = dv.Count;
                    lblTongSachDangMuon.Text = $"Tổng số sách đang mượn: {tongSachDangMuon}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_MouseEnter(object sender, EventArgs e)
        {
            btnTimKiem.BackColor = Color.FromArgb(0, 150, 255);
        }

        private void btnTimKiem_MouseLeave(object sender, EventArgs e)
        {
            btnTimKiem.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void lblTongSachDangMuon_Click(object sender, EventArgs e)
        {

        }
    }
}