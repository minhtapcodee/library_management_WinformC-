using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmMuonTraDocGia : Form
    {
        private MuonTraBLL muonTraBLL = new MuonTraBLL();
        private string maDocGia;

        public frmMuonTraDocGia(string maDocGia)
        {
            InitializeComponent();
            this.maDocGia = maDocGia;
            // Đặt DataGridView thành ReadOnly ngay từ khởi tạo
            dataGridViewMuonTra.ReadOnly = true;
            LoadMuonTraData();
        }

        private void LoadMuonTraData()
        {
            try
            {
                DataTable dt = muonTraBLL.GetMuonTraByMaDocGia(maDocGia);
                dataGridViewMuonTra.DataSource = dt;
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách mượn trả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDataGridView()
        {
            if (dataGridViewMuonTra.Columns.Count > 0)
            {
                if (dataGridViewMuonTra.Columns.Contains("MaMuonTra"))
                {
                    dataGridViewMuonTra.Columns["MaMuonTra"].HeaderText = "Mã Mượn Trả";
                    dataGridViewMuonTra.Columns["MaMuonTra"].DisplayIndex = 0;
                }
                if (dataGridViewMuonTra.Columns.Contains("MaSach"))
                {
                    dataGridViewMuonTra.Columns["MaSach"].HeaderText = "Mã Sách";
                    dataGridViewMuonTra.Columns["MaSach"].DisplayIndex = 1;
                }
                if (dataGridViewMuonTra.Columns.Contains("TenSach"))
                {
                    dataGridViewMuonTra.Columns["TenSach"].HeaderText = "Tên Sách";
                    dataGridViewMuonTra.Columns["TenSach"].DisplayIndex = 2;
                }
                if (dataGridViewMuonTra.Columns.Contains("NgayMuon"))
                {
                    dataGridViewMuonTra.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                    dataGridViewMuonTra.Columns["NgayMuon"].DisplayIndex = 3;
                }
                if (dataGridViewMuonTra.Columns.Contains("NgayTra"))
                {
                    dataGridViewMuonTra.Columns["NgayTra"].HeaderText = "Ngày Trả";
                    dataGridViewMuonTra.Columns["NgayTra"].DisplayIndex = 4;
                }
                if (dataGridViewMuonTra.Columns.Contains("TinhTrang"))
                {
                    dataGridViewMuonTra.Columns["TinhTrang"].HeaderText = "Tình Trạng";
                    dataGridViewMuonTra.Columns["TinhTrang"].DisplayIndex = 5;
                }

                dataGridViewMuonTra.EnableHeadersVisualStyles = false;
                dataGridViewMuonTra.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 179, 113); // Màu xanh lá cho tiêu đề
                dataGridViewMuonTra.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewMuonTra.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridViewMuonTra.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

                dataGridViewMuonTra.DefaultCellStyle.BackColor = Color.White;
                dataGridViewMuonTra.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 245); // Màu xám nhạt thay cho vàng nhạt
                dataGridViewMuonTra.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewMuonTra.DefaultCellStyle.Font = new Font("Arial", 9);
                dataGridViewMuonTra.DefaultCellStyle.Padding = new Padding(5);
                dataGridViewMuonTra.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                // Đặt màu cho các ô được chọn
                dataGridViewMuonTra.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 230); // Màu xanh nhạt thay cho LightYellow
                dataGridViewMuonTra.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewMuonTra.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 230); // Đồng bộ màu xanh nhạt
                dataGridViewMuonTra.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

                dataGridViewMuonTra.GridColor = Color.FromArgb(200, 200, 200);
                dataGridViewMuonTra.BackgroundColor = Color.FromArgb(230, 230, 230);
                dataGridViewMuonTra.RowHeadersVisible = false;

                dataGridViewMuonTra.RowTemplate.Height = 50;
                dataGridViewMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Chỉ cho phép chọn toàn bộ hàng
                dataGridViewMuonTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewMuonTra.MultiSelect = false;
            }
        }

        private void frmMuonTraDocGia_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridViewMuonTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMuonTra.MultiSelect = false;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Sự kiện này không cần thiết, có thể giữ trống
        }
    }
}