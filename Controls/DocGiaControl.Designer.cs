namespace QUANLYTHUVIENC3.Controls
{
    partial class DocGiaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocGiaControl));
            pbImage = new PictureBox();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            resources.ApplyResources(pbImage, "pbImage");
            pbImage.Name = "pbImage";
            pbImage.TabStop = false;
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.ForeColor = SystemColors.Highlight;
            lblName.Name = "lblName";
            lblName.Click += lblName_Click;
            lblName.MouseLeave += lblName_MouseLeave;
            lblName.MouseHover += lblName_MouseHover;
            // 
            // DocGiaControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pbImage);
            Controls.Add(lblName);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "DocGiaControl";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImage;
        private Label lblName;
    }
}
