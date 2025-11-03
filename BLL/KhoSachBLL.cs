using QUANLYTHUVIENC3.DAL;
using System.Data;

namespace QUANLYTHUVIENC3.BLL
{
    class KhoSachBLL
    {
        private KhoSachDAL dal = new KhoSachDAL();

        public DataTable GetKhoSachData()
        {
            return dal.GetKhoSach();
        }
        public DataTable GetKhoSach()
        {
            return dal.GetKhoSach();
        }

        public DataTable SearchKhoSach(string keyword)
        {
            return dal.SearchKhoSach(keyword);
        }

       

        // Thêm phương thức lấy danh sách sách
        public DataTable GetSach()
        {
            return dal.GetSach();
        }

        // Thêm phương thức lấy danh sách nhân viên
        public DataTable GetNhanVien()
        {
            return dal.GetNhanVien();
        }

        // Thêm phương thức thêm sách vào kho
        public bool AddKhoSach(string maSach, int soLuongNhap, string ngayNhap, string moTa, int maNhanVien)
        {
            bool success = dal.AddKhoSach(maSach, soLuongNhap, ngayNhap, moTa, maNhanVien);
            if (success)
            {
                // Lấy tên sách để ghi vào lịch sử
                DataTable sachTable = dal.GetSach();
                string tenSach = "";
                foreach (DataRow row in sachTable.Rows)
                {
                    if (row["MaSach"].ToString() == maSach)
                    {
                        tenSach = row["TenSach"].ToString();
                        break;
                    }
                }

                // Ghi vào lịch sử nhập xuất
                AddLichSuNhapXuat(maSach, tenSach, "Nhập", soLuongNhap, DateTime.Parse(ngayNhap), maNhanVien, moTa);
            }
            return success;
        }

        public bool DeleteKhoSach(int maKho)
        {
            // Lấy thông tin trước khi xóa để ghi vào lịch sử
            DataTable khoSachTable = dal.GetKhoSach();
            string maSach = "";
            string tenSach = "";
            int soLuongNhap = 0;
            int maNhanVien = 0;
            string moTa = "";
            DateTime ngayNhap = DateTime.Now;

            foreach (DataRow row in khoSachTable.Rows)
            {
                if (Convert.ToInt32(row["MaKho"]) == maKho)
                {
                    maSach = row["MaSach"].ToString();
                    tenSach = row["TenSach"].ToString();
                    soLuongNhap = Convert.ToInt32(row["SoLuongNhap"]);
                    maNhanVien = Convert.ToInt32(row["MaNhanVien"]);
                    moTa = row["MoTa"].ToString();
                    ngayNhap = Convert.ToDateTime(row["NgayNhap"]);
                    break;
                }
            }

            bool success = dal.DeleteKhoSach(maKho);
            if (success)
            {
                // Ghi vào lịch sử nhập xuất
                AddLichSuNhapXuat(maSach, tenSach, "Xuất", soLuongNhap, DateTime.Now, maNhanVien, "Xóa khỏi kho: " + moTa);
            }
            return success;
        }
        public bool UpdateKhoSach(int maKho, int soLuongNhap, DateTime ngayNhap, string moTa)
        {
            return dal.UpdateKhoSach(maKho, soLuongNhap, ngayNhap, moTa);
        }
        public DataTable GetLowStockBooks(int threshold = 5)
        {
            return dal.GetLowStockBooks(threshold);
        }

        public DataTable GetLichSuNhapXuat()
        {
            return dal.GetLichSuNhapXuat();
        }
        public void AddLichSuNhapXuat(string maSach, string tenSach, string loaiGiaoDich, int soLuong, DateTime ngayGiaoDich, int maNhanVien, string moTa)
        {
            dal.AddLichSuNhapXuat(maSach, tenSach, loaiGiaoDich, soLuong, ngayGiaoDich, maNhanVien, moTa);
        }
        public DataTable FilterKhoSachByDate(string ngayNhap)
        {
            return dal.FilterKhoSachByDate(ngayNhap);
        }
        public bool DeleteLichSuNhapXuat(int id)
        {
            try
            {
                return dal.DeleteLichSuNhapXuat(id);
            }
            catch (Exception ex)
            {
                // Có thể log lỗi hoặc xử lý thêm tùy theo yêu cầu
                throw new Exception("Lỗi khi xóa lịch sử nhập/xuất: " + ex.Message);
            }
        }
    }
}