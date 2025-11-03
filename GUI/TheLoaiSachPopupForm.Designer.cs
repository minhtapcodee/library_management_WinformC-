using System.Drawing;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    partial class TheLoaiSachPopupForm
    {
        private System.ComponentModel.IContainer components = null;

        // Các thành phần giao diện
        private System.Windows.Forms.Label label1; // Nhãn "Mã thể loại"
        private System.Windows.Forms.Label label2; // Nhãn "Tên thể loại"
        private System.Windows.Forms.TextBox txtMaTL; // Ô nhập mã thể loại
        private System.Windows.Forms.TextBox txtTenTheLoai; // Ô nhập tên thể loại
        private System.Windows.Forms.Button btnLuu; // Nút "Lưu"
        private System.Windows.Forms.Button btnHuy; // Nút "Hủy"

        // Phương thức Dispose để giải phóng tài nguyên
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Phương thức khởi tạo giao diện
        private void InitializeComponent()
        {
            // Khởi tạo các thành phần
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Thiết kế nhãn "Mã thể loại"
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại:";

            // Thiết kế nhãn "Tên thể loại"
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thể loại:";

            // Thiết kế ô nhập "Mã thể loại"
            this.txtMaTL.Location = new System.Drawing.Point(100, 12);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(150, 22);
            this.txtMaTL.TabIndex = 2;

            // Thiết kế ô nhập "Tên thể loại"
            this.txtTenTheLoai.Location = new System.Drawing.Point(100, 42);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(150, 22);
            this.txtTenTheLoai.TabIndex = 3;

            // Thiết kế nút "Lưu"
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(52, 152, 219); // Màu xanh dương nhạt
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(100, 75);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 25);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // Thiết kế nút "Hủy"
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(149, 165, 166); // Màu xám nhạt
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(170, 75);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(60, 25);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // Thiết kế form chính
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250); // Màu nền nhạt
            this.ClientSize = new System.Drawing.Size(270, 120);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenTheLoai);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Không cho thay đổi kích thước
            this.MaximizeBox = false; // Ẩn nút phóng to
            this.MinimizeBox = false; // Ẩn nút thu nhỏ
            this.Name = "TheLoaiSachPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; // Căn giữa form cha
            this.Text = "Thêm Thể Loại"; // Tiêu đề mặc định
            this.Load += new System.EventHandler(this.TheLoaiSachPopupForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}