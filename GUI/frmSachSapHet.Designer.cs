namespace QUANLYTHUVIENC3.GUI
{
    partial class frmSachSapHet
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
            this.dgvSachSapHet = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachSapHet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSachSapHet
            // 
            this.dgvSachSapHet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachSapHet.Location = new System.Drawing.Point(12, 12);
            this.dgvSachSapHet.Name = "dgvSachSapHet";
            this.dgvSachSapHet.ReadOnly = true;
            this.dgvSachSapHet.Size = new System.Drawing.Size(776, 400);
            this.dgvSachSapHet.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 420);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Có 0 sách tồn kho thấp.";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(713, 415);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 30);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmSachSapHet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvSachSapHet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSachSapHet";
            this.Text = "Thống Kê Sách Tồn Kho Thấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachSapHet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSachSapHet;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDong;
    }
}