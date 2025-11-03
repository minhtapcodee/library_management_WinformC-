using MySql.Data.MySqlClient;
using QUANLYTHUVIENC3.DAL;
using System;
using System.Data;

namespace QUANLYTHUVIENC3.BLL
{
    public class TheLoaiSachBLL
    {
        private TheLoaiSachDAL theLoaiSachDAL = new TheLoaiSachDAL();

        public DataTable GetAllTheLoaiSach()
        {
            return theLoaiSachDAL.GetAllTheLoaiSach();
        }

        public DataTable GetTheLoaiSachByPage(int pageNumber, int pageSize)
        {
            return theLoaiSachDAL.GetTheLoaiSachByPage(pageNumber, pageSize);
        }

        public int GetTotalRecords()
        {
            return theLoaiSachDAL.GetTotalRecords();
        }

        public void AddTheLoaiSach(string maTL, string tenTheLoai)
        {
            if (string.IsNullOrWhiteSpace(maTL) || string.IsNullOrWhiteSpace(tenTheLoai))
                throw new ArgumentException("Mã thể loại và tên thể loại không được để trống!");

            theLoaiSachDAL.AddTheLoaiSach(maTL, tenTheLoai);
        }

        public void UpdateTheLoaiSach(string maTL, string tenTheLoai)
        {
            if (string.IsNullOrWhiteSpace(maTL) || string.IsNullOrWhiteSpace(tenTheLoai))
                throw new ArgumentException("Mã thể loại và tên thể loại không được để trống!");

            theLoaiSachDAL.UpdateTheLoaiSach(maTL, tenTheLoai);
        }

        public (bool success, string message) DeleteTheLoaiSach(string maTL)
        {
            if (string.IsNullOrWhiteSpace(maTL))
                return (false, "Mã thể loại không được để trống!");

            try
            {
                theLoaiSachDAL.DeleteTheLoaiSach(maTL);
                return (true, "Xóa thể loại thành công!");
            }
            catch (Exception ex)
            {
                return (false, "Thể loại đang được sử dụng ở các mục quản lý khác nên không thể xóa");
            }
        }

        public bool IsMaTLExists(string maTL)
        {
            using (var conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TheLoaiSach WHERE MaTL = @MaTL";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTL", maTL);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi kiểm tra mã thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public int DemTongTheLoai()
        {
            return theLoaiSachDAL.DemTongTheLoai();
        }
    }
}