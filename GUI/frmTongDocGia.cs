using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using QUANLYTHUVIENC3.BLL;
using System.IO;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmTongDocGia : Form
    {
        private DocGiaBLL docGiaBLL;
        private DataTable duLieuGoc;

        public frmTongDocGia()
        {
            InitializeComponent();
            docGiaBLL = new DocGiaBLL();
            ThietLapGiaoDien();
        }

        private void ThietLapGiaoDien()
        {
            cboGioiTinh.Items.AddRange(new string[] { "Tất cả", "Nam", "Nữ" });
            cboGioiTinh.SelectedIndex = 0;

            cboTrangThai.Items.AddRange(new string[] { "Tất cả", "Có sách chưa trả", "Không có sách chưa trả" });
            cboTrangThai.SelectedIndex = 0;
        }

        private void frmTongDocGia_Load(object sender, EventArgs e)
        {
            duLieuGoc = docGiaBLL.GetAllDocGia();
            if (duLieuGoc == null || duLieuGoc.Rows.Count == 0)
            {
                MessageBox.Show("Không tải được dữ liệu độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Số lượng độc giả: {duLieuGoc.Rows.Count}");
            }
            dgvDocGia.DataSource = duLieuGoc;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LocDuLieu(cboGioiTinh.SelectedItem.ToString(), cboTrangThai.SelectedItem.ToString());
        }

        private void btnXoaLoc_Click(object sender, EventArgs e)
        {
            XoaBoLoc();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            XuatDataGridViewRaExcel(dgvDocGia, "DanhSachDocGia.xlsx");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LocDuLieu(string gioiTinh, string trangThai)
        {
            try
            {
                string gioiTinhFilter = gioiTinh == "Tất cả" ? "" : gioiTinh;
                string trangThaiFilter = trangThai == "Tất cả" ? "" : (trangThai == "Có sách chưa trả" ? "Có" : "Không");

                DataTable duLieuLoc = docGiaBLL.SearchDocGia("", gioiTinhFilter, trangThaiFilter);
                dgvDocGia.DataSource = duLieuLoc;
                dgvDocGia.Refresh();

                if (duLieuLoc.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy độc giả phù hợp với bộ lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaBoLoc()
        {
            cboGioiTinh.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            dgvDocGia.DataSource = duLieuGoc;
            dgvDocGia.Refresh();
        }

        private void XuatDataGridViewRaExcel(DataGridView dgv, string tenFile)
        {
            if (dgv.DataSource == null || ((DataTable)dgv.DataSource).Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Tệp Excel (*.xlsx)|*.xlsx",
                FileName = tenFile
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("DanhSachDocGia");

                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                            worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                            worksheet.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.FromArgb(0, 120, 215);
                            worksheet.Cell(1, col + 1).Style.Font.FontColor = XLColor.White;
                            worksheet.Cell(1, col + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        }

                        DataTable dataToExport = (DataTable)dgv.DataSource;
                        for (int row = 0; row < dataToExport.Rows.Count; row++)
                        {
                            for (int col = 0; col < dataToExport.Columns.Count; col++)
                            {
                                if (dataToExport.Rows[row][col] != null)
                                {
                                    worksheet.Cell(row + 2, col + 1).Value = dataToExport.Rows[row][col].ToString();
                                }
                            }
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveDialog.FileName);
                    }

                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDocGia.Rows.Count)
            {
                DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];
                StringBuilder thongTin = new StringBuilder("Thông tin độc giả:\n");

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string header = dgvDocGia.Columns[cell.ColumnIndex].HeaderText;
                    string value = cell.Value?.ToString() ?? "N/A";
                    thongTin.AppendLine($"{header}: {value}");
                }

                MessageBox.Show(thongTin.ToString(), "Chi tiết độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}