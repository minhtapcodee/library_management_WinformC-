using MySql.Data.MySqlClient;
using QUANLYTHUVIENC3.DAL;
using System;
using System.Data;

namespace QUANLYTHUVIENC3.DAL
{
    public class DocGiaDAL
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        public DataTable GetAllDocGia()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Users WHERE Role = 'Độc giả'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi lấy danh sách độc giả: {ex.Message}", ex);
                }
            }
        }

        public DataTable GetDocGiaByMaDocGia(string maDocGia)
        {
            if (!int.TryParse(maDocGia, out int docGiaId))
            {
                throw new ArgumentException("Mã độc giả phải là một số nguyên hợp lệ.");
            }

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Users WHERE Role = 'Độc giả' AND ID = @maDocGia";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maDocGia", docGiaId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi lấy thông tin độc giả: {ex.Message}", ex);
                }
            }
        }

        public bool AddDocGia(string username, string password, string hoTen, string gioiTinh,
            DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Users (Username, Password, Role, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email) " +
                                  "VALUES (@username, @password, 'Độc giả', @hoTen, @gioiTinh, @ngaySinh, @diaChi, @sdt, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@hoTen", hoTen);
                    cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi thêm độc giả: {ex.Message}", ex);
                }
            }
        }

        public bool UpdateDocGia(int id, string username, string password, string hoTen, string gioiTinh,
            DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    string query = "UPDATE Users SET Username = @username, Password = @password, HoTen = @hoTen, " +
                                  "GioiTinh = @gioiTinh, NgaySinh = @ngaySinh, DiaChi = @diaChi, SDT = @sdt, Email = @email " +
                                  "WHERE ID = @id AND Role = 'Độc giả'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@hoTen", hoTen);
                    cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi cập nhật độc giả: {ex.Message}", ex);
                }
            }
        }

        public bool HasUnreturnedBooks(int userId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM MuonTra WHERE MaNguoiMuon = @userId AND NGAYTRATHUCTE IS NULL";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi kiểm tra sách chưa trả: {ex.Message}", ex);
                }
            }
        }

        public bool DeleteDocGia(int id)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    if (HasUnreturnedBooks(id))
                    {
                        throw new InvalidOperationException("Độc giả đang mượn sách chưa trả.");
                  }

                    string query = "DELETE FROM Users WHERE ID = @id AND Role = 'Độc giả'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi xóa độc giả: {ex.Message}", ex);
                }
            }
        }

        public DataTable SearchDocGia(string keyword, string gioiTinh, string trangThai)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    string query = "SELECT DISTINCT u.* FROM Users u " +
                                  "LEFT JOIN MuonTra mt ON u.ID = mt.MaNguoiMuon " +
                                  "WHERE u.Role = 'Độc giả' ";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += "AND (u.Username LIKE @keyword OR u.HoTen LIKE @keyword OR u.SDT LIKE @keyword OR u.Email LIKE @keyword) ";
                    }
                    if (!string.IsNullOrEmpty(gioiTinh))
                    {
                        query += "AND u.GioiTinh = @gioiTinh ";
                    }
                    if (!string.IsNullOrEmpty(trangThai))
                    {
                        query += "AND mt.TrangThai = @trangThai ";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }
                    if (!string.IsNullOrEmpty(gioiTinh))
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                    }
                    if (!string.IsNullOrEmpty(trangThai))
                    {
                        cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi tìm kiếm độc giả: {ex.Message}", ex);
                }
            }
        }

        public int DemTongDocGia()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Users WHERE Role = 'Độc giả'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi đếm tổng số độc giả: {ex.Message}", ex);
                }
            }
        }
    }
}