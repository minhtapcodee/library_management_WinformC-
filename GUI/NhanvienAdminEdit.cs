using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class NhanvienAdminEdit : Form
    {
        private NhanvienBLL nhanvienBLL = new NhanvienBLL();
        private int selectedId; // ID của nhân viên cần sửa

        // Constructor để nhận dữ liệu nhân viên từ FrmNhanvienAdmin
        public NhanvienAdminEdit(int id, string hoTen, string username, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            InitializeComponent();
            selectedId = id;

            // Gán thông tin vào các trường nhập
            txtHoTen.Text = hoTen;
            txtUsername.Text = username;
            if (gioiTinh == "Nam") rdoNam.Checked = true;
            else rdoNu.Checked = true;
            dtpNgaySinh.Value = ngaySinh;
            txtDiaChi.Text = diaChi;
            txtSDT.Text = sdt;
            txtEmail.Text = email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form nếu người dùng hủy
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu đã chỉnh sửa từ các trường nhập
                string hoTen = txtHoTen.Text.Trim();
                string username = txtUsername.Text.Trim();
                string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();

                // Kiểm tra dữ liệu trước khi cập nhật
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Họ tên và Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Định dạng email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ngaySinh >= DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không được lớn hơn hoặc bằng ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi BLL để cập nhật thông tin nhân viên
                nhanvienBLL.UpdateNhanVien(selectedId, hoTen, username, gioiTinh, ngaySinh, diaChi, sdt, email);

                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi cập nhật thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm kiểm tra định dạng email
        private bool IsValidEmail(string email)
        {
            // Định dạng regex cho email hợp lệ
            string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailRegex);
        }
    



private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
