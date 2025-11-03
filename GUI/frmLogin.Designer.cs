namespace QUANLYTHUVIENC3.GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label3 = new Label();
            chkShowPassword = new CheckBox();
            pnAdmin = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 207);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 254);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 207);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(164, 23);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 254);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gray;
            btnLogin.FlatAppearance.BorderSize = 3;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Snap ITC", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(62, 349);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 38);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gray;
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.FlatAppearance.BorderSize = 3;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Snap ITC", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(199, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 119);
            label3.Name = "label3";
            label3.Size = new Size(267, 58);
            label3.TabIndex = 6;
            label3.Text = "Đăng Nhập";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Script MT Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.Black;
            chkShowPassword.Location = new Point(199, 294);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(101, 18);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // pnAdmin
            // 
            pnAdmin.BackColor = Color.Black;
            pnAdmin.Controls.Add(pictureBox3);
            pnAdmin.Controls.Add(label4);
            pnAdmin.Controls.Add(nightControlBox2);
            pnAdmin.Dock = DockStyle.Top;
            pnAdmin.Location = new Point(0, 0);
            pnAdmin.Name = "pnAdmin";
            pnAdmin.Size = new Size(860, 31);
            pnAdmin.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(55, 8);
            label4.Name = "label4";
            label4.Size = new Size(199, 17);
            label4.TabIndex = 3;
            label4.Text = "Chào mừng bạn đến với thư viện";
            // 
            // nightControlBox2
            // 
            nightControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox2.BackColor = Color.Transparent;
            nightControlBox2.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox2.CloseHoverForeColor = Color.White;
            nightControlBox2.DefaultLocation = true;
            nightControlBox2.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox2.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox2.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox2.EnableMaximizeButton = true;
            nightControlBox2.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox2.EnableMinimizeButton = true;
            nightControlBox2.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox2.Location = new Point(721, 0);
            nightControlBox2.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MaximizeHoverForeColor = Color.White;
            nightControlBox2.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MinimizeHoverForeColor = Color.White;
            nightControlBox2.Name = "nightControlBox2";
            nightControlBox2.Size = new Size(139, 31);
            nightControlBox2.TabIndex = 2;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.TargetForm = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(521, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 492);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 492);
            panel2.TabIndex = 10;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = pnAdmin;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 523);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            pnAdmin.ResumeLayout(false);
            pnAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label label3;
        private CheckBox chkShowPassword;
        private Panel pnAdmin;
        private PictureBox pictureBox3;
        private Label label4;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}