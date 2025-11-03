namespace QUANLYTHUVIENC3.GUI
{
    partial class frmCaiDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaiDat));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnLightTheme = new Button();
            btnDarkTheme = new Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            guna2CustomGradientPanel1.SuspendLayout();
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
            panel1.Size = new Size(1041, 70);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 18);
            label1.Name = "label1";
            label1.Size = new Size(136, 40);
            label1.TabIndex = 1;
            label1.Text = " Cài đặt";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1041, 493);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BorderColor = Color.FromArgb(128, 255, 255);
            guna2CustomGradientPanel1.BorderRadius = 100;
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel1);
            guna2CustomGradientPanel1.Controls.Add(btnLightTheme);
            guna2CustomGradientPanel1.Controls.Add(btnDarkTheme);
            guna2CustomGradientPanel1.CustomBorderColor = Color.FromArgb(128, 255, 255);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.FillColor2 = Color.SpringGreen;
            guna2CustomGradientPanel1.FillColor3 = Color.Gold;
            guna2CustomGradientPanel1.FillColor4 = Color.ForestGreen;
            guna2CustomGradientPanel1.Location = new Point(47, 76);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(481, 475);
            guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // btnLightTheme
            // 
            btnLightTheme.BackColor = Color.ForestGreen;
            btnLightTheme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLightTheme.ForeColor = Color.Black;
            btnLightTheme.Location = new Point(48, 168);
            btnLightTheme.Name = "btnLightTheme";
            btnLightTheme.Size = new Size(162, 50);
            btnLightTheme.TabIndex = 7;
            btnLightTheme.Text = "Light Mode";
            btnLightTheme.UseVisualStyleBackColor = false;
            btnLightTheme.Click += btnLightTheme_Click;
            // 
            // btnDarkTheme
            // 
            btnDarkTheme.BackColor = Color.FromArgb(23, 24, 29);
            btnDarkTheme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDarkTheme.ForeColor = Color.White;
            btnDarkTheme.Location = new Point(264, 168);
            btnDarkTheme.Name = "btnDarkTheme";
            btnDarkTheme.Size = new Size(165, 50);
            btnDarkTheme.TabIndex = 8;
            btnDarkTheme.Text = "Dark Mode";
            btnDarkTheme.UseVisualStyleBackColor = false;
            btnDarkTheme.Click += btnDarkTheme_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(48, 84);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(383, 43);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "Thay đổi giao diện chủ đề";
            // 
            // frmCaiDat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1041, 563);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCaiDat";
            Text = "frmCaiDat";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Button btnLightTheme;
        private Button btnDarkTheme;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}