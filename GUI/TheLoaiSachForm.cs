using QUANLYTHUVIENC3.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.DAL;
using MySql.Data.MySqlClient;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class TheLoaiSachForm : Form
    {
        private TheLoaiSachBLL theLoaiSachBLL = new TheLoaiSachBLL();
        private string selectedMaTL = null;
        private int currentPage = 1;
        private int pageSize = 7;
        private int totalRecords = 0;
        private int totalPages = 0;

        public TheLoaiSachForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.TopLevel = false;
            this.Text = string.Empty;
        }

        private void TheLoaiSachForm_Load(object sender, EventArgs e)
        {
            LoadTheLoaiSachData();
        }

        private void LoadTheLoaiSachData()
        {
            try
            {
                totalRecords = theLoaiSachBLL.GetTotalRecords();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                if (currentPage < 1) currentPage = 1;
                if (currentPage > totalPages && totalPages > 0) currentPage = totalPages;

                DataTable dt = theLoaiSachBLL.GetTheLoaiSachByPage(currentPage, pageSize);
                dataGridViewTheLoai.DataSource = dt;
                dataGridViewTheLoai.ReadOnly = true;
                dataGridViewTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                if (dt.Rows.Count > 0)
                {
                    if (dataGridViewTheLoai.Columns.Contains("MaTL"))
                    {
                        dataGridViewTheLoai.Columns["MaTL"].HeaderText = "Mã Thể Loại";
                        dataGridViewTheLoai.Columns["MaTL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridViewTheLoai.Columns["MaTL"].FillWeight = 50; // 50% chiều rộng
                    }
                    if (dataGridViewTheLoai.Columns.Contains("TenTheLoai"))
                    {
                        dataGridViewTheLoai.Columns["TenTheLoai"].HeaderText = "Tên Thể Loại";
                        dataGridViewTheLoai.Columns["TenTheLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridViewTheLoai.Columns["TenTheLoai"].FillWeight = 50; // 50% chiều rộng
                    }
                }

                // Căn giữa tiêu đề và nội dung
                dataGridViewTheLoai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewTheLoai.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewTheLoai.DefaultCellStyle.Font = new Font("Segoe UI", 10F); // Tăng font
                dataGridViewTheLoai.DefaultCellStyle.Padding = new Padding(5); // Thêm padding

                UpdatePaginationControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePaginationControls()
        {
            lblPageInfo.Text = totalPages > 0 ? $"Trang {currentPage}/{totalPages}" : "Trang 0/0";
            btnPreviousPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadTheLoaiSachData();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadTheLoaiSachData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoaiSachPopupForm popup = new TheLoaiSachPopupForm(null, null);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                currentPage = 1;
                LoadTheLoaiSachData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaTL))
            {
                MessageBox.Show("Vui lòng chọn một thể loại để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTheLoai = dataGridViewTheLoai.SelectedRows[0].Cells["TenTheLoai"].Value?.ToString();
            TheLoaiSachPopupForm popup = new TheLoaiSachPopupForm(selectedMaTL, tenTheLoai);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                LoadTheLoaiSachData();
            }
        }

        private int GetRelatedBooksCount(string maTL)
        {
            using (var conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Sach_TheLoai WHERE MaTL = @MaTL";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTL", maTL);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm sách liên quan (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaTL))
            {
                MessageBox.Show("Vui lòng chọn một thể loại để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int relatedBooksCount = GetRelatedBooksCount(selectedMaTL);
                string tenTheLoai = dataGridViewTheLoai.SelectedRows[0].Cells["TenTheLoai"].Value?.ToString();
                string warningMessage = relatedBooksCount > 0
                    ? $"Bạn có chắc chắn muốn xóa thể loại '{tenTheLoai}'? Có {relatedBooksCount} sách liên quan sẽ bị ảnh hưởng."
                    : $"Bạn có chắc chắn muốn xóa thể loại '{tenTheLoai}'?";

                if (MessageBox.Show(warningMessage, "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var (success, message) = theLoaiSachBLL.DeleteTheLoaiSach(selectedMaTL);
                    if (success)
                    {
                        MessageBox.Show($"Xóa thể loại '{tenTheLoai}' thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        currentPage = 1;
                        LoadTheLoaiSachData();
                        selectedMaTL = null;
                    }
                    else
                    {
                        MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa thể loại: Thể loại đang được sử dụng ở các mục quản lý khác nên không thể xóa ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTheLoai.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewTheLoai.SelectedRows[0];
                selectedMaTL = row.Cells["MaTL"].Value?.ToString();
            }
        }

        private void dataGridViewTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}