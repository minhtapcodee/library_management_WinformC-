namespace QUANLYTHUVIENC3.GUI
{
    partial class frmTKKhoSach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cbMaNhanVien = new ComboBox();
            txtMoTa = new TextBox();
            dtpNgayNhap = new DateTimePicker();
            txtSoLuongNhap = new TextBox();
            cbMaSach = new ComboBox();
            txtMaKho = new TextBox();
            lblMaKho = new Label();
            lblMaSach = new Label();
            lblSoLuongNhap = new Label();
            lblNgayNhap = new Label();
            lblMoTa = new Label();
            lblMaNhanVien = new Label();
            panel1 = new Panel();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            btnBaoCao = new Button();
            btnCanhBaoTonKho = new Button();
            btnLamMoi = new Button();
            btnLocTheoNgay = new Button();
            dtpLocTheoNgay = new DateTimePicker();
            btnTimKiem = new Button();
            txtSearch = new TextBox();
            dgvKhoSach = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoSach).BeginInit();
            SuspendLayout();
            // 
            // cbMaNhanVien
            // 
            cbMaNhanVien.Location = new Point(624, 45);
            cbMaNhanVien.Margin = new Padding(4);
            cbMaNhanVien.Name = "cbMaNhanVien";
            cbMaNhanVien.Size = new Size(175, 23);
            cbMaNhanVien.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(624, 4);
            txtMoTa.Margin = new Padding(4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(175, 23);
            txtMoTa.TabIndex = 4;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(358, 45);
            dtpNgayNhap.Margin = new Padding(4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(175, 23);
            dtpNgayNhap.TabIndex = 3;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Location = new Point(358, 4);
            txtSoLuongNhap.Margin = new Padding(4);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(175, 23);
            txtSoLuongNhap.TabIndex = 2;
            // 
            // cbMaSach
            // 
            cbMaSach.Location = new Point(136, 45);
            cbMaSach.Margin = new Padding(4);
            cbMaSach.Name = "cbMaSach";
            cbMaSach.Size = new Size(175, 23);
            cbMaSach.TabIndex = 1;
            // 
            // txtMaKho
            // 
            txtMaKho.Location = new Point(136, 4);
            txtMaKho.Margin = new Padding(4);
            txtMaKho.Name = "txtMaKho";
            txtMaKho.ReadOnly = true;
            txtMaKho.Size = new Size(175, 23);
            txtMaKho.TabIndex = 0;
            txtMaKho.TextChanged += txtMaKho_TextChanged;
            // 
            // lblMaKho
            // 
            lblMaKho.Location = new Point(10, 4);
            lblMaKho.Margin = new Padding(4, 0, 4, 0);
            lblMaKho.Name = "lblMaKho";
            lblMaKho.Size = new Size(116, 29);
            lblMaKho.TabIndex = 6;
            lblMaKho.Text = "Mã Kho:";
            lblMaKho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaSach
            // 
            lblMaSach.Location = new Point(10, 45);
            lblMaSach.Margin = new Padding(4, 0, 4, 0);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(116, 29);
            lblMaSach.TabIndex = 7;
            lblMaSach.Text = "Mã Sách:";
            lblMaSach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSoLuongNhap
            // 
            lblSoLuongNhap.Location = new Point(232, 4);
            lblSoLuongNhap.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongNhap.Name = "lblSoLuongNhap";
            lblSoLuongNhap.Size = new Size(116, 29);
            lblSoLuongNhap.TabIndex = 8;
            lblSoLuongNhap.Text = "Số Lượng Nhập:";
            lblSoLuongNhap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.Location = new Point(232, 45);
            lblNgayNhap.Margin = new Padding(4, 0, 4, 0);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(116, 29);
            lblNgayNhap.TabIndex = 9;
            lblNgayNhap.Text = "Ngày Nhập:";
            lblNgayNhap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMoTa
            // 
            lblMoTa.Location = new Point(498, 4);
            lblMoTa.Margin = new Padding(4, 0, 4, 0);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(116, 29);
            lblMoTa.TabIndex = 10;
            lblMoTa.Text = "Mô Tả:";
            lblMoTa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.Location = new Point(498, 45);
            lblMaNhanVien.Margin = new Padding(4, 0, 4, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(116, 29);
            lblMaNhanVien.TabIndex = 11;
            lblMaNhanVien.Text = "Mã Nhân Viên:";
            lblMaNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(cbMaNhanVien);
            panel1.Controls.Add(txtMoTa);
            panel1.Controls.Add(dtpNgayNhap);
            panel1.Controls.Add(txtSoLuongNhap);
            panel1.Controls.Add(cbMaSach);
            panel1.Controls.Add(txtMaKho);
            panel1.Controls.Add(lblMaKho);
            panel1.Controls.Add(lblMaSach);
            panel1.Controls.Add(lblSoLuongNhap);
            panel1.Controls.Add(lblNgayNhap);
            panel1.Controls.Add(lblMoTa);
            panel1.Controls.Add(lblMaNhanVien);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 154);
            panel1.TabIndex = 12;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(290, 58);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 35);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(150, 58);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(120, 35);
            btnCapNhat.TabIndex = 13;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(10, 58);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 35);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBaoCao);
            panel2.Controls.Add(btnCanhBaoTonKho);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnLocTheoNgay);
            panel2.Controls.Add(dtpLocTheoNgay);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 154);
            panel2.TabIndex = 13;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Location = new Point(669, 99);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(120, 35);
            btnBaoCao.TabIndex = 6;
            btnBaoCao.Text = "Báo Cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnCanhBaoTonKho
            // 
            btnCanhBaoTonKho.Location = new Point(344, 99);
            btnCanhBaoTonKho.Name = "btnCanhBaoTonKho";
            btnCanhBaoTonKho.Size = new Size(122, 35);
            btnCanhBaoTonKho.TabIndex = 5;
            btnCanhBaoTonKho.Text = "Cảnh Báo ";
            btnCanhBaoTonKho.UseVisualStyleBackColor = true;
            btnCanhBaoTonKho.Click += btnCanhBaoTonKho_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(70, 99);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 35);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLocTheoNgay
            // 
            btnLocTheoNgay.Location = new Point(743, 12);
            btnLocTheoNgay.Name = "btnLocTheoNgay";
            btnLocTheoNgay.Size = new Size(120, 35);
            btnLocTheoNgay.TabIndex = 3;
            btnLocTheoNgay.Text = "Lọc Theo Ngày";
            btnLocTheoNgay.UseVisualStyleBackColor = true;
            btnLocTheoNgay.Click += btnLocTheoNgay_Click;
            // 
            // dtpLocTheoNgay
            // 
            dtpLocTheoNgay.Location = new Point(498, 12);
            dtpLocTheoNgay.Name = "dtpLocTheoNgay";
            dtpLocTheoNgay.Size = new Size(214, 23);
            dtpLocTheoNgay.TabIndex = 2;
            dtpLocTheoNgay.ValueChanged += dtpLocTheoNgay_ValueChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(290, 7);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 35);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(70, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 0;
            // 
            // dgvKhoSach
            // 
            dgvKhoSach.ColumnHeadersHeight = 29;
            dgvKhoSach.Dock = DockStyle.Fill;
            dgvKhoSach.Location = new Point(0, 154);
            dgvKhoSach.Margin = new Padding(4);
            dgvKhoSach.Name = "dgvKhoSach";
            dgvKhoSach.RowHeadersWidth = 51;
            dgvKhoSach.Size = new Size(914, 493);
            dgvKhoSach.TabIndex = 14;
            dgvKhoSach.SelectionChanged += dgvKhoSach_SelectionChanged;
            // 
            // frmTKKhoSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 647);
            Controls.Add(dgvKhoSach);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmTKKhoSach";
            Text = "Quản Lý Kho Sách";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoSach).EndInit();
            ResumeLayout(false);
        }

        private ComboBox cbMaNhanVien;
        private TextBox txtMoTa;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtSoLuongNhap;
        private ComboBox cbMaSach;
        private TextBox txtMaKho;
        private Label lblMaKho;
        private Label lblMaSach;
        private Label lblSoLuongNhap;
        private Label lblNgayNhap;
        private Label lblMoTa;
        private Label lblMaNhanVien;
        private Panel panel1;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Panel panel2;
        private TextBox txtSearch;
        private Button btnTimKiem;
        private DateTimePicker dtpLocTheoNgay;
        private Button btnLocTheoNgay;
        private Button btnLamMoi;
        private Button btnCanhBaoTonKho;
        private Button btnBaoCao;
        private DataGridView dgvKhoSach;
    }
}