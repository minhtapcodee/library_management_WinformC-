using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QUANLYTHUVIENC3.GUI
{
    partial class frmThongKeTongHop
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHomNay = new System.Windows.Forms.TabPage();
            this.lblSoNguoiMuonHomNay = new System.Windows.Forms.Label();
            this.dgvNguoiMuonHomNay = new System.Windows.Forms.DataGridView();
            this.tabTongSoLanMuon = new System.Windows.Forms.TabPage();
            this.lblTongSoLanMuon = new System.Windows.Forms.Label();
            this.dgvTongMuon = new System.Windows.Forms.DataGridView();
            this.tabSach = new System.Windows.Forms.TabPage();
            this.chartThongKeSach = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvThongKeSach = new System.Windows.Forms.DataGridView();
            this.tabDocGia = new System.Windows.Forms.TabPage();
            this.cbDocGia = new System.Windows.Forms.ComboBox();
            this.lblSoLanMuon = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ngayCongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabHomNay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiMuonHomNay)).BeginInit();
            this.tabTongSoLanMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongMuon)).BeginInit();
            this.tabSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeSach)).BeginInit();
            this.tabDocGia.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHomNay);
            this.tabControl.Controls.Add(this.tabTongSoLanMuon);
            this.tabControl.Controls.Add(this.tabSach);
            this.tabControl.Controls.Add(this.tabDocGia);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 400);
            this.tabControl.TabIndex = 0;
            // 
            // tabHomNay
            // 
            this.tabHomNay.Controls.Add(this.lblSoNguoiMuonHomNay);
            this.tabHomNay.Controls.Add(this.dgvNguoiMuonHomNay);
            this.tabHomNay.Location = new System.Drawing.Point(4, 28);
            this.tabHomNay.Name = "tabHomNay";
            this.tabHomNay.Size = new System.Drawing.Size(752, 368);
            this.tabHomNay.TabIndex = 0;
            this.tabHomNay.Text = "Thống kê hôm nay";
            // 
            // lblSoNguoiMuonHomNay
            // 
            this.lblSoNguoiMuonHomNay.Location = new System.Drawing.Point(20, 20);
            this.lblSoNguoiMuonHomNay.Name = "lblSoNguoiMuonHomNay";
            this.lblSoNguoiMuonHomNay.Size = new System.Drawing.Size(200, 25);
            this.lblSoNguoiMuonHomNay.TabIndex = 0;
            this.lblSoNguoiMuonHomNay.Text = "Số người mượn hôm nay: 0";
            // 
            // dgvNguoiMuonHomNay
            // 
            this.dgvNguoiMuonHomNay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiMuonHomNay.ColumnHeadersHeight = 29;
            this.dgvNguoiMuonHomNay.Location = new System.Drawing.Point(20, 60);
            this.dgvNguoiMuonHomNay.Name = "dgvNguoiMuonHomNay";
            this.dgvNguoiMuonHomNay.RowHeadersWidth = 51;
            this.dgvNguoiMuonHomNay.Size = new System.Drawing.Size(720, 300);
            this.dgvNguoiMuonHomNay.TabIndex = 1;
            // 
            // tabTongSoLanMuon
            // 
            this.tabTongSoLanMuon.Controls.Add(this.lblTongSoLanMuon);
            this.tabTongSoLanMuon.Controls.Add(this.dgvTongMuon);
            this.tabTongSoLanMuon.Location = new System.Drawing.Point(4, 28);
            this.tabTongSoLanMuon.Name = "tabTongSoLanMuon";
            this.tabTongSoLanMuon.Size = new System.Drawing.Size(752, 368);
            this.tabTongSoLanMuon.TabIndex = 1;
            this.tabTongSoLanMuon.Text = "Tổng số lần mượn";
            // 
            // lblTongSoLanMuon
            // 
            this.lblTongSoLanMuon.Location = new System.Drawing.Point(20, 20);
            this.lblTongSoLanMuon.Name = "lblTongSoLanMuon";
            this.lblTongSoLanMuon.Size = new System.Drawing.Size(200, 25);
            this.lblTongSoLanMuon.TabIndex = 0;
            this.lblTongSoLanMuon.Text = "Tổng số lần mượn: 0";
            // 
            // dgvTongMuon
            // 
            this.dgvTongMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongMuon.ColumnHeadersHeight = 29;
            this.dgvTongMuon.Location = new System.Drawing.Point(20, 60);
            this.dgvTongMuon.Name = "dgvTongMuon";
            this.dgvTongMuon.RowHeadersWidth = 51;
            this.dgvTongMuon.Size = new System.Drawing.Size(720, 300);
            this.dgvTongMuon.TabIndex = 1;
            // 
            // tabSach
            // 
            this.tabSach.Controls.Add(this.chartThongKeSach);
            this.tabSach.Controls.Add(this.dgvThongKeSach);
            this.tabSach.Location = new System.Drawing.Point(4, 28);
            this.tabSach.Name = "tabSach";
            this.tabSach.Size = new System.Drawing.Size(752, 368);
            this.tabSach.TabIndex = 2;
            this.tabSach.Text = "Thống kê sách";
            // 
            // chartThongKeSach
            // 
            this.chartThongKeSach.Location = new System.Drawing.Point(20, 20);
            this.chartThongKeSach.Name = "chartThongKeSach";
            this.chartThongKeSach.Size = new System.Drawing.Size(720, 300);
            this.chartThongKeSach.TabIndex = 0;
            // 
            // dgvThongKeSach
            // 
            this.dgvThongKeSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeSach.ColumnHeadersHeight = 29;
            this.dgvThongKeSach.Location = new System.Drawing.Point(20, 330);
            this.dgvThongKeSach.Name = "dgvThongKeSach";
            this.dgvThongKeSach.RowHeadersWidth = 51;
            this.dgvThongKeSach.Size = new System.Drawing.Size(720, 60);
            this.dgvThongKeSach.TabIndex = 1;
            // 
            // tabDocGia
            // 
            this.tabDocGia.Controls.Add(this.cbDocGia);
            this.tabDocGia.Controls.Add(this.lblSoLanMuon);
            this.tabDocGia.Controls.Add(this.menuStrip1);
            this.tabDocGia.Location = new System.Drawing.Point(4, 28);
            this.tabDocGia.Name = "tabDocGia";
            this.tabDocGia.Size = new System.Drawing.Size(752, 368);
            this.tabDocGia.TabIndex = 3;
            this.tabDocGia.Text = "Thống kê độc giả";
            // 
            // cbDocGia
            // 
            this.cbDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocGia.Location = new System.Drawing.Point(20, 3);
            this.cbDocGia.Name = "cbDocGia";
            this.cbDocGia.Size = new System.Drawing.Size(200, 27);
            this.cbDocGia.TabIndex = 0;
            // 
            // lblSoLanMuon
            // 
            this.lblSoLanMuon.Location = new System.Drawing.Point(20, 60);
            this.lblSoLanMuon.Name = "lblSoLanMuon";
            this.lblSoLanMuon.Size = new System.Drawing.Size(200, 25);
            this.lblSoLanMuon.TabIndex = 1;
            this.lblSoLanMuon.Text = "Số lần mượn: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngayCongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ngayCongToolStripMenuItem
            // 
            this.ngayCongToolStripMenuItem.Name = "ngayCongToolStripMenuItem";
            this.ngayCongToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.ngayCongToolStripMenuItem.Text = "ngay cong";
            this.ngayCongToolStripMenuItem.Click += new System.EventHandler(this.ngayCongToolStripMenuItem_Click);
            // 
            // frmThongKeTongHop
            // 
            this.ClientSize = new System.Drawing.Size(795, 419);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmThongKeTongHop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tổng hợp";
            this.tabControl.ResumeLayout(false);
            this.tabHomNay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiMuonHomNay)).EndInit();
            this.tabTongSoLanMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongMuon)).EndInit();
            this.tabSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeSach)).EndInit();
            this.tabDocGia.ResumeLayout(false);
            this.tabDocGia.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private TabControl tabControl;
        private TabPage tabHomNay;
        private TabPage tabTongSoLanMuon;
        private TabPage tabSach;
        private TabPage tabDocGia;
        private Label lblSoNguoiMuonHomNay;
        private DataGridView dgvNguoiMuonHomNay;
        private Label lblTongSoLanMuon;
        private DataGridView dgvTongMuon;
        private Chart chartThongKeSach;
        private DataGridView dgvThongKeSach;
        private ComboBox cbDocGia;
        private Label lblSoLanMuon;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ngayCongToolStripMenuItem;
    }
}