namespace QUANLYTHUVIENC3.GUI
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnPreviousPage = new Button();
            lblPageInfo = new Label();
            btnNextPage = new Button();
            dgvTaiKhoan = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            btxExit = new Button();
            txtTenTaiKhoan = new TextBox();
            cboPhanQuyen = new ComboBox();
            btnSave = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            cmbFilter = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.ForeColor = Color.Black;
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 1;
            label1.Text = "  Phân quyền tài khoản";
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
            panel2.BackColor = Color.FromArgb(235, 245, 235);
            panel2.Controls.Add(btnPreviousPage);
            panel2.Controls.Add(lblPageInfo);
            panel2.Controls.Add(btnNextPage);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 499);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 44);
            panel2.TabIndex = 5;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Anchor = AnchorStyles.None;
            btnPreviousPage.BackColor = Color.FromArgb(0, 158, 96);
            btnPreviousPage.FlatAppearance.BorderColor = Color.Black;
            btnPreviousPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 178, 116);
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPreviousPage.ForeColor = Color.White;
            btnPreviousPage.Location = new Point(378, 7);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(100, 30);
            btnPreviousPage.TabIndex = 8;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.None;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageInfo.ForeColor = Color.FromArgb(0, 100, 0);
            lblPageInfo.Location = new Point(519, 13);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(73, 19);
            lblPageInfo.TabIndex = 9;
            lblPageInfo.Text = "Trang 1/1";
            lblPageInfo.Click += lblPageInfo_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.None;
            btnNextPage.BackColor = Color.FromArgb(0, 158, 96);
            btnNextPage.FlatAppearance.BorderColor = Color.Black;
            btnNextPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 178, 116);
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNextPage.ForeColor = Color.White;
            btnNextPage.Location = new Point(621, 7);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(100, 30);
            btnNextPage.TabIndex = 10;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Bottom;
            dgvTaiKhoan.Location = new Point(0, 202);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.Size = new Size(800, 297);
            dgvTaiKhoan.TabIndex = 6;
            dgvTaiKhoan.CellContentClick += dgvTaiKhoan_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(235, 245, 235);
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btxExit);
            groupBox1.Controls.Add(txtTenTaiKhoan);
            groupBox1.Controls.Add(cboPhanQuyen);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(189, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 144);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 100, 0);
            label6.Location = new Point(175, 111);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 16;
            label6.Text = "Phân quyền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 100, 0);
            label5.Location = new Point(149, 56);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 15;
            label5.Text = "Tên người dùng:";
            // 
            // btxExit
            // 
            btxExit.BackColor = Color.FromArgb(0, 158, 96);
            btxExit.FlatAppearance.BorderColor = Color.Black;
            btxExit.FlatAppearance.BorderSize = 3;
            btxExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 178, 116);
            btxExit.FlatStyle = FlatStyle.Flat;
            btxExit.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btxExit.ForeColor = Color.White;
            btxExit.Location = new Point(444, 176);
            btxExit.Name = "btxExit";
            btxExit.Size = new Size(78, 44);
            btxExit.TabIndex = 11;
            btxExit.Text = "Hủy";
            btxExit.UseVisualStyleBackColor = false;
            btxExit.Click += btxExit_Click;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(276, 56);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(150, 23);
            txtTenTaiKhoan.TabIndex = 14;
            txtTenTaiKhoan.TextChanged += txtTenTaiKhoan_TextChanged;
            // 
            // cboPhanQuyen
            // 
            cboPhanQuyen.FormattingEnabled = true;
            cboPhanQuyen.Items.AddRange(new object[] { "ADMIN", "Nhân viên", "Độc giả" });
            cboPhanQuyen.Location = new Point(276, 109);
            cboPhanQuyen.Name = "cboPhanQuyen";
            cboPhanQuyen.Size = new Size(150, 23);
            cboPhanQuyen.TabIndex = 13;
            cboPhanQuyen.SelectedIndexChanged += cboPhanQuyen_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 158, 96);
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 178, 116);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(301, 176);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 44);
            btnSave.TabIndex = 10;
            btnSave.Text = " Lưu ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 100, 0);
            label3.Location = new Point(189, 19);
            label3.Name = "label3";
            label3.Size = new Size(309, 21);
            label3.TabIndex = 12;
            label3.Text = "Thay đổi quyền truy cập tài khoản";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(235, 245, 235);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(189, 130);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 100, 0);
            label2.Location = new Point(130, 31);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 2;
            label2.Text = "Tìm kiếm:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 158, 96);
            btnSearch.FlatAppearance.BorderColor = Color.Black;
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 178, 116);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(365, 66);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 35);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(213, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(235, 245, 235);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cmbFilter);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 14);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 100, 0);
            label4.Location = new Point(55, 46);
            label4.Name = "label4";
            label4.Size = new Size(204, 21);
            label4.TabIndex = 3;
            label4.Text = "Lọc theo quyền người dụng:";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Tất cả", "ADMIN", "Nhân viên", "Độc giả" });
            cmbFilter.Location = new Point(274, 44);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(145, 23);
            cmbFilter.TabIndex = 0;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // frmPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 240, 220);
            ClientSize = new Size(800, 543);
            Controls.Add(panel3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPhanQuyen";
            Text = "frmPhanQuyen";
            Load += frmPhanQuyen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView dgvTaiKhoan;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Button btxExit;
        private TextBox txtTenTaiKhoan;
        private ComboBox cboPhanQuyen;
        private Button btnSave;
        private Label label3;
        private GroupBox groupBox2;
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel3;
        private Label label4;
        private ComboBox cmbFilter;
        private Button btnPreviousPage;
        private Label lblPageInfo;
        private Button btnNextPage;
    }
}