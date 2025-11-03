namespace QUANLYTHUVIENC3.GUI
{
    partial class frmNgayCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNgayCong));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            cboTrangthaifield = new ComboBox();
            dtpNgayxacnhan = new DateTimePicker();
            txtGhichu = new TextBox();
            picHinhanh = new PictureBox();
            dtpNgayChamCong = new DateTimePicker();
            panel4 = new Panel();
            btnRefresh = new Button();
            btnUpdate = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtGiora = new TextBox();
            label6 = new Label();
            txtGiovao = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            chkLocTheoNgay = new CheckBox();
            lblPhantrang = new Label();
            dtpLocNgayChamCong = new DateTimePicker();
            btnNext = new Button();
            btnPrev = new Button();
            cboTrangthai = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhanh).BeginInit();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1189, 58);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 1;
            label1.Text = "Quản lý Chấm công";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTrangthaifield);
            groupBox1.Controls.Add(dtpNgayxacnhan);
            groupBox1.Controls.Add(txtGhichu);
            groupBox1.Controls.Add(picHinhanh);
            groupBox1.Controls.Add(dtpNgayChamCong);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGiora);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtGiovao);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 598);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // cboTrangthaifield
            // 
            cboTrangthaifield.FormattingEnabled = true;
            cboTrangthaifield.Items.AddRange(new object[] { "Chờ xác nhận", "Đã xác nhận", "Từ chối" });
            cboTrangthaifield.Location = new Point(139, 235);
            cboTrangthaifield.Name = "cboTrangthaifield";
            cboTrangthaifield.Size = new Size(200, 23);
            cboTrangthaifield.TabIndex = 22;
            cboTrangthaifield.SelectedIndexChanged += cboTrangthaifield_SelectedIndexChanged;
            // 
            // dtpNgayxacnhan
            // 
            dtpNgayxacnhan.Location = new Point(139, 281);
            dtpNgayxacnhan.Name = "dtpNgayxacnhan";
            dtpNgayxacnhan.Size = new Size(200, 23);
            dtpNgayxacnhan.TabIndex = 21;
            dtpNgayxacnhan.ValueChanged += dtpNgayxacnhan_ValueChanged;
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(139, 153);
            txtGhichu.Multiline = true;
            txtGhichu.Name = "txtGhichu";
            txtGhichu.ScrollBars = ScrollBars.Vertical;
            txtGhichu.Size = new Size(200, 60);
            txtGhichu.TabIndex = 20;
            // 
            // picHinhanh
            // 
            picHinhanh.BackColor = Color.White;
            picHinhanh.ErrorImage = (Image)resources.GetObject("picHinhanh.ErrorImage");
            picHinhanh.Location = new Point(138, 327);
            picHinhanh.Name = "picHinhanh";
            picHinhanh.Size = new Size(200, 158);
            picHinhanh.TabIndex = 19;
            picHinhanh.TabStop = false;
            // 
            // dtpNgayChamCong
            // 
            dtpNgayChamCong.Enabled = false;
            dtpNgayChamCong.Location = new Point(139, 24);
            dtpNgayChamCong.Name = "dtpNgayChamCong";
            dtpNgayChamCong.Size = new Size(200, 23);
            dtpNgayChamCong.TabIndex = 18;
            dtpNgayChamCong.ValueChanged += dtpNgayChamCong_ValueChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnRefresh);
            panel4.Controls.Add(btnUpdate);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 535);
            panel4.Name = "panel4";
            panel4.Size = new Size(338, 60);
            panel4.TabIndex = 14;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Yellow;
            btnRefresh.FlatAppearance.BorderColor = Color.Red;
            btnRefresh.FlatAppearance.BorderSize = 2;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.Red;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(180, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.FlatAppearance.BorderColor = Color.Green;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Green;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Green;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(37, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 327);
            label10.Name = "label10";
            label10.Size = new Size(78, 18);
            label10.TabIndex = 12;
            label10.Text = "Hình ảnh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 281);
            label9.Name = "label9";
            label9.Size = new Size(117, 18);
            label9.TabIndex = 10;
            label9.Text = "Ngày xác nhận:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 235);
            label8.Name = "label8";
            label8.Size = new Size(85, 18);
            label8.TabIndex = 8;
            label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 153);
            label7.Name = "label7";
            label7.Size = new Size(67, 18);
            label7.TabIndex = 6;
            label7.Text = "Ghi chú:";
            // 
            // txtGiora
            // 
            txtGiora.Location = new Point(139, 108);
            txtGiora.Name = "txtGiora";
            txtGiora.Size = new Size(200, 23);
            txtGiora.TabIndex = 5;
            txtGiora.TextChanged += txtGiora_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 108);
            label6.Name = "label6";
            label6.Size = new Size(57, 18);
            label6.TabIndex = 4;
            label6.Text = "Giờ ra:";
            // 
            // txtGiovao
            // 
            txtGiovao.Location = new Point(139, 65);
            txtGiovao.Name = "txtGiovao";
            txtGiovao.Size = new Size(200, 23);
            txtGiovao.TabIndex = 3;
            txtGiovao.TextChanged += txtGiovao_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 65);
            label5.Name = "label5";
            label5.Size = new Size(66, 18);
            label5.TabIndex = 2;
            label5.Text = "Giờ vào:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(129, 18);
            label4.TabIndex = 0;
            label4.Text = "Ngày chấm công:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(344, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(845, 598);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chấm công của bạn ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(839, 495);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(chkLocTheoNgay);
            panel2.Controls.Add(lblPhantrang);
            panel2.Controls.Add(dtpLocNgayChamCong);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnPrev);
            panel2.Controls.Add(cboTrangthai);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 514);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 81);
            panel2.TabIndex = 0;
            // 
            // chkLocTheoNgay
            // 
            chkLocTheoNgay.AutoSize = true;
            chkLocTheoNgay.Location = new Point(232, 15);
            chkLocTheoNgay.Name = "chkLocTheoNgay";
            chkLocTheoNgay.Size = new Size(169, 19);
            chkLocTheoNgay.TabIndex = 4;
            chkLocTheoNgay.Text = "Lọc theo ngày Chấm công:";
            chkLocTheoNgay.UseVisualStyleBackColor = true;
            chkLocTheoNgay.CheckedChanged += chkLocTheoNgay_CheckedChanged;
            // 
            // lblPhantrang
            // 
            lblPhantrang.AutoSize = true;
            lblPhantrang.Location = new Point(607, 12);
            lblPhantrang.Name = "lblPhantrang";
            lblPhantrang.Size = new Size(56, 15);
            lblPhantrang.TabIndex = 2;
            lblPhantrang.Text = "Trang 1/1";
            lblPhantrang.Click += lblPhantrang_Click;
            // 
            // dtpLocNgayChamCong
            // 
            dtpLocNgayChamCong.CalendarForeColor = Color.Black;
            dtpLocNgayChamCong.CalendarMonthBackground = SystemColors.MenuHighlight;
            dtpLocNgayChamCong.CalendarTitleBackColor = Color.Yellow;
            dtpLocNgayChamCong.Location = new Point(232, 43);
            dtpLocNgayChamCong.Name = "dtpLocNgayChamCong";
            dtpLocNgayChamCong.Size = new Size(200, 23);
            dtpLocNgayChamCong.TabIndex = 3;
            dtpLocNgayChamCong.ValueChanged += dtpLocNgayChamCong_ValueChanged;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(255, 128, 0);
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Location = new Point(681, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.FromArgb(255, 128, 0);
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.Location = new Point(513, 8);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // cboTrangthai
            // 
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Location = new Point(8, 43);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(149, 23);
            cboTrangthai.TabIndex = 2;
            cboTrangthai.SelectedIndexChanged += cboTrangthai_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 16);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 0;
            label2.Text = "Lọc trạng thái:";
            // 
            // frmNgayCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 656);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNgayCong";
            Text = "frmNgayCong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhanh).EndInit();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel2;
        private ComboBox cboTrangthai;
        private Label label2;
        private Label label4;
        private DataGridView dataGridView1;
        private Label lblPhantrang;
        private Button btnNext;
        private Button btnPrev;
        private Panel panel4;
        private Button btnRefresh;
        private Button btnUpdate;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtGiora;
        private Label label6;
        private TextBox txtGiovao;
        private Label label5;
        private DateTimePicker dtpLocNgayChamCong;
        private DateTimePicker dtpNgayChamCong;
        private PictureBox picHinhanh;
        private TextBox txtGhichu;
        private DateTimePicker dtpNgayxacnhan;
        private ComboBox cboTrangthaifield;
        private CheckBox chkLocTheoNgay;
    }
}