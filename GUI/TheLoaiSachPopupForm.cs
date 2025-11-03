using QUANLYTHUVIENC3.DAL;
using System;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class TheLoaiSachPopupForm : Form
    {
        // Khai báo các biến
        private TheLoaiSachDAL theLoaiSachDAL = new TheLoaiSachDAL(); // Đối tượng để truy cập dữ liệu
        private string? maTL; // Mã thể loại (dùng khi sửa)
        private bool isEditMode; // Chế độ: true (sửa), false (thêm)

        // Constructor
        public TheLoaiSachPopupForm(string? maTL, string? tenTheLoai)
        {
            InitializeComponent();
            this.maTL = maTL;
            isEditMode = !string.IsNullOrEmpty(maTL); // Xác định chế độ (thêm hay sửa)

            // Nếu là chế độ sửa
            if (isEditMode)
            {
                txtMaTL.Text = maTL; // Hiển thị mã thể loại
                txtMaTL.Enabled = false; // Không cho sửa mã
                txtTenTheLoai.Text = tenTheLoai; // Hiển thị tên thể loại
                this.Text = "Sửa Thể Loại"; // Đổi tiêu đề form
            }
            else
            {
                this.Text = "Thêm Thể Loại"; // Tiêu đề khi thêm
            }
        }

        // Phương thức kiểm tra dữ liệu đầu vào
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaTL.Text))
            {
                MessageBox.Show("Mã thể loại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTL.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenTheLoai.Text))
            {
                MessageBox.Show("Tên thể loại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return false;
            }
            return true;
        }

        // Sự kiện khi nhấn nút "Lưu"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào
            if (!ValidateInput()) return;

            try
            {
                if (isEditMode)
                {
                    // Chế độ sửa: Cập nhật thể loại
                    theLoaiSachDAL.UpdateTheLoaiSach(maTL, txtTenTheLoai.Text);
                    MessageBox.Show($"Cập nhật thể loại '{txtTenTheLoai.Text}' thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Chế độ thêm: Kiểm tra mã thể loại đã tồn tại chưa
                    using (var conn = new DatabaseConnection().GetConnection())
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM TheLoaiSach WHERE MaTL = @MaTL";
                        using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaTL", txtMaTL.Text);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("Mã thể loại đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // Thêm thể loại mới
                    theLoaiSachDAL.AddTheLoaiSach(txtMaTL.Text, txtTenTheLoai.Text);
                    MessageBox.Show($"Thêm thể loại '{txtTenTheLoai.Text}' thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Đóng form với kết quả OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn nút "Hủy"
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Đóng form với kết quả Cancel
            this.Close();
        }

        // Sự kiện Load (không dùng)
        private void TheLoaiSachPopupForm_Load(object sender, EventArgs e)
        {
        }

        // Sự kiện Load dự phòng (không dùng)
        private void TheLoaiSachPopupForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}