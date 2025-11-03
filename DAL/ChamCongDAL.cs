using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QUANLYTHUVIENC3.DAL
{
    public class ChamCongDAL
    {
        private string connectionString = "SERVER=LOCALHOST;DATABASE=QuanLyThuVien;UID=root;PASSWORD=minh123;";

        public DataTable GetChamCongByUser(int userId, string role)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;
                    if (role == "Nhân viên")
                    {
                        // For Nhân viên, only fetch their own records
                        query = @"SELECT cc.ChamCongID, cc.UserID, u.HoTen, cc.NgayChamCong, cc.GioVao, cc.GioRa, 
                                        cc.HinhAnh, cc.GhiChu, cc.TrangThai, cc.NgayXacNhan, cc.AdminXacNhanID
                                 FROM ChamCong cc
                                 JOIN Users u ON cc.UserID = u.ID
                                 WHERE cc.UserID = @UserID";
                    }
                    else if (role == "ADMIN")
                    {
                        // For ADMIN, fetch all records
                        query = @"SELECT cc.ChamCongID, cc.UserID, u.HoTen, cc.NgayChamCong, cc.GioVao, cc.GioRa, 
                                        cc.HinhAnh, cc.GhiChu, cc.TrangThai, cc.NgayXacNhan, cc.AdminXacNhanID
                                 FROM ChamCong cc
                                 JOIN Users u ON cc.UserID = u.ID";
                    }
                    else
                    {
                        // For Độc giả or others, return empty (or adjust as needed)
                        return dt;
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (role == "Nhân viên")
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching ChamCong data: " + ex.Message);
                }
            }
            return dt;
        }

        public void AddChamCong(int userId, DateTime ngayChamCong, string gioVao, string gioRa, string hinhAnh, string ghiChu, DateTime? ngayXacNhan)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO ChamCong (UserID, NgayChamCong, GioVao, GioRa, HinhAnh, GhiChu, TrangThai, NgayXacNhan, AdminXacNhanID)
                                    VALUES (@UserID, @NgayChamCong, @GioVao, @GioRa, @HinhAnh, @GhiChu, @TrangThai, @NgayXacNhan, @AdminXacNhanID)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@NgayChamCong", ngayChamCong);
                    cmd.Parameters.AddWithValue("@GioVao", gioVao);
                    cmd.Parameters.AddWithValue("@GioRa", gioRa);
                    cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu ?? (object)DBNull.Value); // Handle null GhiChu
                    cmd.Parameters.AddWithValue("@TrangThai", "Chờ xác nhận"); // Set default status
                    cmd.Parameters.AddWithValue("@NgayXacNhan", (object)DBNull.Value); // Always NULL by default (admin updates later)
                    cmd.Parameters.AddWithValue("@AdminXacNhanID", (object)DBNull.Value); // AdminXacNhanID is NULL for now

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding ChamCong record: " + ex.Message);
                }
            }
        }
    }
}