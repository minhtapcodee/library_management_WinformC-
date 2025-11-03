// MuonTraDAL.cs
using System.Data;
using MySql.Data.MySqlClient;

namespace QUANLYTHUVIENC3.DAL
{
    public class MuonTraDAL
    {
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=quanlythuvien;User ID=root;Password=minh123;SslMode=none";
        private DatabaseConnection db = new DatabaseConnection();
        public DataTable LayTatCaMuonTra()
        {
            string query = @"
    SELECT mt.MaMT, s.TenSach, s.TacGia, tl.TenTheLoai,
           dg.HoTen AS TenNguoiMuon, dg.SDT AS SDTDocGia,
           dg.Username AS MaNguoiMuon_Username,
           nv.HoTen AS TenNhanVien, nv.Username AS MaNhanVien_Username,
           mt.NgayMuon, mt.NgayTraDuKien, mt.NgayTraThucTe, mt.TienPhat, mt.TrangThai
    FROM MuonTra mt
    JOIN Sach s ON mt.MaSach = s.MaSach
    JOIN Sach_TheLoai stl ON s.MaSach = stl.MaSach
    JOIN TheLoaiSach tl ON stl.MaTL = tl.MaTL
    JOIN Users dg ON mt.MaNguoiMuon = dg.ID AND dg.Role = 'Độc giả'
    JOIN Users nv ON mt.MaNhanVien = nv.ID AND nv.Role = 'Nhân viên';";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dt);

                    // Thêm đoạn log để kiểm tra số lượng bản ghi trả về
                    Console.WriteLine($"Số dòng trả về từ MuonTra: {dt.Rows.Count}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi thực thi câu lệnh SQL: {ex.Message}");
                }

                return dt;
            }
        }



        public DataTable TimKiemMuonTra(string keyword)
        {
            string query = @"
    SELECT mt.MaMT, s.TenSach, s.TacGia, tl.TenTheLoai,
           dg.HoTen AS TenNguoiMuon, dg.SDT AS SDTDocGia,
           dg.Username AS MaNguoiMuon_Username,
           nv.HoTen AS TenNhanVien, nv.Username AS MaNhanVien_Username,
           mt.NgayMuon, mt.NgayTraDuKien, mt.NgayTraThucTe, mt.TienPhat, mt.TrangThai
    FROM MuonTra mt
    JOIN Sach s ON mt.MaSach = s.MaSach
    JOIN Sach_TheLoai stl ON s.MaSach = stl.MaSach
    JOIN TheLoaiSach tl ON stl.MaTL = tl.MaTL
    JOIN Users dg ON mt.MaNguoiMuon = dg.ID AND dg.Role = 'Độc giả'
    JOIN Users nv ON mt.MaNhanVien = nv.ID AND nv.Role = 'Nhân viên'
    WHERE mt.MaMT LIKE @keyword OR s.TenSach LIKE @keyword OR s.TacGia LIKE @keyword
          OR tl.TenTheLoai LIKE @keyword OR dg.HoTen LIKE @keyword OR nv.HoTen LIKE @keyword;
    ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable LayMuonTraTheoTrangThai(string trangThai)
        {
            string query = @"
    SELECT mt.MaMT, s.TenSach, s.TacGia, tl.TenTheLoai,
           dg.HoTen AS TenNguoiMuon, dg.SDT AS SDTDocGia,
           dg.Username AS MaNguoiMuon_Username,
           nv.HoTen AS TenNhanVien, nv.Username AS MaNhanVien_Username,
           mt.NgayMuon, mt.NgayTraDuKien, mt.NgayTraThucTe, mt.TienPhat, mt.TrangThai
    FROM MuonTra mt
    JOIN Sach s ON mt.MaSach = s.MaSach
    JOIN Sach_TheLoai stl ON s.MaSach = stl.MaSach
    JOIN TheLoaiSach tl ON stl.MaTL = tl.MaTL
    JOIN Users dg ON mt.MaNguoiMuon = dg.ID AND dg.Role = 'Độc giả'
    JOIN Users nv ON mt.MaNhanVien = nv.ID AND nv.Role = 'Nhân viên'
    ";

            if (trangThai != "Tất cả")
            {
                query += " WHERE mt.TrangThai = @trangThai";
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@trangThai", trangThai);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public bool XoaMuonTra(string maMT)
        {
            string query = "DELETE FROM MuonTra WHERE MaMT = @maMT";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maMT", maMT);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0; // Trả về true nếu có bản ghi bị xóa
            }
        }
        public DataTable LayDanhSachTuBang(string tableName, string columns)
        {
            string query = $"SELECT {columns} FROM {tableName}";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable LayDocGia()
        {
            string query = "SELECT ID, HoTen FROM Users WHERE Role = 'Độc giả'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable LayNhanVien()
        {
            string query = "SELECT ID, HoTen FROM Users WHERE Role = 'Nhân viên'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

       
        public DataTable LayThongTinMuonTra(string maMT)
        {
            string query = @"
    SELECT mt.MaMT, s.TenSach, dg.HoTen AS TenNguoiMuon,
           nv.HoTen AS TenNhanVien, mt.NgayMuon, mt.NgayTraDuKien,
           mt.NgayTraThucTe, mt.TienPhat, mt.TrangThai
    FROM MuonTra mt
    JOIN Sach s ON mt.MaSach = s.MaSach
    JOIN Users dg ON mt.MaNguoiMuon = dg.ID
    JOIN Users nv ON mt.MaNhanVien = nv.ID
    WHERE mt.MaMT = @maMT";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maMT", maMT);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public bool CapNhatMuonTra(string maMT, string trangThai, DateTime ngayTraThucTe, decimal tienPhat)
{
    string query = @"
    UPDATE MuonTra
    SET TrangThai = @trangThai, NgayTraThucTe = @ngayTraThucTe, TienPhat = @tienPhat
    WHERE MaMT = @maMT";

    using (MySqlConnection conn = new MySqlConnection(connectionString))
    {
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@maMT", maMT);
        cmd.Parameters.AddWithValue("@trangThai", trangThai);
        cmd.Parameters.AddWithValue("@ngayTraThucTe", ngayTraThucTe);
        cmd.Parameters.AddWithValue("@tienPhat", tienPhat);

        conn.Open();
        int rowsAffected = cmd.ExecuteNonQuery();
        conn.Close();

        return rowsAffected > 0; // Trả về true nếu cập nhật thành công
    }
}
        public int KiemTraSoLuongConLai(string maSach)
        {
            string query = @"
    SELECT SoLuongConLai
    FROM KhoSach
    WHERE MaSach = @maSach";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maSach", maSach);
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();
                if (result != null && result != DBNull.Value)
                {
                    int soLuong = Convert.ToInt32(result);
                    Console.WriteLine($"KiemTraSoLuongConLai: MaSach={maSach}, SoLuongConLai={soLuong}");
                    return soLuong;
                }
                Console.WriteLine($"KiemTraSoLuongConLai: MaSach={maSach}, Không tìm thấy hoặc NULL");
                return 0;
            }
        }

        public bool ThemMuonTra(string maSach, string maNguoiMuon, string maNhanVien, DateTime ngayMuon, DateTime ngayTraDuKien)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                // Kiểm tra MaSach tồn tại
                cmd.CommandText = "SELECT COUNT(*) FROM Sach WHERE MaSach = @maSach";
                cmd.Parameters.AddWithValue("@maSach", maSach);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    conn.Close();
                    throw new Exception("Mã sách không tồn tại. Vui lòng kiểm tra lại!");
                }

                // Kiểm tra SoLuongConLai
                cmd.CommandText = "SELECT SoLuongConLai FROM KhoSach WHERE MaSach = @maSach";
                object result = cmd.ExecuteScalar();
                int soLuongConLai = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                Console.WriteLine($"ThemMuonTra: MaSach={maSach}, SoLuongConLai={soLuongConLai}");
                if (soLuongConLai < 5)
                {
                    conn.Close();
                    throw new Exception("Sách này đang không còn trong kho, không thể cho mượn!");
                }

                // Thêm giao dịch
                cmd.CommandText = @"
        INSERT INTO MuonTra (MaSach, MaNguoiMuon, MaNhanVien, NgayMuon, NgayTraDuKien, TrangThai)
        VALUES (@maSach, @maNguoiMuon, @maNhanVien, @ngayMuon, @ngayTraDuKien, 'Đang mượn')";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@maSach", maSach);
                cmd.Parameters.AddWithValue("@maNguoiMuon", maNguoiMuon);
                cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
                cmd.Parameters.AddWithValue("@ngayMuon", ngayMuon);
                cmd.Parameters.AddWithValue("@ngayTraDuKien", ngayTraDuKien);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Cập nhật KhoSach
                cmd.CommandText = @"
        UPDATE KhoSach
        SET SoLuongDangMuon = SoLuongDangMuon + 1,
            SoLuongConLai = SoLuongNhap - (SoLuongDangMuon + 1)
        WHERE MaSach = @maSach";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@maSach", maSach);
                cmd.ExecuteNonQuery();

                conn.Close();
                return rowsAffected > 0;
            }
        }
        public DataTable LaySachCon()
        {
            string query = @" SELECT MaSach, TenSach FROM Sach WHERE TinhTrang = 'Còn'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Console.WriteLine($"Số sách có TinhTrang 'Còn': {dt.Rows.Count}");
                return dt;
            }

        }
        public DataTable GetMuonTraByMaDocGia(string maDocGia)
        {
            string query = @"
SELECT mt.MaMT AS MaMuonTra, mt.MaSach, s.TenSach, 
       mt.NgayMuon, mt.NgayTraDuKien AS NgayTra, mt.TrangThai AS TinhTrang
FROM MuonTra mt
JOIN Sach s ON mt.MaSach = s.MaSach
WHERE mt.MaNguoiMuon = @maDocGia;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maDocGia", maDocGia);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public Dictionary<string, int> ThongKeTrangThai()
        {
            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            string query = @"SELECT TrangThai, COUNT(*) AS SoLuong FROM MuonTra GROUP BY TrangThai";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string trangThai = reader["TrangThai"].ToString();
                        int soLuong = Convert.ToInt32(reader["SoLuong"]);
                        thongKe[trangThai] = soLuong;
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê trạng thái (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
            return thongKe;
        }

        public int DemSachDangMuon()
        {
            string query = "SELECT COUNT(*) FROM MuonTra WHERE TrangThai = 'Đang mượn'";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm sách đang mượn (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public Dictionary<string, int> ThongKeSoLanMuonCuaSach()
        {
            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            string query = @"
                SELECT s.TenSach, COUNT(*) AS SoLanMuon
                FROM MuonTra mt
                JOIN Sach s ON mt.MaSach = s.MaSach
                GROUP BY s.MaSach, s.TenSach
                ORDER BY SoLanMuon DESC";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string tenSach = reader["TenSach"].ToString();
                        int soLanMuon = Convert.ToInt32(reader["SoLanMuon"]);
                        thongKe[tenSach] = soLanMuon;
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê số lần mượn sách (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
            return thongKe;
        }

        public Dictionary<string, int> ThongKeSachItMuon()
        {
            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            string query = @"
                SELECT s.TenSach, COUNT(mt.MaMT) AS SoLanMuon
                FROM Sach s
                LEFT JOIN MuonTra mt ON s.MaSach = mt.MaSach
                GROUP BY s.MaSach, s.TenSach
                HAVING SoLanMuon <= 1
                ORDER BY SoLanMuon ASC";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string tenSach = reader["TenSach"].ToString();
                        int soLanMuon = Convert.ToInt32(reader["SoLanMuon"]);
                        thongKe[tenSach] = soLanMuon;
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê sách ít mượn (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
            return thongKe;
        }

        public DataTable GetSachChuaMuon()
        {
            string query = @"
                SELECT s.MaSach, s.TenSach
                FROM Sach s
                LEFT JOIN MuonTra mt ON s.MaSach = mt.MaSach
                WHERE mt.MaSach IS NULL";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy sách chưa mượn (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public Dictionary<string, double> ThongKeTyLeMuonTheoTheLoai()
        {
            Dictionary<string, double> thongKe = new Dictionary<string, double>();
            string query = @"
                SELECT tls.TenTheLoai, 
                       COUNT(mt.MaMT) AS SoLanMuon,
                       SUM(s.SoLuong) AS TongSach,
                       (COUNT(mt.MaMT) / SUM(s.SoLuong) * 100) AS TyLe
                FROM Sach s
                LEFT JOIN Sach_TheLoai stl ON s.MaSach = stl.MaSach
                LEFT JOIN TheLoaiSach tls ON stl.MaTL = tls.MaTL
                LEFT JOIN MuonTra mt ON s.MaSach = mt.MaSach
                GROUP BY tls.TenTheLoai";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string theLoai = reader["TenTheLoai"].ToString();
                        double tyLe = reader["TyLe"] != DBNull.Value ? Convert.ToDouble(reader["TyLe"]) : 0;
                        thongKe[theLoai] = tyLe;
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi thống kê tỷ lệ mượn theo thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
            return thongKe;
        }

        public DataTable LayDanhSachNguoiMuonTheoNgay(DateTime ngay)
        {
            string query = @"
                SELECT dg.HoTen, dg.SDT, mt.MaMT, mt.NgayMuon
                FROM MuonTra mt
                JOIN Users dg ON mt.MaNguoiMuon = dg.ID AND dg.Role = 'Độc Giả'
                WHERE DATE(mt.NgayMuon) = @Ngay";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ngay", ngay.Date);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy danh sách người mượn theo ngày (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public int DemSoNguoiMuonTheoNgay(DateTime ngay)
        {
            string query = @"
                SELECT COUNT(DISTINCT mt.MaNguoiMuon)
                FROM MuonTra mt
                WHERE DATE(mt.NgayMuon) = @Ngay";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ngay", ngay.Date);
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm số người mượn theo ngày (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public int DemTongSoLanMuon()
        {
            string query = "SELECT COUNT(*) FROM MuonTra";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm tổng số lần mượn (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public Dictionary<string, int> DemSoLanMuonCuaDocGia(int maDocGia)
        {
            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            string query = @"
                SELECT dg.HoTen, COUNT(mt.MaMT) AS SoLanMuon
                FROM MuonTra mt
                JOIN Users dg ON mt.MaNguoiMuon = dg.ID AND dg.Role = 'Độc Giả'
                GROUP BY dg.HoTen
                ORDER BY SoLanMuon DESC";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string hoTen = reader["HoTen"].ToString();
                        int soLanMuon = Convert.ToInt32(reader["SoLanMuon"]);
                        thongKe[hoTen] = soLanMuon;
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm số lần mượn của độc giả (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
            return thongKe;
        }
        //mthong ke theo ngay 
        public DataTable LayDanhSachSachMuonTheoNgay(DateTime ngay)
        {
            string query = @"
        SELECT s.TenSach, s.TacGia, tl.TenTheLoai, dg.HoTen AS TenNguoiMuon, 
               mt.NgayMuon, mt.TrangThai
        FROM MuonTra mt
        JOIN Sach s ON mt.MaSach = s.MaSach
        LEFT JOIN Sach_TheLoai stl ON s.MaSach = stl.MaSach
        LEFT JOIN TheLoaiSach tl ON stl.MaTL = tl.MaTL
        JOIN Users dg ON mt.MaNguoiMuon = dg.ID AND dg.Role = 'Độc Giả'
        WHERE DATE(mt.NgayMuon) = @Ngay";
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ngay", ngay.Date);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy danh sách sách mượn theo ngày (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }
        // tim kiem va loc theo ngay 
        public DataTable TimKiemVaLocSachMuonTheoNgay(string keyword, DateTime? ngay)
        {
            string query = @"
        SELECT s.TenSach, s.TacGia, tl.TenTheLoai, dg.HoTen AS TenNguoiMuon, 
               mt.NgayMuon, mt.TrangThai
        FROM MuonTra mt
        JOIN Sach s ON mt.MaSach = s.MaSach
        LEFT JOIN Sach_TheLoai stl ON s.MaSach = stl.MaSach
        LEFT JOIN TheLoaiSach tl ON stl.MaTL = tl.MaTL
        JOIN Users dg ON mt.MaNguoiMuon = dg.ID AND dg.Role = 'Độc Giả'
        WHERE (s.TenSach LIKE @keyword OR s.TacGia LIKE @keyword OR dg.HoTen LIKE @keyword OR tl.TenTheLoai LIKE @keyword)";

            if (ngay.HasValue)
            {
                query += " AND DATE(mt.NgayMuon) = @Ngay";
            }

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    if (ngay.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@Ngay", ngay.Value.Date);
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi tìm kiếm và lọc sách mượn theo ngày (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }


    }
}

