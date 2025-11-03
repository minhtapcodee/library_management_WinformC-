using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;
using QUANLYTHUVIENC3.DAL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmThongKeHomNay : Form
    {
        private MuonTraBLL bll;
        private System.Windows.Forms.Timer refreshTimer;
        private int soSachMuonHomNay; // Store the count for access

        public frmThongKeHomNay()
        {
            InitializeComponent();
            bll = new MuonTraBLL();
            // Đảm bảo DataGridView không tự động tạo cột
            dgvSachMuonHomNay.AutoGenerateColumns = false;
            InitializeDataGridViewColumns();
            LoadData();

            // Thiết lập Timer để làm mới mỗi 30 giây
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 30000; // 30 giây
            refreshTimer.Tick += (s, e) => LoadData();
            refreshTimer.Start();
        }

        private void InitializeDataGridViewColumns()
        {
            dgvSachMuonHomNay.Columns.Clear();
            dgvSachMuonHomNay.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                HeaderText = "Tên sách",
                DataPropertyName = "TenSach",
                Width = 250,
                HeaderCell = { Style = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) } }
            });
            dgvSachMuonHomNay.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TacGia",
                HeaderText = "Tác giả",
                DataPropertyName = "TacGia",
                Width = 150,
                HeaderCell = { Style = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) } }
            });
            dgvSachMuonHomNay.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenTheLoai",
                HeaderText = "Thể loại",
                DataPropertyName = "TenTheLoai",
                Width = 150,
                HeaderCell = { Style = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) } }
            });
            dgvSachMuonHomNay.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenNguoiMuon",
                HeaderText = "Người mượn",
                DataPropertyName = "TenNguoiMuon",
                Width = 150,
                HeaderCell = { Style = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) } }
            });
            dgvSachMuonHomNay.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayMuon",
                HeaderText = "Ngày mượn",
                DataPropertyName = "NgayMuon",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                HeaderCell = { Style = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) } }
            });
            dgvSachMuonHomNay.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                HeaderText = "Trạng thái",
                DataPropertyName = "TrangThai",
                Width = 100,
                HeaderCell = { Style = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) } }
            });

            // Tùy chỉnh giao diện DataGridView
            dgvSachMuonHomNay.BackgroundColor = Color.White;
            dgvSachMuonHomNay.BorderStyle = BorderStyle.None;
            dgvSachMuonHomNay.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvSachMuonHomNay.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            refreshTimer.Stop();
            refreshTimer.Dispose();
        }

        private void LoadData()
        {
            try
            {
                DateTime ngayHomNay = DateTime.Today;
                // Lấy danh sách sách mượn hôm nay
                DataTable dt = bll.LayDanhSachSachMuonTheoNgay(ngayHomNay);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có sách nào được mượn hôm nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvSachMuonHomNay.DataSource = dt;

                // Hiển thị số lượng sách mượn hôm nay
                soSachMuonHomNay = dt.Rows.Count; // Store the count
                lblSoSachMuonHomNay.Text = $"Số sách mượn hôm nay: {soSachMuonHomNay}";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi trong LoadData: {ex.Message}, StackTrace: {ex.StackTrace}");
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Public method to get the count of books borrowed today
        public int GetSoSachMuonHomNay()
        {
            DateTime ngayHomNay = DateTime.Today;
            DataTable dt = bll.LayDanhSachSachMuonTheoNgay(ngayHomNay);
            return dt.Rows.Count;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                DateTime? ngay = null;
                if (chkLocTheoNgay.Checked)
                {
                    ngay = dtpNgay.Value.Date;
                }
                DataTable dt = bll.TimKiemVaLocSachMuonTheoNgay(keyword, ngay);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách mượn phù hợp với tiêu chí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvSachMuonHomNay.DataSource = dt;

                // Cập nhật số lượng sách tìm thấy
                lblSoSachMuonHomNay.Text = $"Số sách mượn: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi trong btnTimKiem_Click: {ex.Message}, StackTrace: {ex.StackTrace}");
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkLocTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = chkLocTheoNgay.Checked;
            btnTimKiem_Click(sender, e);
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            if (chkLocTheoNgay.Checked)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }
    }
}