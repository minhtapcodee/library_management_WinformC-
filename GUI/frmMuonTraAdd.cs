using System;
using System.Data;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmMuonTraAdd : Form
    {
        private MuonTraBLL muonTraBLL = new MuonTraBLL();

        public frmMuonTraAdd()
        {
            InitializeComponent();
        }

        private void frmMuonTraAdd_Load(object sender, EventArgs e)
        {
            // Load dữ liệu vào các ComboBox
            LoadSachToComboBox();
            LoadNguoiMuonToComboBox();
            LoadNhanVienToComboBox();
        }

        private void LoadSachToComboBox()
        {
            DataTable dt = muonTraBLL.LaySachCon();
            cboBookID.DataSource = dt;
            cboBookID.DisplayMember = "TenSach"; // Hiển thị tên sách
            cboBookID.ValueMember = "MaSach";   // Giá trị mã sách
            cboBookID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboBookID.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadNguoiMuonToComboBox()
        {
            DataTable dt = muonTraBLL.LayDocGia();
            cboBorrowerID.DataSource = dt;
            cboBorrowerID.DisplayMember = "HoTen"; // Hiển thị tên độc giả
            cboBorrowerID.ValueMember = "ID";      // Lấy giá trị mã độc giả
            cboBorrowerID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboBorrowerID.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadNhanVienToComboBox()
        {
            DataTable dt = muonTraBLL.LayNhanVien();
            cboStaffID.DataSource = dt;
            cboStaffID.DisplayMember = "HoTen"; // Hiển thị tên nhân viên
            cboStaffID.ValueMember = "ID";      // Lấy giá trị mã nhân viên
            cboStaffID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboStaffID.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = cboBookID.SelectedValue.ToString();
                string maNguoiMuon = cboBorrowerID.SelectedValue.ToString();
                string maNhanVien = cboStaffID.SelectedValue.ToString();
                DateTime ngayMuon = dtBorrowDate.Value;
                DateTime ngayTraDuKien = dtDueDate.Value;

                Console.WriteLine($"btnSave_Click: Bắt đầu kiểm tra MaSach={maSach}");

                // Kiểm tra ngày mượn không được lớn hơn ngày hiện tại (được phép bằng) - chỉ so sánh ngày
                DateTime ngayHienTai = DateTime.Now; // Hiện tại: 01:29 AM, Thursday, May 29, 2025
                if (ngayMuon.Date > ngayHienTai.Date)
                {
                    MessageBox.Show("Ngày mượn không được lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra ngày trả dự kiến phải lớn hơn hoặc bằng ngày hiện tại, nhưng không được bé hơn ngày mượn - chỉ so sánh ngày
                if (ngayTraDuKien.Date < ngayHienTai.Date || ngayTraDuKien.Date < ngayMuon.Date)
                {
                    MessageBox.Show("Ngày trả dự kiến phải lớn hơn hoặc bằng ngày hiện tại và không được bé hơn ngày mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra số lượng còn lại của sách
                int soLuongConLai = muonTraBLL.KiemTraSoLuongConLai(maSach);
                Console.WriteLine($"btnSave_Click: SoLuongConLai cho MaSach={maSach}: {soLuongConLai}");
                if (soLuongConLai < 5)
                {
                    MessageBox.Show("Sách này đang không còn trong kho, không thể cho mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi hàm BLL để thêm dữ liệu
                bool isAdded = muonTraBLL.ThemMuonTra(maSach, maNguoiMuon, maNhanVien, ngayMuon, ngayTraDuKien);

                if (isAdded)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi lưu thành công
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"btnSave_Click: Lỗi: {ex.Message}");
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboBookID_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboBorrowerID_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboStaffID_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtBorrowDate_ValueChanged(object sender, EventArgs e) { }
        private void dtDueDate_ValueChanged(object sender, EventArgs e) { }
        private void dtReturnDate_ValueChanged(object sender, EventArgs e) { }
        private void txtPenaltyFee_TextChanged(object sender, EventArgs e) { }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}