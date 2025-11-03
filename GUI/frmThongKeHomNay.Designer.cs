namespace QUANLYTHUVIENC3.GUI
{
    partial class frmThongKeHomNay
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
            this.dgvSachMuonHomNay = new System.Windows.Forms.DataGridView();
            this.lblSoSachMuonHomNay = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.chkLocTheoNgay = new System.Windows.Forms.CheckBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuonHomNay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSachMuonHomNay
            // 
            this.dgvSachMuonHomNay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuonHomNay.Location = new System.Drawing.Point(12, 100);
            this.dgvSachMuonHomNay.Name = "dgvSachMuonHomNay";
            this.dgvSachMuonHomNay.RowTemplate.Height = 25;
            this.dgvSachMuonHomNay.Size = new System.Drawing.Size(860, 350);
            this.dgvSachMuonHomNay.TabIndex = 0;
            // 
            // lblSoSachMuonHomNay
            // 
            this.lblSoSachMuonHomNay.AutoSize = true;
            this.lblSoSachMuonHomNay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoSachMuonHomNay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblSoSachMuonHomNay.Location = new System.Drawing.Point(12, 70);
            this.lblSoSachMuonHomNay.Name = "lblSoSachMuonHomNay";
            this.lblSoSachMuonHomNay.Size = new System.Drawing.Size(200, 21);
            this.lblSoSachMuonHomNay.TabIndex = 1;
            this.lblSoSachMuonHomNay.Text = "Số sách mượn hôm nay: 0";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(80, 20);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 25);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(340, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 25);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(550, 20);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(120, 25);
            this.dtpNgay.TabIndex = 4;
            this.dtpNgay.Enabled = false;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // chkLocTheoNgay
            // 
            this.chkLocTheoNgay.AutoSize = true;
            this.chkLocTheoNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLocTheoNgay.Location = new System.Drawing.Point(450, 22);
            this.chkLocTheoNgay.Name = "chkLocTheoNgay";
            this.chkLocTheoNgay.Size = new System.Drawing.Size(100, 23);
            this.chkLocTheoNgay.TabIndex = 5;
            this.chkLocTheoNgay.Text = "Lọc theo ngày";
            this.chkLocTheoNgay.UseVisualStyleBackColor = true;
            this.chkLocTheoNgay.CheckedChanged += new System.EventHandler(this.chkLocTheoNgay_CheckedChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(12, 22);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(60, 19);
            this.lblTimKiem.TabIndex = 6;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // frmThongKeTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.chkLocTheoNgay);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblSoSachMuonHomNay);
            this.Controls.Add(this.dgvSachMuonHomNay);
            this.Name = "frmThongKeTongHop";
            this.Text = "Thống kê sách mượn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuonHomNay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSachMuonHomNay;
        private System.Windows.Forms.Label lblSoSachMuonHomNay;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.CheckBox chkLocTheoNgay;
        private System.Windows.Forms.Label lblTimKiem;
    }
}