namespace QUANLYTHUVIENC3.GUI
{
    partial class frmMuonTraAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTraAdd));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            cboBorrowerID = new ComboBox();
            cboStaffID = new ComboBox();
            cboBookID = new ComboBox();
            dtDueDate = new DateTimePicker();
            dtBorrowDate = new DateTimePicker();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            guna2CustomGradientPanel2.SuspendLayout();
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
            panel1.Size = new Size(883, 58);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(533, 37);
            label1.TabIndex = 1;
            label1.Text = "  Quản lý mượn - trả sách / Lập phiếu sách";
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
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Controls.Add(btnCancel);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(883, 105);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(40, 167, 79);
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
            // cboBorrowerID
            // 
            cboBorrowerID.FormattingEnabled = true;
            cboBorrowerID.Location = new Point(42, 306);
            cboBorrowerID.Name = "cboBorrowerID";
            cboBorrowerID.Size = new Size(218, 23);
            cboBorrowerID.TabIndex = 8;
            cboBorrowerID.SelectedIndexChanged += cboBorrowerID_SelectedIndexChanged;
            // 
            // cboStaffID
            // 
            cboStaffID.FormattingEnabled = true;
            cboStaffID.Location = new Point(42, 99);
            cboStaffID.Name = "cboStaffID";
            cboStaffID.Size = new Size(218, 23);
            cboStaffID.TabIndex = 23;
            cboStaffID.SelectedIndexChanged += cboStaffID_SelectedIndexChanged;
            // 
            // cboBookID
            // 
            cboBookID.FormattingEnabled = true;
            cboBookID.Location = new Point(42, 204);
            cboBookID.Name = "cboBookID";
            cboBookID.Size = new Size(218, 23);
            cboBookID.TabIndex = 4;
            cboBookID.SelectedIndexChanged += cboBookID_SelectedIndexChanged;
            // 
            // dtDueDate
            // 
            dtDueDate.Location = new Point(69, 249);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(218, 23);
            dtDueDate.TabIndex = 18;
            dtDueDate.ValueChanged += dtDueDate_ValueChanged;
            // 
            // dtBorrowDate
            // 
            dtBorrowDate.Location = new Point(69, 153);
            dtBorrowDate.Name = "dtBorrowDate";
            dtBorrowDate.Size = new Size(218, 23);
            dtBorrowDate.TabIndex = 8;
            dtBorrowDate.ValueChanged += dtBorrowDate_ValueChanged;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(dtDueDate);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel3);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel4);
            guna2CustomGradientPanel1.Controls.Add(dtBorrowDate);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges7;
            guna2CustomGradientPanel1.Dock = DockStyle.Right;
            guna2CustomGradientPanel1.FillColor = Color.Yellow;
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(0, 192, 192);
            guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(128, 255, 128);
            guna2CustomGradientPanel1.Location = new Point(427, 58);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2CustomGradientPanel1.Size = new Size(456, 420);
            guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.Controls.Add(guna2HtmlLabel5);
            guna2CustomGradientPanel2.Controls.Add(guna2HtmlLabel2);
            guna2CustomGradientPanel2.Controls.Add(guna2HtmlLabel1);
            guna2CustomGradientPanel2.Controls.Add(cboBorrowerID);
            guna2CustomGradientPanel2.Controls.Add(cboStaffID);
            guna2CustomGradientPanel2.Controls.Add(cboBookID);
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges5;
            guna2CustomGradientPanel2.Dock = DockStyle.Fill;
            guna2CustomGradientPanel2.FillColor = Color.FromArgb(255, 128, 128);
            guna2CustomGradientPanel2.FillColor2 = Color.FromArgb(255, 128, 0);
            guna2CustomGradientPanel2.FillColor3 = Color.FromArgb(192, 255, 255);
            guna2CustomGradientPanel2.Location = new Point(0, 58);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CustomGradientPanel2.Size = new Size(427, 420);
            guna2CustomGradientPanel2.TabIndex = 8;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(42, 68);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(131, 25);
            guna2HtmlLabel1.TabIndex = 24;
            guna2HtmlLabel1.Text = "Tên nhân viên:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(42, 173);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(86, 25);
            guna2HtmlLabel2.TabIndex = 25;
            guna2HtmlLabel2.Text = "Tên sách:";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(69, 218);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(153, 25);
            guna2HtmlLabel3.TabIndex = 26;
            guna2HtmlLabel3.Text = "Ngày trả dự kiến:";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.Location = new Point(69, 122);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(108, 25);
            guna2HtmlLabel4.TabIndex = 27;
            guna2HtmlLabel4.Text = "Ngày mượn:";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.Location = new Point(42, 275);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(150, 25);
            guna2HtmlLabel5.TabIndex = 28;
            guna2HtmlLabel5.Text = "Tên người mượn:";
            // 
            // frmMuonTraAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(883, 583);
            Controls.Add(guna2CustomGradientPanel2);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "frmMuonTraAdd";
            Text = "frmMuonTraAdd";
            Load += frmMuonTraAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            guna2CustomGradientPanel2.ResumeLayout(false);
            guna2CustomGradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cboBookID;
        private ComboBox cboStaffID;
        private DateTimePicker dtDueDate;
        private DateTimePicker dtBorrowDate;
        private ComboBox cboBorrowerID;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}