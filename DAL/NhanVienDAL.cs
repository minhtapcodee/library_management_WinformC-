using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QUANLYTHUVIENC3.DAL
{
    public class NhanvienDAL
    {
        private string connectionString = "Server = 127.0.0.1; Port = 3306; Database = quanlythuvien; User ID = root; Password = minh123; SslMode = none;";

        public DataTable GetNhanVienList()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID, Username, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email FROM Users WHERE Role = 'Nhân viên'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable SearchNhanVien(string keyword)
        {
            DataTable dt = new DataTable();
            string query = @"
            SELECT ID, Username, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email
            FROM Users
            WHERE Role = 'Nhân viên' AND
                  (HoTen LIKE @keyword OR Username LIKE @keyword OR Email LIKE @keyword)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable FilterByGioiTinh(string gioiTinh)
        {
            DataTable dt = new DataTable();
            string query = "SELECT ID, Username, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email FROM Users WHERE Role = 'Nhân viên'";
            if (gioiTinh != "Tất cả")
            {
                query += " AND GioiTinh = @GioiTinh";
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (gioiTinh != "Tất cả")
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        }
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lọc: " + ex.Message);
                }
            }
            return dt;
        }

        public void DeleteNhanVien(int id)
        {
            string query = "DELETE FROM Users WHERE ID = @ID AND Role = 'Nhân viên'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi xóa nhân viên: " + ex.Message);
                }
            }
        }

        public void AddNhanVien(string hoTen, string username, string password, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            string query = @"
            INSERT INTO Users (Role, HoTen, Username, Password, GioiTinh, NgaySinh, DiaChi, SDT, Email)
            VALUES ('Nhân viên', @HoTen, @Username, @Password, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
                }
            }
        }

        public void UpdateNhanVien(int id, string hoTen, string username, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            string query = @"
            UPDATE Users
            SET HoTen = @HoTen, Username = @Username, GioiTinh = @GioiTinh,
                NgaySinh = @NgaySinh, DiaChi = @DiaChi,
                SDT = @SDT, Email = @Email
            WHERE ID = @ID AND Role = 'Nhân viên'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi cập nhật nhân viên: " + ex.Message);
                }
            }
        }
    }
}