using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmMuonTraPrint : Form
    {
        private string maMT, tenSach, tacGia, theLoai, tenNguoiMuon, sdt, tenNhanVien;
        private string ngayMuon, ngayTraDuKien, ngayTraThucTe, tienPhat, trangThai;

        public frmMuonTraPrint(string maMT, string tenSach, string tacGia, string theLoai, string tenNguoiMuon,
            string sdt, string tenNhanVien, string ngayMuon, string ngayTraDuKien, string ngayTraThucTe,
            string tienPhat, string trangThai)
        {
            InitializeComponent();
            this.maMT = maMT;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.theLoai = theLoai;
            this.tenNguoiMuon = tenNguoiMuon;
            this.sdt = sdt;
            this.tenNhanVien = tenNhanVien;
            this.ngayMuon = ngayMuon;
            this.ngayTraDuKien = ngayTraDuKien;
            this.ngayTraThucTe = ngayTraThucTe;
            this.tienPhat = tienPhat;
            this.trangThai = trangThai;

            // Hiển thị dữ liệu lên form
            LoadDataToForm();
        }

        private void LoadDataToForm()
        {
            txtDetails.Text = $"Họ tên: {tenNguoiMuon}\r\n" +
                             $"Mã sinh viên: N/A\r\n" +
                             $"Lớp: N/A\r\n" +
                             $"Mã mượn trả: {maMT}\r\n" +
                             $"Tên sách: {tenSach}\r\n" +
                             $"Tác giả: {tacGia}\r\n" +
                             $"Thể loại: {theLoai}\r\n" +
                             $"Người mượn: {tenNguoiMuon}\r\n" +
                             $"SĐT: {sdt}\r\n" +
                             $"Nhân viên xử lý: {tenNhanVien}\r\n" +
                             $"Ngày mượn: {ngayMuon}\r\n" +
                             $"Trả dự kiến: {ngayTraDuKien}\r\n" +
                             $"Trả thực tế: {ngayTraThucTe}\r\n" +
                             $"Tiền phạt: {tienPhat}\r\n" +
                             $"Trạng thái: {trangThai}";
        }

        private void btnPrintPDF_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sự kiện In PDF được gọi!", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Lưu file PDF",
                FileName = "PhieuMuonTra_" + maMT + ".pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;

                // Đường dẫn cố định đến thư mục chứa hình ảnh
                string imageFolderPath = @"C:\Users\DELL\Visual .NET folder\QUANLYTHUVIENC3\QUANLYTHUVIENC3\GUI\Image";
                string logoPath = Path.Combine(imageFolderPath, "hunre1.jpg");
                string stampPath = Path.Combine(imageFolderPath, "dấuđỏ.png");

                try
                {
                    // Kiểm tra xem file hình ảnh có tồn tại không
                    if (!File.Exists(logoPath))
                    {
                        throw new FileNotFoundException($"Không tìm thấy file logo tại: {logoPath}");
                    }
                    if (!File.Exists(stampPath))
                    {
                        throw new FileNotFoundException($"Không tìm thấy file dấu đỏ tại: {stampPath}");
                    }

                    // Tạo tài liệu PDF
                    PdfDocument document = new PdfDocument();
                    document.Info.Title = "Phiếu Mượn Sách";
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    // Font cho các phần
                    XFont titleFont = new XFont("Arial", 20);
                    XFont subtitleFont = new XFont("Arial", 14);
                    XFont labelFont = new XFont("Times New Roman", 18); // Font thay thế cho cột "Trường"
                    XFont valueFont = new XFont("Times New Roman", 18); // Font thay thế cho cột "Giá trị"
                    XFont normalFont = new XFont("Arial", 12);

                    // Thêm logo HUNRE từ đường dẫn cố định
                    XImage logo = XImage.FromFile(logoPath);
                    double logoWidth = 110; // Chiều rộng logo
                    double logoHeight = 110; // Chiều cao logo
                    double logoX = (page.Width - logoWidth) / 2; // Căn giữa logo
                    gfx.DrawImage(logo, logoX, 20, logoWidth, logoHeight);

                    // Vẽ tiêu đề
                    gfx.DrawString("PHIẾU MƯỢN TRẢ SÁCH", titleFont, XBrushes.Black,
                        new XRect(0, 130, page.Width, page.Height), XStringFormats.TopCenter);

                    // Vẽ đường kẻ dưới tiêu đề
                    gfx.DrawLine(XPens.Black, 50, 160, page.Width - 50, 160);

                    // Vẽ thông tin sinh viên
                    double studentInfoY = 180;
                    gfx.DrawString("Thông tin sinh viên", subtitleFont, XBrushes.Black,
                        new XRect(50, studentInfoY, page.Width, page.Height), XStringFormats.TopLeft);
                    studentInfoY += 20;
                    gfx.DrawString($"Họ tên: {tenNguoiMuon}", normalFont, XBrushes.Black,
                        new XRect(50, studentInfoY, page.Width, page.Height), XStringFormats.TopLeft);
                    studentInfoY += 20;
                    gfx.DrawString($"Mã sinh viên:.........................", normalFont, XBrushes.Black,
                        new XRect(50, studentInfoY, page.Width, page.Height), XStringFormats.TopLeft);
                    studentInfoY += 20;
                    gfx.DrawString($"Lớp: ...........................", normalFont, XBrushes.Black,
                        new XRect(50, studentInfoY, page.Width, page.Height), XStringFormats.TopLeft);

                    // Vẽ tiêu đề phụ
                    double tableY = studentInfoY + 30;
                    gfx.DrawString("Thông tin chi tiết", subtitleFont, XBrushes.Black,
                        new XRect(50, tableY, page.Width, page.Height), XStringFormats.TopLeft);

                    // Vẽ bảng
                    tableY += 20;
                    double tableWidth = page.Width - 100; // Chiều rộng bảng
                    double col1Width = tableWidth * 0.3; // Cột "Trường" (30%)
                    double col2Width = tableWidth * 0.7; // Cột "Giá trị" (70%)
                    double rowHeight = 20; // Chiều cao mỗi dòng

                    // Vẽ viền ngoài bảng
                    gfx.DrawRectangle(XPens.Black, 50, tableY, tableWidth, rowHeight * 13); // 12 dòng + 1 dòng tiêu đề

                    // Vẽ tiêu đề bảng (font Times New Roman, căn giữa)
                    gfx.DrawString("Trường", labelFont, XBrushes.Black,
                        new XRect(50, tableY + 5, col1Width, rowHeight), XStringFormats.Center);
                    gfx.DrawString("Giá trị", valueFont, XBrushes.Black,
                        new XRect(50 + col1Width, tableY + 5, col2Width, rowHeight), XStringFormats.Center);
                    gfx.DrawLine(XPens.Black, 50, tableY + rowHeight, 50 + tableWidth, tableY + rowHeight); // Đường ngang dưới tiêu đề
                    gfx.DrawLine(XPens.Black, 50 + col1Width, tableY, 50 + col1Width, tableY + rowHeight * 13); // Đường dọc giữa cột

                    // Dữ liệu bảng
                    string[,] tableData = new string[,]
                    {
                        { "Mã mượn trả", maMT ?? "N/A" },
                        { "Tên sách", tenSach ?? "N/A" },
                        { "Tác giả", tacGia ?? "N/A" },
                        { "Thể loại", theLoai ?? "N/A" },
                        { "Người mượn", tenNguoiMuon ?? "N/A" },
                        { "SĐT", sdt ?? "N/A" },
                        { "Nhân viên xử lý", tenNhanVien ?? "N/A" },
                        { "Ngày mượn", ngayMuon ?? "N/A" },
                        { "Trả dự kiến", ngayTraDuKien ?? "N/A" },
                        { "Trả thực tế", ngayTraThucTe ?? "N/A" },
                        { "Tiền phạt", $"{tienPhat ?? "0"} VND" },
                        { "Trạng thái", trangThai ?? "N/A" }
                    };

                    // Vẽ các dòng dữ liệu (font Arial, căn trái)
                    for (int i = 0; i < tableData.GetLength(0); i++)
                    {
                        double rowY = tableY + (i + 1) * rowHeight;
                        gfx.DrawString(tableData[i, 0], normalFont, XBrushes.Black,
                            new XRect(55, rowY + 5, col1Width, rowHeight), XStringFormats.TopLeft);
                        gfx.DrawString(tableData[i, 1], normalFont, XBrushes.Black,
                            new XRect(55 + col1Width, rowY + 5, col2Width, rowHeight), XStringFormats.TopLeft);
                        gfx.DrawLine(XPens.Black, 50, rowY + rowHeight, 50 + tableWidth, rowY + rowHeight); // Đường ngang
                    }

                    // Vẽ ngày in
                    double footerY = tableY + rowHeight * 13 + 20;
                    gfx.DrawString($"Ngày in: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}", normalFont, XBrushes.Black,
                        new XRect(50, footerY, page.Width, page.Height), XStringFormats.TopLeft);

                    // Thêm dấu đỏ từ đường dẫn cố định
                    XImage stamp = XImage.FromFile(stampPath);
                    double stampWidth = 80;  // Chiều rộng dấu đỏ
                    double stampHeight = 80; // Chiều cao dấu đỏ
                    double stampX = page.Width - stampWidth - 50; // Căn phải
                    double stampY = page.Height - stampHeight - 50; // Căn dưới
                    gfx.DrawImage(stamp, stampX, stampY, stampWidth, stampHeight);

                    // Lưu file PDF
                    document.Save(outputPath);

                    MessageBox.Show($"Đã xuất file PDF thành công tại: {outputPath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file PDF: {ex.ToString()}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}