namespace QUANLYTHUVIENC3.GUI
{
    partial class frmTThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTThongKe));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            btnRefresh = new Button();
            panelThongKeSachMuon = new Panel();
            lblSachMuonHomNayValue = new Label();
            pictureBox6 = new PictureBox();
            lblThongKeSachMuonValue = new Label();
            lblThongKeSachMuonTitle = new Label();
            panelTongSachDangMuon = new Panel();
            pictureBox2 = new PictureBox();
            lblTongSachDangMuonValue = new Label();
            lblTongSachDangMuonTitle = new Label();
            panelTongTheLoai = new Panel();
            pictureBox4 = new PictureBox();
            lblTongTheLoaiValue = new Label();
            lblTongTheLoaiTitle = new Label();
            panelTongDocGia = new Panel();
            pictureBox5 = new PictureBox();
            lblTongDocGiaValue = new Label();
            lblTongDocGiaTitle = new Label();
            panelTongQuyenSach = new Panel();
            pictureBox3 = new PictureBox();
            lblTongQuyenSachValue = new Label();
            lblTongQuyenSachTitle = new Label();
            panelTongSach = new Panel();
            pictureBox1 = new PictureBox();
            lblTongSachValue = new Label();
            lblTongSachTitle = new Label();
            panelChartSach = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            panelChartSachTheoThang = new Panel();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            panelFilter = new Panel();
            btnXuatBaoCao = new Button();
            cboTieuChiLoc = new ComboBox();
            btnApDungLoc = new Button();
            panelDataGridView = new Panel();
            dataGridViewThongKe = new DataGridView();
            panelMainContent = new Panel();
            panelHeader.SuspendLayout();
            panelThongKeSachMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelTongSachDangMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTongTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelTongDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelTongQuyenSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTongSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChartSach.SuspendLayout();
            panelChartSachTheoThang.SuspendLayout();
            panelFilter.SuspendLayout();
            panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongKe).BeginInit();
            panelMainContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(panelThongKeSachMuon);
            panelHeader.Controls.Add(panelTongSachDangMuon);
            panelHeader.Controls.Add(panelTongTheLoai);
            panelHeader.Controls.Add(panelTongDocGia);
            panelHeader.Controls.Add(panelTongQuyenSach);
            panelHeader.Controls.Add(panelTongSach);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1050, 213);
            panelHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Lime;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Location = new Point(972, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelThongKeSachMuon
            // 
            panelThongKeSachMuon.BackColor = Color.FromArgb(106, 27, 154);
            panelThongKeSachMuon.Controls.Add(lblSachMuonHomNayValue);
            panelThongKeSachMuon.Controls.Add(pictureBox6);
            panelThongKeSachMuon.Controls.Add(lblThongKeSachMuonValue);
            panelThongKeSachMuon.Controls.Add(lblThongKeSachMuonTitle);
            panelThongKeSachMuon.Location = new Point(722, 107);
            panelThongKeSachMuon.Name = "panelThongKeSachMuon";
            panelThongKeSachMuon.Size = new Size(232, 75);
            panelThongKeSachMuon.TabIndex = 6;
            panelThongKeSachMuon.Click += lblThongKeSachMuon_Click;
            // 
            // lblSachMuonHomNayValue
            // 
            lblSachMuonHomNayValue.AutoSize = true;
            lblSachMuonHomNayValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSachMuonHomNayValue.ForeColor = Color.White;
            lblSachMuonHomNayValue.Location = new Point(18, 38);
            lblSachMuonHomNayValue.Name = "lblSachMuonHomNayValue";
            lblSachMuonHomNayValue.Size = new Size(19, 21);
            lblSachMuonHomNayValue.TabIndex = 6;
            lblSachMuonHomNayValue.Text = "0";
            lblSachMuonHomNayValue.Click += lblSachMuonHomNayValue_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(159, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // lblThongKeSachMuonValue
            // 
            lblThongKeSachMuonValue.AutoSize = true;
            lblThongKeSachMuonValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblThongKeSachMuonValue.ForeColor = Color.White;
            lblThongKeSachMuonValue.Location = new Point(18, 38);
            lblThongKeSachMuonValue.Name = "lblThongKeSachMuonValue";
            lblThongKeSachMuonValue.Size = new Size(0, 21);
            lblThongKeSachMuonValue.TabIndex = 1;
            lblThongKeSachMuonValue.Click += lblThongKeSachMuon_Click;
            // 
            // lblThongKeSachMuonTitle
            // 
            lblThongKeSachMuonTitle.AutoSize = true;
            lblThongKeSachMuonTitle.Font = new Font("Segoe UI", 10F);
            lblThongKeSachMuonTitle.ForeColor = Color.White;
            lblThongKeSachMuonTitle.Location = new Point(18, 9);
            lblThongKeSachMuonTitle.Name = "lblThongKeSachMuonTitle";
            lblThongKeSachMuonTitle.Size = new Size(135, 19);
            lblThongKeSachMuonTitle.TabIndex = 0;
            lblThongKeSachMuonTitle.Text = "Sách mượn hôm nay";
            // 
            // panelTongSachDangMuon
            // 
            panelTongSachDangMuon.BackColor = Color.FromArgb(128, 0, 128);
            panelTongSachDangMuon.Controls.Add(pictureBox2);
            panelTongSachDangMuon.Controls.Add(lblTongSachDangMuonValue);
            panelTongSachDangMuon.Controls.Add(lblTongSachDangMuonTitle);
            panelTongSachDangMuon.Location = new Point(60, 107);
            panelTongSachDangMuon.Name = "panelTongSachDangMuon";
            panelTongSachDangMuon.Size = new Size(238, 75);
            panelTongSachDangMuon.TabIndex = 4;
            panelTongSachDangMuon.Click += lblTongSachDangMuon_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(164, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblTongSachDangMuonValue
            // 
            lblTongSachDangMuonValue.AutoSize = true;
            lblTongSachDangMuonValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongSachDangMuonValue.ForeColor = Color.White;
            lblTongSachDangMuonValue.Location = new Point(18, 38);
            lblTongSachDangMuonValue.Name = "lblTongSachDangMuonValue";
            lblTongSachDangMuonValue.Size = new Size(19, 21);
            lblTongSachDangMuonValue.TabIndex = 1;
            lblTongSachDangMuonValue.Text = "0";
            lblTongSachDangMuonValue.Click += lblTongSachDangMuon_Click;
            // 
            // lblTongSachDangMuonTitle
            // 
            lblTongSachDangMuonTitle.AutoSize = true;
            lblTongSachDangMuonTitle.Font = new Font("Segoe UI", 10F);
            lblTongSachDangMuonTitle.ForeColor = Color.White;
            lblTongSachDangMuonTitle.Location = new Point(18, 9);
            lblTongSachDangMuonTitle.Name = "lblTongSachDangMuonTitle";
            lblTongSachDangMuonTitle.Size = new Size(140, 19);
            lblTongSachDangMuonTitle.TabIndex = 0;
            lblTongSachDangMuonTitle.Text = "Đầu sách đang mượn";
            // 
            // panelTongTheLoai
            // 
            panelTongTheLoai.BackColor = Color.FromArgb(0, 192, 0);
            panelTongTheLoai.Controls.Add(pictureBox4);
            panelTongTheLoai.Controls.Add(lblTongTheLoaiValue);
            panelTongTheLoai.Controls.Add(lblTongTheLoaiTitle);
            panelTongTheLoai.Location = new Point(390, 107);
            panelTongTheLoai.Name = "panelTongTheLoai";
            panelTongTheLoai.Size = new Size(221, 75);
            panelTongTheLoai.TabIndex = 3;
            panelTongTheLoai.Click += lblTongTheLoai_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(152, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // lblTongTheLoaiValue
            // 
            lblTongTheLoaiValue.AutoSize = true;
            lblTongTheLoaiValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTheLoaiValue.ForeColor = Color.White;
            lblTongTheLoaiValue.Location = new Point(18, 38);
            lblTongTheLoaiValue.Name = "lblTongTheLoaiValue";
            lblTongTheLoaiValue.Size = new Size(19, 21);
            lblTongTheLoaiValue.TabIndex = 1;
            lblTongTheLoaiValue.Text = "0";
            lblTongTheLoaiValue.Click += lblTongTheLoai_Click;
            // 
            // lblTongTheLoaiTitle
            // 
            lblTongTheLoaiTitle.AutoSize = true;
            lblTongTheLoaiTitle.Font = new Font("Segoe UI", 10F);
            lblTongTheLoaiTitle.ForeColor = Color.White;
            lblTongTheLoaiTitle.Location = new Point(26, 9);
            lblTongTheLoaiTitle.Name = "lblTongTheLoaiTitle";
            lblTongTheLoaiTitle.Size = new Size(89, 19);
            lblTongTheLoaiTitle.TabIndex = 0;
            lblTongTheLoaiTitle.Text = "Tổng thể loại";
            lblTongTheLoaiTitle.Click += lblTongTheLoaiTitle_Click;
            // 
            // panelTongDocGia
            // 
            panelTongDocGia.BackColor = Color.FromArgb(255, 165, 0);
            panelTongDocGia.Controls.Add(pictureBox5);
            panelTongDocGia.Controls.Add(lblTongDocGiaValue);
            panelTongDocGia.Controls.Add(lblTongDocGiaTitle);
            panelTongDocGia.Location = new Point(722, 19);
            panelTongDocGia.Name = "panelTongDocGia";
            panelTongDocGia.Size = new Size(232, 75);
            panelTongDocGia.TabIndex = 2;
            panelTongDocGia.Click += lblTongDocGia_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(148, 9);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // lblTongDocGiaValue
            // 
            lblTongDocGiaValue.AutoSize = true;
            lblTongDocGiaValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongDocGiaValue.ForeColor = Color.White;
            lblTongDocGiaValue.Location = new Point(18, 38);
            lblTongDocGiaValue.Name = "lblTongDocGiaValue";
            lblTongDocGiaValue.Size = new Size(19, 21);
            lblTongDocGiaValue.TabIndex = 1;
            lblTongDocGiaValue.Text = "0";
            lblTongDocGiaValue.Click += lblTongDocGia_Click;
            // 
            // lblTongDocGiaTitle
            // 
            lblTongDocGiaTitle.AutoSize = true;
            lblTongDocGiaTitle.Font = new Font("Segoe UI", 10F);
            lblTongDocGiaTitle.ForeColor = Color.White;
            lblTongDocGiaTitle.Location = new Point(18, 9);
            lblTongDocGiaTitle.Name = "lblTongDocGiaTitle";
            lblTongDocGiaTitle.Size = new Size(88, 19);
            lblTongDocGiaTitle.TabIndex = 0;
            lblTongDocGiaTitle.Text = "Tổng độc giả";
            // 
            // panelTongQuyenSach
            // 
            panelTongQuyenSach.BackColor = Color.FromArgb(192, 0, 0);
            panelTongQuyenSach.Controls.Add(pictureBox3);
            panelTongQuyenSach.Controls.Add(lblTongQuyenSachValue);
            panelTongQuyenSach.Controls.Add(lblTongQuyenSachTitle);
            panelTongQuyenSach.Location = new Point(390, 19);
            panelTongQuyenSach.Name = "panelTongQuyenSach";
            panelTongQuyenSach.Size = new Size(221, 75);
            panelTongQuyenSach.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(152, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblTongQuyenSachValue
            // 
            lblTongQuyenSachValue.AutoSize = true;
            lblTongQuyenSachValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongQuyenSachValue.ForeColor = Color.White;
            lblTongQuyenSachValue.Location = new Point(18, 38);
            lblTongQuyenSachValue.Name = "lblTongQuyenSachValue";
            lblTongQuyenSachValue.Size = new Size(19, 21);
            lblTongQuyenSachValue.TabIndex = 1;
            lblTongQuyenSachValue.Text = "0";
            // 
            // lblTongQuyenSachTitle
            // 
            lblTongQuyenSachTitle.AutoSize = true;
            lblTongQuyenSachTitle.Font = new Font("Segoe UI", 10F);
            lblTongQuyenSachTitle.ForeColor = Color.White;
            lblTongQuyenSachTitle.Location = new Point(18, 9);
            lblTongQuyenSachTitle.Name = "lblTongQuyenSachTitle";
            lblTongQuyenSachTitle.Size = new Size(128, 19);
            lblTongQuyenSachTitle.TabIndex = 0;
            lblTongQuyenSachTitle.Text = "Tổng số lượng sách";
            // 
            // panelTongSach
            // 
            panelTongSach.BackColor = Color.FromArgb(0, 120, 215);
            panelTongSach.Controls.Add(pictureBox1);
            panelTongSach.Controls.Add(lblTongSachValue);
            panelTongSach.Controls.Add(lblTongSachTitle);
            panelTongSach.Location = new Point(60, 19);
            panelTongSach.Name = "panelTongSach";
            panelTongSach.Size = new Size(238, 75);
            panelTongSach.TabIndex = 0;
            panelTongSach.Click += lblTongSach_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTongSachValue
            // 
            lblTongSachValue.AutoSize = true;
            lblTongSachValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongSachValue.ForeColor = Color.White;
            lblTongSachValue.Location = new Point(18, 38);
            lblTongSachValue.Name = "lblTongSachValue";
            lblTongSachValue.Size = new Size(19, 21);
            lblTongSachValue.TabIndex = 1;
            lblTongSachValue.Text = "0";
            lblTongSachValue.Click += lblTongSach_Click;
            // 
            // lblTongSachTitle
            // 
            lblTongSachTitle.AutoSize = true;
            lblTongSachTitle.Font = new Font("Segoe UI", 10F);
            lblTongSachTitle.ForeColor = Color.White;
            lblTongSachTitle.Location = new Point(18, 9);
            lblTongSachTitle.Name = "lblTongSachTitle";
            lblTongSachTitle.Size = new Size(98, 19);
            lblTongSachTitle.TabIndex = 0;
            lblTongSachTitle.Text = "Tổng đầu sách";
            // 
            // panelChartSach
            // 
            panelChartSach.Controls.Add(formsPlot1);
            panelChartSach.Location = new Point(0, 203);
            panelChartSach.Name = "panelChartSach";
            panelChartSach.Size = new Size(1050, 318);
            panelChartSach.TabIndex = 1;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.White;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(0, 35);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1050, 281);
            formsPlot1.TabIndex = 2;
            // 
            // panelChartSachTheoThang
            // 
            panelChartSachTheoThang.Controls.Add(formsPlot2);
            panelChartSachTheoThang.Location = new Point(0, 527);
            panelChartSachTheoThang.Name = "panelChartSachTheoThang";
            panelChartSachTheoThang.Size = new Size(1050, 282);
            panelChartSachTheoThang.TabIndex = 2;
            // 
            // formsPlot2
            // 
            formsPlot2.BackColor = Color.White;
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(0, 1);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(1050, 281);
            formsPlot2.TabIndex = 3;
            // 
            // panelFilter
            // 
            panelFilter.Controls.Add(btnXuatBaoCao);
            panelFilter.Controls.Add(cboTieuChiLoc);
            panelFilter.Controls.Add(btnApDungLoc);
            panelFilter.Location = new Point(0, 853);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1050, 70);
            panelFilter.TabIndex = 3;
            // 
            // btnXuatBaoCao
            // 
            btnXuatBaoCao.BackColor = Color.FromArgb(0, 192, 0);
            btnXuatBaoCao.FlatAppearance.BorderSize = 0;
            btnXuatBaoCao.FlatStyle = FlatStyle.Flat;
            btnXuatBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuatBaoCao.ForeColor = Color.White;
            btnXuatBaoCao.Location = new Point(396, 19);
            btnXuatBaoCao.Name = "btnXuatBaoCao";
            btnXuatBaoCao.Size = new Size(116, 29);
            btnXuatBaoCao.TabIndex = 1;
            btnXuatBaoCao.Text = "Xuất báo cáo";
            btnXuatBaoCao.UseVisualStyleBackColor = false;
            btnXuatBaoCao.MouseEnter += btnXuatBaoCao_MouseEnter;
            btnXuatBaoCao.MouseLeave += btnXuatBaoCao_MouseLeave;
            // 
            // cboTieuChiLoc
            // 
            cboTieuChiLoc.Font = new Font("Segoe UI", 10F);
            cboTieuChiLoc.Location = new Point(5, 20);
            cboTieuChiLoc.Name = "cboTieuChiLoc";
            cboTieuChiLoc.Size = new Size(232, 25);
            cboTieuChiLoc.TabIndex = 0;
            // 
            // btnApDungLoc
            // 
            btnApDungLoc.BackColor = Color.FromArgb(0, 120, 215);
            btnApDungLoc.FlatAppearance.BorderSize = 0;
            btnApDungLoc.FlatStyle = FlatStyle.Flat;
            btnApDungLoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApDungLoc.ForeColor = Color.White;
            btnApDungLoc.Location = new Point(254, 20);
            btnApDungLoc.Name = "btnApDungLoc";
            btnApDungLoc.Size = new Size(116, 29);
            btnApDungLoc.TabIndex = 1;
            btnApDungLoc.Text = "Áp dụng";
            btnApDungLoc.UseVisualStyleBackColor = false;
            btnApDungLoc.MouseEnter += btnApDungLoc_MouseEnter;
            btnApDungLoc.MouseLeave += btnApDungLoc_MouseLeave;
            // 
            // panelDataGridView
            // 
            panelDataGridView.Controls.Add(dataGridViewThongKe);
            panelDataGridView.Location = new Point(0, 905);
            panelDataGridView.Name = "panelDataGridView";
            panelDataGridView.Size = new Size(1481, 385);
            panelDataGridView.TabIndex = 4;
            // 
            // dataGridViewThongKe
            // 
            dataGridViewThongKe.AllowUserToResizeRows = false;
            dataGridViewThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewThongKe.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewThongKe.EnableHeadersVisualStyles = false;
            dataGridViewThongKe.GridColor = Color.LightGray;
            dataGridViewThongKe.Location = new Point(5, 45);
            dataGridViewThongKe.Name = "dataGridViewThongKe";
            dataGridViewThongKe.RowHeadersVisible = false;
            dataGridViewThongKe.RowHeadersWidth = 51;
            dataGridViewThongKe.Size = new Size(1042, 330);
            dataGridViewThongKe.TabIndex = 0;
            // 
            // panelMainContent
            // 
            panelMainContent.AutoScroll = true;
            panelMainContent.AutoScrollMinSize = new Size(1050, 0);
            panelMainContent.Controls.Add(panelDataGridView);
            panelMainContent.Controls.Add(panelChartSachTheoThang);
            panelMainContent.Controls.Add(panelFilter);
            panelMainContent.Controls.Add(panelChartSach);
            panelMainContent.Controls.Add(panelHeader);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1097, 749);
            panelMainContent.TabIndex = 5;
            // 
            // frmTThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1097, 749);
            Controls.Add(panelMainContent);
            Name = "frmTThongKe";
            Text = "Thống kê tổng quan";
            Load += frmThongKe_Load;
            panelHeader.ResumeLayout(false);
            panelThongKeSachMuon.ResumeLayout(false);
            panelThongKeSachMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelTongSachDangMuon.ResumeLayout(false);
            panelTongSachDangMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTongTheLoai.ResumeLayout(false);
            panelTongTheLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelTongDocGia.ResumeLayout(false);
            panelTongDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelTongQuyenSach.ResumeLayout(false);
            panelTongQuyenSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTongSach.ResumeLayout(false);
            panelTongSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelChartSach.ResumeLayout(false);
            panelChartSachTheoThang.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongKe).EndInit();
            panelMainContent.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTongSach;
        private System.Windows.Forms.Label lblTongSachValue;
        private System.Windows.Forms.Label lblTongSachTitle;
        private System.Windows.Forms.Panel panelTongQuyenSach;
        private System.Windows.Forms.Label lblTongQuyenSachValue;
        private System.Windows.Forms.Label lblTongQuyenSachTitle;
        private System.Windows.Forms.Panel panelTongDocGia;
        private System.Windows.Forms.Label lblTongDocGiaValue;
        private System.Windows.Forms.Label lblTongDocGiaTitle;
        private System.Windows.Forms.Panel panelTongTheLoai;
        private System.Windows.Forms.Label lblTongTheLoaiValue;
        private System.Windows.Forms.Label lblTongTheLoaiTitle;
        private System.Windows.Forms.Panel panelTongSachDangMuon;
        private System.Windows.Forms.Label lblTongSachDangMuonValue;
        private System.Windows.Forms.Label lblTongSachDangMuonTitle;
        private System.Windows.Forms.Panel panelThongKeSachMuon;
        private System.Windows.Forms.Label lblThongKeSachMuonValue;
        private System.Windows.Forms.Label lblThongKeSachMuonTitle;
        private System.Windows.Forms.Panel panelChartSach;
        private System.Windows.Forms.Panel panelChartSachTheoThang;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox cboTieuChiLoc;
        private System.Windows.Forms.Button btnApDungLoc;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewThongKe;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Panel panelMainContent;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private Button btnRefresh;
        private Label lblSachMuonHomNayValue;
    }
}