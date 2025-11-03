using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace QUANLYTHUVIENC3.DAL
{
    public class SachDAL
    {
        private DatabaseConnection db = new DatabaseConnection();

        public DataTable GetAllSach()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT s.MaSach, s.TenSach, s.HinhAnh, s.TacGia, s.NamXB, s.NhaXB, s.TinhTrang, s.Gia, s.MoTa, 
                                   GROUP_CONCAT(tl.TenTheLoai SEPARATOR ', ') AS TheLoai
                                   FROM Sach s
                                   LEFT JOIN Sach_TheLoai st ON s.MaSach = st.MaSach
                                   LEFT JOIN TheLoaiSach tl ON st.MaTL = tl.MaTL
                                   GROUP BY s.MaSach, s.TenSach, s.HinhAnh, s.TacGia, s.NamXB, s.NhaXB, s.TinhTrang, s.Gia, s.MoTa";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy danh sách sách: {ex.Message}");
                }
            }
        }

        public DataTable GetDanhSachSach()
        {
            return GetAllSach(); // Gọi lại GetAllSach để đảm bảo tính nhất quán
        }

        public DataTable GetSachByFilters(string tinhTrang, string tenTheLoai)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT s.MaSach, s.TenSach, s.HinhAnh, s.TacGia, s.NamXB, s.NhaXB, s.TinhTrang, s.Gia, s.MoTa, 
                                   GROUP_CONCAT(tl.TenTheLoai SEPARATOR ', ') AS TheLoai
                                   FROM Sach s
                                   LEFT JOIN Sach_TheLoai st ON s.MaSach = st.MaSach
                                   LEFT JOIN TheLoaiSach tl ON st.MaTL = tl.MaTL
                                   WHERE 1=1";

                    if (!string.IsNullOrEmpty(tinhTrang) && tinhTrang != "Tất cả")
                        query += " AND s.TinhTrang = @TinhTrang";
                    if (!string.IsNullOrEmpty(tenTheLoai) && tenTheLoai != "Tất cả")
                        query += " AND tl.TenTheLoai = @TenTheLoai";

                    query += " GROUP BY s.MaSach, s.TenSach, s.HinhAnh, s.TacGia, s.NamXB, s.NhaXB, s.TinhTrang, s.Gia, s.MoTa";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(tinhTrang) && tinhTrang != "Tất cả")
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                    if (!string.IsNullOrEmpty(tenTheLoai) && tenTheLoai != "Tất cả")
                        cmd.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lọc sách: {ex.Message}");
                }
            }
        }

        public DataTable TimKiemSach(string tuKhoa)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT s.MaSach, s.TenSach, s.HinhAnh, s.TacGia, s.NamXB, s.NhaXB, s.TinhTrang, s.Gia, s.MoTa, 
                                   GROUP_CONCAT(tl.TenTheLoai SEPARATOR ', ') AS TheLoai
                                   FROM Sach s
                                   LEFT JOIN Sach_TheLoai st ON s.MaSach = st.MaSach
                                   LEFT JOIN TheLoaiSach tl ON st.MaTL = tl.MaTL
                                   WHERE s.TenSach LIKE @TuKhoa OR s.TacGia LIKE @TuKhoa
                                   GROUP BY s.MaSach, s.TenSach, s.HinhAnh, s.TacGia, s.NamXB, s.NhaXB, s.TinhTrang, s.Gia, s.MoTa";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi tìm kiếm sách: {ex.Message}");
                }
            }
        }

        public void AddSach(string maSach, string tenSach, string hinhAnh, string tacGia, int namXB, string nhaXB,
                           string tinhTrang, decimal gia, string moTa, string[] maTLs)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string querySach = @"INSERT INTO Sach (MaSach, TenSach, HinhAnh, TacGia, NamXB, NhaXB, TinhTrang, Gia, MoTa) 
                                          VALUES (@MaSach, @TenSach, @HinhAnh, @TacGia, @NamXB, @NhaXB, @TinhTrang, @Gia, @MoTa)";
                        MySqlCommand cmdSach = new MySqlCommand(querySach, conn, transaction);
                        cmdSach.Parameters.AddWithValue("@MaSach", maSach);
                        cmdSach.Parameters.AddWithValue("@TenSach", tenSach);
                        cmdSach.Parameters.AddWithValue("@HinhAnh", string.IsNullOrEmpty(hinhAnh) ? (object)DBNull.Value : hinhAnh);
                        cmdSach.Parameters.AddWithValue("@TacGia", tacGia);
                        cmdSach.Parameters.AddWithValue("@NamXB", namXB);
                        cmdSach.Parameters.AddWithValue("@NhaXB", nhaXB);
                        cmdSach.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                        cmdSach.Parameters.AddWithValue("@Gia", gia);
                        cmdSach.Parameters.AddWithValue("@MoTa", moTa);
                        cmdSach.ExecuteNonQuery();

                        if (maTLs != null && maTLs.Length > 0)
                        {
                            string querySachTheLoai = @"INSERT INTO Sach_TheLoai (MaSach, MaTL) VALUES (@MaSach, @MaTL)";
                            foreach (string maTL in maTLs)
                            {
                                if (!string.IsNullOrEmpty(maTL))
                                {
                                    MySqlCommand cmdSachTheLoai = new MySqlCommand(querySachTheLoai, conn, transaction);
                                    cmdSachTheLoai.Parameters.AddWithValue("@MaSach", maSach);
                                    cmdSachTheLoai.Parameters.AddWithValue("@MaTL", maTL);
                                    cmdSachTheLoai.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();
                        if (ex.Number == 1062)
                            throw new Exception($"Mã sách {maSach} đã tồn tại. Vui lòng chọn mã khác.");
                        throw new Exception($"Lỗi khi thêm sách: {ex.Message}");
                    }
                }
            }
        }

        public void UpdateSach(string maSach, string tenSach, string hinhAnh, string tacGia, int namXB, string nhaXB,
                              string tinhTrang, decimal gia, string moTa, string[] maTLs)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string querySach = @"UPDATE Sach SET TenSach = @TenSach, HinhAnh = @HinhAnh, TacGia = @TacGia, 
                                          NamXB = @NamXB, NhaXB = @NhaXB, TinhTrang = @TinhTrang, Gia = @Gia, MoTa = @MoTa 
                                          WHERE MaSach = @MaSach";
                        MySqlCommand cmdSach = new MySqlCommand(querySach, conn, transaction);
                        cmdSach.Parameters.AddWithValue("@MaSach", maSach);
                        cmdSach.Parameters.AddWithValue("@TenSach", tenSach);
                        cmdSach.Parameters.AddWithValue("@HinhAnh", string.IsNullOrEmpty(hinhAnh) ? (object)DBNull.Value : hinhAnh);
                        cmdSach.Parameters.AddWithValue("@TacGia", tacGia);
                        cmdSach.Parameters.AddWithValue("@NamXB", namXB);
                        cmdSach.Parameters.AddWithValue("@NhaXB", nhaXB);
                        cmdSach.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                        cmdSach.Parameters.AddWithValue("@Gia", gia);
                        cmdSach.Parameters.AddWithValue("@MoTa", moTa);
                        int rowsAffected = cmdSach.ExecuteNonQuery();
                        if (rowsAffected == 0)
                            throw new Exception($"Không tìm thấy sách với mã {maSach} để cập nhật.");

                        string deleteSachTheLoai = "DELETE FROM Sach_TheLoai WHERE MaSach = @MaSach";
                        MySqlCommand cmdDelete = new MySqlCommand(deleteSachTheLoai, conn, transaction);
                        cmdDelete.Parameters.AddWithValue("@MaSach", maSach);
                        cmdDelete.ExecuteNonQuery();

                        if (maTLs != null && maTLs.Length > 0)
                        {
                            string querySachTheLoai = "INSERT INTO Sach_TheLoai (MaSach, MaTL) VALUES (@MaSach, @MaTL)";
                            foreach (string maTL in maTLs)
                            {
                                if (!string.IsNullOrEmpty(maTL))
                                {
                                    MySqlCommand cmdSachTheLoai = new MySqlCommand(querySachTheLoai, conn, transaction);
                                    cmdSachTheLoai.Parameters.AddWithValue("@MaSach", maSach);
                                    cmdSachTheLoai.Parameters.AddWithValue("@MaTL", maTL);
                                    cmdSachTheLoai.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Lỗi khi cập nhật sách: {ex.Message}");
                    }
                }
            }
        }

        public void DeleteSach(string maSach)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string deleteSachTheLoai = "DELETE FROM Sach_TheLoai WHERE MaSach = @MaSach";
                        MySqlCommand cmdDeleteSachTheLoai = new MySqlCommand(deleteSachTheLoai, conn, transaction);
                        cmdDeleteSachTheLoai.Parameters.AddWithValue("@MaSach", maSach);
                        cmdDeleteSachTheLoai.ExecuteNonQuery();

                        string deleteSach = "DELETE FROM Sach WHERE MaSach = @MaSach";
                        MySqlCommand cmdDeleteSach = new MySqlCommand(deleteSach, conn, transaction);
                        cmdDeleteSach.Parameters.AddWithValue("@MaSach", maSach);
                        int rowsAffected = cmdDeleteSach.ExecuteNonQuery();

                        if (rowsAffected == 0)
                            throw new Exception($"Không tìm thấy sách với mã {maSach} để xóa.");

                        transaction.Commit();
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();
                        if (ex.Number == 1451)
                            throw new Exception($"Sách với mã {maSach} đang liên kết với dữ liệu khác, không thể xóa!");
                        throw new Exception($"Lỗi khi xóa sách: {ex.Message}");
                    }
                }
            }
        }

        public int DemTongSach()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SUM(SoLuongConLai) FROM KhoSach";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm tổng số sách (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }



        public int DemTongDauSach()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Sach";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm tổng đầu sách (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public int DemSachMatHong()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SUM(SoLuong) FROM Sach WHERE TinhTrang IN ('Hỏng', 'Mất')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm sách mất/hỏng (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public Dictionary<string, int> ThongKeSachTheoTheLoai()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT tls.TenTheLoai, COUNT(stl.MaSach) AS SoLuong 
                                    FROM Sach_TheLoai stl 
                                    LEFT JOIN TheLoaiSach tls ON stl.MaTL = tls.MaTL 
                                    GROUP BY tls.TenTheLoai";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<string, int> thongKe = new Dictionary<string, int>();
                    while (reader.Read())
                    {
                        string theLoai = reader["TenTheLoai"].ToString();
                        int soLuong = Convert.ToInt32(reader["SoLuong"]);
                        thongKe[theLoai] = soLuong;
                    }
                    reader.Close();
                    return thongKe;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê sách theo thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public Dictionary<string, int> ThongKeSachTheoNhaXuatBan()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT NhaXB, SUM(SoLuong) AS SoLuong FROM Sach GROUP BY NhaXB";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<string, int> thongKe = new Dictionary<string, int>();
                    while (reader.Read())
                    {
                        string nhaXB = reader["NhaXB"].ToString();
                        int soLuong = Convert.ToInt32(reader["SoLuong"]);
                        thongKe[nhaXB] = soLuong;
                    }
                    reader.Close();
                    return thongKe;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê sách theo nhà xuất bản (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public Dictionary<string, int> ThongKeSachTheoTacGia()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TacGia, SUM(SoLuong) AS SoLuong FROM Sach GROUP BY TacGia";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<string, int> thongKe = new Dictionary<string, int>();
                    while (reader.Read())
                    {
                        string tacGia = reader["TacGia"].ToString();
                        int soLuong = Convert.ToInt32(reader["SoLuong"]);
                        thongKe[tacGia] = soLuong;
                    }
                    reader.Close();
                    return thongKe;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê sách theo tác giả (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public Dictionary<string, int> ThongKeSachTheoNamXuatBan()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT NamXB, SUM(SoLuong) AS SoLuong FROM Sach GROUP BY NamXB";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<string, int> thongKe = new Dictionary<string, int>();
                    while (reader.Read())
                    {
                        string namXB = reader["NamXB"].ToString();
                        int soLuong = Convert.ToInt32(reader["SoLuong"]);
                        thongKe[namXB] = soLuong;
                    }
                    reader.Close();
                    return thongKe;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê sách theo năm xuất bản (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public Dictionary<string, int> ThongKeNhapSachTheoThang()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DATE_FORMAT(NgayNhap, '%Y-%m') AS Thang, SUM(SoLuong) AS SoLuong FROM LichSuNhapXuat WHERE Loai = 'Nhập' GROUP BY Thang";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<string, int> thongKe = new Dictionary<string, int>();
                    while (reader.Read())
                    {
                        string thang = reader["Thang"].ToString();
                        int soLuong = Convert.ToInt32(reader["SoLuong"]);
                        thongKe[thang] = soLuong;
                    }
                    reader.Close();
                    return thongKe;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê sách nhập theo tháng (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }
        public DataTable GetThongKeSachTheoTheLoai()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT tls.TenTheLoai, SUM(s.SoLuong) AS SoLuong 
                                    FROM Sach s 
                                    LEFT JOIN TheLoaiSach tls ON s.MaTL = tls.MaTL 
                                    GROUP BY tls.TenTheLoai";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy thống kê sách theo thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public DataTable GetThongKeSachTheoNhaXuatBan()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT NhaXB, SUM(SoLuong) AS SoLuong FROM Sach GROUP BY NhaXB";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy thống kê sách theo nhà xuất bản (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public DataTable GetThongKeSachTheoTacGia()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TacGia, SUM(SoLuong) AS SoLuong FROM Sach GROUP BY TacGia";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy thống kê sách theo tác giả (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public DataTable GetThongKeSachTheoNamXuatBan()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT NamXB, SUM(SoLuong) AS SoLuong FROM Sach GROUP BY NamXB";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy thống kê sách theo năm xuất bản (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public DataTable GetThongKeTonKho()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TenSach, SoLuong FROM Sach ORDER BY SoLuong DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy thống kê tồn kho (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public DataTable GetThongKeTinhTrangSach()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TinhTrang, SUM(SoLuong) AS SoLuong FROM Sach GROUP BY TinhTrang";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy thống kê tình trạng sách (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

    }
}