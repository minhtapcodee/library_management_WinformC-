namespace QUANLYTHUVIENC3.GUI
{
    partial class frmThongTin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelContainer; // Panel chứa các điều khiển

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTin));
            lblTitle = new Label();
            lblMaDocGia = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblDiaChi = new Label();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            txtMaDocGia = new TextBox();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            txtDiaChi = new TextBox();
            txtSoDienThoai = new TextBox();
            txtEmail = new TextBox();
            btnChinhSua = new Button();
            btnDangXuat = new Button();
            panelContainer = new Panel();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(135, 20);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông Tin Cá Nhân";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaDocGia
            // 
            lblMaDocGia.AutoSize = true;
            lblMaDocGia.Font = new Font("Segoe UI", 10F);
            lblMaDocGia.ForeColor = Color.Black;
            lblMaDocGia.Location = new Point(30, 80);
            lblMaDocGia.Margin = new Padding(4, 0, 4, 0);
            lblMaDocGia.Name = "lblMaDocGia";
            lblMaDocGia.Size = new Size(84, 19);
            lblMaDocGia.TabIndex = 1;
            lblMaDocGia.Text = "Mã Độc Giả:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.ForeColor = Color.Black;
            lblHoTen.Location = new Point(30, 120);
            lblHoTen.Margin = new Padding(4, 0, 4, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(55, 19);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ Tên:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 10F);
            lblNgaySinh.ForeColor = Color.Black;
            lblNgaySinh.Location = new Point(30, 160);
            lblNgaySinh.Margin = new Padding(4, 0, 4, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 19);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.ForeColor = Color.Black;
            lblDiaChi.Location = new Point(30, 200);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(56, 19);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            lblSoDienThoai.ForeColor = Color.Black;
            lblSoDienThoai.Location = new Point(30, 240);
            lblSoDienThoai.Margin = new Padding(4, 0, 4, 0);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(96, 19);
            lblSoDienThoai.TabIndex = 5;
            lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(30, 280);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.BackColor = Color.FromArgb(245, 245, 245);
            txtMaDocGia.BorderStyle = BorderStyle.FixedSingle;
            txtMaDocGia.Font = new Font("Segoe UI", 10F);
            txtMaDocGia.Location = new Point(150, 80);
            txtMaDocGia.Margin = new Padding(4, 3, 4, 3);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.ReadOnly = true;
            txtMaDocGia.Size = new Size(350, 25);
            txtMaDocGia.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.FromArgb(245, 245, 245);
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(150, 120);
            txtHoTen.Margin = new Padding(4, 3, 4, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(350, 25);
            txtHoTen.TabIndex = 8;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.BackColor = Color.FromArgb(245, 245, 245);
            txtNgaySinh.BorderStyle = BorderStyle.FixedSingle;
            txtNgaySinh.Font = new Font("Segoe UI", 10F);
            txtNgaySinh.Location = new Point(150, 160);
            txtNgaySinh.Margin = new Padding(4, 3, 4, 3);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.ReadOnly = true;
            txtNgaySinh.Size = new Size(350, 25);
            txtNgaySinh.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.FromArgb(245, 245, 245);
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(150, 200);
            txtDiaChi.Margin = new Padding(4, 3, 4, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(350, 25);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BackColor = Color.FromArgb(245, 245, 245);
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            txtSoDienThoai.Location = new Point(150, 240);
            txtSoDienThoai.Margin = new Padding(4, 3, 4, 3);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.ReadOnly = true;
            txtSoDienThoai.Size = new Size(350, 25);
            txtSoDienThoai.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 245, 245);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(150, 280);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(350, 25);
            txtEmail.TabIndex = 12;
            // 
            // btnChinhSua
            // 
            btnChinhSua.BackColor = Color.FromArgb(60, 179, 113);
            btnChinhSua.FlatAppearance.BorderSize = 0;
            btnChinhSua.FlatStyle = FlatStyle.Flat;
            btnChinhSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChinhSua.ForeColor = Color.White;
            btnChinhSua.Location = new Point(150, 330);
            btnChinhSua.Margin = new Padding(4, 3, 4, 3);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(160, 40);
            btnChinhSua.TabIndex = 13;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = false;
            btnChinhSua.Click += btnChinhSua_Click;
            btnChinhSua.MouseEnter += btnChinhSua_MouseEnter;
            btnChinhSua.MouseLeave += btnChinhSua_MouseLeave;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(220, 53, 69);
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(340, 330);
            btnDangXuat.Margin = new Padding(4, 3, 4, 3);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(160, 40);
            btnDangXuat.TabIndex = 14;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            btnDangXuat.MouseEnter += btnDangXuat_MouseEnter;
            btnDangXuat.MouseLeave += btnDangXuat_MouseLeave;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Controls.Add(btnDangXuat);
            panelContainer.Controls.Add(btnChinhSua);
            panelContainer.Controls.Add(txtEmail);
            panelContainer.Controls.Add(txtSoDienThoai);
            panelContainer.Controls.Add(txtDiaChi);
            panelContainer.Controls.Add(txtNgaySinh);
            panelContainer.Controls.Add(txtHoTen);
            panelContainer.Controls.Add(txtMaDocGia);
            panelContainer.Controls.Add(lblEmail);
            panelContainer.Controls.Add(lblSoDienThoai);
            panelContainer.Controls.Add(lblDiaChi);
            panelContainer.Controls.Add(lblNgaySinh);
            panelContainer.Controls.Add(lblHoTen);
            panelContainer.Controls.Add(lblMaDocGia);
            panelContainer.Controls.Add(lblTitle);
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(523, 402);
            panelContainer.TabIndex = 15;
            // 
            // frmThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 500);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongTin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Cá Nhân";
            Load += frmThongTin_Load;
            Resize += frmThongTin_Resize;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }
    }
}