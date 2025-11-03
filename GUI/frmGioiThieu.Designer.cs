namespace QUANLYTHUVIENC3.GUI
{
    partial class frmGioiThieu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle1;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.Label lblSubtitle3;
        private System.Windows.Forms.Label lblNoiQuyThuVien;
        private System.Windows.Forms.Label lblNoiQuyPhongDoc;
        private System.Windows.Forms.Label lblNoiQuyPhongMuon;
        private System.Windows.Forms.Panel panelContent;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGioiThieu));
            lblTitle = new Label();
            lblSubtitle1 = new Label();
            lblSubtitle2 = new Label();
            lblSubtitle3 = new Label();
            lblNoiQuyThuVien = new Label();
            lblNoiQuyPhongDoc = new Label();
            lblNoiQuyPhongMuon = new Label();
            panelContent = new Panel();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(617, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NỘI QUY THƯ VIỆN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle1
            // 
            lblSubtitle1.AutoSize = true;
            lblSubtitle1.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblSubtitle1.ForeColor = Color.DarkGray;
            lblSubtitle1.Location = new Point(12, 57);
            lblSubtitle1.Name = "lblSubtitle1";
            lblSubtitle1.Size = new Size(410, 38);
            lblSubtitle1.TabIndex = 1;
            lblSubtitle1.Text = "(Ban hành theo 4582/QĐ-TĐHHN ngày 13 tháng 12 năm 2019)\r\n(Áp dụng chung cho tất cả các phòng nghiệp vụ)";
            // 
            // lblSubtitle2
            // 
            lblSubtitle2.AutoSize = true;
            lblSubtitle2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSubtitle2.ForeColor = Color.DarkBlue;
            lblSubtitle2.Location = new Point(17, 422);
            lblSubtitle2.Name = "lblSubtitle2";
            lblSubtitle2.Size = new Size(212, 25);
            lblSubtitle2.TabIndex = 3;
            lblSubtitle2.Text = "NỘI QUY PHÒNG ĐỌC";
            // 
            // lblSubtitle3
            // 
            lblSubtitle3.AutoSize = true;
            lblSubtitle3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSubtitle3.ForeColor = Color.DarkBlue;
            lblSubtitle3.Location = new Point(17, 700);
            lblSubtitle3.Name = "lblSubtitle3";
            lblSubtitle3.Size = new Size(235, 25);
            lblSubtitle3.TabIndex = 5;
            lblSubtitle3.Text = "NỘI QUY PHÒNG MƯỢN";
            // 
            // lblNoiQuyThuVien
            // 
            lblNoiQuyThuVien.Font = new Font("Segoe UI", 11F);
            lblNoiQuyThuVien.ForeColor = Color.Green;
            lblNoiQuyThuVien.Location = new Point(17, 128);
            lblNoiQuyThuVien.Name = "lblNoiQuyThuVien";
            lblNoiQuyThuVien.Size = new Size(1240, 294);
            lblNoiQuyThuVien.TabIndex = 2;
            lblNoiQuyThuVien.Text = resources.GetString("lblNoiQuyThuVien.Text");
            lblNoiQuyThuVien.Click += lblNoiQuyThuVien_Click;
            // 
            // lblNoiQuyPhongDoc
            // 
            lblNoiQuyPhongDoc.Font = new Font("Segoe UI", 11F);
            lblNoiQuyPhongDoc.ForeColor = Color.Green;
            lblNoiQuyPhongDoc.Location = new Point(17, 450);
            lblNoiQuyPhongDoc.Name = "lblNoiQuyPhongDoc";
            lblNoiQuyPhongDoc.Size = new Size(1240, 250);
            lblNoiQuyPhongDoc.TabIndex = 4;
            lblNoiQuyPhongDoc.Text = resources.GetString("lblNoiQuyPhongDoc.Text");
            // 
            // lblNoiQuyPhongMuon
            // 
            lblNoiQuyPhongMuon.Font = new Font("Segoe UI", 11F);
            lblNoiQuyPhongMuon.ForeColor = Color.Green;
            lblNoiQuyPhongMuon.Location = new Point(17, 728);
            lblNoiQuyPhongMuon.Name = "lblNoiQuyPhongMuon";
            lblNoiQuyPhongMuon.Size = new Size(1240, 304);
            lblNoiQuyPhongMuon.TabIndex = 6;
            lblNoiQuyPhongMuon.Text = resources.GetString("lblNoiQuyPhongMuon.Text");
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(lblTitle);
            panelContent.Controls.Add(lblSubtitle1);
            panelContent.Controls.Add(lblNoiQuyThuVien);
            panelContent.Controls.Add(lblSubtitle2);
            panelContent.Controls.Add(lblNoiQuyPhongDoc);
            panelContent.Controls.Add(lblSubtitle3);
            panelContent.Controls.Add(lblNoiQuyPhongMuon);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Margin = new Padding(3, 2, 3, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1321, 749);
            panelContent.TabIndex = 0;
            // 
            // frmGioiThieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1321, 749);
            Controls.Add(panelContent);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGioiThieu";
            Text = "Giới Thiệu - Nội Quy Thư Viện";
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }
    }
}