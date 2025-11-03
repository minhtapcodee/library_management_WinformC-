namespace QUANLYTHUVIENC3.GUI
{
    partial class frmNgayCongNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNgayCongNhanvien));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dtpNgayChamCong = new DateTimePicker();
            picHinhanh = new PictureBox();
            btnChoosePicture = new Button();
            panel4 = new Panel();
            btnRefresh = new Button();
            btnAdd = new Button();
            label10 = new Label();
            txtNgayxacnhan = new TextBox();
            label9 = new Label();
            txtTrangthai = new TextBox();
            label8 = new Label();
            txtGhichu = new TextBox();
            label7 = new Label();
            txtGiora = new TextBox();
            label6 = new Label();
            txtGiovao = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            lblPhantrang = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnNext = new Button();
            cboTrangthai = new ComboBox();
            btnPrev = new Button();
            label2 = new Label();
            chkLocTheoNgay = new CheckBox();
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
            panel1.Size = new Size(1079, 58);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 18);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 1;
            label1.Text = "Chấm công";
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
            groupBox1.Controls.Add(dtpNgayChamCong);
            groupBox1.Controls.Add(picHinhanh);
            groupBox1.Controls.Add(btnChoosePicture);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtNgayxacnhan);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTrangthai);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtGhichu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGiora);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtGiovao);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 598);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // dtpNgayChamCong
            // 
            dtpNgayChamCong.Location = new Point(141, 24);
            dtpNgayChamCong.Name = "dtpNgayChamCong";
            dtpNgayChamCong.Size = new Size(200, 23);
            dtpNgayChamCong.TabIndex = 17;
            // 
            // picHinhanh
            // 
            picHinhanh.BackColor = Color.White;
            picHinhanh.ErrorImage = (Image)resources.GetObject("picHinhanh.ErrorImage");
            picHinhanh.Location = new Point(141, 328);
            picHinhanh.Name = "picHinhanh";
            picHinhanh.Size = new Size(200, 158);
            picHinhanh.TabIndex = 16;
            picHinhanh.TabStop = false;
            picHinhanh.Click += picHinhanh_Click;
            // 
            // btnChoosePicture
            // 
            btnChoosePicture.Location = new Point(271, 492);
            btnChoosePicture.Name = "btnChoosePicture";
            btnChoosePicture.Size = new Size(75, 23);
            btnChoosePicture.TabIndex = 15;
            btnChoosePicture.Text = "Choose...";
            btnChoosePicture.UseVisualStyleBackColor = true;
            btnChoosePicture.Click += btnChoosePicture_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnRefresh);
            panel4.Controls.Add(btnAdd);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 535);
            panel4.Name = "panel4";
            panel4.Size = new Size(343, 60);
            panel4.TabIndex = 14;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Yellow;
            btnRefresh.FlatAppearance.BorderColor = Color.Red;
            btnRefresh.FlatAppearance.BorderSize = 3;
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.FlatAppearance.BorderColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Green;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(37, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 328);
            label10.Name = "label10";
            label10.Size = new Size(78, 18);
            label10.TabIndex = 12;
            label10.Text = "Hình ảnh:";
            // 
            // txtNgayxacnhan
            // 
            txtNgayxacnhan.Location = new Point(141, 278);
            txtNgayxacnhan.Name = "txtNgayxacnhan";
            txtNgayxacnhan.ReadOnly = true;
            txtNgayxacnhan.Size = new Size(200, 23);
            txtNgayxacnhan.TabIndex = 11;
            txtNgayxacnhan.TextChanged += txtNgayxacnhan_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 278);
            label9.Name = "label9";
            label9.Size = new Size(117, 18);
            label9.TabIndex = 10;
            label9.Text = "Ngày xác nhận:";
            // 
            // txtTrangthai
            // 
            txtTrangthai.Location = new Point(141, 238);
            txtTrangthai.Name = "txtTrangthai";
            txtTrangthai.ReadOnly = true;
            txtTrangthai.Size = new Size(200, 23);
            txtTrangthai.TabIndex = 9;
            txtTrangthai.TextChanged += txtTrangthai_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 238);
            label8.Name = "label8";
            label8.Size = new Size(85, 18);
            label8.TabIndex = 8;
            label8.Text = "Trạng thái:";
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(141, 157);
            txtGhichu.Multiline = true;
            txtGhichu.Name = "txtGhichu";
            txtGhichu.ScrollBars = ScrollBars.Vertical;
            txtGhichu.Size = new Size(200, 60);
            txtGhichu.TabIndex = 7;
            txtGhichu.TextChanged += txtGhichu_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 157);
            label7.Name = "label7";
            label7.Size = new Size(67, 18);
            label7.TabIndex = 6;
            label7.Text = "Ghi chú:";
            // 
            // txtGiora
            // 
            txtGiora.Location = new Point(141, 112);
            txtGiora.Name = "txtGiora";
            txtGiora.Size = new Size(200, 23);
            txtGiora.TabIndex = 5;
            txtGiora.TextChanged += txtGiora_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 112);
            label6.Name = "label6";
            label6.Size = new Size(57, 18);
            label6.TabIndex = 4;
            label6.Text = "Giờ ra:";
            // 
            // txtGiovao
            // 
            txtGiovao.Location = new Point(141, 69);
            txtGiovao.Name = "txtGiovao";
            txtGiovao.Size = new Size(200, 23);
            txtGiovao.TabIndex = 3;
            txtGiovao.TextChanged += txtGiovao_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 69);
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
            groupBox2.Location = new Point(349, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 598);
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
            dataGridView1.Size = new Size(724, 491);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(chkLocTheoNgay);
            panel2.Controls.Add(lblPhantrang);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(cboTrangthai);
            panel2.Controls.Add(btnPrev);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 510);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 85);
            panel2.TabIndex = 0;
            // 
            // lblPhantrang
            // 
            lblPhantrang.AutoSize = true;
            lblPhantrang.Location = new Point(591, 10);
            lblPhantrang.Name = "lblPhantrang";
            lblPhantrang.Size = new Size(56, 15);
            lblPhantrang.TabIndex = 2;
            lblPhantrang.Text = "Trang 1/1";
            lblPhantrang.Click += lblPhantrang_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(246, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Cyan;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Location = new Point(665, 6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // cboTrangthai
            // 
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Location = new Point(21, 39);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(149, 23);
            cboTrangthai.TabIndex = 2;
            cboTrangthai.SelectedIndexChanged += cboTrangthai_SelectedIndexChanged;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Cyan;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.Location = new Point(497, 6);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 16);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 0;
            label2.Text = "Lọc trạng thái:";
            // 
            // chkLocTheoNgay
            // 
            chkLocTheoNgay.AutoSize = true;
            chkLocTheoNgay.Location = new Point(246, 15);
            chkLocTheoNgay.Name = "chkLocTheoNgay";
            chkLocTheoNgay.Size = new Size(169, 19);
            chkLocTheoNgay.TabIndex = 5;
            chkLocTheoNgay.Text = "Lọc theo ngày Chấm công:";
            chkLocTheoNgay.UseVisualStyleBackColor = true;
            // 
            // frmNgayCongNhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 656);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNgayCongNhanvien";
            Text = "frmNgayCongNhanvien";
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
        private Button btnAdd;
        private Label label10;
        private TextBox txtNgayxacnhan;
        private Label label9;
        private TextBox txtTrangthai;
        private Label label8;
        private TextBox txtGhichu;
        private Label label7;
        private TextBox txtGiora;
        private Label label6;
        private TextBox txtGiovao;
        private Label label5;
        private Button btnChoosePicture;
        private PictureBox picHinhanh;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpNgayChamCong;
        private CheckBox chkLocTheoNgay;
    }
}