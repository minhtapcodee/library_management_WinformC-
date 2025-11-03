namespace QUANLYTHUVIENC3.GUI
{
    partial class frmMuonTraUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTraUpdate));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnExit = new Button();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            txtStaffID = new TextBox();
            txtBorrowerID = new TextBox();
            txtBookID = new TextBox();
            lblBorrowerID = new Label();
            lblBookID = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            txtDueDate = new TextBox();
            txtBorrowDate = new TextBox();
            dtReturnDate = new DateTimePicker();
            txtPenaltyFee = new TextBox();
            lblPenaltyFee = new Label();
            lblDueDate = new Label();
            lblReturnDate = new Label();
            lblBorrowDate = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
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
            panel1.Size = new Size(944, 58);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(536, 37);
            label1.TabIndex = 1;
            label1.Text = "  Quản lý mượn - trả sách / Sửa phiếu sách";
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
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 477);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(944, 104);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(40, 167, 79);
            btnExit.FlatAppearance.BorderSize = 3;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(621, 30);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 44);
            btnExit.TabIndex = 6;
            btnExit.Text = "Hủy";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 79);
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(txtStaffID);
            groupBox1.Controls.Add(txtBorrowerID);
            groupBox1.Controls.Add(txtBookID);
            groupBox1.Controls.Add(lblBorrowerID);
            groupBox1.Controls.Add(lblBookID);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 419);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin về sách";
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(90, 279);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(218, 23);
            txtStaffID.TabIndex = 26;
            txtStaffID.TextChanged += txtStaffID_TextChanged;
            // 
            // txtBorrowerID
            // 
            txtBorrowerID.Location = new Point(90, 182);
            txtBorrowerID.Name = "txtBorrowerID";
            txtBorrowerID.ReadOnly = true;
            txtBorrowerID.Size = new Size(218, 23);
            txtBorrowerID.TabIndex = 25;
            txtBorrowerID.TextChanged += txtBorrowerID_TextChanged;
            // 
            // txtBookID
            // 
            txtBookID.BackColor = Color.White;
            txtBookID.Location = new Point(90, 86);
            txtBookID.Name = "txtBookID";
            txtBookID.ReadOnly = true;
            txtBookID.Size = new Size(218, 23);
            txtBookID.TabIndex = 24;
            txtBookID.TextChanged += txtBookID_TextChanged;
            // 
            // lblBorrowerID
            // 
            lblBorrowerID.AutoSize = true;
            lblBorrowerID.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBorrowerID.Location = new Point(84, 154);
            lblBorrowerID.Name = "lblBorrowerID";
            lblBorrowerID.Size = new Size(153, 25);
            lblBorrowerID.TabIndex = 7;
            lblBorrowerID.Text = "Tên người mượn:";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookID.Location = new Point(84, 58);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(88, 25);
            lblBookID.TabIndex = 0;
            lblBookID.Text = "Tên sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 251);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 8;
            label2.Text = "Tên nhân viên:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Violet;
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtDueDate);
            groupBox4.Controls.Add(txtBorrowDate);
            groupBox4.Controls.Add(dtReturnDate);
            groupBox4.Controls.Add(txtPenaltyFee);
            groupBox4.Controls.Add(lblPenaltyFee);
            groupBox4.Controls.Add(lblDueDate);
            groupBox4.Controls.Add(lblReturnDate);
            groupBox4.Controls.Add(lblBorrowDate);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(434, 58);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(510, 419);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin về giao dịch";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Đã trả", "Quá hạn (chưa trả)", "Quá hạn (đã trả)" });
            comboBox1.Location = new Point(82, 348);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 23);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 320);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 27;
            label3.Text = "Trạng thái giao dịch :";
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(80, 128);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.ReadOnly = true;
            txtDueDate.Size = new Size(218, 23);
            txtDueDate.TabIndex = 26;
            txtDueDate.TextChanged += txtDueDate_TextChanged;
            // 
            // txtBorrowDate
            // 
            txtBorrowDate.Location = new Point(80, 58);
            txtBorrowDate.Name = "txtBorrowDate";
            txtBorrowDate.ReadOnly = true;
            txtBorrowDate.Size = new Size(218, 23);
            txtBorrowDate.TabIndex = 25;
            txtBorrowDate.TextChanged += txtBorrowDate_TextChanged;
            // 
            // dtReturnDate
            // 
            dtReturnDate.Location = new Point(82, 201);
            dtReturnDate.Name = "dtReturnDate";
            dtReturnDate.Size = new Size(216, 23);
            dtReturnDate.TabIndex = 19;
            dtReturnDate.ValueChanged += dtReturnDate_ValueChanged;
            // 
            // txtPenaltyFee
            // 
            txtPenaltyFee.BackColor = Color.White;
            txtPenaltyFee.ForeColor = Color.Black;
            txtPenaltyFee.Location = new Point(82, 277);
            txtPenaltyFee.Name = "txtPenaltyFee";
            txtPenaltyFee.Size = new Size(216, 23);
            txtPenaltyFee.TabIndex = 17;
            txtPenaltyFee.TextChanged += txtPenaltyFee_TextChanged;
            // 
            // lblPenaltyFee
            // 
            lblPenaltyFee.AutoSize = true;
            lblPenaltyFee.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPenaltyFee.Location = new Point(89, 249);
            lblPenaltyFee.Name = "lblPenaltyFee";
            lblPenaltyFee.Size = new Size(141, 21);
            lblPenaltyFee.TabIndex = 16;
            lblPenaltyFee.Text = "Tiền phạt( Nếu có):";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDueDate.Location = new Point(89, 100);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(152, 25);
            lblDueDate.TabIndex = 11;
            lblDueDate.Text = "Ngày trả dự kiến:";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblReturnDate.Location = new Point(89, 173);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(148, 25);
            lblReturnDate.TabIndex = 10;
            lblReturnDate.Text = "Ngày trả thực tế:";
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBorrowDate.Location = new Point(83, 30);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(113, 25);
            lblBorrowDate.TabIndex = 9;
            lblBorrowDate.Text = "Ngày mượn:";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmMuonTraUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 581);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMuonTraUpdate";
            Text = "frmMuonTraUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnExit;
        private Button btnSave;
        private GroupBox groupBox1;
        private Label lblBorrowerID;
        private Label lblBookID;
        private Label label2;
        private GroupBox groupBox4;
        private DateTimePicker dtReturnDate;
        private TextBox txtPenaltyFee;
        private Label lblPenaltyFee;
        private Label lblDueDate;
        private Label lblReturnDate;
        private Label lblBorrowDate;
        private TextBox txtStaffID;
        private TextBox txtBorrowerID;
        private TextBox txtBookID;
        private TextBox txtBorrowDate;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox txtDueDate;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}