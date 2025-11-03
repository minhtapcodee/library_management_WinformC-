namespace QUANLYTHUVIENC3.GUI
{
    partial class frmTongHopNhanvien
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
            tabKhoSach = new TabPage();
            tabThongKe = new TabPage();
            tabControlMain = new TabControl();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabKhoSach
            // 
            tabKhoSach.BackColor = Color.White;
            tabKhoSach.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabKhoSach.Location = new Point(4, 44);
            tabKhoSach.Name = "tabKhoSach";
            tabKhoSach.Padding = new Padding(9);
            tabKhoSach.Size = new Size(1028, 635);
            tabKhoSach.TabIndex = 1;
            tabKhoSach.Text = "Quản Lý Kho Sách";
            // 
            // tabThongKe
            // 
            tabThongKe.BackColor = Color.White;
            tabThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabThongKe.Location = new Point(4, 44);
            tabThongKe.Name = "tabThongKe";
            tabThongKe.Padding = new Padding(9);
            tabThongKe.Size = new Size(1028, 635);
            tabThongKe.TabIndex = 0;
            tabThongKe.Text = "Quản Lý Sách";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabThongKe);
            tabControlMain.Controls.Add(tabKhoSach);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlMain.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlMain.ForeColor = Color.FromArgb(34, 139, 34);
            tabControlMain.ItemSize = new Size(0, 40);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1036, 683);
            tabControlMain.SizeMode = TabSizeMode.FillToRight;
            tabControlMain.TabIndex = 0;
            tabControlMain.DrawItem += tabControlMain_DrawItem;
            // 
            // frmTongHopNhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 255, 245);
            ClientSize = new Size(1036, 683);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTongHopNhanvien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tổng Hợp Quản Lý Thư Viện";
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabKhoSach;
        private TabPage tabThongKe;
        private TabControl tabControlMain;
    }
}