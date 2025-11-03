namespace QUANLYTHUVIENC3.GUI
{
    partial class SachPopupForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.Label lblNhaXB;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Button btnChonHinhAnh;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.ComboBox cboMaTL;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;

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
            lblMaSach = new Label();
            lblTenSach = new Label();
            lblHinhAnh = new Label();
            lblTacGia = new Label();
            lblNamXB = new Label();
            lblNhaXB = new Label();
            lblTinhTrang = new Label();
            lblGia = new Label();
            lblMoTa = new Label();
            lblMaTL = new Label();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            txtHinhAnh = new TextBox();
            btnChonHinhAnh = new Button();
            txtTacGia = new TextBox();
            txtNamXB = new TextBox();
            txtNhaXB = new TextBox();
            cboTinhTrang = new ComboBox();
            txtGia = new TextBox();
            txtMoTa = new TextBox();
            cboMaTL = new ComboBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(39, 19);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(55, 15);
            lblMaSach.TabIndex = 0;
            lblMaSach.Text = "Mã Sách:";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(39, 47);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(56, 15);
            lblTenSach.TabIndex = 1;
            lblTenSach.Text = "Tên Sách:";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Location = new Point(39, 75);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(61, 15);
            lblHinhAnh.TabIndex = 2;
            lblHinhAnh.Text = "Hình Ảnh:";
            // 
            // lblTacGia
            // 
            lblTacGia.AutoSize = true;
            lblTacGia.Location = new Point(39, 103);
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(47, 15);
            lblTacGia.TabIndex = 3;
            lblTacGia.Text = "Tác Giả:";
            // 
            // lblNamXB
            // 
            lblNamXB.AutoSize = true;
            lblNamXB.Location = new Point(39, 131);
            lblNamXB.Name = "lblNamXB";
            lblNamXB.Size = new Size(86, 15);
            lblNamXB.TabIndex = 4;
            lblNamXB.Text = "Năm Xuất Bản:";
            // 
            // lblNhaXB
            // 
            lblNhaXB.AutoSize = true;
            lblNhaXB.Location = new Point(39, 159);
            lblNhaXB.Name = "lblNhaXB";
            lblNhaXB.Size = new Size(82, 15);
            lblNhaXB.TabIndex = 5;
            lblNhaXB.Text = "Nhà Xuất Bản:";
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(39, 188);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(65, 15);
            lblTinhTrang.TabIndex = 6;
            lblTinhTrang.Text = "Tình Trạng:";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(39, 216);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(27, 15);
            lblGia.TabIndex = 7;
            lblGia.Text = "Giá:";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(39, 244);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(43, 15);
            lblMoTa.TabIndex = 8;
            lblMoTa.Text = "Mô Tả:";
            // 
            // lblMaTL
            // 
            lblMaTL.AutoSize = true;
            lblMaTL.Location = new Point(39, 300);
            lblMaTL.Name = "lblMaTL";
            lblMaTL.Size = new Size(54, 15);
            lblMaTL.TabIndex = 9;
            lblMaTL.Text = "Thể Loại:";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(127, 19);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(175, 23);
            txtMaSach.TabIndex = 10;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(127, 47);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(175, 23);
            txtTenSach.TabIndex = 11;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(127, 75);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(148, 23);
            txtHinhAnh.TabIndex = 12;
            // 
            // btnChonHinhAnh
            // 
            btnChonHinhAnh.Location = new Point(279, 75);
            btnChonHinhAnh.Name = "btnChonHinhAnh";
            btnChonHinhAnh.Size = new Size(22, 18);
            btnChonHinhAnh.TabIndex = 13;
            btnChonHinhAnh.Text = "...";
            btnChonHinhAnh.UseVisualStyleBackColor = true;
            btnChonHinhAnh.Click += btnChonHinhAnh_Click;
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(127, 103);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(175, 23);
            txtTacGia.TabIndex = 14;
            // 
            // txtNamXB
            // 
            txtNamXB.Location = new Point(127, 131);
            txtNamXB.Name = "txtNamXB";
            txtNamXB.Size = new Size(175, 23);
            txtNamXB.TabIndex = 15;
            // 
            // txtNhaXB
            // 
            txtNhaXB.Location = new Point(127, 159);
            txtNhaXB.Name = "txtNhaXB";
            txtNhaXB.Size = new Size(175, 23);
            txtNhaXB.TabIndex = 16;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.Items.AddRange(new object[] { "Còn", "Hết" });
            cboTinhTrang.Location = new Point(127, 188);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(175, 23);
            cboTinhTrang.TabIndex = 17;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(127, 216);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(175, 23);
            txtGia.TabIndex = 18;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(127, 244);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(175, 47);
            txtMoTa.TabIndex = 19;
            // 
            // cboMaTL
            // 
            cboMaTL.Location = new Point(127, 300);
            cboMaTL.Name = "cboMaTL";
            cboMaTL.Size = new Size(175, 23);
            cboMaTL.TabIndex = 20;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(52, 152, 219);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(127, 338);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(79, 28);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(231, 76, 60);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(223, 338);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(79, 28);
            btnHuy.TabIndex = 22;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // SachPopupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 415);
            Controls.Add(lblMaSach);
            Controls.Add(lblTenSach);
            Controls.Add(lblHinhAnh);
            Controls.Add(lblTacGia);
            Controls.Add(lblNamXB);
            Controls.Add(lblNhaXB);
            Controls.Add(lblTinhTrang);
            Controls.Add(lblGia);
            Controls.Add(lblMoTa);
            Controls.Add(lblMaTL);
            Controls.Add(txtMaSach);
            Controls.Add(txtTenSach);
            Controls.Add(txtHinhAnh);
            Controls.Add(btnChonHinhAnh);
            Controls.Add(txtTacGia);
            Controls.Add(txtNamXB);
            Controls.Add(txtNhaXB);
            Controls.Add(cboTinhTrang);
            Controls.Add(txtGia);
            Controls.Add(txtMoTa);
            Controls.Add(cboMaTL);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SachPopupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm/Sửa Sách";
            Load += SachPopupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}