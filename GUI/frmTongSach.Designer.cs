namespace QUANLYTHUVIENC3.GUI
{
    partial class frmTongSach
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
            this.dgvTongSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTongSach
            // 
            this.dgvTongSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongSach.Location = new System.Drawing.Point(0, 60); // Để lại không gian cho panel lọc
            this.dgvTongSach.Name = "dgvTongSach";
            this.dgvTongSach.Size = new System.Drawing.Size(800, 390);
            this.dgvTongSach.TabIndex = 0;
            this.dgvTongSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTongSach_CellContentClick);
            // 
            // frmTongSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTongSach);
            this.Name = "frmTongSach";
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.frmTongSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongSach)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvTongSach;
    }
}