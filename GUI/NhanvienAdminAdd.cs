using QUANLYTHUVIENC3.BLL;
using System.Text.RegularExpressions;

using System;

using System.Windows.Forms;


namespace QUANLYTHUVIENC3.GUI
{
    public partial class NhanvienAdminAdd : Form
    {
        private NhanvienBLL nhanvienBLL = new NhanvienBLL();

        public NhanvienAdminAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập
                string hoTen = txtHoTen.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Họ tên, Tên đăng nhập và Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Định dạng email không đúng định dạng !", "Bạn gì ơi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ngaySinh >= DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không được lớn hơn hoặc bằng ngày hiện tại!", "Bạn gì ơi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(sdt) || sdt.Length != 10 || sdt[0] != '0' || !sdt.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại phải bắt đầu bằng 0 và có đúng 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(diaChi))
                {
                    MessageBox.Show("Địa chỉ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Gọi BLL để thêm nhân viên
                nhanvienBLL.AddNhanVien(hoTen, username, password, gioiTinh, ngaySinh, diaChi, sdt, email);

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form nếu người dùng hủy
        }

        // Hàm kiểm tra định dạng email
        private bool IsValidEmail(string email)
        {
            // Định dạng regex cho email hợp lệ
            string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailRegex);
        }
  

private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý khi RadioButton Nam được chọn
        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý khi RadioButton Nữ được chọn
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi nội dung TextBox Username thay đổi
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi nội dung TextBox Password thay đổi
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi nội dung TextBox Họ tên thay đổi
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi nội dung TextBox Số điện thoại thay đổi
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi nội dung TextBox Địa chỉ thay đổi
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi nội dung TextBox Email thay đổi
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            // Xử lý khi giá trị của DateTimePicker thay đổi
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label1
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label2
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label3
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label4
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label5
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label6
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label7
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label8
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Label9
        }

        // ======= SỰ KIỆN CHO PICTUREBOX =======
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào PictureBox
        }

        // ======= SỰ KIỆN CHO PANEL =======
        private void panel1_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Panel1
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào Panel2
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Xử lý khi groupBox được focus hoặc người dùng tương tác
        }
    }
}
