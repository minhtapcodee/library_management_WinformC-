namespace QUANLYTHUVIENC3.GUI
{
    partial class SachForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboLocTinhTrang;
        private System.Windows.Forms.ComboBox cboLocTheLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblLocTinhTrang;
        private System.Windows.Forms.Label lblLocTheLoai;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Panel panelPagination;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.PictureBox pictureBoxSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblMaSachValue;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTenSachValue;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTacGiaValue;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.Label lblNamXBValue;
        private System.Windows.Forms.Label lblNhaXB;
        private System.Windows.Forms.Label lblNhaXBValue;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblTheLoaiValue;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblGiaValue;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMoTaValue;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SachForm));
            dataGridViewSach = new DataGridView();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            cboLocTinhTrang = new ComboBox();
            cboLocTheLoai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnXuatExcel = new Button();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            lblPageInfo = new Label();
            lblTitle = new Label();
            lblTimKiem = new Label();
            lblLocTinhTrang = new Label();
            lblLocTheLoai = new Label();
            panelHeader = new Panel();
            panelSearch = new Panel();
            panelAction = new Panel();
            panelPagination = new Panel();
            panelDetails = new Panel();
            pictureBoxSach = new PictureBox();
            lblMaSach = new Label();
            lblMaSachValue = new Label();
            lblTenSach = new Label();
            lblTenSachValue = new Label();
            lblTacGia = new Label();
            lblTacGiaValue = new Label();
            lblNamXB = new Label();
            lblNamXBValue = new Label();
            lblNhaXB = new Label();
            lblNhaXBValue = new Label();
            lblTheLoai = new Label();
            lblTheLoaiValue = new Label();
            lblGia = new Label();
            lblGiaValue = new Label();
            lblMoTa = new Label();
            lblMoTaValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSach).BeginInit();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            panelAction.SuspendLayout();
            panelPagination.SuspendLayout();
            panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSach).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSach
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 245, 245);
            dataGridViewSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSach.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 179, 113);
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 179, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSach.ColumnHeadersHeight = 46;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 240, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewSach.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSach.Dock = DockStyle.Fill;
            dataGridViewSach.Location = new Point(0, 102);
            dataGridViewSach.Margin = new Padding(4, 3, 4, 3);
            dataGridViewSach.Name = "dataGridViewSach";
            dataGridViewSach.ReadOnly = true;
            dataGridViewSach.RowHeadersVisible = false;
            dataGridViewSach.RowHeadersWidth = 51;
            dataGridViewSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSach.Size = new Size(1161, 172);
            dataGridViewSach.TabIndex = 0;
            dataGridViewSach.SelectionChanged += dataGridViewSach_SelectionChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(108, 19);
            txtTimKiem.Margin = new Padding(4, 3, 4, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(176, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.White;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(290, 19);
            btnTimKiem.Margin = new Padding(4, 3, 4, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(24, 20);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            btnTimKiem.MouseEnter += btnTimKiem_MouseEnter;
            btnTimKiem.MouseLeave += btnTimKiem_MouseLeave;
            // 
            // cboLocTinhTrang
            // 
            cboLocTinhTrang.Items.AddRange(new object[] { "Tất cả", "Còn", "Hết" });
            cboLocTinhTrang.Location = new Point(641, 19);
            cboLocTinhTrang.Margin = new Padding(4, 3, 4, 3);
            cboLocTinhTrang.Name = "cboLocTinhTrang";
            cboLocTinhTrang.Size = new Size(126, 23);
            cboLocTinhTrang.TabIndex = 3;
            cboLocTinhTrang.SelectedIndexChanged += cboLocTinhTrang_SelectedIndexChanged;
            // 
            // cboLocTheLoai
            // 
            cboLocTheLoai.Location = new Point(975, 19);
            cboLocTheLoai.Margin = new Padding(4, 3, 4, 3);
            cboLocTheLoai.Name = "cboLocTheLoai";
            cboLocTheLoai.Size = new Size(129, 23);
            cboLocTheLoai.TabIndex = 4;
            cboLocTheLoai.SelectedIndexChanged += cboLocTheLoai_SelectedIndexChanged;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(161, 3);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 28);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            btnThem.MouseEnter += btnThem_MouseEnter;
            btnThem.MouseLeave += btnThem_MouseLeave;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.Red;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(352, 3);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 28);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            btnSua.MouseEnter += btnSua_MouseEnter;
            btnSua.MouseLeave += btnSua_MouseLeave;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.FromArgb(255, 128, 0);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(562, 3);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 28);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            btnXoa.MouseEnter += btnXoa_MouseEnter;
            btnXoa.MouseLeave += btnXoa_MouseLeave;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.FromArgb(192, 0, 192);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(737, 3);
            btnLamMoi.Margin = new Padding(4, 3, 4, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 28);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            btnLamMoi.MouseEnter += btnLamMoi_MouseEnter;
            btnLamMoi.MouseLeave += btnLamMoi_MouseLeave;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.None;
            btnXuatExcel.BackColor = Color.FromArgb(0, 0, 192);
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(920, 3);
            btnXuatExcel.Margin = new Padding(4, 3, 4, 3);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(86, 28);
            btnXuatExcel.TabIndex = 9;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            btnXuatExcel.MouseEnter += btnXuatExcel_MouseEnter;
            btnXuatExcel.MouseLeave += btnXuatExcel_MouseLeave;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Anchor = AnchorStyles.None;
            btnPreviousPage.BackColor = Color.FromArgb(60, 179, 113);
            btnPreviousPage.FlatAppearance.BorderColor = Color.FromArgb(60, 179, 113);
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPreviousPage.ForeColor = Color.White;
            btnPreviousPage.Location = new Point(343, 0);
            btnPreviousPage.Margin = new Padding(4, 3, 4, 3);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(79, 34);
            btnPreviousPage.TabIndex = 10;
            btnPreviousPage.Text = "<";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            btnPreviousPage.MouseEnter += btnPreviousPage_MouseEnter;
            btnPreviousPage.MouseLeave += btnPreviousPage_MouseLeave;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.None;
            btnNextPage.BackColor = Color.FromArgb(60, 179, 113);
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnNextPage.ForeColor = Color.White;
            btnNextPage.Location = new Point(769, -1);
            btnNextPage.Margin = new Padding(4, 3, 4, 3);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(78, 34);
            btnNextPage.TabIndex = 11;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            btnNextPage.MouseEnter += btnNextPage_MouseEnter;
            btnNextPage.MouseLeave += btnNextPage_MouseLeave;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.None;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Arial", 10F);
            lblPageInfo.ForeColor = Color.Black;
            lblPageInfo.Location = new Point(554, 9);
            lblPageInfo.Margin = new Padding(4, 0, 4, 0);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(68, 16);
            lblPageInfo.TabIndex = 12;
            lblPageInfo.Text = "Trang 1/1";
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1161, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lý Sách";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Arial", 12F);
            lblTimKiem.ForeColor = Color.Black;
            lblTimKiem.Location = new Point(17, 22);
            lblTimKiem.Margin = new Padding(4, 0, 4, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(75, 18);
            lblTimKiem.TabIndex = 13;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // lblLocTinhTrang
            // 
            lblLocTinhTrang.AutoSize = true;
            lblLocTinhTrang.Font = new Font("Arial", 12F);
            lblLocTinhTrang.ForeColor = Color.Black;
            lblLocTinhTrang.Location = new Point(514, 22);
            lblLocTinhTrang.Margin = new Padding(4, 0, 4, 0);
            lblLocTinhTrang.Name = "lblLocTinhTrang";
            lblLocTinhTrang.Size = new Size(104, 18);
            lblLocTinhTrang.TabIndex = 14;
            lblLocTinhTrang.Text = "Lọc tình trạng:";
            // 
            // lblLocTheLoai
            // 
            lblLocTheLoai.AutoSize = true;
            lblLocTheLoai.Font = new Font("Arial", 12F);
            lblLocTheLoai.ForeColor = Color.Black;
            lblLocTheLoai.Location = new Point(865, 22);
            lblLocTheLoai.Margin = new Padding(4, 0, 4, 0);
            lblLocTheLoai.Name = "lblLocTheLoai";
            lblLocTheLoai.Size = new Size(92, 18);
            lblLocTheLoai.TabIndex = 15;
            lblLocTheLoai.Text = "Lọc thể loại:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(245, 245, 245);
            panelHeader.Controls.Add(lblLocTheLoai);
            panelHeader.Controls.Add(cboLocTheLoai);
            panelHeader.Controls.Add(cboLocTinhTrang);
            panelHeader.Controls.Add(lblLocTinhTrang);
            panelHeader.Controls.Add(btnTimKiem);
            panelHeader.Controls.Add(lblTimKiem);
            panelHeader.Controls.Add(txtTimKiem);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 46);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1161, 56);
            panelHeader.TabIndex = 1;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(245, 245, 245);
            panelSearch.Controls.Add(lblTitle);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Margin = new Padding(4, 3, 4, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1161, 46);
            panelSearch.TabIndex = 2;
            panelSearch.Paint += panelSearch_Paint;
            // 
            // panelAction
            // 
            panelAction.BackColor = Color.FromArgb(245, 245, 245);
            panelAction.BorderStyle = BorderStyle.FixedSingle;
            panelAction.Controls.Add(btnThem);
            panelAction.Controls.Add(btnSua);
            panelAction.Controls.Add(btnXoa);
            panelAction.Controls.Add(btnLamMoi);
            panelAction.Controls.Add(btnXuatExcel);
            panelAction.Dock = DockStyle.Bottom;
            panelAction.Location = new Point(0, 418);
            panelAction.Margin = new Padding(4, 3, 4, 3);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(1161, 38);
            panelAction.TabIndex = 3;
            // 
            // panelPagination
            // 
            panelPagination.BackColor = Color.FromArgb(245, 245, 245);
            panelPagination.BorderStyle = BorderStyle.FixedSingle;
            panelPagination.Controls.Add(btnPreviousPage);
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnNextPage);
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Location = new Point(0, 456);
            panelPagination.Margin = new Padding(4, 3, 4, 3);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(1161, 38);
            panelPagination.TabIndex = 4;
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.FromArgb(245, 245, 245);
            panelDetails.Controls.Add(pictureBoxSach);
            panelDetails.Controls.Add(lblMaSach);
            panelDetails.Controls.Add(lblMaSachValue);
            panelDetails.Controls.Add(lblTenSach);
            panelDetails.Controls.Add(lblTenSachValue);
            panelDetails.Controls.Add(lblTacGia);
            panelDetails.Controls.Add(lblTacGiaValue);
            panelDetails.Controls.Add(lblNamXB);
            panelDetails.Controls.Add(lblNamXBValue);
            panelDetails.Controls.Add(lblNhaXB);
            panelDetails.Controls.Add(lblNhaXBValue);
            panelDetails.Controls.Add(lblTheLoai);
            panelDetails.Controls.Add(lblTheLoaiValue);
            panelDetails.Controls.Add(lblGia);
            panelDetails.Controls.Add(lblGiaValue);
            panelDetails.Controls.Add(lblMoTa);
            panelDetails.Controls.Add(lblMoTaValue);
            panelDetails.Dock = DockStyle.Bottom;
            panelDetails.Location = new Point(0, 274);
            panelDetails.Margin = new Padding(4, 3, 4, 3);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(1161, 144);
            panelDetails.TabIndex = 5;
            // 
            // pictureBoxSach
            // 
            pictureBoxSach.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxSach.Location = new Point(20, 10);
            pictureBoxSach.Margin = new Padding(4, 3, 4, 3);
            pictureBoxSach.Name = "pictureBoxSach";
            pictureBoxSach.Size = new Size(150, 120);
            pictureBoxSach.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSach.TabIndex = 0;
            pictureBoxSach.TabStop = false;
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblMaSach.Location = new Point(190, 10);
            lblMaSach.Margin = new Padding(4, 0, 4, 0);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(58, 15);
            lblMaSach.TabIndex = 1;
            lblMaSach.Text = "Mã sách:";
            // 
            // lblMaSachValue
            // 
            lblMaSachValue.AutoSize = true;
            lblMaSachValue.Font = new Font("Arial", 9F);
            lblMaSachValue.Location = new Point(290, 10);
            lblMaSachValue.Margin = new Padding(4, 0, 4, 0);
            lblMaSachValue.Name = "lblMaSachValue";
            lblMaSachValue.Size = new Size(0, 15);
            lblMaSachValue.TabIndex = 2;
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblTenSach.Location = new Point(190, 25);
            lblTenSach.Margin = new Padding(4, 0, 4, 0);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(62, 15);
            lblTenSach.TabIndex = 3;
            lblTenSach.Text = "Tên sách:";
            // 
            // lblTenSachValue
            // 
            lblTenSachValue.AutoSize = true;
            lblTenSachValue.Font = new Font("Arial", 9F);
            lblTenSachValue.Location = new Point(290, 25);
            lblTenSachValue.Margin = new Padding(4, 0, 4, 0);
            lblTenSachValue.Name = "lblTenSachValue";
            lblTenSachValue.Size = new Size(0, 15);
            lblTenSachValue.TabIndex = 4;
            // 
            // lblTacGia
            // 
            lblTacGia.AutoSize = true;
            lblTacGia.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblTacGia.Location = new Point(190, 40);
            lblTacGia.Margin = new Padding(4, 0, 4, 0);
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(51, 15);
            lblTacGia.TabIndex = 5;
            lblTacGia.Text = "Tác giả:";
            // 
            // lblTacGiaValue
            // 
            lblTacGiaValue.AutoSize = true;
            lblTacGiaValue.Font = new Font("Arial", 9F);
            lblTacGiaValue.Location = new Point(290, 40);
            lblTacGiaValue.Margin = new Padding(4, 0, 4, 0);
            lblTacGiaValue.Name = "lblTacGiaValue";
            lblTacGiaValue.Size = new Size(0, 15);
            lblTacGiaValue.TabIndex = 6;
            // 
            // lblNamXB
            // 
            lblNamXB.AutoSize = true;
            lblNamXB.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblNamXB.Location = new Point(190, 55);
            lblNamXB.Margin = new Padding(4, 0, 4, 0);
            lblNamXB.Name = "lblNamXB";
            lblNamXB.Size = new Size(88, 15);
            lblNamXB.TabIndex = 7;
            lblNamXB.Text = "Năm xuất bản:";
            // 
            // lblNamXBValue
            // 
            lblNamXBValue.AutoSize = true;
            lblNamXBValue.Font = new Font("Arial", 9F);
            lblNamXBValue.Location = new Point(290, 55);
            lblNamXBValue.Margin = new Padding(4, 0, 4, 0);
            lblNamXBValue.Name = "lblNamXBValue";
            lblNamXBValue.Size = new Size(0, 15);
            lblNamXBValue.TabIndex = 8;
            // 
            // lblNhaXB
            // 
            lblNhaXB.AutoSize = true;
            lblNhaXB.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblNhaXB.Location = new Point(190, 70);
            lblNhaXB.Margin = new Padding(4, 0, 4, 0);
            lblNhaXB.Name = "lblNhaXB";
            lblNhaXB.Size = new Size(84, 15);
            lblNhaXB.TabIndex = 9;
            lblNhaXB.Text = "Nhà xuất bản:";
            // 
            // lblNhaXBValue
            // 
            lblNhaXBValue.AutoSize = true;
            lblNhaXBValue.Font = new Font("Arial", 9F);
            lblNhaXBValue.Location = new Point(290, 70);
            lblNhaXBValue.Margin = new Padding(4, 0, 4, 0);
            lblNhaXBValue.Name = "lblNhaXBValue";
            lblNhaXBValue.Size = new Size(0, 15);
            lblNhaXBValue.TabIndex = 10;
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblTheLoai.Location = new Point(190, 85);
            lblTheLoai.Margin = new Padding(4, 0, 4, 0);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(54, 15);
            lblTheLoai.TabIndex = 11;
            lblTheLoai.Text = "Thể loại:";
            // 
            // lblTheLoaiValue
            // 
            lblTheLoaiValue.AutoSize = true;
            lblTheLoaiValue.Font = new Font("Arial", 9F);
            lblTheLoaiValue.Location = new Point(290, 85);
            lblTheLoaiValue.Margin = new Padding(4, 0, 4, 0);
            lblTheLoaiValue.Name = "lblTheLoaiValue";
            lblTheLoaiValue.Size = new Size(0, 15);
            lblTheLoaiValue.TabIndex = 12;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblGia.Location = new Point(190, 100);
            lblGia.Margin = new Padding(4, 0, 4, 0);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(28, 15);
            lblGia.TabIndex = 13;
            lblGia.Text = "Giá:";
            // 
            // lblGiaValue
            // 
            lblGiaValue.AutoSize = true;
            lblGiaValue.Font = new Font("Arial", 9F);
            lblGiaValue.Location = new Point(290, 100);
            lblGiaValue.Margin = new Padding(4, 0, 4, 0);
            lblGiaValue.Name = "lblGiaValue";
            lblGiaValue.Size = new Size(0, 15);
            lblGiaValue.TabIndex = 14;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblMoTa.Location = new Point(190, 115);
            lblMoTa.Margin = new Padding(4, 0, 4, 0);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(41, 15);
            lblMoTa.TabIndex = 15;
            lblMoTa.Text = "Mô tả:";
            // 
            // lblMoTaValue
            // 
            lblMoTaValue.AutoSize = true;
            lblMoTaValue.Font = new Font("Arial", 9F);
            lblMoTaValue.Location = new Point(290, 115);
            lblMoTaValue.Margin = new Padding(4, 0, 4, 0);
            lblMoTaValue.Name = "lblMoTaValue";
            lblMoTaValue.Size = new Size(0, 15);
            lblMoTaValue.TabIndex = 16;
            // 
            // SachForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(1161, 494);
            Controls.Add(dataGridViewSach);
            Controls.Add(panelDetails);
            Controls.Add(panelHeader);
            Controls.Add(panelSearch);
            Controls.Add(panelAction);
            Controls.Add(panelPagination);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SachForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sách";
            WindowState = FormWindowState.Maximized;
            Load += SachForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSach).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelAction.ResumeLayout(false);
            panelPagination.ResumeLayout(false);
            panelPagination.PerformLayout();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSach).EndInit();
            ResumeLayout(false);
        }
    }
}