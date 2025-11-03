using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;
using QUANLYTHUVIENC3.Models;

namespace QUANLYTHUVIENC3.Controls
{
    public partial class UCDocGiaPanel : UserControl
    {
        private SachBLL sachBLL = new SachBLL();
        public UCDocGiaPanel()
        {
            InitializeComponent();
            tbView.ColumnCount = 2;
            tbView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = sachBLL.GetDanhSachSach();
            List<Sach> dtSach = Utils.DatatableToObjects<Sach>(dataTable);

            int maxBooks = Math.Min(dtSach.Count, 10);
            int maxRow = (int)(maxBooks / 2F);
            tbView.RowCount = maxRow;
            foreach (Sach sach in dtSach)
            {
                var control = new DocGiaControl()
                {
                    Dock = DockStyle.Top,
                };
                control.SetData(sach);
                tbView.Controls.Add(control);
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void sachMoi_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void sachMoi_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkRed;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
