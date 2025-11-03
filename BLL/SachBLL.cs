using MySql.Data.MySqlClient;
using QUANLYTHUVIENC3.DAL;
using System;
using System.Data;
using System.Data.Common;

namespace QUANLYTHUVIENC3.BLL
{
    public class SachBLL
    {
        private SachDAL sachDAL = new SachDAL();

        public DataTable GetAllSach()
        {
            try
            {
                return sachDAL.GetAllSach();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách sách: {ex.Message}");
            }
        }

        public DataTable GetDanhSachSach()
        {
            try
            {
                return sachDAL.GetDanhSachSach();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách sách: {ex.Message}");
            }
        }

        public DataTable GetSachByFilters(string tinhTrang, string tenTheLoai)
        {
            try
            {
                return sachDAL.GetSachByFilters(tinhTrang, tenTheLoai);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lọc sách: {ex.Message}");
            }
        }

        public DataTable TimKiemSach(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
                throw new Exception("Từ khóa tìm kiếm không được để trống!");
            try
            {
                return sachDAL.TimKiemSach(tuKhoa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm sách: {ex.Message}");
            }
        }

        public void AddSach(string maSach, string tenSach, string hinhAnh, string tacGia, int namXB, string nhaXB,
                           string tinhTrang, decimal gia, string moTa, string[] maTLs)
        {
            if (string.IsNullOrWhiteSpace(maSach) || string.IsNullOrWhiteSpace(tenSach))
                throw new Exception("Mã sách và tên sách không được để trống!");
            if (gia < 0)
                throw new Exception("Giá sách không được âm!");
            if (namXB < 0 || namXB > DateTime.Now.Year)
                throw new Exception("Năm xuất bản không hợp lệ!");

            try
            {
                sachDAL.AddSach(maSach, tenSach, hinhAnh, tacGia, namXB, nhaXB, tinhTrang, gia, moTa, maTLs);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sách: {ex.Message}");
            }
        }

        public void UpdateSach(string maSach, string tenSach, string hinhAnh, string tacGia, int namXB, string nhaXB,
                              string tinhTrang, decimal gia, string moTa, string[] maTLs)
        {
            if (string.IsNullOrWhiteSpace(maSach) || string.IsNullOrWhiteSpace(tenSach))
                throw new Exception("Mã sách và tên sách không được để trống!");
            if (gia < 0)
                throw new Exception("Giá sách không được âm!");
            if (namXB < 0 || namXB > DateTime.Now.Year)
                throw new Exception("Năm xuất bản không hợp lệ!");

            try
            {
                sachDAL.UpdateSach(maSach, tenSach, hinhAnh, tacGia, namXB, nhaXB, tinhTrang, gia, moTa, maTLs);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật sách: {ex.Message}");
            }
        }

        public (bool success, string message) DeleteSach(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                return (false, "Mã sách không được để trống!");

            try
            {
                sachDAL.DeleteSach(maSach);
                return (true, "Xóa sách thành công!");
            }
            catch (Exception ex)
            {
                return (false, $"Lỗi khi xóa sách: {ex.Message}");
            }
        }

        public int DemTongSach()
        {
            try
            {
                return sachDAL.DemTongSach();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đếm tổng số sách: {ex.Message}");
            }
        }

        //public Dictionary<string, int> ThongKeSachTheoTheLoai()
        //{
        //    try
        //    {
        //        return sachDAL.ThongKeSachTheoTheLoai();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi khi thống kê sách theo thể loại: {ex.Message}");
        //    }
        //}
        private DatabaseConnection dbConnection = new DatabaseConnection();
        public int DemTongDauSach()
        {
            string query = "SELECT COUNT(DISTINCT MaSach) FROM Sach";
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
                }
            }
        }

        //public int DemTongSach()
        //{
        //    string query = "SELECT SUM(SoLuong) FROM Sach";
        //    using (MySqlConnection connection = dbConnection.GetConnection())
        //    {
        //        connection.Open();
        //        using (MySqlCommand command = new MySqlCommand(query, connection))
        //        {
        //            object result = command.ExecuteScalar();
        //            return result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
        //        }
        //    }
        //}

        public int DemSachMatHong()
        {
            string query = "SELECT COUNT(*) FROM Sach WHERE TinhTrang = 'Hết'";
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
                }
            }
        }

        public Dictionary<string, int> ThongKeSachTheoTheLoai()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string query = "SELECT tl.TenTheLoai, COUNT(s.MaSach) AS SoLuong " +
                           "FROM Sach s " +
                           "JOIN Sach_TheLoai stl ON s.MaSach = stl.MaSach " +
                           "JOIN TheLoaiSach tl ON stl.MaTL = tl.MaTL " +
            "GROUP BY tl.TenTheLoai";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string theLoai = reader["TenTheLoai"].ToString();
                            int soLuong = Convert.ToInt32(reader["SoLuong"]);
                            result[theLoai] = soLuong;
                        }
                    }
                }
            }

            return result;
        }

        public Dictionary<string, int> ThongKeSachTheoNhaXuatBan()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string query = "SELECT NhaXB, COUNT(MaSach) AS SoLuong " +
                           "FROM Sach " +
            "GROUP BY NhaXB";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nhaXB = reader["NhaXB"].ToString();
                            int soLuong = Convert.ToInt32(reader["SoLuong"]);
                            result[nhaXB] = soLuong;
                        }
                    }
                }
            }

            return result;
        }

        public Dictionary<string, int> ThongKeNhapSachTheoThang()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string query = "SELECT MONTH(NgayNhap) AS Thang, SUM(SoLuongNhap) AS SoLuongNhap " +
                           "FROM KhoSach " +
                           "GROUP BY MONTH(NgayNhap)";

            try
            {
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string thang = reader["Thang"].ToString();
                                int soLuong = Convert.ToInt32(reader["SoLuongNhap"]);
                                result[thang] = soLuong;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thống kê nhập sách theo tháng: " + ex.Message);
            }

            return result;
        }

        public DataTable GetThongKeSachTheoTheLoai()
        {
            DataTable dt = new DataTable();
            string query = "SELECT tl.TenTheLoai, COUNT(s.MaSach) AS SoLuong " +
                           "FROM Sach s " +
                           "JOIN Sach_TheLoai stl ON s.MaSach = stl.MaSach " +
                           "JOIN TheLoaiSach tl ON stl.MaTL = tl.MaTL " +
                           "GROUP BY tl.TenTheLoai";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable GetThongKeSachTheoNhaXuatBan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT NhaXB, COUNT(MaSach) AS SoLuong " +
                           "FROM Sach " +
            "GROUP BY NhaXB";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable GetThongKeSachTheoTacGia()
        {
            DataTable dt = new DataTable();
            string query = "SELECT TacGia, COUNT(MaSach) AS SoLuong " +
                           "FROM Sach " +
                           "GROUP BY TacGia";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable GetThongKeSachTheoNamXuatBan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT NamXB, COUNT(MaSach) AS SoLuong " +
                           "FROM Sach " +
                           "GROUP BY NamXB";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable GetThongKeTonKho()
        {
            DataTable dt = new DataTable();
            string query = "SELECT s.MaSach, s.TenSach, k.SoLuongConLai " +
                           "FROM Sach s " +
                           "JOIN KhoSach k ON s.MaSach = k.MaSach";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable GetThongKeTinhTrangSach()
        {
            DataTable dt = new DataTable();
            string query = "SELECT TinhTrang, COUNT(MaSach) AS SoLuong " +
                           "FROM Sach " +
                           "GROUP BY TinhTrang";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
        //thêm GétsachByNgayNhap 
        public DataTable GetSachByNgayNhap(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT s.*, k.NgayNhap 
                FROM Sach s
                JOIN KhoSach k ON s.MaSach = k.MaSach
                WHERE k.NgayNhap BETWEEN @TuNgay AND @DenNgay";

            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TuNgay", tuNgay.Date);
                    command.Parameters.AddWithValue("@DenNgay", denNgay.Date);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}