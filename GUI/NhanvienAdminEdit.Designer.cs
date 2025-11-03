namespace QUANLYTHUVIENC3.GUI
{
    partial class NhanvienAdminEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanvienAdminEdit));
            panel2 = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dtpNgaySinh = new DateTimePicker();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label9 = new Label();
            txtDiaChi = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtSDT = new TextBox();
            label5 = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 478);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 100);
            panel2.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 79);
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(453, 29);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(40, 167, 79);
            btnCancel.FlatAppearance.BorderSize = 3;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(650, 29);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 44);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(457, 37);
            label1.TabIndex = 1;
            label1.Text = "  Quản lý nhân viên / Sửa nhân viên ";
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
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 58);
            panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(rdoNu);
            groupBox1.Controls.Add(rdoNam);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 420);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(291, 253);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(222, 23);
            dtpNgaySinh.TabIndex = 34;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.BackColor = Color.Black;
            rdoNu.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoNu.ForeColor = Color.White;
            rdoNu.Location = new Point(413, 103);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(49, 23);
            rdoNu.TabIndex = 28;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = false;
            rdoNu.CheckedChanged += rdoNu_CheckedChanged;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.BackColor = Color.Black;
            rdoNam.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoNam.ForeColor = Color.White;
            rdoNam.Location = new Point(297, 103);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(59, 23);
            rdoNam.TabIndex = 26;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = false;
            rdoNam.CheckedChanged += rdoNam_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(291, 231);
            label9.Name = "label9";
            label9.Size = new Size(94, 22);
            label9.TabIndex = 33;
            label9.Text = "Năm sinh:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(297, 338);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(222, 23);
            txtDiaChi.TabIndex = 32;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(297, 313);
            label8.Name = "label8";
            label8.Size = new Size(75, 22);
            label8.TabIndex = 31;
            label8.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(291, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 30;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(291, 152);
            label7.Name = "label7";
            label7.Size = new Size(67, 22);
            label7.TabIndex = 29;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(291, 60);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 27;
            label6.Text = "Giới tính:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(22, 338);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(216, 23);
            txtSDT.TabIndex = 25;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(22, 313);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 24;
            label5.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(22, 256);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(216, 23);
            txtHoTen.TabIndex = 23;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 231);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 22;
            label4.Text = "Họ tên:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(22, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(235, 20);
            txtPassword.TabIndex = 21;
            txtPassword.Text = "Quyền riêng tư của nhân viên , không được xem";
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 143);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 20;
            label3.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Enabled = false;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(22, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 23);
            txtUsername.TabIndex = 19;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(139, 22);
            label2.TabIndex = 18;
            label2.Text = "Tên đăng nhập:";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // NhanvienAdminEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 578);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanvienAdminEdit";
            Text = "NhanvienAdminEdit";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label label9;
        private TextBox txtDiaChi;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private Label label6;
        private TextBox txtSDT;
        private Label label5;
        private TextBox txtHoTen;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}