namespace QUANLYTHUVIENC3.GUI
{
    partial class frmSachDangMuon
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
            lblTongSachDangMuon = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvSachDangMuon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSachDangMuon).BeginInit();
            SuspendLayout();
            // 
            // lblTongSachDangMuon
            // 
            lblTongSachDangMuon.AutoSize = true;
            lblTongSachDangMuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongSachDangMuon.Location = new Point(10, 15);
            lblTongSachDangMuon.Name = "lblTongSachDangMuon";
            lblTongSachDangMuon.Size = new Size(209, 21);
            lblTongSachDangMuon.TabIndex = 0;
            lblTongSachDangMuon.Text = "Tổng số sách đang mượn: ";
            lblTongSachDangMuon.Click += lblTongSachDangMuon_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(407, 16);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(168, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(0, 120, 215);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(591, 16);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(88, 24);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            btnTimKiem.MouseEnter += btnTimKiem_MouseEnter;
            btnTimKiem.MouseLeave += btnTimKiem_MouseLeave;
            // 
            // dgvSachDangMuon
            // 
            dgvSachDangMuon.AllowUserToAddRows = false;
            dgvSachDangMuon.AllowUserToDeleteRows = false;
            dgvSachDangMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachDangMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachDangMuon.Location = new Point(10, 59);
            dgvSachDangMuon.Margin = new Padding(3, 2, 3, 2);
            dgvSachDangMuon.Name = "dgvSachDangMuon";
            dgvSachDangMuon.ReadOnly = true;
            dgvSachDangMuon.RowHeadersWidth = 51;
            dgvSachDangMuon.RowTemplate.Height = 24;
            dgvSachDangMuon.Size = new Size(679, 380);
            dgvSachDangMuon.TabIndex = 3;
            // 
            // frmSachDangMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(dgvSachDangMuon);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTongSachDangMuon);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSachDangMuon";
            Text = "Sách Đang Mượn";
            ((System.ComponentModel.ISupportInitialize)dgvSachDangMuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTongSachDangMuon;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvSachDangMuon;
    }
}