namespace QUANLYTHUVIENC3.GUI
{
    partial class frmMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTra));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnPreviousPage = new Button();
            lblPageInfo = new Label();
            btnNextPage = new Button();
            dgvBorrow = new DataGridView();
            panel2 = new Panel();
            btnRefresh = new Button();
            btnPrint = new Button();
            btnAdd = new Button();
            btxDelete = new Button();
            btnEdit = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            btnFilter = new Button();
            cmbFilterStatus = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1088, 58);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 37);
            label1.TabIndex = 1;
            label1.Text = "  Quản lý mượn - trả sách";
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
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(btnPreviousPage);
            panel3.Controls.Add(lblPageInfo);
            panel3.Controls.Add(btnNextPage);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 518);
            panel3.Name = "panel3";
            panel3.Size = new Size(1088, 62);
            panel3.TabIndex = 7;
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
            btnPreviousPage.Location = new Point(691, 20);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(100, 30);
            btnPreviousPage.TabIndex = 14;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.None;
            lblPageInfo.AutoSize = true;
            lblPageInfo.BackColor = SystemColors.ControlDark;
            lblPageInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = Color.White;
            lblPageInfo.Location = new Point(797, 23);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(99, 25);
            lblPageInfo.TabIndex = 15;
            lblPageInfo.Text = "Trang 1/1";
            lblPageInfo.Click += lblPageInfo_Click_1;
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
            btnNextPage.Location = new Point(902, 20);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(100, 30);
            btnNextPage.TabIndex = 16;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // dgvBorrow
            // 
            dgvBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrow.Dock = DockStyle.Bottom;
            dgvBorrow.Location = new Point(0, 247);
            dgvBorrow.Name = "dgvBorrow";
            dgvBorrow.Size = new Size(1088, 271);
            dgvBorrow.TabIndex = 8;
            dgvBorrow.CellContentClick += dgvBorrow_CellContentClick_1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btxDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 105);
            panel2.TabIndex = 9;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(40, 167, 79);
            btnRefresh.FlatAppearance.BorderSize = 3;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(72, 45);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 44);
            btnRefresh.TabIndex = 12;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(40, 167, 79);
            btnPrint.FlatAppearance.BorderSize = 3;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.Location = new Point(896, 45);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(85, 44);
            btnPrint.TabIndex = 11;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 79);
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(277, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 44);
            btnAdd.TabIndex = 8;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btxDelete
            // 
            btxDelete.BackColor = Color.FromArgb(40, 167, 79);
            btxDelete.FlatAppearance.BorderSize = 3;
            btxDelete.FlatStyle = FlatStyle.Flat;
            btxDelete.Image = (Image)resources.GetObject("btxDelete.Image");
            btxDelete.Location = new Point(691, 45);
            btxDelete.Name = "btxDelete";
            btxDelete.Size = new Size(78, 44);
            btxDelete.TabIndex = 10;
            btxDelete.UseVisualStyleBackColor = false;
            btxDelete.Click += btxDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(40, 167, 79);
            btnEdit.FlatAppearance.BorderSize = 3;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(482, 45);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 44);
            btnEdit.TabIndex = 9;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(649, 84);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 34);
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
            btnSearch.Location = new Point(527, 93);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 35);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(282, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(222, 23);
            txtSearch.TabIndex = 0;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Controls.Add(cmbFilterStatus);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(649, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 84);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc theo trạng thái";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(40, 167, 69);
            btnFilter.FlatAppearance.BorderSize = 2;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Image = (Image)resources.GetObject("btnFilter.Image");
            btnFilter.Location = new Point(166, 74);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(69, 35);
            btnFilter.TabIndex = 2;
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Đã trả", "Quá hạn (chưa trả)", "Quá hạn (đã trả)" });
            cmbFilterStatus.Location = new Point(98, 34);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(200, 23);
            cmbFilterStatus.TabIndex = 0;
            cmbFilterStatus.Click += cmbFilterStatus_SelectedIndexChanged;
            // 
            // frmMuonTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 580);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(dgvBorrow);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMuonTra";
            Text = "frmMuonTra";
            Load += frmMuonTra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private DataGridView dgvBorrow;
        private Panel panel2;
        private Button btnPrint;
        private Button btnAdd;
        private Button btxDelete;
        private Button btnEdit;
        private GroupBox groupBox2;
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private Button btnFilter;
        private ComboBox cmbFilterStatus;
        private Button btnPreviousPage;
        private Label lblPageInfo;
        private Button btnNextPage;
        private Button btnRefresh;
    }
}