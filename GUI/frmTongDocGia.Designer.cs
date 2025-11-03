namespace QUANLYTHUVIENC3.GUI
{
    partial class frmTongDocGia
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvDocGia = new DataGridView();
            panelLoc = new FlowLayoutPanel();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnLoc = new Button();
            btnXoaLoc = new Button();
            panelChucNang = new FlowLayoutPanel();
            btnXuatExcel = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            panelLoc.SuspendLayout();
            panelChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.BackgroundColor = Color.White;
            dgvDocGia.BorderStyle = BorderStyle.None;
            dgvDocGia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocGia.Dock = DockStyle.Fill;
            dgvDocGia.EnableHeadersVisualStyles = false;
            dgvDocGia.Location = new Point(0, 116);
            dgvDocGia.Margin = new Padding(4, 3, 4, 3);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.Size = new Size(1283, 403);
            dgvDocGia.TabIndex = 0;
            dgvDocGia.CellContentClick += dgvDocGia_CellContentClick;
            // 
            // panelLoc
            // 
            panelLoc.BackColor = Color.FromArgb(230, 230, 230);
            panelLoc.Controls.Add(lblGioiTinh);
            panelLoc.Controls.Add(cboGioiTinh);
            panelLoc.Controls.Add(lblTrangThai);
            panelLoc.Controls.Add(cboTrangThai);
            panelLoc.Controls.Add(btnLoc);
            panelLoc.Controls.Add(btnXoaLoc);
            panelLoc.Controls.Add(btnXuatExcel);
            panelLoc.Dock = DockStyle.Top;
            panelLoc.Location = new Point(0, 0);
            panelLoc.Margin = new Padding(4, 3, 4, 3);
            panelLoc.Name = "panelLoc";
            panelLoc.Padding = new Padding(12, 12, 12, 12);
            panelLoc.Size = new Size(1283, 58);
            panelLoc.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 10F);
            lblGioiTinh.Location = new Point(24, 29);
            lblGioiTinh.Margin = new Padding(12, 17, 6, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(64, 19);
            lblGioiTinh.TabIndex = 0;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 10F);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(94, 24);
            cboGioiTinh.Margin = new Padding(0, 12, 12, 0);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(116, 25);
            cboGioiTinh.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10F);
            lblTrangThai.Location = new Point(234, 29);
            lblTrangThai.Margin = new Padding(12, 17, 6, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(73, 19);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 10F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(313, 24);
            cboTrangThai.Margin = new Padding(0, 12, 12, 0);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(174, 25);
            cboTrangThai.TabIndex = 3;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(0, 120, 215);
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Segoe UI", 10F);
            btnLoc.ForeColor = Color.White;
            btnLoc.Location = new Point(511, 24);
            btnLoc.Margin = new Padding(12, 12, 12, 0);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(93, 35);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnXoaLoc
            // 
            btnXoaLoc.BackColor = Color.FromArgb(220, 53, 69);
            btnXoaLoc.FlatStyle = FlatStyle.Flat;
            btnXoaLoc.Font = new Font("Segoe UI", 10F);
            btnXoaLoc.ForeColor = Color.White;
            btnXoaLoc.Location = new Point(628, 24);
            btnXoaLoc.Margin = new Padding(12, 12, 12, 0);
            btnXoaLoc.Name = "btnXoaLoc";
            btnXoaLoc.Size = new Size(117, 35);
            btnXoaLoc.TabIndex = 5;
            btnXoaLoc.Text = "Xóa bộ lọc";
            btnXoaLoc.UseVisualStyleBackColor = false;
            btnXoaLoc.Click += btnXoaLoc_Click;
            // 
            // panelChucNang
            // 
            panelChucNang.BackColor = Color.FromArgb(230, 230, 230);
            panelChucNang.Controls.Add(btnThoat);
            panelChucNang.Dock = DockStyle.Top;
            panelChucNang.Location = new Point(0, 58);
            panelChucNang.Margin = new Padding(4, 3, 4, 3);
            panelChucNang.Name = "panelChucNang";
            panelChucNang.Padding = new Padding(12, 12, 12, 12);
            panelChucNang.Size = new Size(1283, 58);
            panelChucNang.TabIndex = 2;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(40, 167, 69);
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 10F);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(769, 24);
            btnXuatExcel.Margin = new Padding(12, 12, 12, 0);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(117, 35);
            btnXuatExcel.TabIndex = 0;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(24, 24);
            btnThoat.Margin = new Padding(12, 12, 12, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(93, 35);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmTongDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1283, 519);
            Controls.Add(dgvDocGia);
            Controls.Add(panelChucNang);
            Controls.Add(panelLoc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmTongDocGia";
            Text = "Quản Lý Độc Giả";
            Load += frmTongDocGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            panelLoc.ResumeLayout(false);
            panelLoc.PerformLayout();
            panelChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.FlowLayoutPanel panelLoc;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXoaLoc;
        private System.Windows.Forms.FlowLayoutPanel panelChucNang;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThoat;
    }
}