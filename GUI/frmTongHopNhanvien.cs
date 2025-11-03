using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmTongHopNhanvien : Form
    {
        public frmTongHopNhanvien()
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
                Dock = DockStyle.Fill
            };
            tabThongKe.Controls.Add(thongKeForm);
            thongKeForm.Show();

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
            Color selectedColor = Color.FromArgb(144, 238, 144); // Light green for selected tab
            Color normalColor = Color.FromArgb(200, 230, 200); // Slightly darker green for unselected
            Color textColor = Color.FromArgb(34, 139, 34); // Forest green for text

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