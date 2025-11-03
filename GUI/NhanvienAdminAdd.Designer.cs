namespace QUANLYTHUVIENC3.GUI
{
    partial class NhanvienAdminAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanvienAdminAdd));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSave = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtHoTen = new TextBox();
            label5 = new Label();
            txtSDT = new TextBox();
            rdoNam = new RadioButton();
            groupBox1 = new GroupBox();
            dtpNgaySinh = new DateTimePicker();
            rdoNu = new RadioButton();
            label9 = new Label();
            txtDiaChi = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 58);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(480, 37);
            label1.TabIndex = 1;
            label1.Text = "  Quản lý nhân viên / Thêm nhân viên ";
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
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 479);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 100);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 36);
            label2.Name = "label2";
            label2.Size = new Size(139, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(21, 61);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(205, 23);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 119);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            label3.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(21, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(139, 23);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 207);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 4;
            label4.Text = "Họ tên:";
            label4.Click += label4_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(21, 232);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(205, 23);
            txtHoTen.TabIndex = 5;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 289);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 6;
            label5.Text = "Số điện thoại:";
            label5.Click += label5_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(21, 314);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(176, 23);
            txtSDT.TabIndex = 7;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.BackColor = Color.White;
            rdoNam.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoNam.ForeColor = Color.Black;
            rdoNam.Location = new Point(267, 61);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(59, 23);
            rdoNam.TabIndex = 8;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = false;
            rdoNam.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(guna2CustomGradientPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(841, 421);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(267, 230);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(222, 23);
            dtpNgaySinh.TabIndex = 17;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.BackColor = Color.White;
            rdoNu.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoNu.ForeColor = Color.Black;
            rdoNu.Location = new Point(385, 61);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(49, 23);
            rdoNu.TabIndex = 10;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = false;
            rdoNu.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(267, 205);
            label9.Name = "label9";
            label9.Size = new Size(94, 22);
            label9.TabIndex = 16;
            label9.Text = "Năm sinh:";
            label9.Click += label9_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(267, 314);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(222, 23);
            txtDiaChi.TabIndex = 15;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(267, 289);
            label8.Name = "label8";
            label8.Size = new Size(75, 22);
            label8.TabIndex = 14;
            label8.Text = "Địa chỉ:";
            label8.Click += label8_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(267, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 13;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(267, 128);
            label7.Name = "label7";
            label7.Size = new Size(67, 22);
            label7.TabIndex = 12;
            label7.Text = "Email:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(267, 36);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 9;
            label6.Text = "Giới tính:";
            label6.Click += label6_Click;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.LightSeaGreen;
            guna2CustomGradientPanel1.BorderRadius = 30;
            guna2CustomGradientPanel1.Controls.Add(label2);
            guna2CustomGradientPanel1.Controls.Add(rdoNu);
            guna2CustomGradientPanel1.Controls.Add(dtpNgaySinh);
            guna2CustomGradientPanel1.Controls.Add(txtUsername);
            guna2CustomGradientPanel1.Controls.Add(label3);
            guna2CustomGradientPanel1.Controls.Add(rdoNam);
            guna2CustomGradientPanel1.Controls.Add(txtPassword);
            guna2CustomGradientPanel1.Controls.Add(label9);
            guna2CustomGradientPanel1.Controls.Add(label4);
            guna2CustomGradientPanel1.Controls.Add(txtDiaChi);
            guna2CustomGradientPanel1.Controls.Add(txtHoTen);
            guna2CustomGradientPanel1.Controls.Add(label8);
            guna2CustomGradientPanel1.Controls.Add(label5);
            guna2CustomGradientPanel1.Controls.Add(txtEmail);
            guna2CustomGradientPanel1.Controls.Add(txtSDT);
            guna2CustomGradientPanel1.Controls.Add(label7);
            guna2CustomGradientPanel1.Controls.Add(label6);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.FillColor3 = Color.LightSeaGreen;
            guna2CustomGradientPanel1.FillColor4 = Color.DarkCyan;
            guna2CustomGradientPanel1.Location = new Point(12, 22);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(507, 393);
            guna2CustomGradientPanel1.TabIndex = 18;
            // 
            // NhanvienAdminAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 579);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanvienAdminAdd";
            Text = "NhanvienAdminAdd";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtHoTen;
        private Label label5;
        private TextBox txtSDT;
        private RadioButton rdoNam;
        private GroupBox groupBox1;
        private Label label6;
        private RadioButton rdoNu;
        private TextBox txtDiaChi;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private Label label9;
        private DateTimePicker dtpNgaySinh;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}