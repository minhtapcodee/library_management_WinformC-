using QUANLYTHUVIENC3.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmTimKiem : Form
    {
        private SachBLL sachBLL = new SachBLL();
        private DataTable sachDataTable;
        private int pageSize = 5;
        private int currentPage = 1;
        private int totalPages;

        public frmTimKiem()
        {
            InitializeComponent();
            dataGridViewSach.ReadOnly = true;
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            LoadSachData();
            dataGridViewSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSach.MultiSelect = false;
        }

        private void LoadSachData()
        {
            try
            {
                sachDataTable = sachBLL.GetDanhSachSach();
                UpdatePagination();
                DisplayPage(currentPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePagination()
        {
            totalPages = (int)Math.Ceiling((double)sachDataTable.Rows.Count / pageSize);
            if (totalPages == 0) totalPages = 1;
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
            btnPreviousPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;
        }

        private void DisplayPage(int page)
        {
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, sachDataTable.Rows.Count);

            DataTable pageTable = sachDataTable.Clone();
            if (pageTable.Columns.Contains("HinhAnh"))
            {
                pageTable.Columns["HinhAnh"].DataType = typeof(string);
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow newRow = pageTable.NewRow();
                DataRow sourceRow = sachDataTable.Rows[i];

                foreach (DataColumn col in sachDataTable.Columns)
                {
                    newRow[col.ColumnName] = sourceRow[col.ColumnName];
                }

                pageTable.Rows.Add(newRow);
            }

            // Gán DataSource và đảm bảo dữ liệu không bị chỉnh sửa
            dataGridViewSach.DataSource = null; // Xóa DataSource cũ để tránh xung đột
            dataGridViewSach.DataSource = pageTable;
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            if (dataGridViewSach.Columns.Count > 0)
            {
                if (dataGridViewSach.Columns.Contains("MaSach"))
                {
                    dataGridViewSach.Columns["MaSach"].HeaderText = "Mã Sách";
                    dataGridViewSach.Columns["MaSach"].DisplayIndex = 0;
                }
                if (dataGridViewSach.Columns.Contains("TenSach"))
                {
                    dataGridViewSach.Columns["TenSach"].HeaderText = "Tên Sách";
                    dataGridViewSach.Columns["TenSach"].DisplayIndex = 1;
                }
                if (dataGridViewSach.Columns.Contains("TacGia"))
                {
                    dataGridViewSach.Columns["TacGia"].HeaderText = "Tác Giả";
                    dataGridViewSach.Columns["TacGia"].DisplayIndex = 2;
                }
                if (dataGridViewSach.Columns.Contains("NamXB"))
                {
                    dataGridViewSach.Columns["NamXB"].HeaderText = "Năm Xuất Bản";
                    dataGridViewSach.Columns["NamXB"].DisplayIndex = 3;
                }
                if (dataGridViewSach.Columns.Contains("NhaXB"))
                {
                    dataGridViewSach.Columns["NhaXB"].HeaderText = "Nhà Xuất Bản";
                    dataGridViewSach.Columns["NhaXB"].DisplayIndex = 4;
                }
                if (dataGridViewSach.Columns.Contains("TinhTrang"))
                {
                    dataGridViewSach.Columns["TinhTrang"].HeaderText = "Tình Trạng";
                    dataGridViewSach.Columns["TinhTrang"].DisplayIndex = 5;
                }
                if (dataGridViewSach.Columns.Contains("Gia"))
                {
                    dataGridViewSach.Columns["Gia"].HeaderText = "Giá";
                    dataGridViewSach.Columns["Gia"].DisplayIndex = 6;
                }
                if (dataGridViewSach.Columns.Contains("MoTa"))
                {
                    dataGridViewSach.Columns["MoTa"].HeaderText = "Mô Tả";
                    dataGridViewSach.Columns["MoTa"].DisplayIndex = 7;
                }
                if (dataGridViewSach.Columns.Contains("TenTheLoai"))
                {
                    // Ẩn cột TenTheLoai vì đã xóa chức năng lọc thể loại
                    dataGridViewSach.Columns["TenTheLoai"].Visible = false;
                }
                if (dataGridViewSach.Columns.Contains("HinhAnh"))
                {
                    // Ẩn cột HinhAnh trong DataGridView
                    dataGridViewSach.Columns["HinhAnh"].Visible = false;
                }

                dataGridViewSach.EnableHeadersVisualStyles = false;
                dataGridViewSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 179, 113); // Màu xanh lá đồng bộ
                dataGridViewSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewSach.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridViewSach.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

                dataGridViewSach.DefaultCellStyle.BackColor = Color.White;
                dataGridViewSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 245); // Màu xám nhạt thay cho vàng nhạt
                dataGridViewSach.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewSach.DefaultCellStyle.Font = new Font("Arial", 9);
                dataGridViewSach.DefaultCellStyle.Padding = new Padding(5);
                dataGridViewSach.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                // Đặt màu cho các ô được chọn
                dataGridViewSach.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 230); // Màu xanh nhạt
                dataGridViewSach.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewSach.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 230); // Đồng bộ màu xanh nhạt
                dataGridViewSach.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

                dataGridViewSach.GridColor = Color.FromArgb(200, 200, 200);
                dataGridViewSach.BackgroundColor = Color.FromArgb(230, 230, 230);
                dataGridViewSach.RowHeadersVisible = false;

                dataGridViewSach.RowTemplate.Height = 50;
                dataGridViewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiem.Focus();
                return;
            }

            try
            {
                sachDataTable = sachBLL.TimKiemSach(tuKhoa);
                currentPage = 1;
                UpdatePagination();
                DisplayPage(currentPage);
                if (sachDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLocTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSach();
        }

        private void FilterSach()
        {
            string tinhTrang = cboLocTinhTrang.SelectedItem?.ToString();

            try
            {
                sachDataTable = sachBLL.GetDanhSachSach();
                DataView dv = new DataView(sachDataTable);

                string filter = "";
                if (tinhTrang != "Tất cả")
                {
                    filter += $"TinhTrang = '{tinhTrang}'";
                }

                dv.RowFilter = filter;
                sachDataTable = dv.ToTable();
                currentPage = 1;
                UpdatePagination();
                DisplayPage(currentPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocTinhTrang.SelectedIndex = 0;
            LoadSachData();
            // Xóa thông tin chi tiết và hình ảnh khi làm mới
            pictureBoxSach.Image = null;
            lblMaSachValue.Text = "";
            lblTenSachValue.Text = "";
            lblTacGiaValue.Text = "";
            lblNamXBValue.Text = "";
            lblNhaXBValue.Text = "";
            lblTheLoaiValue.Text = "";
            lblGiaValue.Text = "";
            lblMoTaValue.Text = "";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayPage(currentPage);
                UpdatePagination();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayPage(currentPage);
                UpdatePagination();
            }
        }

        private void btnTimKiem_MouseEnter(object sender, EventArgs e) => btnTimKiem.BackColor = Color.FromArgb(40, 139, 83); // Màu xanh đậm khi hover
        private void btnTimKiem_MouseLeave(object sender, EventArgs e) => btnTimKiem.BackColor = Color.FromArgb(60, 179, 113); // Màu xanh lá bình thường
        private void btnLamMoi_MouseEnter(object sender, EventArgs e) => btnLamMoi.BackColor = Color.FromArgb(40, 139, 83); // Màu xanh đậm khi hover
        private void btnLamMoi_MouseLeave(object sender, EventArgs e) => btnLamMoi.BackColor = Color.FromArgb(60, 179, 113); // Màu xanh lá bình thường
        private void btnPreviousPage_MouseEnter(object sender, EventArgs e) => btnPreviousPage.BackColor = Color.FromArgb(40, 139, 83); // Màu xanh đậm khi hover
        private void btnPreviousPage_MouseLeave(object sender, EventArgs e) => btnPreviousPage.BackColor = Color.FromArgb(60, 179, 113); // Màu xanh lá bình thường
        private void btnNextPage_MouseEnter(object sender, EventArgs e) => btnNextPage.BackColor = Color.FromArgb(40, 139, 83); // Màu xanh đậm khi hover
        private void btnNextPage_MouseLeave(object sender, EventArgs e) => btnNextPage.BackColor = Color.FromArgb(60, 179, 113); // Màu xanh lá bình thường

        private void dataGridViewSach_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (dataGridViewSach.SelectedRows.Count == 0)
            {
                // Nếu không có hàng nào được chọn, xóa thông tin chi tiết
                pictureBoxSach.Image = null;
                lblMaSachValue.Text = "";
                lblTenSachValue.Text = "";
                lblTacGiaValue.Text = "";
                lblNamXBValue.Text = "";
                lblNhaXBValue.Text = "";
                lblTheLoaiValue.Text = "";
                lblGiaValue.Text = "";
                lblMoTaValue.Text = "";
                return;
            }

            DataGridViewRow selectedRow = dataGridViewSach.SelectedRows[0];

            // Hiển thị hình ảnh trong PictureBox
            if (dataGridViewSach.Columns.Contains("HinhAnh"))
            {
                string imagePath = selectedRow.Cells["HinhAnh"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        pictureBoxSach.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải hình ảnh từ đường dẫn {imagePath}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBoxSach.Image = null;
                    }
                }
                else
                {
                    pictureBoxSach.Image = null;
                }
            }

            // Hiển thị thông tin chi tiết với kiểm tra cột tồn tại
            lblMaSachValue.Text = dataGridViewSach.Columns.Contains("MaSach") ? (selectedRow.Cells["MaSach"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblTenSachValue.Text = dataGridViewSach.Columns.Contains("TenSach") ? (selectedRow.Cells["TenSach"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblTacGiaValue.Text = dataGridViewSach.Columns.Contains("TacGia") ? (selectedRow.Cells["TacGia"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblNamXBValue.Text = dataGridViewSach.Columns.Contains("NamXB") ? (selectedRow.Cells["NamXB"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblNhaXBValue.Text = dataGridViewSach.Columns.Contains("NhaXB") ? (selectedRow.Cells["NhaXB"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblTheLoaiValue.Text = "Không có dữ liệu"; // Xóa dữ liệu thể loại vì chức năng đã bị xóa
            lblGiaValue.Text = dataGridViewSach.Columns.Contains("Gia") ? (selectedRow.Cells["Gia"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblMoTaValue.Text = dataGridViewSach.Columns.Contains("MoTa") ? (selectedRow.Cells["MoTa"].Value?.ToString() ?? "") : "Không có dữ liệu";
        }
    }
}