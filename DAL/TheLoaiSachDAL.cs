using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace QUANLYTHUVIENC3.DAL
{
    public class TheLoaiSachDAL
    {
        private DatabaseConnection db = new DatabaseConnection();

        public DataTable GetAllTheLoaiSach()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaTL, TenTheLoai FROM TheLoaiSach";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy danh sách thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public DataTable GetTheLoaiSachByPage(int pageNumber, int pageSize)
        {
            if (pageNumber < 1 || pageSize < 1)
                throw new ArgumentException("Số trang và kích thước trang phải lớn hơn 0!");

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    int offset = (pageNumber - 1) * pageSize;
                    string query = "SELECT MaTL, TenTheLoai FROM TheLoaiSach LIMIT @PageSize OFFSET @Offset";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);
                    cmd.Parameters.AddWithValue("@Offset", offset);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi lấy danh sách thể loại theo trang (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public int GetTotalRecords()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TheLoaiSach";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm số lượng thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public void AddTheLoaiSach(string maTL, string tenTheLoai)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO TheLoaiSach (MaTL, TenTheLoai) VALUES (@MaTL, @TenTheLoai)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaTL", maTL);
                    cmd.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        throw new Exception($"Mã thể loại {maTL} đã tồn tại. Vui lòng chọn mã khác.");
                    throw new Exception($"Lỗi khi thêm thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public void UpdateTheLoaiSach(string maTL, string tenTheLoai)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE TheLoaiSach SET TenTheLoai = @TenTheLoai WHERE MaTL = @MaTL";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaTL", maTL);
                    cmd.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception($"Không tìm thấy thể loại với mã {maTL} để cập nhật.");
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi cập nhật thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public void DeleteTheLoaiSach(string maTL)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // Xóa thể loại
                        string deleteQuery = "DELETE FROM TheLoaiSach WHERE MaTL = @MaTL";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn, transaction);
                        deleteCmd.Parameters.AddWithValue("@MaTL", maTL);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                            throw new Exception($"Không tìm thấy thể loại với mã {maTL} để xóa.");

                        transaction.Commit();
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi xóa thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }

        public int DemTongTheLoai()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TheLoaiSach";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Lỗi khi đếm tổng thể loại (Mã lỗi: {ex.Number}): {ex.Message}");
                }
            }
        }
    }
}