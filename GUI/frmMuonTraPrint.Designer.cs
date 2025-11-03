namespace QUANLYTHUVIENC3.GUI
{
    partial class frmMuonTraPrint
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtDetails;

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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTraPrint));
            lblHeader = new Label();
            txtDetails = new TextBox();
            btnCancel = new Button();
            btnPrintPDF = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.DarkBlue;
            lblHeader.Location = new Point(168, 32);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(313, 25);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Thông Tin Phiếu Mượn Sách";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDetails
            // 
            txtDetails.Font = new Font("Segoe UI", 10F);
            txtDetails.Location = new Point(20, 70);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(630, 345);
            txtDetails.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Lime;
            btnCancel.Dock = DockStyle.Right;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(353, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(309, 80);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnPrintPDF
            // 
            btnPrintPDF.BackColor = Color.Red;
            btnPrintPDF.Dock = DockStyle.Fill;
            btnPrintPDF.FlatStyle = FlatStyle.Popup;
            btnPrintPDF.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPrintPDF.Location = new Point(0, 0);
            btnPrintPDF.Name = "btnPrintPDF";
            btnPrintPDF.Size = new Size(353, 80);
            btnPrintPDF.TabIndex = 5;
            btnPrintPDF.Text = "Xuất PDF";
            btnPrintPDF.UseVisualStyleBackColor = false;
            btnPrintPDF.Click += btnPrintPDF_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPrintPDF);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 448);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 80);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmMuonTraPrint
            // 
            ClientSize = new Size(662, 528);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblHeader);
            Controls.Add(txtDetails);
            Name = "frmMuonTraPrint";
            Text = "In Phiếu Mượn Sách";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnPrintPDF;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
