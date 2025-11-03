namespace QUANLYTHUVIENC3.GUI
{
    partial class FrmNhanvienAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanvienAdmin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnPreviousPage = new Button();
            lblPageInfo = new Label();
            btnNextPage = new Button();
            dgvNhanvien = new DataGridView();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            btnRefresh = new Button();
            btnExcel = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            label5 = new Label();
            btxDelete = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            cboLocTheoGioiTinh = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            panel1.Size = new Size(1040, 58);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 37);
            label1.TabIndex = 1;
            label1.Text = "  Quản lý nhân viên";
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
            panel2.Controls.Add(btnPreviousPage);
            panel2.Controls.Add(lblPageInfo);
            panel2.Controls.Add(btnNextPage);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 534);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 51);
            panel2.TabIndex = 7;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Anchor = AnchorStyles.None;
            btnPreviousPage.BackColor = Color.LimeGreen;
            btnPreviousPage.FlatAppearance.BorderColor = Color.FromArgb(0, 100, 182);
            btnPreviousPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 182);
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPreviousPage.ForeColor = Color.White;
            btnPreviousPage.Location = new Point(549, 9);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(100, 30);
            btnPreviousPage.TabIndex = 11;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.None;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageInfo.ForeColor = Color.LimeGreen;
            lblPageInfo.Location = new Point(690, 15);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(73, 19);
            lblPageInfo.TabIndex = 12;
            lblPageInfo.Text = "Trang 1/1";
            lblPageInfo.Click += lblPageInfo_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.None;
            btnNextPage.BackColor = Color.LimeGreen;
            btnNextPage.FlatAppearance.BorderColor = Color.FromArgb(0, 100, 182);
            btnNextPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 182);
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNextPage.ForeColor = Color.White;
            btnNextPage.Location = new Point(792, 9);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(100, 30);
            btnNextPage.TabIndex = 13;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // dgvNhanvien
            // 
            dgvNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanvien.Dock = DockStyle.Bottom;
            dgvNhanvien.Location = new Point(0, 242);
            dgvNhanvien.Name = "dgvNhanvien";
            dgvNhanvien.Size = new Size(1040, 292);
            dgvNhanvien.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btxDelete);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1040, 184);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(332, 144);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 18;
            label8.Text = "Xuất Excel:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(347, 69);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 17;
            label7.Text = "Làm mới:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(40, 167, 79);
            btnRefresh.FlatAppearance.BorderSize = 3;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(442, 59);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 44);
            btnRefresh.TabIndex = 16;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(40, 167, 79);
            btnExcel.FlatAppearance.BorderSize = 3;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Image = (Image)resources.GetObject("btnExcel.Image");
            btnExcel.Location = new Point(442, 134);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(116, 44);
            btnExcel.TabIndex = 15;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 79);
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(132, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 44);
            btnAdd.TabIndex = 9;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(40, 167, 79);
            btnEdit.FlatAppearance.BorderSize = 3;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(132, 96);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 44);
            btnEdit.TabIndex = 10;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 171);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 14;
            label5.Text = "Xóa:";
            // 
            // btxDelete
            // 
            btxDelete.BackColor = Color.FromArgb(40, 167, 79);
            btxDelete.FlatAppearance.BorderSize = 3;
            btxDelete.FlatStyle = FlatStyle.Flat;
            btxDelete.Image = (Image)resources.GetObject("btxDelete.Image");
            btxDelete.Location = new Point(132, 161);
            btxDelete.Name = "btxDelete";
            btxDelete.Size = new Size(117, 44);
            btxDelete.TabIndex = 11;
            btxDelete.UseVisualStyleBackColor = false;
            btxDelete.Click += btxDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 45);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 12;
            label3.Text = "Thêm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 106);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 13;
            label4.Text = "Sửa:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 255);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(620, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 184);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboLocTheoGioiTinh);
            groupBox3.Controls.Add(label6);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(3, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 122);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // cboLocTheoGioiTinh
            // 
            cboLocTheoGioiTinh.FormattingEnabled = true;
            cboLocTheoGioiTinh.Location = new Point(21, 52);
            cboLocTheoGioiTinh.Name = "cboLocTheoGioiTinh";
            cboLocTheoGioiTinh.Size = new Size(222, 23);
            cboLocTheoGioiTinh.TabIndex = 8;
            cboLocTheoGioiTinh.SelectedIndexChanged += cboLocTheoGioiTinh_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 24);
            label6.Name = "label6";
            label6.Size = new Size(134, 21);
            label6.TabIndex = 7;
            label6.Text = "Lọc theo giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 35);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 2;
            label2.Text = "Nhập thông tin:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(40, 167, 69);
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(291, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(56, 35);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 66);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(222, 23);
            txtSearch.TabIndex = 0;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // FrmNhanvienAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 585);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvNhanvien);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNhanvienAdmin";
            Text = "FrmNhanvienAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView dgvNhanvien;
        private Button btnPreviousPage;
        private Label lblPageInfo;
        private Button btnNextPage;
        private GroupBox groupBox1;
        private Button btnRefresh;
        private Button btnExcel;
        private Button btnAdd;
        private Button btnEdit;
        private Label label5;
        private Button btxDelete;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cboLocTheoGioiTinh;
        private Label label6;
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label8;
        private Label label7;
    }
}