using QUANLYTHUVIENC3.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmMuonTraUpdate : Form
    {
        private string maMT;
        private MuonTraBLL muonTraBLL = new MuonTraBLL();
        private DateTime ngayMuon; // Lưu ngày mượn dưới dạng DateTime để so sánh

        // Constructor nhận dữ liệu từ frmMuonTra
        public frmMuonTraUpdate(string maMT, string tenSach, string tenNguoiMuon, string tenNhanVien, string ngayMuon,
                               string ngayTraDuKien, DateTime ngayTraThucTe, string tienPhat, string trangThai)
        {
            InitializeComponent();
            this.maMT = maMT;

            // Chuyển đổi ngày mượn từ chuỗi thành DateTime với định dạng cụ thể
            if (!DateTime.TryParseExact(ngayMuon, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out this.ngayMuon))
            {
                // Nếu không parse được, đặt thành ngày mặc định và cảnh báo
                this.ngayMuon = DateTime.Now.Date;
                MessageBox.Show($"Ngày mượn '{ngayMuon}' không hợp lệ, sử dụng ngày hiện tại ({DateTime.Now.Date}) làm mặc định.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Gán dữ liệu vào các điều khiển
            txtBookID.Text = tenSach;
            txtBorrowerID.Text = tenNguoiMuon;
            txtStaffID.Text = tenNhanVien;
            txtBorrowDate.Text = ngayMuon;
            txtDueDate.Text = ngayTraDuKien;
            dtReturnDate.Value = ngayTraThucTe;
            txtPenaltyFee.Text = tienPhat;

            // Đặt các trường thành đọc chỉ đọc và đổi màu nền để rõ ràng
            txtBookID.ReadOnly = true;
            txtBookID.BackColor = Color.FromArgb(250, 128, 114); // Màu xám nhạt
            txtBorrowerID.ReadOnly = true;
            txtBorrowerID.BackColor = Color.FromArgb(250, 128, 114);
            txtStaffID.ReadOnly = true;
            txtStaffID.BackColor = Color.FromArgb(250, 128, 114);
            txtBorrowDate.ReadOnly = true;
            txtBorrowDate.BackColor = Color.FromArgb(250, 128, 114);
            txtDueDate.ReadOnly = true;
            txtDueDate.BackColor = Color.FromArgb(250, 128, 114);

            // Khởi tạo comboBox1
            comboBox1.Items.Clear(); // Xóa danh sách hiện tại để tránh lặp
            comboBox1.Items.AddRange(new string[] { "Đang mượn", "Đã trả", "Quá hạn (chưa trả)", "Quá hạn (đã trả)" });
            if (!string.IsNullOrEmpty(trangThai) && comboBox1.Items.Contains(trangThai))
            {
                comboBox1.SelectedItem = trangThai;
            }
            else
            {
                comboBox1.SelectedIndex = 0; // Mặc định chọn "Đang mượn"
            }
        }

        private void frmMuonTraUpdate_Load(object sender, EventArgs e)
        {
            // Không cần tải dữ liệu vì đã truyền qua constructor
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu hợp lệ
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái giao dịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPenaltyFee.Text, out decimal tienPhat) || tienPhat < 0)
                {
                    MessageBox.Show("Tiền phạt không hợp lệ! Vui lòng nhập số không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string trangThai = comboBox1.SelectedItem.ToString();
                DateTime ngayTraThucTe = dtReturnDate.Value;

                // Debug để kiểm tra giá trị
                Console.WriteLine($"ngayMuon: {ngayMuon.Date}, ngayTraThucTe: {ngayTraThucTe.Date}");

                // Kiểm tra ngày trả thực tế không được bé hơn ngày mượn (được phép bằng) - chỉ so sánh ngày
                if (ngayTraThucTe.Date < ngayMuon.Date)
                {
                    MessageBox.Show("Ngày trả thực tế không được bé hơn ngày mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi hàm BLL để cập nhật dữ liệu
                bool isUpdated = muonTraBLL.CapNhatMuonTra(maMT, trangThai, ngayTraThucTe, tienPhat);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra mã mượn trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblContactInfo_Click(object sender, EventArgs e) { }
        private void txtBookID_TextChanged(object sender, EventArgs e) { }
        private void txtBorrowerID_TextChanged(object sender, EventArgs e) { }
        private void txtStaffID_TextChanged(object sender, EventArgs e) { }
        private void txtBorrowDate_TextChanged(object sender, EventArgs e) { }
        private void txtDueDate_TextChanged(object sender, EventArgs e) { }
        private void dtReturnDate_ValueChanged(object sender, EventArgs e) { }
        private void txtPenaltyFee_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}