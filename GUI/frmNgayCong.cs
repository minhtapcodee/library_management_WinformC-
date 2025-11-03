using System;
using System.Data;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmNgayCong : Form
    {
        private NgayCongAdminBLL ngayCongAdminBLL = new NgayCongAdminBLL();
        private int currentPage = 1;
        private int rowsPerPage = 10; // Số dòng trên mỗi trang là 10
        private int totalRows = 0;

        public frmNgayCong()
        {
            InitializeComponent();
            dtpNgayChamCong.Enabled = false; // Đặt chỉ đọc khi form tải
            dtpNgayxacnhan.Value = DateTime.Today; // Đặt ngày xác nhận mặc định là ngày hiện tại
            dtpNgayxacnhan.Checked = true; // Đảm bảo ngày xác nhận được chọn mặc định
            // Thêm các lựa chọn vào cboTrangthai
            cboTrangthai.Items.Add("Tất cả");
            cboTrangthai.Items.Add("Chờ xác nhận");
            cboTrangthai.Items.Add("Đã xác nhận");
            cboTrangthai.Items.Add("Từ chối");
            cboTrangthai.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            dtpLocNgayChamCong.Value = DateTime.Today; // Đặt ngày lọc mặc định là hôm nay
            chkLocTheoNgay.Checked = false; // Mặc định không lọc theo ngày
            LoadChamCongData();
        }

        private void LoadChamCongData()
        {
            try
            {
                DataTable dt;
                string selectedTrangThai = cboTrangthai.SelectedItem?.ToString();
                DateTime? selectedNgayChamCong = chkLocTheoNgay.Checked ? (DateTime?)dtpLocNgayChamCong.Value.Date : null;

                // Sử dụng phương thức lọc theo cả trạng thái và ngày
                dt = ngayCongAdminBLL.GetChamCongByFilters(selectedTrangThai, selectedNgayChamCong);

                if (dt == null || dt.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    totalRows = 0;
                    lblPhantrang.Text = "Trang 0/0";
                    btnPrev.Enabled = false;
                    btnNext.Enabled = false;
                    MessageBox.Show("Không có dữ liệu chấm công để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                totalRows = dt.Rows.Count;
                int totalPages = (int)Math.Ceiling((double)totalRows / rowsPerPage);

                // Cập nhật nhãn phân trang
                lblPhantrang.Text = $"Trang {currentPage}/{totalPages}";

                // Bật/tắt nút điều hướng
                btnPrev.Enabled = currentPage > 1;
                btnNext.Enabled = currentPage < totalPages;

                // Áp dụng phân trang
                DataTable paginatedDt = dt.Clone();
                int startIndex = (currentPage - 1) * rowsPerPage;
                int endIndex = Math.Min(startIndex + rowsPerPage, totalRows);
                for (int i = startIndex; i < endIndex; i++)
                {
                    paginatedDt.ImportRow(dt.Rows[i]);
                }

                dataGridView1.DataSource = paginatedDt;

                // Tùy chỉnh tiêu đề cột
                dataGridView1.Columns["ChamCongID"].HeaderText = "ID Chấm Công";
                dataGridView1.Columns["UserID"].HeaderText = "ID Nhân Viên";
                dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
                dataGridView1.Columns["NgayChamCong"].HeaderText = "Ngày Chấm Công";
                dataGridView1.Columns["GioVao"].HeaderText = "Giờ Vào";
                dataGridView1.Columns["GioRa"].HeaderText = "Giờ Ra";
                dataGridView1.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
                dataGridView1.Columns["GhiChu"].HeaderText = "Ghi Chú";
                dataGridView1.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dataGridView1.Columns["NgayXacNhan"].HeaderText = "Ngày Xác Nhận";
                dataGridView1.Columns["AdminXacNhanID"].HeaderText = "ID Admin Xác Nhận";

                // Ẩn cột ChamCongID và AdminXacNhanID
                dataGridView1.Columns["ChamCongID"].Visible = false;
                dataGridView1.Columns["AdminXacNhanID"].Visible = false;

                // Thiết lập giao diện DataGridView với tông xanh lá cây đẹp hơn
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50); // Xanh lá cây đậm (Dark Green) cho tiêu đề cột
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Chữ trắng trên tiêu đề cột
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                dataGridView1.EnableHeadersVisualStyles = false;

                dataGridView1.DefaultCellStyle.BackColor = Color.White; // Nền dòng bình thường màu trắng
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Chữ đen để dễ đọc
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 199, 132); // Xanh lá cây trung bình (Medium Green) khi chọn
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(210, 250, 190); // Xanh lá cây nhạt (Light Green) cho dòng xen kẽ
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 40; // Tăng chiều cao của từng dòng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGiovao_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGiora_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGhichu_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboTrangthaifield_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtpNgayxacnhan_ValueChanged(object sender, EventArgs e)
        {
        }

        private void picHinhanh_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có hàng nào được chọn không
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một bản ghi để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy hàng được chọn
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                if (row.Cells["ChamCongID"].Value == null)
                {
                    MessageBox.Show("Bản ghi không có ID chấm công hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int chamCongId = Convert.ToInt32(row.Cells["ChamCongID"].Value);

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtGiovao.Text))
                {
                    MessageBox.Show("Vui lòng nhập giờ vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra định dạng giờ vào (HH:mm:ss)
                if (!TimeSpan.TryParse(txtGiovao.Text, out _))
                {
                    MessageBox.Show("Giờ vào không đúng định dạng (HH:mm:ss)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGiora.Text))
                {
                    MessageBox.Show("Vui lòng nhập giờ ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra định dạng giờ ra (HH:mm:ss)
                if (!TimeSpan.TryParse(txtGiora.Text, out _))
                {
                    MessageBox.Show("Giờ ra không đúng định dạng (HH:mm:ss)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giờ ra không được nhỏ hơn hoặc bằng giờ vào
                try
                {
                    TimeSpan gioVaoTimeSpan = TimeSpan.Parse(txtGiovao.Text);
                    TimeSpan gioRaTimeSpan = TimeSpan.Parse(txtGiora.Text);

                    if (gioRaTimeSpan <= gioVaoTimeSpan)
                    {
                        MessageBox.Show("Giờ ra phải lớn hơn giờ vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Định dạng giờ vào hoặc giờ ra không hợp lệ! Vui lòng nhập theo định dạng HH:mm:ss (ví dụ: 08:00:00).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Giờ vào hoặc giờ ra không hợp lệ! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(cboTrangthaifield.Text))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giá trị trạng thái hợp lệ
                string[] validTrangThai = { "Chờ xác nhận", "Đã xác nhận", "Từ chối" };
                if (!validTrangThai.Contains(cboTrangthaifield.Text))
                {
                    MessageBox.Show("Trạng thái không hợp lệ! Vui lòng chọn: Chờ xác nhận, Đã xác nhận, hoặc Từ chối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra ngày xác nhận không được nhỏ hơn ngày chấm công
                if (dtpNgayxacnhan.Checked)
                {
                    DateTime ngayChamCong = dtpNgayChamCong.Value.Date;
                    DateTime ngayXacNhan = dtpNgayxacnhan.Value.Date;

                    if (ngayXacNhan < ngayChamCong)
                    {
                        MessageBox.Show($"Ngày xác nhận ({ngayXacNhan.ToString("dd/MM/yyyy")}) không được nhỏ hơn ngày chấm công ({ngayChamCong.ToString("dd/MM/yyyy")})!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DateTime? ngayXacNhanNullable = null;
                if (dtpNgayxacnhan.Checked)
                {
                    ngayXacNhanNullable = dtpNgayxacnhan.Value;
                }

                // Gọi BLL để cập nhật bản ghi
                ngayCongAdminBLL.UpdateChamCong(chamCongId, txtGiovao.Text, txtGiora.Text, txtGhichu.Text, cboTrangthaifield.Text, ngayXacNhanNullable);

                // Hiển thị thông báo thành công và làm mới dữ liệu
                MessageBox.Show("Cập nhật bản ghi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChamCongData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // Đặt tất cả TextBox về rỗng
                txtGiovao.Text = "";
                txtGiora.Text = "";
                txtGhichu.Text = "";

                // Đặt cboTrangthaifield về giá trị mặc định (chưa chọn)
                cboTrangthaifield.SelectedIndex = -1;

                // Đặt dtpNgayxacnhan về trạng thái không được chọn
                dtpNgayxacnhan.Checked = false;

                // Đặt hình ảnh trong picHinhanh về ErrorImage
                picHinhanh.Image = picHinhanh.ErrorImage;
                picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;

                // Reset trạng thái lọc theo ngày
                chkLocTheoNgay.Checked = false;

                // Reset trang về trang đầu tiên và load lại DataGridView
                currentPage = 1;
                LoadChamCongData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải click vào hàng hợp lệ không (e.RowIndex >= 0 để tránh click vào tiêu đề)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Điền dữ liệu từ hàng được chọn vào các control
                try
                {
                    dtpNgayChamCong.Value = row.Cells["NgayChamCong"].Value != DBNull.Value ?
                        Convert.ToDateTime(row.Cells["NgayChamCong"].Value) : DateTime.Today;
                }
                catch
                {
                    dtpNgayChamCong.Value = DateTime.Today;
                }

                txtGiovao.Text = row.Cells["GioVao"].Value?.ToString() ?? "";
                txtGiora.Text = row.Cells["GioRa"].Value?.ToString() ?? "";
                txtGhichu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
                cboTrangthaifield.Text = row.Cells["TrangThai"].Value?.ToString() ?? "";

                try
                {
                    if (row.Cells["NgayXacNhan"].Value != DBNull.Value)
                    {
                        dtpNgayxacnhan.Value = Convert.ToDateTime(row.Cells["NgayXacNhan"].Value);
                        dtpNgayxacnhan.Checked = true;
                    }
                    else
                    {
                        dtpNgayxacnhan.Checked = false;
                    }
                }
                catch
                {
                    dtpNgayxacnhan.Checked = false;
                }

                // Tải hình ảnh vào PictureBox nếu có đường dẫn hợp lệ
                string imagePath = row.Cells["HinhAnh"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        picHinhanh.Image = System.Drawing.Image.FromFile(imagePath);
                        picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        try
                        {
                            string defaultImagePath = "GUI/Image/error1.png";
                            picHinhanh.Image = System.Drawing.Image.FromFile(defaultImagePath);
                            picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch
                        {
                            MessageBox.Show("Không tìm thấy hình ảnh mặc định tại GUI/Image/error1.png!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picHinhanh.Image = null;
                        }
                    }
                }
                else
                {
                    try
                    {
                        string defaultImagePath = "GUI/Image/error1.png";
                        picHinhanh.Image = System.Drawing.Image.FromFile(defaultImagePath);
                        picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm thấy hình ảnh mặc định tại GUI/Image/error1.png!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picHinhanh.Image = null;
                    }
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadChamCongData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRows / rowsPerPage);
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadChamCongData();
            }
        }

        private void lblPhantrang_Click(object sender, EventArgs e)
        {
        }

        private void cboTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang 1 khi thay đổi lọc
            LoadChamCongData();
        }

        private void dtpLocNgayChamCong_ValueChanged(object sender, EventArgs e)
        {
            if (chkLocTheoNgay.Checked) // Chỉ làm mới dữ liệu nếu đang bật lọc ngày
            {
                currentPage = 1; // Reset về trang 1 khi thay đổi lọc
                LoadChamCongData();
            }
        }

        private void dtpNgayChamCong_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cboTrangthaifield_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chkLocTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang 1 khi thay đổi trạng thái lọc
            LoadChamCongData();
        }
    }
}