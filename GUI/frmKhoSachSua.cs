using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmKhoSachSua : Form
    {
        private KhoSachBLL bll = new KhoSachBLL();
        private int maKho; // Lưu MaKho để xác định bản ghi cần sửa
        private string maSach; // Sửa từ int thành string
        private int maNhanVien; // Lưu MaNhanVien (chỉ để hiển thị)

        public frmKhoSachSua()
        {
            InitializeComponent();
        }

        // Phương thức để nhận dữ liệu từ frmKhoSach
        public void SetData(int maKho, string maSach, string tenSach, int soLuongNhap, string ngayNhap, string moTa, int maNhanVien, string tenNhanVien)
        {
            this.maKho = maKho;
            this.maSach = maSach;
            this.maNhanVien = maNhanVien;

            // Hiển thị dữ liệu lên các điều khiển
            cboTenSach.Items.Clear();
            cboTenSach.Items.Add(tenSach);
            cboTenSach.SelectedIndex = 0;
            cboTenSach.Enabled = false; // Không cho phép chỉnh sửa Tên sách

            cboTenNhanvien.Items.Clear();
            cboTenNhanvien.Items.Add(tenNhanVien);
            cboTenNhanvien.SelectedIndex = 0;
            cboTenNhanvien.Enabled = false; // Không cho phép chỉnh sửa Tên nhân viên

            txtSoLuong.Text = soLuongNhap.ToString();
            try
            {
                dtNgayNhap.Value = DateTime.ParseExact(ngayNhap, "dd/MM/yyyy", null);
            }
            catch (FormatException)
            {
                dtNgayNhap.Value = DateTime.Now; // Giá trị mặc định nếu định dạng sai
            }
            txtMoTa.Text = moTa;
        }

        private void frmKhoSachSua_Load(object sender, EventArgs e)
        {
            // Không cần tải dữ liệu ở đây vì dữ liệu đã được truyền từ frmKhoSach
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            if (!int.TryParse(txtSoLuong.Text, out int soLuongNhap) || soLuongNhap <= 0)
            {
                MessageBox.Show("Số lượng phải là một số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime ngayNhap = dtNgayNhap.Value;
            DateTime ngayHienTai = DateTime.Now.Date; // Chỉ lấy ngày hiện tại (29/05/2025)
            string moTa = txtMoTa.Text.Trim();

            // Kiểm tra ngày nhập kho không được lớn hơn ngày hiện tại (được phép bằng)
            if (ngayNhap.Date > ngayHienTai)
            {
                MessageBox.Show("Ngày nhập kho không được lớn hơn ngày hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi BLL để cập nhật dữ liệu
            bool isUpdated = bll.UpdateKhoSach(maKho, soLuongNhap, ngayNhap, moTa);
            if (isUpdated)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Đặt DialogResult để báo cho frmKhoSach biết đã lưu thành công
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form mà không lưu
        }

        private void cboTenSach_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtSoLuong_TextChanged(object sender, EventArgs e) { }
        private void dtNgayNhap_ValueChanged(object sender, EventArgs e) { }
        private void cboTenNhanvien_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtMoTa_TextChanged(object sender, EventArgs e) { }
    }
}