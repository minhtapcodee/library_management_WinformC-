using ClosedXML.Excel;
using QUANLYTHUVIENC3.BLL;
using QUANLYTHUVIENC3.DAL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class SachForm : Form
    {
        private SachBLL sachBLL = new SachBLL();
        private TheLoaiSachDAL theLoaiSachDAL = new TheLoaiSachDAL();
        private DataTable sachDataTable;
        private int pageSize = 10;
        private int currentPage = 1;
        private int totalPages;

        public SachForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            dataGridViewSach.ReadOnly = true;
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            LoadSachData();
            LoadTheLoaiSach();
            dataGridViewSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSach.MultiSelect = false;
        }

        private void LoadSachData()
        {
            try
            {
                sachDataTable = sachBLL.GetAllSach();
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

            dataGridViewSach.DataSource = null;
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
                if (dataGridViewSach.Columns.Contains("TheLoai"))
                {
                    dataGridViewSach.Columns["TheLoai"].HeaderText = "Thể Loại";
                    dataGridViewSach.Columns["TheLoai"].DisplayIndex = 8;
                }
                if (dataGridViewSach.Columns.Contains("HinhAnh"))
                {
                    dataGridViewSach.Columns["HinhAnh"].Visible = false;
                }

                dataGridViewSach.EnableHeadersVisualStyles = false;
                dataGridViewSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 179, 113);
                dataGridViewSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewSach.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridViewSach.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

                dataGridViewSach.DefaultCellStyle.BackColor = Color.White;
                dataGridViewSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 245);
                dataGridViewSach.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewSach.DefaultCellStyle.Font = new Font("Arial", 9);
                dataGridViewSach.DefaultCellStyle.Padding = new Padding(5);
                dataGridViewSach.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dataGridViewSach.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 230);
                dataGridViewSach.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewSach.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 230);
                dataGridViewSach.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

                dataGridViewSach.GridColor = Color.FromArgb(200, 200, 200);
                dataGridViewSach.BackgroundColor = Color.FromArgb(230, 230, 230);
                dataGridViewSach.RowHeadersVisible = false;

                dataGridViewSach.RowTemplate.Height = 50;
                dataGridViewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LoadTheLoaiSach()
        {
            try
            {
                DataTable dt = theLoaiSachDAL.GetAllTheLoaiSach();
                cboLocTheLoai.Items.Clear();
                cboLocTheLoai.Items.Add("Tất cả");
                foreach (DataRow row in dt.Rows)
                {
                    cboLocTheLoai.Items.Add(row["TenTheLoai"].ToString());
                }
                cboLocTheLoai.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thể loại: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SachPopupForm popup = new SachPopupForm();
            if (popup.ShowDialog() == DialogResult.OK)
                LoadSachData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewSach.SelectedRows.Count > 0)
            {
                string maSach = dataGridViewSach.SelectedRows[0].Cells["MaSach"].Value.ToString();
                SachPopupForm popup = new SachPopupForm(maSach);
                if (popup.ShowDialog() == DialogResult.OK)
                    LoadSachData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewSach.SelectedRows.Count > 0)
            {
                string maSach = dataGridViewSach.SelectedRows[0].Cells["MaSach"].Value.ToString();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sách {maSach}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var (success, message) = sachBLL.DeleteSach(maSach);
                        if (success)
                        {
                            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSachData();
                        }
                        else
                        {
                            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi không xác định khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cboLocTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSach();
        }

        private void FilterSach()
        {
            string tinhTrang = cboLocTinhTrang.SelectedItem?.ToString();
            string theLoai = cboLocTheLoai.SelectedItem?.ToString();

            try
            {
                sachDataTable = sachBLL.GetDanhSachSach();
                DataView dv = new DataView(sachDataTable);

                string filter = "";
                if (tinhTrang != "Tất cả")
                {
                    filter += $"TinhTrang = '{tinhTrang}'";
                }
                if (theLoai != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"TheLoai LIKE '%{theLoai}%'";
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
            cboLocTheLoai.SelectedIndex = 0;
            LoadSachData();
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (sachDataTable == null || sachDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel Files|*.xlsx";
                    sfd.FileName = $"DanhSachSach_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportToExcel(sachDataTable, sfd.FileName);
                        MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel(DataTable dt, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DanhSachSach");

                // Thêm tiêu đề chính
                worksheet.Cell(1, 1).Value = "Danh Sách Sách";
                worksheet.Range("A1:I1").Merge().Style
                    .Font.SetBold()
                    .Font.SetFontSize(16)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                // Thêm tiêu đề cột
                string[] headers = { "Mã Sách", "Tên Sách", "Tác Giả", "Năm Xuất Bản", "Nhà Xuất Bản", "Tình Trạng", "Giá", "Mô Tả", "Thể Loại" };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cell(3, i + 1).Value = headers[i];
                    worksheet.Cell(3, i + 1).Style
                        .Font.SetBold()
                        .Fill.SetBackgroundColor(XLColor.FromArgb(60, 179, 113))
                        .Font.SetFontColor(XLColor.White)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                }

                // Thêm dữ liệu
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    worksheet.Cell(i + 4, 1).Value = dt.Rows[i]["MaSach"]?.ToString();
                    worksheet.Cell(i + 4, 2).Value = dt.Rows[i]["TenSach"]?.ToString();
                    worksheet.Cell(i + 4, 3).Value = dt.Rows[i]["TacGia"]?.ToString();
                    worksheet.Cell(i + 4, 4).Value = dt.Rows[i]["NamXB"]?.ToString();
                    worksheet.Cell(i + 4, 5).Value = dt.Rows[i]["NhaXB"]?.ToString();
                    worksheet.Cell(i + 4, 6).Value = dt.Rows[i]["TinhTrang"]?.ToString();
                    worksheet.Cell(i + 4, 7).Value = dt.Rows[i]["Gia"]?.ToString();
                    worksheet.Cell(i + 4, 8).Value = dt.Rows[i]["MoTa"]?.ToString();
                    worksheet.Cell(i + 4, 9).Value = dt.Rows[i]["TheLoai"]?.ToString();
                }

                // Định dạng bảng
                var tableRange = worksheet.Range(3, 1, dt.Rows.Count + 3, 9);
                tableRange.CreateTable();
                worksheet.Columns().AdjustToContents();

                // Lưu file
                workbook.SaveAs(filePath);
            }
        }

        private void dataGridViewSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSach.SelectedRows.Count == 0)
            {
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

            lblMaSachValue.Text = dataGridViewSach.Columns.Contains("MaSach") ? (selectedRow.Cells["MaSach"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblTenSachValue.Text = dataGridViewSach.Columns.Contains("TenSach") ? (selectedRow.Cells["TenSach"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblTacGiaValue.Text = dataGridViewSach.Columns.Contains("TacGia") ? (selectedRow.Cells["TacGia"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblNamXBValue.Text = dataGridViewSach.Columns.Contains("NamXB") ? (selectedRow.Cells["NamXB"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblNhaXBValue.Text = dataGridViewSach.Columns.Contains("NhaXB") ? (selectedRow.Cells["NhaXB"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblTheLoaiValue.Text = dataGridViewSach.Columns.Contains("TheLoai") ? (selectedRow.Cells["TheLoai"].Value?.ToString() ?? "Không có dữ liệu") : "Không có dữ liệu";
            lblGiaValue.Text = dataGridViewSach.Columns.Contains("Gia") ? (selectedRow.Cells["Gia"].Value?.ToString() ?? "") : "Không có dữ liệu";
            lblMoTaValue.Text = dataGridViewSach.Columns.Contains("MoTa") ? (selectedRow.Cells["MoTa"].Value?.ToString() ?? "") : "Không có dữ liệu";
        }

        private void btnThem_MouseEnter(object sender, EventArgs e) => btnThem.BackColor = Color.FromArgb(40, 139, 83);
        private void btnThem_MouseLeave(object sender, EventArgs e) => btnThem.BackColor = Color.FromArgb(60, 179, 113);
        private void btnSua_MouseEnter(object sender, EventArgs e) => btnSua.BackColor = Color.FromArgb(40, 139, 83);
        private void btnSua_MouseLeave(object sender, EventArgs e) => btnSua.BackColor = Color.FromArgb(60, 179, 113);
        private void btnXoa_MouseEnter(object sender, EventArgs e) => btnXoa.BackColor = Color.FromArgb(40, 139, 83);
        private void btnXoa_MouseLeave(object sender, EventArgs e) => btnXoa.BackColor = Color.FromArgb(60, 179, 113);
        private void btnTimKiem_MouseEnter(object sender, EventArgs e) => btnTimKiem.BackColor = Color.FromArgb(40, 139, 83);
        private void btnTimKiem_MouseLeave(object sender, EventArgs e) => btnTimKiem.BackColor = Color.FromArgb(60, 179, 113);
        private void btnLamMoi_MouseEnter(object sender, EventArgs e) => btnLamMoi.BackColor = Color.FromArgb(40, 139, 83);
        private void btnLamMoi_MouseLeave(object sender, EventArgs e) => btnLamMoi.BackColor = Color.FromArgb(60, 179, 113);
        private void btnPreviousPage_MouseEnter(object sender, EventArgs e) => btnPreviousPage.BackColor = Color.FromArgb(40, 139, 83);
        private void btnPreviousPage_MouseLeave(object sender, EventArgs e) => btnPreviousPage.BackColor = Color.FromArgb(60, 179, 113);
        private void btnNextPage_MouseEnter(object sender, EventArgs e) => btnNextPage.BackColor = Color.FromArgb(40, 139, 83);
        private void btnNextPage_MouseLeave(object sender, EventArgs e) => btnNextPage.BackColor = Color.FromArgb(60, 179, 113);
        private void btnXuatExcel_MouseEnter(object sender, EventArgs e) => btnXuatExcel.BackColor = Color.FromArgb(40, 139, 83);
        private void btnXuatExcel_MouseLeave(object sender, EventArgs e) => btnXuatExcel.BackColor = Color.FromArgb(60, 179, 113);

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}