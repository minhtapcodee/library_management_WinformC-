using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmTKNgayCong : Form
    {
        private NgayCongAdminBLL ngayCongBLL = new NgayCongAdminBLL();
        private const string PLACEHOLDER_TEXT = "Tìm kiếm nhân viên...";
        private bool isShowingKhongChamCong = false;

        public frmTKNgayCong()
        {
            InitializeComponent();
            InitializeControls();
            LoadData();
        }

        private void InitializeControls()
        {
            // Cài đặt Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Text = "Quản Lý Ngày Công";

            // DataGridView
            dgvChamCong = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AllowUserToAddRows = false
            };
            CustomizeDataGridView();
            dgvChamCong.CellFormatting += DgvChamCong_CellFormatting;
            splitContainer1.Panel2.Controls.Add(dgvChamCong);

            // DateTimePicker
            dtpNgayChamCong = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Width = 120,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10)
            };
            dtpNgayChamCong.ValueChanged += (s, e) => { isShowingKhongChamCong = false; LoadData(); };

            // ComboBox cho Trạng thái
            cbTrangThai = new ComboBox
            {
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10),
                FlatStyle = FlatStyle.Flat
            };
            cbTrangThai.Items.AddRange(new object[] { "Tất cả", "Đã xác nhận", "Chờ xác nhận", "Từ chối" });
            cbTrangThai.SelectedIndex = 0;
            cbTrangThai.SelectedIndexChanged += (s, e) => { isShowingKhongChamCong = false; LoadData(); };

            // TextBox tìm kiếm
            txtSearch = new TextBox
            {
                Width = 200,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.Gray,
                Text = PLACEHOLDER_TEXT
            };
            txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.Text == PLACEHOLDER_TEXT)
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };
            txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = PLACEHOLDER_TEXT;
                    txtSearch.ForeColor = Color.Gray;
                }
            };
            txtSearch.TextChanged += (s, e) =>
            {
                if (txtSearch.Text != PLACEHOLDER_TEXT)
                {
                    isShowingKhongChamCong = false;
                    LoadData();
                }
            };
            txtSearch.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(100, 181, 246), 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, txtSearch.Width - 1, txtSearch.Height - 1);
                }
            };

            // Label thống kê
            lblChamCongHomNay = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 12),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(100, 181, 246),
                Padding = new Padding(10),
                Margin = new Padding(5),
                Cursor = Cursors.Hand
            };
            lblChamCongHomNay.Click += (s, e) => { isShowingKhongChamCong = false; LoadData(); };

            lblKhongChamCong = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 12),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(255, 99, 132),
                Padding = new Padding(10),
                Margin = new Padding(5),
                Cursor = Cursors.Hand
            };
            lblKhongChamCong.Click += LblKhongChamCong_Click;

            // Panel cho điều khiển
            FlowLayoutPanel panelControls = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.FromArgb(255, 255, 255),
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10)
            };
            panelControls.Controls.AddRange(new Control[] {
                new Label { Text = "Ngày:", Font = new Font("Segoe UI", 10), AutoSize = true, Margin = new Padding(5, 10, 5, 0) },
                dtpNgayChamCong,
                new Label { Text = "Trạng thái:", Font = new Font("Segoe UI", 10), AutoSize = true, Margin = new Padding(10, 10, 5, 0) },
                cbTrangThai,
                new Label { Text = "Tìm kiếm:", Font = new Font("Segoe UI", 10), AutoSize = true, Margin = new Padding(10, 10, 5, 0) },
                txtSearch
            });

            // Panel cho thống kê
            FlowLayoutPanel panelStats = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(245, 247, 250),
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10)
            };
            panelStats.Controls.AddRange(new Control[] { lblChamCongHomNay, lblKhongChamCong });

            splitContainer1.Panel1.Controls.AddRange(new Control[] { panelStats, panelControls });
        }

        private void CustomizeDataGridView()
        {
            dgvChamCong.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 181, 246);
            dgvChamCong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChamCong.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvChamCong.EnableHeadersVisualStyles = false;
            dgvChamCong.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 255);
            dgvChamCong.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvChamCong.DefaultCellStyle.SelectionBackColor = Color.FromArgb(149, 202, 255);
            dgvChamCong.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void DgvChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (isShowingKhongChamCong)
            {
                dgvChamCong.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                dgvChamCong.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void LblKhongChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                isShowingKhongChamCong = true;
                DateTime selectedDate = dtpNgayChamCong.Checked ? dtpNgayChamCong.Value.Date : DateTime.Today;
                DataTable dtKhongChamCong = ngayCongBLL.GetNhanVienKhongChamCong(selectedDate);
                dgvChamCong.DataSource = dtKhongChamCong;
                MessageBox.Show($"Số nhân viên không chấm công: {dtKhongChamCong.Rows.Count}", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách không chấm công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataGridView dgvChamCong;
        private DateTimePicker dtpNgayChamCong;
        private ComboBox cbTrangThai;
        private TextBox txtSearch;
        private Label lblChamCongHomNay;
        private Label lblKhongChamCong;

        private void LoadData()
        {
            try
            {
                // Lấy ngày từ DateTimePicker (mặc định là ngày hiện tại)
                DateTime selectedDate = dtpNgayChamCong.Checked ? dtpNgayChamCong.Value.Date : DateTime.Today;

                // Lấy danh sách không chấm công
                DataTable dtKhongChamCong = ngayCongBLL.GetNhanVienKhongChamCong(selectedDate);

                if (isShowingKhongChamCong)
                {
                    dgvChamCong.DataSource = dtKhongChamCong;
                }
                else
                {
                    string trangThai = cbTrangThai.SelectedItem?.ToString();
                    string hoTen = txtSearch.Text == PLACEHOLDER_TEXT ? "" : txtSearch.Text.Trim();

                    DataTable dtChamCong = ngayCongBLL.SearchChamCong(hoTen, trangThai, dtpNgayChamCong.Checked ? selectedDate : (DateTime?)null);
                    dgvChamCong.DataSource = dtChamCong;
                }

                // Thống kê chấm công
                DataTable dtHomNay = ngayCongBLL.GetChamCongByDate(selectedDate);
                lblChamCongHomNay.Text = $"Chấm công: {dtHomNay.Rows.Count}";
                lblKhongChamCong.Text = $"Không chấm công: {dtKhongChamCong.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}