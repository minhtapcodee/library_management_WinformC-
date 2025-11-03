using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmTongHop : Form
    {
        public frmTongHop()
        {
            InitializeComponent(); // Gọi hàm đã được định nghĩa trong .Designer.cs
            InitializeTabContent();
            CustomizeFormAppearance();
        }

        private void InitializeTabContent()
        {
            // Gán frmTThongKe vào tabThongKe
            frmTThongKe thongKeForm = new frmTThongKe
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                //AutoScroll = true
            };
            tabThongKe.Controls.Add(thongKeForm);
            thongKeForm.Show();

            // Gán frmNgayCong vào tabNgayCong
            frmTKNgayCong ngayCongForm = new frmTKNgayCong
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            tabNgayCong.Controls.Add(ngayCongForm);
            ngayCongForm.Show();

            // Gán frmKhoSach vào tabKhoSach
            frmTKKhoSach khoSachForm = new frmTKKhoSach
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            tabKhoSach.Controls.Add(khoSachForm);
            khoSachForm.Show();


        }
        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage tabPage = tabControl.TabPages[e.Index];
            Graphics g = e.Graphics;

            // Define colors
            Color selectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(238)))), ((int)(((byte)(144))))); // Light green for selected tab
            Color normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(200))))); // Slightly darker green for unselected
            Color textColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34))))); // Forest green for text

            // Get the tab rectangle
            Rectangle tabRect = tabControl.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2); // Adjust for padding

            // Draw the background of the tab
            if (e.State == DrawItemState.Selected)
            {
                using (SolidBrush brush = new SolidBrush(selectedColor))
                {
                    g.FillRectangle(brush, tabRect);
                }
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(normalColor))
                {
                    g.FillRectangle(brush, tabRect);
                }
            }

            // Draw the text
            using (SolidBrush brush = new SolidBrush(textColor))
            {
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(tabPage.Text, tabControl.Font, brush, tabRect, stringFormat);
            }
        }
        private void CustomizeFormAppearance()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);

            this.Paint += (sender, e) =>
            {
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    this.ClientRectangle,
                    Color.FromArgb(245, 247, 250),
                    Color.FromArgb(200, 220, 255),
                    90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            };
        }
    }
}
