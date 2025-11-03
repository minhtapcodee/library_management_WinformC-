using System;
using System.Data;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;
using System.IO;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmNgayCongNhanvien : Form
    {
        private ChamCongBLL chamCongBLL = new ChamCongBLL();
        private int loggedInUserId;
        private string loggedInUserRole;
        private string selectedImagePath; // To store the path of the selected image

        public frmNgayCongNhanvien(int userId, string role)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRole = role;
            // Set DateTimePicker to current date and make it read-only
            dtpNgayChamCong.Value = DateTime.Today; // Set to 5/7/2025 today
            dtpNgayChamCong.Enabled = false; // Prevent user from changing the date
            LoadChamCongData();
        }

        private void LoadChamCongData()
        {
            try
            {
                DataTable dt = chamCongBLL.GetChamCongData(loggedInUserId, loggedInUserRole);
                dataGridView1.DataSource = dt;

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

                // Thiết lập giao diện DataGridView với tông xanh lá cây giống frmNgayCong
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
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtTrangthai_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNgayxacnhan_TextChanged(object sender, EventArgs e)
        {
        }

        private void picHinhanh_Click(object sender, EventArgs e)
        {
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select an image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the filter to image files only
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
                openFileDialog.Title = "Select an Image";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Store the selected image path
                        selectedImagePath = openFileDialog.FileName;

                        // Load the selected image into the PictureBox
                        picHinhanh.Image = System.Drawing.Image.FromFile(selectedImagePath);
                        picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Load default image if the selected image fails to load
                        try
                        {
                            string defaultImagePath = "GUI/Image/error1.png";
                            picHinhanh.Image = System.Drawing.Image.FromFile(defaultImagePath);
                            picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch
                        {
                            MessageBox.Show("Default image not found at GUI/Image/error1.png!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picHinhanh.Image = null;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtGiovao.Text))
                {
                    MessageBox.Show("Vui lòng nhập giờ vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGiora.Text))
                {
                    MessageBox.Show("Vui lòng nhập giờ ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate time format and comparison
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

                if (string.IsNullOrWhiteSpace(selectedImagePath))
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the current date from DateTimePicker
                DateTime ngayChamCong = dtpNgayChamCong.Value.Date;

                // Ensure the date is the current date
                if (ngayChamCong.Date != DateTime.Today.Date)
                {
                    MessageBox.Show("Bạn chỉ được chấm công cho ngày hiện tại (" + DateTime.Today.ToString("dd/MM/yyyy") + ")!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for duplicate record (same UserID and NgayChamCong)
                DataTable existingRecords = chamCongBLL.GetChamCongData(loggedInUserId, loggedInUserRole);
                foreach (DataRow row in existingRecords.Rows)
                {
                    if (row["NgayChamCong"] != DBNull.Value && Convert.ToDateTime(row["NgayChamCong"]).Date == ngayChamCong.Date)
                    {
                        MessageBox.Show("Hôm nay bạn đã chấm công rồi, vui lòng quay lại vào ngày mai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Copy the selected image to the project folder (GUI/Image/)
                string imageFileName = Path.GetFileName(selectedImagePath);
                string newImagePath = Path.Combine(Application.StartupPath, "GUI/Image", imageFileName);
                string relativeImagePath = Path.Combine("GUI/Image", imageFileName);

                // Create the directory if it doesn't exist
                Directory.CreateDirectory(Path.GetDirectoryName(newImagePath));
                File.Copy(selectedImagePath, newImagePath, true); // Copy the image to the project folder

                // Get other input values
                string gioVao = txtGiovao.Text; // No re-declaration, use the string directly
                string gioRa = txtGiora.Text;   // No re-declaration, use the string directly
                string ghiChu = string.IsNullOrWhiteSpace(txtGhichu.Text) ? null : txtGhichu.Text;

                // Add the new record via BLL (NgayXacNhan is NULL by default)
                chamCongBLL.AddChamCong(loggedInUserId, ngayChamCong, gioVao, gioRa, relativeImagePath, ghiChu, null);

                // Show success message
                MessageBox.Show("Thêm bản ghi chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the form and DataGridView
                btnRefresh_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtGiovao.Text = "";
            txtGiora.Text = "";
            txtGhichu.Text = "";
            txtNgayxacnhan.Text = "";
            // Note: txtTrangthai is not used for adding, as TrangThai is set to "Chờ xác nhận" by default
            // dtpNgayChamCong remains set to current date and is not cleared

            // Load default image into PictureBox instead of clearing it
            try
            {
                string defaultImagePath = "GUI/Image/error1.png";
                picHinhanh.Image = System.Drawing.Image.FromFile(defaultImagePath);
                picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                MessageBox.Show("Default image not found at GUI/Image/error1.png!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picHinhanh.Image = null; // Fallback to blank if default image fails
            }

            // Clear the selected image path
            selectedImagePath = null;

            // Refresh DataGridView data
            LoadChamCongData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked (e.RowIndex >= 0 ensures it's not a header click)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate controls with the selected row's data, formatting dates to show only date
                dtpNgayChamCong.Value = row.Cells["NgayChamCong"].Value != DBNull.Value ?
                    Convert.ToDateTime(row.Cells["NgayChamCong"].Value) : DateTime.Today;
                txtGiovao.Text = row.Cells["GioVao"].Value?.ToString() ?? "";
                txtGiora.Text = row.Cells["GioRa"].Value?.ToString() ?? "";
                txtGhichu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
                txtTrangthai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "";
                txtNgayxacnhan.Text = row.Cells["NgayXacNhan"].Value != DBNull.Value ?
                    Convert.ToDateTime(row.Cells["NgayXacNhan"].Value).ToShortDateString() : "";

                // Load image into PictureBox if HinhAnh contains a valid file path
                string imagePath = row.Cells["HinhAnh"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        picHinhanh.Image = System.Drawing.Image.FromFile(imagePath);
                        picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image display mode
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Load default image instead of clearing PictureBox
                        try
                        {
                            string defaultImagePath = "GUI/Image/error1.png";
                            picHinhanh.Image = System.Drawing.Image.FromFile(defaultImagePath);
                            picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch
                        {
                            MessageBox.Show("Default image not found at GUI/Image/error1.png!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picHinhanh.Image = null; // Fallback to blank if default image also fails
                        }
                    }
                }
                else
                {
                    // Load default image if no valid image path
                    try
                    {
                        string defaultImagePath = "GUI/Image/error1.png";
                        picHinhanh.Image = System.Drawing.Image.FromFile(defaultImagePath);
                        picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch
                    {
                        MessageBox.Show("Default image not found at GUI/Image/error1.png!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picHinhanh.Image = null; // Fallback to blank if default image also fails
                    }
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        }

        private void lblPhantrang_Click(object sender, EventArgs e)
        {
        }

        private void cboTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}