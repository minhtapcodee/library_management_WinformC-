using MySql.Data.MySqlClient;
using QUANLYTHUVIENC3.BLL;
using QUANLYTHUVIENC3.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class SachPopupForm : Form
    {
        private SachBLL sachBLL = new SachBLL();
        private TheLoaiSachDAL theLoaiSachDAL = new TheLoaiSachDAL();
        private string maSach = null;

        public SachPopupForm(string maSach = null)
        {
            InitializeComponent();
            this.maSach = maSach;
            LoadTheLoaiSach();
            if (maSach != null)
            {
                LoadSachData();
                Text = "Sửa Sách";
                txtMaSach.Enabled = false; // Không cho sửa mã sách khi chỉnh sửa
            }
            else
            {
                Text = "Thêm Sách";
            }
        }

        private void LoadTheLoaiSach()
        {
            try
            {
                DataTable dt = theLoaiSachDAL.GetAllTheLoaiSach();
                cboMaTL.DataSource = dt;
                cboMaTL.DisplayMember = "TenTheLoai";
                cboMaTL.ValueMember = "MaTL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thể loại: " + ex.Message);
            }
        }

        private void LoadSachData()
        {
            try
            {
                DataTable dt = sachBLL.GetAllSach();
                DataRow[] rows = dt.Select($"MaSach = '{maSach}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    txtMaSach.Text = row["MaSach"].ToString();
                    txtTenSach.Text = row["TenSach"].ToString();
                    txtHinhAnh.Text = row["HinhAnh"]?.ToString();
                    txtTacGia.Text = row["TacGia"].ToString();
                    txtNamXB.Text = row["NamXB"].ToString();
                    txtNhaXB.Text = row["NhaXB"].ToString();
                    cboTinhTrang.SelectedItem = row["TinhTrang"].ToString();
                    txtGia.Text = row["Gia"].ToString();
                    txtMoTa.Text = row["MoTa"].ToString();

                    // Lấy thể loại từ bảng Sach_TheLoai
                    using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                    {
                        conn.Open();
                        string query = "SELECT MaTL FROM Sach_TheLoai WHERE MaSach = @MaSach";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            cboMaTL.SelectedValue = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin sách: " + ex.Message);
            }
        }

        private void btnChonHinhAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn hình ảnh sách";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtHinhAnh.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = txtMaSach.Text.Trim();
                string tenSach = txtTenSach.Text.Trim();
                string hinhAnh = txtHinhAnh.Text.Trim(); // Lấy đường dẫn hình ảnh
                string tacGia = txtTacGia.Text.Trim();
                string namXBText = txtNamXB.Text.Trim();
                string nhaXB = txtNhaXB.Text.Trim();
                string tinhTrang = cboTinhTrang.SelectedItem?.ToString();
                string giaText = txtGia.Text.Trim();
                string moTa = txtMoTa.Text.Trim();
                string maTL = cboMaTL.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(maSach) || string.IsNullOrEmpty(tenSach) || string.IsNullOrEmpty(tinhTrang) || string.IsNullOrEmpty(giaText))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(namXBText, out int namXB))
                {
                    MessageBox.Show("Năm xuất bản phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(giaText, out decimal gia) || gia < 0)
                {
                    MessageBox.Show("Giá phải là số hợp lệ và không âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển maTL thành mảng string[] (chỉ có 1 phần tử nếu chọn 1 thể loại)
                string[] maTLs = string.IsNullOrEmpty(maTL) ? new string[0] : new string[] { maTL };

                if (this.maSach == null)
                {
                    sachBLL.AddSach(maSach, tenSach, hinhAnh, tacGia, namXB, nhaXB, tinhTrang, gia, moTa, maTLs);
                    MessageBox.Show("Thêm sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sachBLL.UpdateSach(maSach, tenSach, hinhAnh, tacGia, namXB, nhaXB, tinhTrang, gia, moTa, maTLs);
                    MessageBox.Show("Cập nhật sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SachPopupForm_Load(object sender, EventArgs e)
        {
        }
    }
}