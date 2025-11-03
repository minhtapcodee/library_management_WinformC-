using System;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;
using System.Data;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmThongTin : Form
    {
        private string maDocGia;
        private DocGiaBLL docGiaBLL = new DocGiaBLL();
        private bool isEditing = false;
        private int docGiaId;
        private string username;
        private string password;
        private string gioiTinh;

        public frmThongTin(string maDocGia)
        {
            InitializeComponent();
            this.maDocGia = maDocGia;
            Debug.WriteLine($"frmThongTin khởi tạo với maDocGia: {maDocGia}");
            LoadThongTinDocGia();
        }

        private void LoadThongTinDocGia()
        {
            if (string.IsNullOrEmpty(maDocGia))
            {
                MessageBox.Show("Mã độc giả không hợp lệ! Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                DataTable dt = docGiaBLL.GetDocGiaByMaDocGia(maDocGia);
                Debug.WriteLine($"Số hàng trả về cho maDocGia {maDocGia}: {dt.Rows.Count}");
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtMaDocGia.Text = row["ID"]?.ToString();
                    txtHoTen.Text = row["HoTen"]?.ToString();
                    txtNgaySinh.Text = row["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy") : "";
                    txtDiaChi.Text = row["DiaChi"]?.ToString();
                    txtSoDienThoai.Text = row["SDT"]?.ToString();
                    txtEmail.Text = row["Email"]?.ToString();

                    docGiaId = Convert.ToInt32(row["ID"]);
                    username = row["Username"]?.ToString();
                    password = row["Password"]?.ToString();
                    gioiTinh = row["GioiTinh"]?.ToString();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy thông tin độc giả với mã {maDocGia}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin độc giả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Lỗi trong LoadThongTinDocGia: {ex.StackTrace}");
                this.Close();
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                isEditing = true;
                btnChinhSua.Text = "Lưu";
                EnableEditing(true);
            }
            else
            {
                if (!ValidateInput())
                    return;

                try
                {
                    bool success = docGiaBLL.UpdateDocGia(
                        docGiaId,
                        username,
                        password,
                        txtHoTen.Text,
                        gioiTinh,
                        DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null),
                        txtDiaChi.Text,
                        txtSoDienThoai.Text,
                        txtEmail.Text
                    );

                    if (success)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isEditing = false;
                        btnChinhSua.Text = "Chỉnh sửa";
                        EnableEditing(false);
                        LoadThongTinDocGia();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine($"Lỗi trong btnChinhSua_Click: {ex.StackTrace}");
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtNgaySinh.Text, @"^\d{2}/\d{2}/\d{4}$"))
            {
                MessageBox.Show("Ngày sinh phải có định dạng dd/MM/yyyy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && !Regex.IsMatch(txtSoDienThoai.Text, @"^\d{10,11}$"))
            {
                MessageBox.Show("Số điện thoại phải có 10 hoặc 11 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void EnableEditing(bool enable)
        {
            txtMaDocGia.ReadOnly = true; // Luôn khóa
            txtHoTen.ReadOnly = true;    // Không cho chỉnh sửa
            txtNgaySinh.ReadOnly = true; // Không cho chỉnh sửa
            txtDiaChi.ReadOnly = !enable;
            txtSoDienThoai.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;
        }

        private void btnChinhSua_MouseEnter(object sender, EventArgs e)
        {
            btnChinhSua.BackColor = Color.FromArgb(40, 139, 83); // Màu xanh đậm khi hover
        }

        private void btnChinhSua_MouseLeave(object sender, EventArgs e)
        {
            btnChinhSua.BackColor = Color.FromArgb(60, 179, 113); // Màu xanh lá bình thường
        }

        private void btnDangXuat_MouseEnter(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(200, 35, 51); // Màu đỏ đậm khi hover
        }

        private void btnDangXuat_MouseLeave(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(220, 53, 69); // Màu đỏ bình thường
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
           

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                frmLogin loginForm = new frmLogin();
                loginForm.ShowDialog();

                // Optional: Close frmMainDocGia if it exists
                Form mainForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is frmMainDocGia);
                if (mainForm != null)
                {
                    mainForm.Close();
                }

                this.Close();

                //// Safeguard to prevent application exit
                //if (Application.OpenForms.Count == 0)
                //{
                //    Application.Run(new frmLogin());
                //}
            }
        }
        private void frmThongTin_Load(object sender, EventArgs e)
        {
            EnableEditing(false);
            // Căn giữa panelContainer
            CenterPanelContainer();
        }

        private void CenterPanelContainer()
        {
            // Tính toán vị trí để căn giữa panelContainer
            int x = (this.ClientSize.Width - panelContainer.Width) / 2;
            int y = (this.ClientSize.Height - panelContainer.Height) / 2;
            panelContainer.Location = new Point(x, y);
        }

        private void frmThongTin_Resize(object sender, EventArgs e)
        {
            // Căn giữa lại panelContainer khi form thay đổi kích thước
            CenterPanelContainer();
        }
    }
}