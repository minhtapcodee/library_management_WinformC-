namespace QUANLYTHUVIENC3.GUI
{
    partial class frmKhoSachThem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoSachThem));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            cboTenNhanvien = new ComboBox();
            cboTenSach = new ComboBox();
            label2 = new Label();
            txtMoTa = new TextBox();
            lblMoTa = new Label();
            txtSoLuong = new TextBox();
            lblSoLuong = new Label();
            dtNgayNhap = new DateTimePicker();
            lblNgayNhap = new Label();
            lblBookID = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 1;
            label1.Text = "Thông tin nhập kho ";
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.Khaki;
            groupBox2.Controls.Add(btnCancel);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 104);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.BurlyWood;
            btnCancel.FlatAppearance.BorderSize = 3;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(621, 30);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 44);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.BurlyWood;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(400, 30);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 44);
            btnSave.TabIndex = 5;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 339);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(600, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 339);
            panel3.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGoldenrod;
            groupBox1.Controls.Add(cboTenNhanvien);
            groupBox1.Controls.Add(cboTenSach);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(lblMoTa);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(lblSoLuong);
            groupBox1.Controls.Add(dtNgayNhap);
            groupBox1.Controls.Add(lblNgayNhap);
            groupBox1.Controls.Add(lblBookID);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(200, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 339);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhập sách ";
            // 
            // cboTenNhanvien
            // 
            cboTenNhanvien.FormattingEnabled = true;
            cboTenNhanvien.Location = new Point(81, 207);
            cboTenNhanvien.Name = "cboTenNhanvien";
            cboTenNhanvien.Size = new Size(218, 23);
            cboTenNhanvien.TabIndex = 18;
            cboTenNhanvien.SelectedIndexChanged += cboTenNhanvien_SelectedIndexChanged;
            // 
            // cboTenSach
            // 
            cboTenSach.FormattingEnabled = true;
            cboTenSach.Location = new Point(81, 47);
            cboTenSach.Name = "cboTenSach";
            cboTenSach.Size = new Size(218, 23);
            cboTenSach.TabIndex = 17;
            cboTenSach.SelectedIndexChanged += cboTenSach_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 179);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 16;
            label2.Text = "Tên nhân viên:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(81, 269);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(218, 23);
            txtMoTa.TabIndex = 15;
            txtMoTa.TextChanged += txtMoTa_TextChanged;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            lblMoTa.Location = new Point(77, 241);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(63, 25);
            lblMoTa.TabIndex = 14;
            lblMoTa.Text = "Mô tả:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(81, 101);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(218, 23);
            txtSoLuong.TabIndex = 13;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            lblSoLuong.Location = new Point(77, 73);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(170, 25);
            lblSoLuong.TabIndex = 12;
            lblSoLuong.Text = "Số lượng nhập kho:";
            // 
            // dtNgayNhap
            // 
            dtNgayNhap.Location = new Point(81, 153);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.Size = new Size(218, 23);
            dtNgayNhap.TabIndex = 10;
            dtNgayNhap.ValueChanged += dtNgayNhap_ValueChanged;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNgayNhap.Location = new Point(77, 125);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(141, 25);
            lblNgayNhap.TabIndex = 11;
            lblNgayNhap.Text = "Ngày nhập kho:";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookID.Location = new Point(75, 19);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(88, 25);
            lblBookID.TabIndex = 5;
            lblBookID.Text = "Tên sách:";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmKhoSachThem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "frmKhoSachThem";
            Text = "frmKhoSachThem";
            Load += frmKhoSachThem_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private ComboBox cboTenNhanvien;
        private ComboBox cboTenSach;
        private Label label2;
        private TextBox txtMoTa;
        private Label lblMoTa;
        private TextBox txtSoLuong;
        private Label lblSoLuong;
        private DateTimePicker dtNgayNhap;
        private Label lblNgayNhap;
        private Label lblBookID;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}