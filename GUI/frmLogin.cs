using System;
using System.Data;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginBLL loginBLL = new LoginBLL();
            string role = loginBLL.CheckLogin(username, password);

            if (role == "ADMIN")
            {
                MessageBox.Show("Đăng nhập với quyền ADMIN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmAdmin adminForm = new frmAdmin();
                adminForm.ShowDialog();
                this.Close();
            }
            else if (role == "Nhân viên")
            {
                LoginResult loginResult = loginBLL.CheckLoginWithId(username, password);
                if (string.IsNullOrEmpty(loginResult.UserId))
                {
                    MessageBox.Show("Không thể lấy mã nhân viên. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Retrieve employee details
                NhanvienBLL nhanvienBLL = new NhanvienBLL();
                DataTable dt;
                try
                {
                    dt = nhanvienBLL.GetNhanVienList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lấy danh sách nhân viên: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow[] rows = dt.Select($"ID = '{loginResult.UserId}'");

                if (rows.Length > 0)
                {
                    DataRow userRow = rows[0];

                    // Extract profile data with null checks
                    try
                    {
                        string maNhanvien = userRow["ID"].ToString();
                        string hoTen = userRow["HoTen"] != DBNull.Value ? userRow["HoTen"].ToString() : "";
                        string ngaySinh = userRow["NgaySinh"] != DBNull.Value ? userRow["NgaySinh"].ToString() : DateTime.Today.ToString();
                        string diaChi = userRow["DiaChi"] != DBNull.Value ? userRow["DiaChi"].ToString() : "";
                        string soDienThoai = userRow["SDT"] != DBNull.Value ? userRow["SDT"].ToString() : "";
                        string email = userRow["Email"] != DBNull.Value ? userRow["Email"].ToString() : "";
                        string gioiTinh = userRow["GioiTinh"] != DBNull.Value ? userRow["GioiTinh"].ToString() : "";
                        string userName = userRow["Username"] != DBNull.Value ? userRow["Username"].ToString() : username; // Fallback to login username

                        MessageBox.Show("Đăng nhập với quyền Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        // Pass UserId, Role, and profile data to frmNhanVien
                        frmNhanVien nhanvienForm = new frmNhanVien(
                            int.Parse(loginResult.UserId),
                            loginResult.Role,
                            maNhanvien,
                            hoTen,
                            ngaySinh,
                            diaChi,
                            soDienThoai,
                            email,
                            gioiTinh,
                            userName
                        );
                        nhanvienForm.ShowDialog();

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi truy cập dữ liệu nhân viên: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else if (role == "Độc giả")
            {
                LoginResult loginResult = loginBLL.CheckLoginWithId(username, password);
                if (string.IsNullOrEmpty(loginResult.UserId))
                {
                    MessageBox.Show("Không thể lấy mã độc giả. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Đăng nhập với quyền Độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMainDocGia docGiaForm = new frmMainDocGia(loginResult.UserId);
                docGiaForm.FormClosed += (s, args) => this.Show();
                docGiaForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}