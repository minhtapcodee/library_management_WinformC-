using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmGioiThieu : Form
    {
        public frmGioiThieu()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(240, 248, 255); // Màu nền AliceBlue
        }

        private void frmGioiThieu_Load(object sender, EventArgs e)
        {
            // Không cần gán text nữa vì đã tích hợp vào Designer
        }

        private void lblNoiQuyThuVien_Click(object sender, EventArgs e)
        {
            // Có thể thêm logic xử lý khi nhấp vào Label nếu cần
        }
    }
}