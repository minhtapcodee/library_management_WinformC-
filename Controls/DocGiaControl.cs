using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIENC3.Models;

namespace QUANLYTHUVIENC3.Controls
{
    public partial class DocGiaControl : UserControl
    {
        public DocGiaControl()
        {
            InitializeComponent();
        }


        public void SetData(Sach sach)
        {
            lblName.Text = sach.TenSach;
            if (sach.HinhAnh != null)
            {
                pbImage.Image = Image.FromFile(sach.HinhAnh);
            }
            else
            {
                pbImage.Image = Image.FromFile(Path.Combine(Application.StartupPath, "GUI\\Image\\thuvien.png"));
            }
        }

        private void lblName_MouseHover(object sender, EventArgs e)
        {
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
