using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QUANLYTHUVIENC3.DAL
{
    class KhoSachDAL
    {
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=quanlythuvien;User ID=root;Password=minh123;SslMode=none";

        public DataTable GetKhoSach()
        {
            string query = @"
        SELECT ks.MaKho,  -- Thêm cột MaKho
               ks.MaSach, 
               s.TenSach, 
               tl.TenTheLoai, 
               ks.SoLuongNhap, 
               (SELECT COUNT(*) 
                FROM MuonTra mt 
                WHERE mt.MaSach = ks.MaSach 
                  AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)')) AS SoLuongDangMuon,
               ks.SoLuongNhap - (SELECT COUNT(*) 
                                 FROM MuonTra mt 
                                 WHERE mt.MaSach = ks.MaSach 
                                   AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)')) AS SoLuongConLai,
               ks.MaNhanVien, 
               ks.NgayNhap, 
               ks.MoTa
        FROM KhoSach ks
        JOIN Sach s ON ks.MaSach = s.MaSach
        JOIN Sach_TheLoai st ON s.MaSach = st.MaSach
        JOIN TheLoaiSach tl ON st.MaTL = tl.MaTL";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable SearchKhoSach(string keyword)
        {
            string query = @"
        SELECT ks.MaKho,  -- Thêm cột MaKho
               ks.MaSach, 
               s.TenSach, 
               tl.TenTheLoai, 
               ks.SoLuongNhap, 
               (SELECT COUNT(*) 
                FROM MuonTra mt 
                WHERE mt.MaSach = ks.MaSach 
                  AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)')) AS SoLuongDangMuon,
               ks.SoLuongNhap - (SELECT COUNT(*) 
                                 FROM MuonTra mt 
                                 WHERE mt.MaSach = ks.MaSach 
                                   AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)')) AS SoLuongConLai,
               ks.MaNhanVien, 
               ks.NgayNhap, 
               ks.MoTa
        FROM KhoSach ks
        JOIN Sach s ON ks.MaSach = s.MaSach
        JOIN Sach_TheLoai st ON s.MaSach = st.MaSach
        JOIN TheLoaiSach tl ON st.MaTL = tl.MaTL
        WHERE s.TenSach LIKE @Keyword
           OR tl.TenTheLoai LIKE @Keyword
           OR ks.MaSach LIKE @Keyword";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public bool DeleteKhoSach(int maKho) // Đổi tham số từ maSach thành maKho
        {
            string query = "DELETE FROM KhoSach WHERE MaKho = @MaKho";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKho", maKho);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Thêm phương thức lấy danh sách sách
        public DataTable GetSach()
        {
            string query = @"
SELECT MaSach, TenSach
FROM Sach
WHERE TinhTrang = 'Còn'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Console.WriteLine($"Số sách có TinhTrang 'Còn': {dt.Rows.Count}");
                        return dt;
                    }
                }
            }
        }

        // Thêm phương thức lấy danh sách nhân viên
        public DataTable GetNhanVien()
        {
            string query = "SELECT ID, HoTen FROM Users WHERE Role = 'Nhân viên'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Thêm phương thức thêm sách vào kho
        public bool AddKhoSach(string maSach, int soLuongNhap, string ngayNhap, string moTa, int maNhanVien)
        {
            string query = @"
                INSERT INTO KhoSach (MaSach, SoLuongNhap, SoLuongDangMuon, SoLuongConLai, NgayNhap, MoTa, MaNhanVien) 
                VALUES (@MaSach, @SoLuongNhap, 0, @SoLuongNhap, @NgayNhap, @MoTa, @MaNhanVien)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSach", maSach);
                    command.Parameters.AddWithValue("@SoLuongNhap", soLuongNhap);
                    command.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                    command.Parameters.AddWithValue("@MoTa", moTa);
                    command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateKhoSach(int maKho, int soLuongNhap, DateTime ngayNhap, string moTa)
        {
            string query = @"
        UPDATE KhoSach 
        SET SoLuongNhap = @SoLuongNhap, 
            NgayNhap = @NgayNhap, 
            MoTa = @MoTa 
        WHERE MaKho = @MaKho";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKho", maKho);
                    command.Parameters.AddWithValue("@SoLuongNhap", soLuongNhap);
                    command.Parameters.AddWithValue("@NgayNhap", ngayNhap.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@MoTa", moTa);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public DataTable GetLowStockBooks(int threshold = 5)
        {
            string query = @"
        SELECT ks.MaKho, ks.MaSach, s.TenSach, tl.TenTheLoai, ks.SoLuongNhap, 
               (SELECT COUNT(*) 
                FROM MuonTra mt 
                WHERE mt.MaSach = ks.MaSach 
                  AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)')) AS SoLuongDangMuon,
               ks.SoLuongNhap - (SELECT COUNT(*) 
                                 FROM MuonTra mt 
                                 WHERE mt.MaSach = ks.MaSach 
                                   AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)')) AS SoLuongConLai
        FROM KhoSach ks
        JOIN Sach s ON ks.MaSach = s.MaSach
        JOIN Sach_TheLoai st ON s.MaSach = st.MaSach
        JOIN TheLoaiSach tl ON st.MaTL = tl.MaTL
        WHERE (ks.SoLuongNhap - (SELECT COUNT(*) 
                                 FROM MuonTra mt 
                                 WHERE mt.MaSach = ks.MaSach 
                                   AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)'))) <= @Threshold";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Threshold", threshold);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetLichSuNhapXuat()
        {
            string query = @"
                SELECT ls.ID, ls.MaSach, ls.TenSach, ls.LoaiGiaoDich, ls.SoLuong, ls.NgayGiaoDich, ls.MaNhanVien, ls.MoTa
                FROM LichSuNhapXuat ls
                ORDER BY ls.NgayGiaoDich DESC";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public void AddLichSuNhapXuat(string maSach, string tenSach, string loaiGiaoDich, int soLuong, DateTime ngayGiaoDich, int maNhanVien, string moTa)
        {
            string query = @"
        INSERT INTO LichSuNhapXuat (MaSach, TenSach, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNhanVien, MoTa)
        VALUES (@MaSach, @TenSach, @LoaiGiaoDich, @SoLuong, @NgayGiaoDich, @MaNhanVien, @MoTa)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSach", maSach);
                    command.Parameters.AddWithValue("@TenSach", tenSach);
                    command.Parameters.AddWithValue("@LoaiGiaoDich", loaiGiaoDich);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@NgayGiaoDich", ngayGiaoDich.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    command.Parameters.AddWithValue("@MoTa", moTa ?? (object)DBNull.Value);
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable FilterKhoSachByDate(string ngayNhap)
        {
            string query = @"
        SELECT ks.MaKho,  
               ks.MaSach, 
               s.TenSach, 
               tl.TenTheLoai, 
               ks.SoLuongNhap, 
               (SELECT COUNT(*) 
                FROM MuonTra mt 
                WHERE mt.MaSach = ks.MaSach 
                  AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)')) AS SoLuongDangMuon,
               ks.SoLuongNhap - (SELECT COUNT(*) 
                                 FROM MuonTra mt 
                                 WHERE mt.MaSach = ks.MaSach 
                                   AND mt.TrangThai IN ('Đang mượn', 'Quá hạn (chưa trả)')) AS SoLuongConLai,
               ks.MaNhanVien, 
               ks.NgayNhap, 
               ks.MoTa
        FROM KhoSach ks
        JOIN Sach s ON ks.MaSach = s.MaSach
        JOIN Sach_TheLoai st ON s.MaSach = st.MaSach
        JOIN TheLoaiSach tl ON st.MaTL = tl.MaTL
        WHERE DATE(ks.NgayNhap) = @NgayNhap";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public bool DeleteLichSuNhapXuat(int id)
        {
            string query = "DELETE FROM LichSuNhapXuat WHERE ID = @ID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}