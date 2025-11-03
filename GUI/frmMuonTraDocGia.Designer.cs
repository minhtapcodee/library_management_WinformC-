namespace QUANLYTHUVIENC3.GUI
{
    partial class frmMuonTraDocGia
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewMuonTra;
        private System.Windows.Forms.Panel panelTitle;

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
            panelTitle = new Panel();
            lblTitle = new Label();
            dataGridViewMuonTra = new DataGridView();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuonTra).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(245, 245, 245);
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(2, 1, 2, 1);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(431, 38);
            panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(25, 25, 112);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(431, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh Sách Mượn Trả";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += new EventHandler(lblTitle_Click);
            // 
            // dataGridViewMuonTra
            // 
            dataGridViewMuonTra.BackgroundColor = Color.FromArgb(230, 230, 230);
            dataGridViewMuonTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMuonTra.Dock = DockStyle.Fill;
            dataGridViewMuonTra.Margin = new Padding(2, 10, 2, 1);
            dataGridViewMuonTra.MultiSelect = false;
            dataGridViewMuonTra.Name = "dataGridViewMuonTra";
            dataGridViewMuonTra.ReadOnly = true;
            dataGridViewMuonTra.RowHeadersWidth = 82;
            dataGridViewMuonTra.RowHeadersVisible = false;
            dataGridViewMuonTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMuonTra.TabIndex = 1;
            // 
            // frmMuonTraDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            Controls.Add(dataGridViewMuonTra);
            Controls.Add(panelTitle);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmMuonTraDocGia";
            Text = "Mượn Trả Độc Giả";
            Load += new EventHandler(frmMuonTraDocGia_Load);
            panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuonTra).EndInit();
            ResumeLayout(false);
        }
    }
}