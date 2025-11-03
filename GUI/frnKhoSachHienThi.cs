using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frnKhoSachHienThi : Form
    {
        public frnKhoSachHienThi()
        {
            InitializeComponent();
        }


        // Phương thức để nhận và hiển thị dữ liệu
        public void SetData(int maKho, string maSach, string tenSach, string theLoai, int soLuongNhapKho, int soLuongDangMuon, int soLuongConLai, string tenNhanVien, string ngayNhap, string mieuTa)
        {
            txtMaKho.Text = maKho.ToString();
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtTheLoai.Text = theLoai;
            txtNhapKho.Text = soLuongNhapKho.ToString();
            txtDangMuon.Text = soLuongDangMuon.ToString();
            txtConLai.Text = soLuongConLai.ToString();
            txtTenNhanvien.Text = tenNhanVien;
            txtNgayNhap.Text = ngayNhap;
            txtMieuTa.Text = mieuTa;

            // Đặt các TextBox thành chỉ đọc
            txtMaKho.ReadOnly = true;
            txtMaSach.ReadOnly = true;
            txtTenSach.ReadOnly = true;
            txtTheLoai.ReadOnly = true;
            txtNhapKho.ReadOnly = true;
            txtDangMuon.ReadOnly = true;
            txtConLai.ReadOnly = true;
            txtTenNhanvien.ReadOnly = true;
            txtNgayNhap.ReadOnly = true;
            txtMieuTa.ReadOnly = true;
        }
        private void txtNgayNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMieuTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDangMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConLai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void frnKhoSachHienThi_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
