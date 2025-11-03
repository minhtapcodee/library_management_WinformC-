namespace QUANLYTHUVIENC3.GUI
{
    partial class frmMainDocGia
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHinhAnh;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnThongTinCaNhan;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel theSachTemplate;
        private System.Windows.Forms.PictureBox hinhAnhSachTemplate;
        private System.Windows.Forms.Label tacGiaTemplate;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainDocGia));
            panelHinhAnh = new Panel();
            pictureBoxBanner = new PictureBox();
            panelMenu = new Panel();
            btnTrangChu = new Button();
            btnGioiThieu = new Button();
            btnTimKiem = new Button();
            btnMuonTra = new Button();
            btnThongTinCaNhan = new Button();
            panelContent = new Panel();
            theSachTemplate = new Panel();
            hinhAnhSachTemplate = new PictureBox();
            tacGiaTemplate = new Label();
            panelHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            theSachTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hinhAnhSachTemplate).BeginInit();
            SuspendLayout();
            // 
            // panelHinhAnh
            // 
            panelHinhAnh.BackColor = Color.FromArgb(135, 206, 250);
            panelHinhAnh.Controls.Add(pictureBoxBanner);
            panelHinhAnh.Dock = DockStyle.Top;
            panelHinhAnh.Location = new Point(0, 0);
            panelHinhAnh.Margin = new Padding(0);
            panelHinhAnh.Name = "panelHinhAnh";
            panelHinhAnh.Size = new Size(1364, 173);
            panelHinhAnh.TabIndex = 0;
            // 
            // pictureBoxBanner
            // 
            pictureBoxBanner.Dock = DockStyle.Fill;
            pictureBoxBanner.Image = (Image)resources.GetObject("pictureBoxBanner.Image");
            pictureBoxBanner.Location = new Point(0, 0);
            pictureBoxBanner.Margin = new Padding(4, 3, 4, 3);
            pictureBoxBanner.Name = "pictureBoxBanner";
            pictureBoxBanner.Size = new Size(1364, 173);
            pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBanner.TabIndex = 0;
            pictureBoxBanner.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(176, 224, 230);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Controls.Add(btnGioiThieu);
            panelMenu.Controls.Add(btnTimKiem);
            panelMenu.Controls.Add(btnMuonTra);
            panelMenu.Controls.Add(btnThongTinCaNhan);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 173);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1364, 60);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.FromArgb(176, 224, 230);
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnTrangChu.ForeColor = Color.FromArgb(25, 25, 112);
            btnTrangChu.Image = (Image)resources.GetObject("btnTrangChu.Image");
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Margin = new Padding(4, 3, 4, 3);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(88, 27);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Tag = "Home";
            btnTrangChu.Text = "    Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnMenu_Click;
            btnTrangChu.MouseEnter += btnMenu_MouseEnter;
            btnTrangChu.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnGioiThieu
            // 
            btnGioiThieu.BackColor = Color.FromArgb(176, 224, 230);
            btnGioiThieu.FlatAppearance.BorderSize = 0;
            btnGioiThieu.FlatStyle = FlatStyle.Flat;
            btnGioiThieu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnGioiThieu.ForeColor = Color.FromArgb(25, 25, 112);
            btnGioiThieu.Image = (Image)resources.GetObject("btnGioiThieu.Image");
            btnGioiThieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnGioiThieu.Location = new Point(0, 0);
            btnGioiThieu.Margin = new Padding(4, 3, 4, 3);
            btnGioiThieu.Name = "btnGioiThieu";
            btnGioiThieu.Size = new Size(88, 27);
            btnGioiThieu.TabIndex = 1;
            btnGioiThieu.Tag = "About";
            btnGioiThieu.Text = "    Giới thiệu";
            btnGioiThieu.UseVisualStyleBackColor = false;
            btnGioiThieu.Click += btnMenu_Click;
            btnGioiThieu.MouseEnter += btnMenu_MouseEnter;
            btnGioiThieu.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(176, 224, 230);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.FromArgb(25, 25, 112);
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(0, 0);
            btnTimKiem.Margin = new Padding(4, 3, 4, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(88, 27);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Tag = "Search";
            btnTimKiem.Text = "  Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnMenu_Click;
            btnTimKiem.MouseEnter += btnMenu_MouseEnter;
            btnTimKiem.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnMuonTra
            // 
            btnMuonTra.BackColor = Color.FromArgb(176, 224, 230);
            btnMuonTra.FlatAppearance.BorderSize = 0;
            btnMuonTra.FlatStyle = FlatStyle.Flat;
            btnMuonTra.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMuonTra.ForeColor = Color.FromArgb(25, 25, 112);
            btnMuonTra.Image = (Image)resources.GetObject("btnMuonTra.Image");
            btnMuonTra.ImageAlign = ContentAlignment.MiddleLeft;
            btnMuonTra.Location = new Point(0, 0);
            btnMuonTra.Margin = new Padding(4, 3, 4, 3);
            btnMuonTra.Name = "btnMuonTra";
            btnMuonTra.Size = new Size(88, 27);
            btnMuonTra.TabIndex = 3;
            btnMuonTra.Tag = "Rent";
            btnMuonTra.Text = "  Mượn-Trả";
            btnMuonTra.UseVisualStyleBackColor = false;
            btnMuonTra.Click += btnMenu_Click;
            btnMuonTra.MouseEnter += btnMenu_MouseEnter;
            btnMuonTra.MouseLeave += btnMenu_MouseLeave;
            // 
            // btnThongTinCaNhan
            // 
            btnThongTinCaNhan.BackColor = Color.FromArgb(176, 224, 230);
            btnThongTinCaNhan.FlatAppearance.BorderSize = 0;
            btnThongTinCaNhan.FlatStyle = FlatStyle.Flat;
            btnThongTinCaNhan.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnThongTinCaNhan.ForeColor = Color.FromArgb(25, 25, 112);
            btnThongTinCaNhan.Image = (Image)resources.GetObject("btnThongTinCaNhan.Image");
            btnThongTinCaNhan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTinCaNhan.Location = new Point(0, 0);
            btnThongTinCaNhan.Margin = new Padding(4, 3, 4, 3);
            btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            btnThongTinCaNhan.Size = new Size(88, 27);
            btnThongTinCaNhan.TabIndex = 4;
            btnThongTinCaNhan.Tag = "Info";
            btnThongTinCaNhan.Text = "Thông tin cá nhân";
            btnThongTinCaNhan.UseVisualStyleBackColor = false;
            btnThongTinCaNhan.Click += btnMenu_Click;
            btnThongTinCaNhan.MouseEnter += btnMenu_MouseEnter;
            btnThongTinCaNhan.MouseLeave += btnMenu_MouseLeave;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(240, 248, 255);
            panelContent.Controls.Add(theSachTemplate);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 233);
            panelContent.Margin = new Padding(4, 3, 4, 3);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1364, 516);
            panelContent.TabIndex = 2;
            panelContent.Paint += panelContent_Paint;
            // 
            // theSachTemplate
            // 
            theSachTemplate.BackColor = Color.White;
            theSachTemplate.BorderStyle = BorderStyle.FixedSingle;
            theSachTemplate.Controls.Add(hinhAnhSachTemplate);
            theSachTemplate.Controls.Add(tacGiaTemplate);
            theSachTemplate.Location = new Point(12, 12);
            theSachTemplate.Margin = new Padding(4, 3, 4, 3);
            theSachTemplate.Name = "theSachTemplate";
            theSachTemplate.Size = new Size(233, 254);
            theSachTemplate.TabIndex = 1;
            theSachTemplate.Visible = false;
            // 
            // hinhAnhSachTemplate
            // 
            hinhAnhSachTemplate.Location = new Point(6, 6);
            hinhAnhSachTemplate.Margin = new Padding(4, 3, 4, 3);
            hinhAnhSachTemplate.Name = "hinhAnhSachTemplate";
            hinhAnhSachTemplate.Padding = new Padding(16, 16, 16, 0);
            hinhAnhSachTemplate.Size = new Size(222, 162);
            hinhAnhSachTemplate.SizeMode = PictureBoxSizeMode.StretchImage;
            hinhAnhSachTemplate.TabIndex = 0;
            hinhAnhSachTemplate.TabStop = false;
            // 
            // tacGiaTemplate
            // 
            tacGiaTemplate.AutoSize = true;
            tacGiaTemplate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tacGiaTemplate.ForeColor = Color.DarkGray;
            tacGiaTemplate.Location = new Point(6, 173);
            tacGiaTemplate.Margin = new Padding(4, 0, 4, 0);
            tacGiaTemplate.MaximumSize = new Size(222, 46);
            tacGiaTemplate.Name = "tacGiaTemplate";
            tacGiaTemplate.Size = new Size(126, 19);
            tacGiaTemplate.TabIndex = 1;
            tacGiaTemplate.Text = "Tác giả: Không rõ";
            tacGiaTemplate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMainDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 749);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelHinhAnh);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMainDocGia";
            Text = "Trang Chủ Độc Giả";
            Load += frmMainDocGia_Load;
            panelHinhAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
            panelMenu.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            theSachTemplate.ResumeLayout(false);
            theSachTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hinhAnhSachTemplate).EndInit();
            ResumeLayout(false);
        }
    }
}