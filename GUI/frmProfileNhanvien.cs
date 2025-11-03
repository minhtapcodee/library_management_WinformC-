using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL; // For NhanvienBLL

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmProfileNhanvien : Form
    {
        private string maNhanvien; // Store the employee ID for refreshing data
        private string username;   // Store the username separately
        private bool isEditing = false; // Track edit mode
        private NhanvienBLL nhanvienBLL; // To interact with the business layer

        public frmProfileNhanvien()
        {
            InitializeComponent();
            nhanvienBLL = new NhanvienBLL();
            // Set initial states
            SetReadOnlyFields(true);
            // Initialize ComboBox for GioiTinh
            if (cmbGioiTinh != null)
            {
                cmbGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
                cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        public void LoadUserData(string maNhanvien, string hoTen, string ngaySinh, string diaChi, string soDienThoai, string email, string gioiTinh = "", string username = "")
        {
            this.maNhanvien = maNhanvien; // Store the ID for refreshing
            this.username = username;     // Store the username
            txtMaNhanvien.Text = maNhanvien;
            txtHoTen.Text = hoTen;
            try
            {
                // Parse the ngaySinh string and set it to the DateTimePicker
                dtpNgaySinh.Value = DateTime.Parse(ngaySinh);
            }
            catch (Exception)
            {
                // If parsing fails, set a default date and show a warning
                dtpNgaySinh.Value = DateTime.Today;
                MessageBox.Show("Ngày sinh không hợp lệ, đã đặt về ngày hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtDiaChi.Text = diaChi;
            txtSoDienThoai.Text = soDienThoai;
            txtEmail.Text = email;
            if (cmbGioiTinh != null && !string.IsNullOrEmpty(gioiTinh))
            {
                cmbGioiTinh.SelectedItem = gioiTinh;
            }
        }

        private void SetReadOnlyFields(bool readOnly)
        {
            // txtMaNhanvien and txtHoTen should always be read-only
            txtMaNhanvien.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            // Other fields can be toggled
            txtDiaChi.ReadOnly = readOnly;
            txtSoDienThoai.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            // DateTimePicker doesn't have ReadOnly, so we disable/enable it
            dtpNgaySinh.Enabled = !readOnly;
            // ComboBox for GioiTinh
            if (cmbGioiTinh != null)
            {
                cmbGioiTinh.Enabled = !readOnly;
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtMaNhanvien_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGioiTinh.SelectedItem != null)
            {
                string selectedGender = cmbGioiTinh.SelectedItem.ToString();
                // Add custom logic here if needed
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Enter edit mode
                isEditing = true;
                btnChinhSua.Text = "Lưu"; // Change button text to "Save"
                SetReadOnlyFields(false); // Enable editing for editable fields
            }
            else
            {
                // Validate input before saving
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbGioiTinh != null && cmbGioiTinh.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save changes and exit edit mode
                try
                {
                    // Update the employee data in the database
                    nhanvienBLL.UpdateNhanVien(
                        id: int.Parse(txtMaNhanvien.Text),
                        hoTen: txtHoTen.Text, // Use the original HoTen since it's read-only
                        username: string.IsNullOrEmpty(this.username) ? txtMaNhanvien.Text : this.username, // Use stored username or fallback to txtMaNhanvien
                        gioiTinh: cmbGioiTinh?.SelectedItem?.ToString() ?? "", // Use ComboBox value if available
                        ngaySinh: dtpNgaySinh.Value,
                        diaChi: txtDiaChi.Text,
                        sdt: txtSoDienThoai.Text,
                        email: txtEmail.Text
                    );

                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isEditing = false;
                    btnChinhSua.Text = "Chỉnh sửa"; // Revert button text
                    SetReadOnlyFields(true); // Disable editing
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật thông tin: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNhanvien))
            {
                MessageBox.Show("Không có thông tin nhân viên để tải lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Fetch the latest data from the database
                DataTable dt = nhanvienBLL.GetNhanVienList();
                DataRow[] rows = dt.Select($"ID = '{maNhanvien}'");

                if (rows.Length > 0)
                {
                    DataRow userRow = rows[0];
                    // Reload the data into the form
                    LoadUserData(
                        maNhanvien: userRow["ID"].ToString(),
                        hoTen: userRow["HoTen"] != DBNull.Value ? userRow["HoTen"].ToString() : "",
                        ngaySinh: userRow["NgaySinh"] != DBNull.Value ? userRow["NgaySinh"].ToString() : DateTime.Today.ToString(),
                        diaChi: userRow["DiaChi"] != DBNull.Value ? userRow["DiaChi"].ToString() : "",
                        soDienThoai: userRow["SDT"] != DBNull.Value ? userRow["SDT"].ToString() : "",
                        email: userRow["Email"] != DBNull.Value ? userRow["Email"].ToString() : "",
                        gioiTinh: userRow["GioiTinh"] != DBNull.Value ? userRow["GioiTinh"].ToString() : "",
                        username: userRow["Username"] != DBNull.Value ? userRow["Username"].ToString() : ""
                    );
                    MessageBox.Show("Tải lại dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lại dữ liệu: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}