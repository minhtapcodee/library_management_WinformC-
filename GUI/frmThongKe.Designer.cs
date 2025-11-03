using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QUANLYTHUVIENC3.GUI
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayoutPanel;
        private PictureBox picSach;
        private PictureBox picDocGia;
        private PictureBox picTheLoai;
        private Label lblTongSach;
        private Label lblTongDocGia;
        private Label lblTongTheLoai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            tableLayoutPanel = new TableLayoutPanel();
            picSach = new PictureBox();
            picDocGia = new PictureBox();
            picTheLoai = new PictureBox();
            lblTongSach = new Label();
            lblTongDocGia = new Label();
            lblTongTheLoai = new Label();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDocGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTheLoai).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel.Controls.Add(picSach, 0, 0);
            tableLayoutPanel.Controls.Add(picDocGia, 1, 0);
            tableLayoutPanel.Controls.Add(picTheLoai, 2, 0);
            tableLayoutPanel.Controls.Add(lblTongSach, 0, 1);
            tableLayoutPanel.Controls.Add(lblTongDocGia, 1, 1);
            tableLayoutPanel.Controls.Add(lblTongTheLoai, 2, 1);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.Size = new Size(784, 161);
            tableLayoutPanel.TabIndex = 0;
            // 
            // picSach
            // 
            picSach.Dock = DockStyle.Fill;
            picSach.Image = (Image)resources.GetObject("picSach.Image");
            picSach.Location = new Point(3, 3);
            picSach.Name = "picSach";
            picSach.Size = new Size(252, 74);
            picSach.SizeMode = PictureBoxSizeMode.Zoom;
            picSach.TabIndex = 0;
            picSach.TabStop = false;
            picSach.Click += picSach_Click_1;
            // 
            // picDocGia
            // 
            picDocGia.Dock = DockStyle.Fill;
            picDocGia.Image = (Image)resources.GetObject("picDocGia.Image");
            picDocGia.Location = new Point(261, 3);
            picDocGia.Name = "picDocGia";
            picDocGia.Size = new Size(260, 74);
            picDocGia.SizeMode = PictureBoxSizeMode.Zoom;
            picDocGia.TabIndex = 1;
            picDocGia.TabStop = false;
            picDocGia.Click += picDocGia_Click_1;
            // 
            // picTheLoai
            // 
            picTheLoai.Dock = DockStyle.Fill;
            picTheLoai.Image = (Image)resources.GetObject("picTheLoai.Image");
            picTheLoai.Location = new Point(527, 3);
            picTheLoai.Name = "picTheLoai";
            picTheLoai.Size = new Size(254, 74);
            picTheLoai.SizeMode = PictureBoxSizeMode.Zoom;
            picTheLoai.TabIndex = 2;
            picTheLoai.TabStop = false;
            picTheLoai.Click += picTheLoai_Click_1;
            // 
            // lblTongSach
            // 
            lblTongSach.Dock = DockStyle.Fill;
            lblTongSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongSach.ForeColor = Color.Navy;
            lblTongSach.Location = new Point(3, 80);
            lblTongSach.Name = "lblTongSach";
            lblTongSach.Size = new Size(252, 81);
            lblTongSach.TabIndex = 3;
            lblTongSach.Text = "Tổng sách: 0";
            lblTongSach.TextAlign = ContentAlignment.MiddleCenter;
            lblTongSach.Click += lblTongSach_Click_1;
            // 
            // lblTongDocGia
            // 
            lblTongDocGia.Dock = DockStyle.Fill;
            lblTongDocGia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongDocGia.ForeColor = Color.DarkGreen;
            lblTongDocGia.Location = new Point(261, 80);
            lblTongDocGia.Name = "lblTongDocGia";
            lblTongDocGia.Size = new Size(260, 81);
            lblTongDocGia.TabIndex = 4;
            lblTongDocGia.Text = "Tổng độc giả: 0";
            lblTongDocGia.TextAlign = ContentAlignment.MiddleCenter;
            lblTongDocGia.Click += lblTongDocGia_Click_1;
            // 
            // lblTongTheLoai
            // 
            lblTongTheLoai.Dock = DockStyle.Fill;
            lblTongTheLoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTheLoai.ForeColor = Color.DarkRed;
            lblTongTheLoai.Location = new Point(527, 80);
            lblTongTheLoai.Name = "lblTongTheLoai";
            lblTongTheLoai.Size = new Size(254, 81);
            lblTongTheLoai.TabIndex = 5;
            lblTongTheLoai.Text = "Tổng thể loại: 0";
            lblTongTheLoai.TextAlign = ContentAlignment.MiddleCenter;
            lblTongTheLoai.Click += lblTongTheLoai_Click_1;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.FromArgb(128, 255, 128);
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 161);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(784, 300);
            formsPlot1.TabIndex = 1;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // frmThongKe
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(formsPlot1);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongKe";
            Text = "Thống kê thư viện";
            Load += frmThongKe_Load;
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDocGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTheLoai).EndInit();
            ResumeLayout(false);

        }
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}
