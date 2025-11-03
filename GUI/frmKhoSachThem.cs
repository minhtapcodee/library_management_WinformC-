using System;
using System.Data;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmKhoSachThem : Form
    {
        private KhoSachBLL bll = new KhoSachBLL();

        public frmKhoSachThem()
        {
            InitializeComponent();
        }

        private void LoadSachToComboBox()
        {
            try
            {
                DataTable dt = bll.GetSach();
                if (dt != null)
                {
                    Console.WriteLine($"Số sách tìm thấy: {dt.Rows.Count}");
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"Mã sách: {row["MaSach"]}, Tên sách: {row["TenSach"]}");
                    }

                    if (dt.Rows.Count > 0)
                    {
                        cboTenSach.DataSource = null;
                        cboTenSach.Items.Clear();
                        cboTenSach.DataSource = dt;
                        cboTenSach.DisplayMember = "TenSach";
                        cboTenSach.ValueMember = "MaSach";
                        cboTenSach.SelectedIndex = -1;

                        Console.WriteLine($"Số mục trong cboTenSach: {cboTenSach.Items.Count}");
                        if (cboTenSach.Items.Count == 0)
                        {
                            MessageBox.Show("Dữ liệu sách đã được lấy nhưng không hiển thị trong ComboBox.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách có tình trạng 'Còn' trong bảng Sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy dữ liệu từ bảng Sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNhanVienToComboBox()
        {
            try
            {
                DataTable dt = bll.GetNhanVien();
                if (dt != null)
                {
                    Console.WriteLine($"Số nhân viên tìm thấy: {dt.Rows.Count}");
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"Mã nhân viên: {row["ID"]}, Tên nhân viên: {row["HoTen"]}");
                    }

                    if (dt.Rows.Count > 0)
                    {
                        cboTenNhanvien.DataSource = null;
                        cboTenNhanvien.Items.Clear();
                        cboTenNhanvien.DataSource = dt;
                        cboTenNhanvien.DisplayMember = "HoTen";
                        cboTenNhanvien.ValueMember = "ID";
                        cboTenNhanvien.SelectedIndex = -1;

                        Console.WriteLine($"Số mục trong cboTenNhanvien: {cboTenNhanvien.Items.Count}");
                        if (cboTenNhanvien.Items.Count == 0)
                        {
                            MessageBox.Show("Dữ liệu nhân viên đã được lấy nhưng không hiển thị trong ComboBox.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên trong bảng Users.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy dữ liệu từ bảng Users.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (cboTenSach.SelectedIndex == -1 || cboTenNhanvien.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn sách và nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maSach = cboTenSach.SelectedValue.ToString();
                int maNhanVien = Convert.ToInt32(cboTenNhanvien.SelectedValue);

                if (!int.TryParse(txtSoLuong.Text, out int soLuongNhap) || soLuongNhap <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên dương)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string moTa = txtMoTa.Text.Trim();
                DateTime ngayNhap = dtNgayNhap.Value;
                DateTime ngayHienTai = DateTime.Now.Date; // Chỉ lấy ngày hiện tại (29/05/2025)

                // Kiểm tra ngày nhập kho không được lớn hơn ngày hiện tại (được phép bằng)
                if (ngayNhap.Date > ngayHienTai)
                {
                    MessageBox.Show("Ngày nhập kho không được lớn hơn ngày hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi BLL để thêm sách vào kho
                bool isAdded = bll.AddKhoSach(maSach, soLuongNhap, ngayNhap.ToString("yyyy-MM-dd"), moTa, maNhanVien);

                if (isAdded)
                {
                    MessageBox.Show("Thêm sách vào kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sách không thành công. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sách vào kho: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTenSach_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtSoLuong_TextChanged(object sender, EventArgs e) { }
        private void dtNgayNhap_ValueChanged(object sender, EventArgs e) { }
        private void cboTenNhanvien_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtMoTa_TextChanged(object sender, EventArgs e) { }
        private void frmKhoSachThem_Load_1(object sender, EventArgs e)
        {
            LoadSachToComboBox();
            LoadNhanVienToComboBox();
        }
    }
}