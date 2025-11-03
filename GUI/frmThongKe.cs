using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLYTHUVIENC3.BLL;
using ScottPlot;
using ScottPlot.WinForms;
using Color = System.Drawing.Color;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmThongKe : Form
    {
        private SachBLL sachBLL = new SachBLL();
        private DocGiaBLL docGiaBLL = new DocGiaBLL();
        private TheLoaiSachBLL theLoaiBLL = new TheLoaiSachBLL();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadThongTinTongQuan();
            LoadChart();
        }

        private void LoadThongTinTongQuan()
        {
            int tongSach = sachBLL.DemTongSach();
            int tongDocGia = docGiaBLL.DemTongDocGia();
            int tongTheLoai = theLoaiBLL.DemTongTheLoai();

            lblTongSach.Text = $"Tổng sách: {tongSach}";
            lblTongDocGia.Text = $"Tổng độc giả: {tongDocGia}";
            lblTongTheLoai.Text = $"Tổng thể loại: {tongTheLoai}";
        }

        private void lblTongSach_Click(object sender, EventArgs e)
        {
            frmTongSach frm = new frmTongSach();
            frm.ShowDialog();
        }

        private void picSach_Click(object sender, EventArgs e)
        {
            lblTongSach_Click(sender, e);
        }

        private void lblTongDocGia_Click(object sender, EventArgs e)
        {
            frmTongDocGia frm = new frmTongDocGia();
            frm.ShowDialog();
        }

        private void picDocGia_Click(object sender, EventArgs e)
        {
            lblTongDocGia_Click(sender, e);
        }

        private void lblTongTheLoai_Click(object sender, EventArgs e)
        {
            frmTongTheLoai frm = new frmTongTheLoai();
            frm.ShowDialog();
            RefreshChart(); // Refresh the chart after the dialog closes
        }

        private void picTheLoai_Click(object sender, EventArgs e)
        {
            lblTongTheLoai_Click(sender, e);
        }

        private void LoadChart()
        {
            // Lấy dữ liệu từ BLL
            Dictionary<string, int> duLieu = sachBLL.ThongKeSachTheoTheLoai();

            // Chuyển đổi dữ liệu
            string[] categories = new string[duLieu.Count];
            int[] values = new int[duLieu.Count];
            int index = 0;

            foreach (var item in duLieu)
            {
                categories[index] = item.Key;
                values[index] = item.Value;
                index++;
            }

            // Tạo màu ngẫu nhiên cho từng cột
            var random = new Random();
            var colors = new Color[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                colors[i] = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }

            // Xóa biểu đồ cũ
            formsPlot1.Plot.Clear();

            // Tạo cột với màu riêng
            int[] positions = Enumerable.Range(0, categories.Length).ToArray();
            for (int i = 0; i < positions.Length; i++)
            {
                var bar = formsPlot1.Plot.Add.Bar(position: positions[i], value: values[i]);
                bar.Color = ScottPlot.Color.FromColor(colors[i]);
            }

            // Nhãn trục X
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                positions.Select(p => (double)p).ToArray(),
                categories
            );

            // Đảm bảo trục Y chỉ hiển thị số nguyên
            double maxValue = values.Max();
            double[] yTicks = Enumerable.Range(0, (int)maxValue + 1).Select(i => (double)i).ToArray();
            string[] yLabels = yTicks.Select(i => i.ToString("0")).ToArray();
            formsPlot1.Plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericManual(yTicks, yLabels);

            // Giao diện biểu đồ
            formsPlot1.Plot.Axes.Left.Label.Text = "Số lượng sách";
            formsPlot1.Plot.Axes.Bottom.Label.Text = "Thể loại sách";
            formsPlot1.Plot.Title("Thống kê số sách theo thể loại");

            // Hiển thị lưới
            formsPlot1.Plot.ShowAxesAndGrid();

            // Làm mới biểu đồ
            formsPlot1.Refresh();
        }

        // Public method to refresh the chart
        public void RefreshChart()
        {
            LoadChart();
        }

        private void picSach_Click_1(object sender, EventArgs e)
        {
            frmTongSach frm = new frmTongSach();
            frm.ShowDialog();
        }

        private void lblTongSach_Click_1(object sender, EventArgs e)
        {
            lblTongSach_Click(sender, e);
        }

        private void picDocGia_Click_1(object sender, EventArgs e)
        {
            frmTongDocGia frm = new frmTongDocGia();
            frm.ShowDialog();
        }

        private void lblTongDocGia_Click_1(object sender, EventArgs e)
        {
            lblTongDocGia_Click(sender, e);
        }

        private void picTheLoai_Click_1(object sender, EventArgs e)
        {
            frmTongTheLoai frm = new frmTongTheLoai();
            frm.ShowDialog();
            RefreshChart(); // Refresh the chart after the dialog closes
        }

        private void lblTongTheLoai_Click_1(object sender, EventArgs e)
        {
            lblTongTheLoai_Click(sender, e);
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
        }
    }
}