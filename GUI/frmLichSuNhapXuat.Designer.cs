using System;
namespace QUANLYTHUVIENC3.GUI
{
    partial class frmLichSuNhapXuat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvLichSu = new DataGridView();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnLoc = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnXuatExcel = new Button();
            btnLamMoi = new Button();
            lblTuNgay = new Label();
            lblDenNgay = new Label();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // dgvLichSu
            // 
            dgvLichSu.ColumnHeadersHeight = 29;
            dgvLichSu.Location = new Point(14, 14);
            dgvLichSu.Margin = new Padding(4);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.RowHeadersWidth = 51;
            dgvLichSu.Size = new Size(886, 346);
            dgvLichSu.TabIndex = 0;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(105, 369);
            dtpTuNgay.Margin = new Padding(4);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(175, 23);
            dtpTuNgay.TabIndex = 1;
            dtpTuNgay.Value = new DateTime(2025, 4, 9, 11, 10, 10, 28);
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(374, 369);
            dtpDenNgay.Margin = new Padding(4);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(175, 23);
            dtpDenNgay.TabIndex = 2;
            dtpDenNgay.Value = new DateTime(2025, 5, 9, 11, 10, 10, 30);
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(560, 369);
            btnLoc.Margin = new Padding(4);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(116, 46);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(105, 415);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(232, 23);
            txtTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(350, 415);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(116, 46);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(479, 415);
            btnXuatExcel.Margin = new Padding(4);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(116, 46);
            btnXuatExcel.TabIndex = 6;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(606, 415);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(116, 46);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTuNgay
            // 
            lblTuNgay.Location = new Point(14, 369);
            lblTuNgay.Margin = new Padding(4, 0, 4, 0);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(81, 29);
            lblTuNgay.TabIndex = 8;
            lblTuNgay.Text = "Từ Ngày:";
            lblTuNgay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDenNgay
            // 
            lblDenNgay.Location = new Point(291, 369);
            lblDenNgay.Margin = new Padding(4, 0, 4, 0);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(81, 29);
            lblDenNgay.TabIndex = 9;
            lblDenNgay.Text = "Đến Ngày:";
            lblDenNgay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.RoyalBlue;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(741, 415);
            btnXoa.Margin = new Padding(4, 0, 4, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 46);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa Lịch sử";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmLichSuNhapXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 489);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLoc);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(dgvLichSu);
            Controls.Add(lblTuNgay);
            Controls.Add(lblDenNgay);
            Margin = new Padding(4);
            Name = "frmLichSuNhapXuat";
            Text = "Lịch Sử Nhập/Xuất";
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private Button btnXoa;
    }
}