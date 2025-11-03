namespace QUANLYTHUVIENC3.GUI
{
    partial class frmKhoSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoSach));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnXuatExel = new Button();
            btnRefresh = new Button();
            btxDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDisplay = new Button();
            panel2 = new Panel();
            btnPreviousPage = new Button();
            lblPageInfo = new Label();
            btnNextPage = new Button();
            dgvKhoSach = new DataGridView();
            groupBox1 = new GroupBox();
            dtpLocNgayNhapKho = new DateTimePicker();
            chkLocTheoNgay = new CheckBox();
            cboLocTheoSach = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoSach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Size = new Size(1084, 58);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 1;
            label1.Text = "  Quản lý kho sách";
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
            // btnXuatExel
            // 
            btnXuatExel.BackColor = Color.FromArgb(50, 205, 50);
            btnXuatExel.FlatAppearance.BorderColor = Color.Black;
            btnXuatExel.FlatAppearance.BorderSize = 3;
            btnXuatExel.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btnXuatExel.FlatStyle = FlatStyle.Flat;
            btnXuatExel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExel.ForeColor = Color.White;
            btnXuatExel.Image = (Image)resources.GetObject("btnXuatExel.Image");
            btnXuatExel.Location = new Point(464, 252);
            btnXuatExel.Name = "btnXuatExel";
            btnXuatExel.Size = new Size(141, 42);
            btnXuatExel.TabIndex = 23;
            btnXuatExel.UseVisualStyleBackColor = false;
            btnXuatExel.Click += btnXuatExel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(50, 205, 50);
            btnRefresh.FlatAppearance.BorderColor = Color.Black;
            btnRefresh.FlatAppearance.BorderSize = 3;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(57, 252);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 44);
            btnRefresh.TabIndex = 14;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btxDelete
            // 
            btxDelete.BackColor = Color.FromArgb(50, 205, 50);
            btxDelete.FlatAppearance.BorderColor = Color.Black;
            btxDelete.FlatAppearance.BorderSize = 3;
            btxDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btxDelete.FlatStyle = FlatStyle.Flat;
            btxDelete.Image = (Image)resources.GetObject("btxDelete.Image");
            btxDelete.Location = new Point(464, 161);
            btxDelete.Name = "btxDelete";
            btxDelete.Size = new Size(141, 44);
            btxDelete.TabIndex = 13;
            btxDelete.UseVisualStyleBackColor = false;
            btxDelete.Click += btxDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(50, 205, 50);
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatAppearance.BorderSize = 3;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(258, 161);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 44);
            btnEdit.TabIndex = 12;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(50, 205, 50);
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(57, 161);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 44);
            btnAdd.TabIndex = 11;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(50, 205, 50);
            btnDisplay.FlatAppearance.BorderColor = Color.Black;
            btnDisplay.FlatAppearance.BorderSize = 3;
            btnDisplay.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btnDisplay.FlatStyle = FlatStyle.Flat;
            btnDisplay.Image = (Image)resources.GetObject("btnDisplay.Image");
            btnDisplay.Location = new Point(258, 252);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(136, 44);
            btnDisplay.TabIndex = 15;
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 245, 225);
            panel2.Controls.Add(btnPreviousPage);
            panel2.Controls.Add(lblPageInfo);
            panel2.Controls.Add(btnNextPage);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 535);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 60);
            panel2.TabIndex = 24;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = Color.FromArgb(50, 205, 50);
            btnPreviousPage.FlatAppearance.BorderSize = 0;
            btnPreviousPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPreviousPage.ForeColor = Color.White;
            btnPreviousPage.Location = new Point(722, 21);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(87, 28);
            btnPreviousPage.TabIndex = 20;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageInfo.ForeColor = Color.FromArgb(0, 128, 0);
            lblPageInfo.Location = new Point(854, 26);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(73, 19);
            lblPageInfo.TabIndex = 22;
            lblPageInfo.Text = "Trang 1/1";
            lblPageInfo.Click += lblPageInfo_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.FromArgb(50, 205, 50);
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNextPage.ForeColor = Color.White;
            btnNextPage.Location = new Point(941, 21);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(87, 28);
            btnNextPage.TabIndex = 21;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // dgvKhoSach
            // 
            dgvKhoSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoSach.Dock = DockStyle.Bottom;
            dgvKhoSach.Location = new Point(0, 227);
            dgvKhoSach.Name = "dgvKhoSach";
            dgvKhoSach.Size = new Size(1084, 308);
            dgvKhoSach.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(225, 245, 225);
            groupBox1.Controls.Add(dtpLocNgayNhapKho);
            groupBox1.Controls.Add(chkLocTheoNgay);
            groupBox1.Controls.Add(cboLocTheoSach);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(656, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 169);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // dtpLocNgayNhapKho
            // 
            dtpLocNgayNhapKho.CalendarForeColor = Color.Black;
            dtpLocNgayNhapKho.CalendarMonthBackground = Color.FromArgb(225, 245, 225);
            dtpLocNgayNhapKho.CalendarTitleBackColor = Color.FromArgb(50, 205, 50);
            dtpLocNgayNhapKho.Location = new Point(132, 153);
            dtpLocNgayNhapKho.Name = "dtpLocNgayNhapKho";
            dtpLocNgayNhapKho.Size = new Size(217, 23);
            dtpLocNgayNhapKho.TabIndex = 7;
            dtpLocNgayNhapKho.ValueChanged += dtpLocNgayNhapKho_ValueChanged;
            dtpLocNgayNhapKho.Enter += dtpLocNgayNhapKho_ValueChanged;
            // 
            // chkLocTheoNgay
            // 
            chkLocTheoNgay.AutoSize = true;
            chkLocTheoNgay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLocTheoNgay.ForeColor = Color.FromArgb(0, 128, 0);
            chkLocTheoNgay.Location = new Point(163, 118);
            chkLocTheoNgay.Name = "chkLocTheoNgay";
            chkLocTheoNgay.Size = new Size(149, 29);
            chkLocTheoNgay.TabIndex = 8;
            chkLocTheoNgay.Text = "Lọc theo ngày";
            chkLocTheoNgay.UseVisualStyleBackColor = true;
            // 
            // cboLocTheoSach
            // 
            cboLocTheoSach.FormattingEnabled = true;
            cboLocTheoSach.Location = new Point(130, 74);
            cboLocTheoSach.Name = "cboLocTheoSach";
            cboLocTheoSach.Size = new Size(217, 23);
            cboLocTheoSach.TabIndex = 6;
            cboLocTheoSach.SelectedIndexChanged += cboLocTheoSach_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 128, 0);
            label3.Location = new Point(172, 36);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 5;
            label3.Text = "Lọc theo sách";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(225, 245, 225);
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(656, 91);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 128, 0);
            label2.Location = new Point(39, 40);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 2;
            label2.Text = "Nhập thông tin:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(50, 205, 50);
            btnSearch.FlatAppearance.BorderColor = Color.Black;
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 225, 80);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(409, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 35);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(163, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(222, 23);
            txtSearch.TabIndex = 0;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // frmKhoSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 235);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 595);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvKhoSach);
            Controls.Add(panel2);
            Controls.Add(btnEdit);
            Controls.Add(btnDisplay);
            Controls.Add(btnXuatExel);
            Controls.Add(btnAdd);
            Controls.Add(btxDelete);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKhoSach";
            Text = "frmKhoSach";
            Load += frmKhoSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoSach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btxDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnRefresh;
        private Button btnDisplay;
        private Button btnXuatExel;
        private Panel panel2;
        private Button btnPreviousPage;
        private Label lblPageInfo;
        private Button btnNextPage;
        private DataGridView dgvKhoSach;
        private GroupBox groupBox1;
        private DateTimePicker dtpLocNgayNhapKho;
        private CheckBox chkLocTheoNgay;
        private ComboBox cboLocTheoSach;
        private Label label3;
        private GroupBox groupBox2;
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}