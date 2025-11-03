namespace QUANLYTHUVIENC3.GUI
{
    partial class frnKhoSachHienThi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnKhoSachHienThi));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMieuTa = new TextBox();
            txtTheLoai = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            txtMaKho = new TextBox();
            txtTenNhanvien = new TextBox();
            txtNgayNhap = new TextBox();
            txtConLai = new TextBox();
            txtDangMuon = new TextBox();
            txtNhapKho = new TextBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(440, 37);
            label1.TabIndex = 1;
            label1.Text = "Thông tin chi tiết dữ liệu nhập kho";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtMieuTa);
            panel2.Controls.Add(txtTheLoai);
            panel2.Controls.Add(txtTenSach);
            panel2.Controls.Add(txtMaSach);
            panel2.Controls.Add(txtMaKho);
            panel2.Controls.Add(txtTenNhanvien);
            panel2.Controls.Add(txtNgayNhap);
            panel2.Controls.Add(txtConLai);
            panel2.Controls.Add(txtDangMuon);
            panel2.Controls.Add(txtNhapKho);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(350, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 478);
            panel2.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 3;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe Script", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(168, 433);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 33);
            btnExit.TabIndex = 20;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label11.Location = new Point(254, 340);
            label11.Name = "label11";
            label11.Size = new Size(148, 19);
            label11.TabIndex = 19;
            label11.Text = "Nhân viên nhập kho :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label10.Location = new Point(254, 259);
            label10.Name = "label10";
            label10.Size = new Size(92, 19);
            label10.TabIndex = 18;
            label10.Text = "Ngày nhập :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label9.Location = new Point(254, 182);
            label9.Name = "label9";
            label9.Size = new Size(121, 19);
            label9.TabIndex = 17;
            label9.Text = "Số lượng còn lại :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label8.Location = new Point(254, 110);
            label8.Name = "label8";
            label8.Size = new Size(151, 19);
            label8.TabIndex = 16;
            label8.Text = "Số lượng đang mượn :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label7.Location = new Point(40, 340);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 15;
            label7.Text = "Miêu tả :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label6.Location = new Point(40, 259);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 14;
            label6.Text = "Thể loại :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label5.Location = new Point(40, 182);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 13;
            label5.Text = "Tên sách :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 110);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 12;
            label4.Text = "Mã sách :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 33);
            label3.Name = "label3";
            label3.Size = new Size(139, 19);
            label3.TabIndex = 11;
            label3.Text = "Số lượng nhập kho :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            label2.Location = new Point(40, 33);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 10;
            label2.Text = "Mã kho :";
            // 
            // txtMieuTa
            // 
            txtMieuTa.Location = new Point(40, 367);
            txtMieuTa.Name = "txtMieuTa";
            txtMieuTa.Size = new Size(154, 23);
            txtMieuTa.TabIndex = 9;
            txtMieuTa.TextChanged += txtMieuTa_TextChanged;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Location = new Point(40, 286);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(154, 23);
            txtTheLoai.TabIndex = 8;
            txtTheLoai.TextChanged += txtTheLoai_TextChanged;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(40, 209);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(154, 23);
            txtTenSach.TabIndex = 7;
            txtTenSach.TextChanged += txtTenSach_TextChanged;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(40, 137);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(154, 23);
            txtMaSach.TabIndex = 6;
            txtMaSach.TextChanged += txtMaSach_TextChanged;
            // 
            // txtMaKho
            // 
            txtMaKho.Location = new Point(40, 60);
            txtMaKho.Name = "txtMaKho";
            txtMaKho.Size = new Size(154, 23);
            txtMaKho.TabIndex = 5;
            txtMaKho.TextChanged += txtMaKho_TextChanged;
            // 
            // txtTenNhanvien
            // 
            txtTenNhanvien.Location = new Point(254, 367);
            txtTenNhanvien.Name = "txtTenNhanvien";
            txtTenNhanvien.Size = new Size(160, 23);
            txtTenNhanvien.TabIndex = 4;
            txtTenNhanvien.TextChanged += txtTenNhanvien_TextChanged;
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.Location = new Point(254, 286);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.Size = new Size(160, 23);
            txtNgayNhap.TabIndex = 3;
            txtNgayNhap.TextChanged += txtNgayNhap_TextChanged;
            // 
            // txtConLai
            // 
            txtConLai.Location = new Point(254, 209);
            txtConLai.Name = "txtConLai";
            txtConLai.Size = new Size(160, 23);
            txtConLai.TabIndex = 2;
            txtConLai.TextChanged += txtConLai_TextChanged;
            // 
            // txtDangMuon
            // 
            txtDangMuon.Location = new Point(254, 137);
            txtDangMuon.Name = "txtDangMuon";
            txtDangMuon.Size = new Size(160, 23);
            txtDangMuon.TabIndex = 1;
            txtDangMuon.TextChanged += txtDangMuon_TextChanged;
            // 
            // txtNhapKho
            // 
            txtNhapKho.Location = new Point(254, 60);
            txtNhapKho.Name = "txtNhapKho";
            txtNhapKho.Size = new Size(160, 23);
            txtNhapKho.TabIndex = 0;
            txtNhapKho.TextChanged += txtNhapKho_TextChanged;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 478);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // frnKhoSachHienThi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 536);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frnKhoSachHienThi";
            Text = "frnKhoSachHienThi";
            Load += frnKhoSachHienThi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private TextBox txtMieuTa;
        private TextBox txtTheLoai;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private TextBox txtMaKho;
        private TextBox txtTenNhanvien;
        private TextBox txtNgayNhap;
        private TextBox txtConLai;
        private TextBox txtDangMuon;
        private TextBox txtNhapKho;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnExit;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private PictureBox pictureBox2;
    }
}