namespace QUANLYTHUVIENC3.GUI
{
    partial class frmProfileNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfileNhanvien));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panelContainer = new Panel();
            dtpNgaySinh = new DateTimePicker();
            btnRefresh = new Button();
            btnChinhSua = new Button();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtMaNhanvien = new TextBox();
            lblEmail = new Label();
            lblSoDienThoai = new Label();
            lblDiaChi = new Label();
            lblNgaySinh = new Label();
            lblHoTen = new Label();
            lblMaDocGia = new Label();
            lblTitle = new Label();
            label2 = new Label();
            cmbGioiTinh = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 74);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(97, 25);
            label1.Name = "label1";
            label1.Size = new Size(177, 40);
            label1.TabIndex = 1;
            label1.Text = "My Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 502);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(774, 74);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(365, 502);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Silver;
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Controls.Add(cmbGioiTinh);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(dtpNgaySinh);
            panelContainer.Controls.Add(btnRefresh);
            panelContainer.Controls.Add(btnChinhSua);
            panelContainer.Controls.Add(txtEmail);
            panelContainer.Controls.Add(txtSoDienThoai);
            panelContainer.Controls.Add(txtDiaChi);
            panelContainer.Controls.Add(txtHoTen);
            panelContainer.Controls.Add(txtMaNhanvien);
            panelContainer.Controls.Add(lblEmail);
            panelContainer.Controls.Add(lblSoDienThoai);
            panelContainer.Controls.Add(lblDiaChi);
            panelContainer.Controls.Add(lblNgaySinh);
            panelContainer.Controls.Add(lblHoTen);
            panelContainer.Controls.Add(lblMaDocGia);
            panelContainer.Controls.Add(lblTitle);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(337, 74);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(437, 502);
            panelContainer.TabIndex = 20;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(40, 192);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(350, 23);
            dtpNgaySinh.TabIndex = 16;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(220, 53, 69);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(230, 465);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 40);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Hủy";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnChinhSua
            // 
            btnChinhSua.BackColor = Color.FromArgb(60, 179, 113);
            btnChinhSua.FlatAppearance.BorderSize = 0;
            btnChinhSua.FlatStyle = FlatStyle.Flat;
            btnChinhSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChinhSua.ForeColor = Color.White;
            btnChinhSua.Location = new Point(41, 465);
            btnChinhSua.Margin = new Padding(4, 3, 4, 3);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(160, 40);
            btnChinhSua.TabIndex = 13;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = false;
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 245, 245);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(40, 240);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 25);
            txtEmail.TabIndex = 12;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BackColor = Color.FromArgb(245, 245, 245);
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            txtSoDienThoai.Location = new Point(40, 340);
            txtSoDienThoai.Margin = new Padding(4, 3, 4, 3);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(350, 25);
            txtSoDienThoai.TabIndex = 11;
            txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.FromArgb(245, 245, 245);
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(40, 390);
            txtDiaChi.Margin = new Padding(4, 3, 4, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(350, 25);
            txtDiaChi.TabIndex = 10;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.FromArgb(245, 245, 245);
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(40, 142);
            txtHoTen.Margin = new Padding(4, 3, 4, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(350, 25);
            txtHoTen.TabIndex = 8;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtMaNhanvien
            // 
            txtMaNhanvien.BackColor = Color.FromArgb(245, 245, 245);
            txtMaNhanvien.BorderStyle = BorderStyle.FixedSingle;
            txtMaNhanvien.Font = new Font("Segoe UI", 10F);
            txtMaNhanvien.Location = new Point(40, 92);
            txtMaNhanvien.Margin = new Padding(4, 3, 4, 3);
            txtMaNhanvien.Name = "txtMaNhanvien";
            txtMaNhanvien.ReadOnly = true;
            txtMaNhanvien.Size = new Size(350, 25);
            txtMaNhanvien.TabIndex = 7;
            txtMaNhanvien.TextChanged += txtMaNhanvien_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(40, 218);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            lblSoDienThoai.ForeColor = Color.Black;
            lblSoDienThoai.Location = new Point(42, 318);
            lblSoDienThoai.Margin = new Padding(4, 0, 4, 0);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(96, 19);
            lblSoDienThoai.TabIndex = 5;
            lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.ForeColor = Color.Black;
            lblDiaChi.Location = new Point(41, 368);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(56, 19);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 10F);
            lblNgaySinh.ForeColor = Color.Black;
            lblNgaySinh.Location = new Point(40, 170);
            lblNgaySinh.Margin = new Padding(4, 0, 4, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 19);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.ForeColor = Color.Black;
            lblHoTen.Location = new Point(41, 120);
            lblHoTen.Margin = new Padding(4, 0, 4, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(55, 19);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ Tên:";
            // 
            // lblMaDocGia
            // 
            lblMaDocGia.AutoSize = true;
            lblMaDocGia.Font = new Font("Segoe UI", 10F);
            lblMaDocGia.ForeColor = Color.Black;
            lblMaDocGia.Location = new Point(40, 70);
            lblMaDocGia.Margin = new Padding(4, 0, 4, 0);
            lblMaDocGia.Name = "lblMaDocGia";
            lblMaDocGia.Size = new Size(98, 19);
            lblMaDocGia.TabIndex = 1;
            lblMaDocGia.Text = "Mã Nhân viên:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(64, 19);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(299, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông Tin Cá Nhân";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 268);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 17;
            label2.Text = "Giới tính:";
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioiTinh.FormattingEnabled = true;
            cmbGioiTinh.Location = new Point(40, 288);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new Size(350, 23);
            cmbGioiTinh.TabIndex = 18;
            cmbGioiTinh.SelectedIndexChanged += cmbGioiTinh_SelectedIndexChanged;
            // 
            // frmProfileNhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 576);
            Controls.Add(panelContainer);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProfileNhanvien";
            Text = "frmProfileNhanvien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panelContainer;
        private Button btnRefresh;
        private Button btnChinhSua;
        private TextBox txtEmail;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtMaNhanvien;
        private Label lblEmail;
        private Label lblSoDienThoai;
        private Label lblDiaChi;
        private Label lblNgaySinh;
        private Label lblHoTen;
        private Label lblMaDocGia;
        private Label lblTitle;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cmbGioiTinh;
        private Label label2;
    }
}