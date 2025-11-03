using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmSachSapHet : Form
    {
        private KhoSachBLL khoSachBLL = new KhoSachBLL();

        public frmSachSapHet()
        {
            InitializeComponent();
            InitializeControls();
            CustomizeFormAppearance();
            LoadLowStockBooks();
        }

        private void CustomizeFormAppearance()
        {
            // Form styling
            this.BackColor = Color.FromArgb(220, 240, 255); // Light blue background
            this.Font = new Font("Segoe UI", 10F);

            // Customize DataGridView
            CustomizeDataGridView();

            // Customize Button
            btnDong.BackColor = Color.FromArgb(0, 105, 148); // Deep sea blue
            btnDong.FlatAppearance.BorderSize = 2;
            btnDong.FlatAppearance.BorderColor = Color.FromArgb(0, 50, 80); // Dark blue border
            btnDong.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 200); // Lighter sea blue on hover
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.ForeColor = Color.White;
            btnDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Customize Label
            lblStatus.ForeColor = Color.FromArgb(0, 50, 80); // Dark blue for text
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
        }

        private void CustomizeDataGridView()
        {
            dgvSachSapHet.BackgroundColor = Color.White;
            dgvSachSapHet.BorderStyle = BorderStyle.None;
            dgvSachSapHet.EnableHeadersVisualStyles = false;

            // Header styling
            dgvSachSapHet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 105, 148); // Deep sea blue
            dgvSachSapHet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSachSapHet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvSachSapHet.ColumnHeadersHeight = 40;
            dgvSachSapHet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Row styling
            dgvSachSapHet.DefaultCellStyle.BackColor = Color.White;
            dgvSachSapHet.DefaultCellStyle.ForeColor = Color.Black;
            dgvSachSapHet.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvSachSapHet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 230, 255); // Soft blue for alternating rows
            dgvSachSapHet.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 200); // Lighter sea blue for selection
            dgvSachSapHet.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Grid styling
            dgvSachSapHet.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvSachSapHet.GridColor = Color.FromArgb(200, 200, 200);
        }

        private void InitializeControls()
        {
            // Khởi tạo DataGridView
            dgvSachSapHet.AutoGenerateColumns = false;
            dgvSachSapHet.Columns.Clear();

            DataGridViewTextBoxColumn colMaKho = new DataGridViewTextBoxColumn
            {
                Name = "MaKho",
                HeaderText = "Mã Kho",
                DataPropertyName = "MaKho"
            };
            dgvSachSapHet.Columns.Add(colMaKho);

            DataGridViewTextBoxColumn colMaSach = new DataGridViewTextBoxColumn
            {
                Name = "MaSach",
                HeaderText = "Mã Sách",
                DataPropertyName = "MaSach"
            };
            dgvSachSapHet.Columns.Add(colMaSach);

            DataGridViewTextBoxColumn colTenSach = new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                HeaderText = "Tên Sách",
                DataPropertyName = "TenSach"
            };
            dgvSachSapHet.Columns.Add(colTenSach);

            DataGridViewTextBoxColumn colTenTheLoai = new DataGridViewTextBoxColumn
            {
                Name = "TenTheLoai",
                HeaderText = "Thể Loại",
                DataPropertyName = "TenTheLoai"
            };
            dgvSachSapHet.Columns.Add(colTenTheLoai);

            DataGridViewTextBoxColumn colSoLuongNhap = new DataGridViewTextBoxColumn
            {
                Name = "SoLuongNhap",
                HeaderText = "Số Lượng Nhập",
                DataPropertyName = "SoLuongNhap"
            };
            dgvSachSapHet.Columns.Add(colSoLuongNhap);

            DataGridViewTextBoxColumn colSoLuongDangMuon = new DataGridViewTextBoxColumn
            {
                Name = "SoLuongDangMuon",
                HeaderText = "Số Lượng Đang Mượn",
                DataPropertyName = "SoLuongDangMuon"
            };
            dgvSachSapHet.Columns.Add(colSoLuongDangMuon);

            DataGridViewTextBoxColumn colSoLuongConLai = new DataGridViewTextBoxColumn
            {
                Name = "SoLuongConLai",
                HeaderText = "Số Lượng Còn Lại",
                DataPropertyName = "SoLuongConLai"
            };
            dgvSachSapHet.Columns.Add(colSoLuongConLai);

            // Tùy chỉnh kích thước cột
            foreach (DataGridViewColumn column in dgvSachSapHet.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadLowStockBooks()
        {
            try
            {
                DataTable lowStockBooks = khoSachBLL.GetLowStockBooks(5);
                if (lowStockBooks == null || lowStockBooks.Rows.Count == 0)
                {
                    lblStatus.Text = "Không có sách nào tồn kho thấp (dưới hoặc bằng 5 quyển).";
                    dgvSachSapHet.DataSource = null;
                    return;
                }

                dgvSachSapHet.DataSource = null;
                dgvSachSapHet.DataSource = lowStockBooks;
                dgvSachSapHet.Refresh();

                // Hiển thị thông báo số lượng sách tồn kho thấp
                lblStatus.Text = $"Có {lowStockBooks.Rows.Count} sách tồn kho thấp (dưới hoặc bằng 5 quyển).";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}