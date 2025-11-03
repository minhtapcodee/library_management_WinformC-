namespace QUANLYTHUVIENC3.GUI
{
    partial class frmDocGia
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocGioiTinh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblLocGioiTinh;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDataGrid;

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
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            cboLocGioiTinh = new ComboBox();
            cboLocTrangThai = new ComboBox();
            lblLocTrangThai = new Label();
            lblTitle = new Label();
            lblTimKiem = new Label();
            lblLocGioiTinh = new Label();
            panelHeader = new Panel();
            panelPagination = new Panel();
            panelMain = new Panel();
            panelDataGrid = new Panel();
            btnPreviousPage = new Button();
            lblPageInfo = new Label();
            btnNextPage = new Button();
            dataGridViewDocGia = new DataGridView();
            panelInput = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnExportExcel = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnLamMoi = new Button();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocGia).BeginInit();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(87, 38);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(175, 25);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(65, 105, 225);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(280, 38);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(87, 28);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            btnTimKiem.MouseEnter += btnTimKiem_MouseEnter;
            btnTimKiem.MouseLeave += btnTimKiem_MouseLeave;
            // 
            // cboLocGioiTinh
            // 
            cboLocGioiTinh.Font = new Font("Segoe UI", 10F);
            cboLocGioiTinh.Location = new Point(119, 442);
            cboLocGioiTinh.Name = "cboLocGioiTinh";
            cboLocGioiTinh.Size = new Size(132, 25);
            cboLocGioiTinh.TabIndex = 3;
            cboLocGioiTinh.SelectedIndexChanged += cboLocGioiTinh_SelectedIndexChanged;
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.Font = new Font("Segoe UI", 10F);
            cboLocTrangThai.Location = new Point(119, 400);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(132, 25);
            cboLocTrangThai.TabIndex = 4;
            cboLocTrangThai.SelectedIndexChanged += cboLocTrangThai_SelectedIndexChanged;
            // 
            // lblLocTrangThai
            // 
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.Font = new Font("Segoe UI", 9F);
            lblLocTrangThai.ForeColor = Color.Black;
            lblLocTrangThai.Location = new Point(30, 403);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.Size = new Size(83, 15);
            lblLocTrangThai.TabIndex = 5;
            lblLocTrangThai.Text = "Lọc trạng thái:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(555, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(202, 32);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Quản Lý Độc Giả";
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F);
            lblTimKiem.ForeColor = Color.Black;
            lblTimKiem.Location = new Point(17, 38);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(59, 15);
            lblTimKiem.TabIndex = 15;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // lblLocGioiTinh
            // 
            lblLocGioiTinh.AutoSize = true;
            lblLocGioiTinh.Font = new Font("Segoe UI", 9F);
            lblLocGioiTinh.ForeColor = Color.Black;
            lblLocGioiTinh.Location = new Point(30, 447);
            lblLocGioiTinh.Name = "lblLocGioiTinh";
            lblLocGioiTinh.Size = new Size(76, 15);
            lblLocGioiTinh.TabIndex = 16;
            lblLocGioiTinh.Text = "Lọc giới tính:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 248, 255);
            panelHeader.Controls.Add(panelPagination);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblTimKiem);
            panelHeader.Controls.Add(txtTimKiem);
            panelHeader.Controls.Add(btnTimKiem);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1249, 94);
            panelHeader.TabIndex = 1;
            // 
            // panelPagination
            // 
            panelPagination.BackColor = Color.FromArgb(240, 248, 255);
            panelPagination.Location = new Point(478, 44);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(687, 40);
            panelPagination.TabIndex = 4;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelDataGrid);
            panelMain.Controls.Add(panelInput);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 94);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1249, 570);
            panelMain.TabIndex = 5;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Controls.Add(btnPreviousPage);
            panelDataGrid.Controls.Add(lblPageInfo);
            panelDataGrid.Controls.Add(btnNextPage);
            panelDataGrid.Controls.Add(dataGridViewDocGia);
            panelDataGrid.Controls.Add(cboLocGioiTinh);
            panelDataGrid.Controls.Add(cboLocTrangThai);
            panelDataGrid.Controls.Add(lblLocTrangThai);
            panelDataGrid.Controls.Add(lblLocGioiTinh);
            panelDataGrid.Location = new Point(420, 0);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(1133, 609);
            panelDataGrid.TabIndex = 3;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = Color.FromArgb(0, 192, 0);
            btnPreviousPage.FlatAppearance.BorderSize = 0;
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPreviousPage.ForeColor = Color.White;
            btnPreviousPage.Location = new Point(338, 396);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(87, 28);
            btnPreviousPage.TabIndex = 17;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            btnPreviousPage.MouseEnter += btnPreviousPage_MouseEnter;
            btnPreviousPage.MouseLeave += btnPreviousPage_MouseLeave;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageInfo.ForeColor = Color.Black;
            lblPageInfo.Location = new Point(470, 401);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(73, 19);
            lblPageInfo.TabIndex = 19;
            lblPageInfo.Text = "Trang 1/1";
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.FromArgb(0, 192, 0);
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNextPage.ForeColor = Color.White;
            btnNextPage.Location = new Point(557, 396);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(87, 28);
            btnNextPage.TabIndex = 18;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            btnNextPage.MouseEnter += btnNextPage_MouseEnter;
            btnNextPage.MouseLeave += btnNextPage_MouseLeave;
            // 
            // dataGridViewDocGia
            // 
            dataGridViewDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocGia.BackgroundColor = Color.White;
            dataGridViewDocGia.ColumnHeadersHeight = 46;
            dataGridViewDocGia.Location = new Point(0, 0);
            dataGridViewDocGia.Name = "dataGridViewDocGia";
            dataGridViewDocGia.RowHeadersWidth = 82;
            dataGridViewDocGia.Size = new Size(678, 385);
            dataGridViewDocGia.TabIndex = 0;
            dataGridViewDocGia.SelectionChanged += dataGridViewDocGia_SelectionChanged;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.FromArgb(240, 248, 255);
            panelInput.Controls.Add(lblUsername);
            panelInput.Controls.Add(txtUsername);
            panelInput.Controls.Add(lblPassword);
            panelInput.Controls.Add(txtPassword);
            panelInput.Controls.Add(lblHoTen);
            panelInput.Controls.Add(txtHoTen);
            panelInput.Controls.Add(lblGioiTinh);
            panelInput.Controls.Add(cboGioiTinh);
            panelInput.Controls.Add(lblNgaySinh);
            panelInput.Controls.Add(dtpNgaySinh);
            panelInput.Controls.Add(lblDiaChi);
            panelInput.Controls.Add(txtDiaChi);
            panelInput.Controls.Add(lblSDT);
            panelInput.Controls.Add(txtSDT);
            panelInput.Controls.Add(lblEmail);
            panelInput.Controls.Add(txtEmail);
            panelInput.Controls.Add(btnExportExcel);
            panelInput.Controls.Add(btnSua);
            panelInput.Controls.Add(btnXoa);
            panelInput.Controls.Add(btnLuu);
            panelInput.Controls.Add(btnLamMoi);
            panelInput.Dock = DockStyle.Left;
            panelInput.Location = new Point(0, 0);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(420, 570);
            panelInput.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(17, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(88, 15);
            lblUsername.TabIndex = 17;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(123, 19);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 25);
            txtUsername.TabIndex = 25;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(17, 66);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(123, 66);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 25);
            txtPassword.TabIndex = 26;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F);
            lblHoTen.ForeColor = Color.Black;
            lblHoTen.Location = new Point(17, 112);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(46, 15);
            lblHoTen.TabIndex = 19;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(123, 112);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(263, 25);
            txtHoTen.TabIndex = 27;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F);
            lblGioiTinh.ForeColor = Color.Black;
            lblGioiTinh.Location = new Point(17, 159);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(55, 15);
            lblGioiTinh.TabIndex = 20;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Font = new Font("Segoe UI", 10F);
            cboGioiTinh.Location = new Point(123, 159);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(263, 25);
            cboGioiTinh.TabIndex = 28;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F);
            lblNgaySinh.ForeColor = Color.Black;
            lblNgaySinh.Location = new Point(17, 206);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(63, 15);
            lblNgaySinh.TabIndex = 21;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 10F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(123, 206);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(263, 25);
            dtpNgaySinh.TabIndex = 29;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F);
            lblDiaChi.ForeColor = Color.Black;
            lblDiaChi.Location = new Point(17, 253);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(46, 15);
            lblDiaChi.TabIndex = 22;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(123, 253);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(263, 25);
            txtDiaChi.TabIndex = 30;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F);
            lblSDT.ForeColor = Color.Black;
            lblSDT.Location = new Point(17, 300);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(79, 15);
            lblSDT.TabIndex = 23;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F);
            txtSDT.Location = new Point(123, 300);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(263, 25);
            txtSDT.TabIndex = 31;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(17, 347);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(123, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 25);
            txtEmail.TabIndex = 32;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(0, 150, 0);
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(3, 534);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(84, 28);
            btnExportExcel.TabIndex = 6;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            btnExportExcel.MouseEnter += btnExportExcel_MouseEnter;
            btnExportExcel.MouseLeave += btnExportExcel_MouseLeave;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(50, 205, 50);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(96, 534);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 28);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            btnSua.MouseEnter += btnSua_MouseEnter;
            btnSua.MouseLeave += btnSua_MouseLeave;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 69, 0);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(175, 534);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 28);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            btnXoa.MouseEnter += btnXoa_MouseEnter;
            btnXoa.MouseLeave += btnXoa_MouseLeave;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(65, 105, 225);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(254, 534);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(70, 28);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            btnLuu.MouseEnter += btnLuu_MouseEnter;
            btnLuu.MouseLeave += btnLuu_MouseLeave;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(255, 215, 0);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(333, 534);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(70, 28);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            btnLamMoi.MouseEnter += btnLamMoi_MouseEnter;
            btnLamMoi.MouseLeave += btnLamMoi_MouseLeave;
            // 
            // frmDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 664);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDocGia";
            Text = "Quản Lý Độc Giả";
            Load += frmDocGia_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelDataGrid.ResumeLayout(false);
            panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocGia).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
        }
        private Panel panelInput;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblGioiTinh;
        private ComboBox cboGioiTinh;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnExportExcel;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnLamMoi;
        private DataGridView dataGridViewDocGia;
        private Panel panelPagination;
        private Button btnPreviousPage;
        private Label lblPageInfo;
        private Button btnNextPage;
    }
}