using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QUANLYTHUVIENC3.DAL
{
    public class NgayCongAdminDAL
    {
        private string connectionString = "SERVER=LOCALHOST;DATABASE=QuanLyThuVien;UID=root;PASSWORD=minh123;";

        public DataTable GetAllChamCong()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT cc.ChamCongID, cc.UserID, u.HoTen, cc.NgayChamCong, cc.GioVao, cc.GioRa, 
                                     cc.HinhAnh, cc.GhiChu, cc.TrangThai, cc.NgayXacNhan, cc.AdminXacNhanID
                                     FROM ChamCong cc
                                     JOIN Users u ON cc.UserID = u.ID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching all ChamCong data: " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable GetChamCongByTrangThai(string trangThai)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT cc.ChamCongID, cc.UserID, u.HoTen, cc.NgayChamCong, cc.GioVao, cc.GioRa, 
                                     cc.HinhAnh, cc.GhiChu, cc.TrangThai, cc.NgayXacNhan, cc.AdminXacNhanID
                                     FROM ChamCong cc
                                     JOIN Users u ON cc.UserID = u.ID";
                    if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                    {
                        query += " WHERE cc.TrangThai = @TrangThai";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                    {
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching ChamCong by TrangThai: " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable GetChamCongByFilters(string trangThai, DateTime? ngayChamCong)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT cc.ChamCongID, cc.UserID, u.HoTen, cc.NgayChamCong, cc.GioVao, cc.GioRa, 
                                     cc.HinhAnh, cc.GhiChu, cc.TrangThai, cc.NgayXacNhan, cc.AdminXacNhanID
                                     FROM ChamCong cc
                                     JOIN Users u ON cc.UserID = u.ID";
                    bool hasCondition = false;
                    if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                    {
                        query += " WHERE cc.TrangThai = @TrangThai";
                        hasCondition = true;
                    }
                    if (ngayChamCong.HasValue)
                    {
                        query += hasCondition ? " AND DATE(cc.NgayChamCong) = @NgayChamCong" : " WHERE DATE(cc.NgayChamCong) = @NgayChamCong";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                    {
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    }
                    if (ngayChamCong.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@NgayChamCong", ngayChamCong.Value.Date);
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching ChamCong by filters: " + ex.Message);
                }
            }
            return dt;
        }

        public void UpdateChamCong(int chamCongId, string gioVao, string gioRa, string ghiChu, string trangThai, DateTime? ngayXacNhan)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE ChamCong 
                                    SET GioVao = @GioVao, GioRa = @GioRa, GhiChu = @GhiChu, 
                                        TrangThai = @TrangThai, NgayXacNhan = @NgayXacNhan
                                    WHERE ChamCongID = @ChamCongId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ChamCongId", chamCongId);
                    cmd.Parameters.AddWithValue("@GioVao", gioVao);
                    cmd.Parameters.AddWithValue("@GioRa", gioRa);
                    cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrWhiteSpace(ghiChu) ? (object)DBNull.Value : ghiChu);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@NgayXacNhan", ngayXacNhan.HasValue ? (object)ngayXacNhan.Value : DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating ChamCong record: " + ex.Message);
                }
            }
        }
        public DataTable GetNhanVienKhongChamCong(DateTime date)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT u.ID, u.HoTen
                                     FROM Users u
                                     WHERE u.ID NOT IN (
                                         SELECT cc.UserID 
                                         FROM ChamCong cc 
                                         WHERE DATE(cc.NgayChamCong) = @NgayChamCong
                                     )";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NgayChamCong", date.ToString("yyyy-MM-dd"));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching employees not checked in: " + ex.Message);
                }
            }
            return dt;
        }
        public DataTable GetChamCongByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT cc.ChamCongID, cc.UserID, u.HoTen, cc.NgayChamCong, cc.GioVao, cc.GioRa, 
                                     cc.HinhAnh, cc.GhiChu, cc.TrangThai, cc.NgayXacNhan, cc.AdminXacNhanID
                                     FROM ChamCong cc
                                     JOIN Users u ON cc.UserID = u.ID
                                     WHERE DATE(cc.NgayChamCong) = @NgayChamCong";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NgayChamCong", date.ToString("yyyy-MM-dd"));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching ChamCong by date: " + ex.Message);
                }
            }
            return dt;
        }
        public DataTable SearchChamCong(string hoTen, string trangThai, DateTime? ngayChamCong)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT cc.ChamCongID, cc.UserID, u.HoTen, cc.NgayChamCong, cc.GioVao, cc.GioRa, 
                                     cc.HinhAnh, cc.GhiChu, cc.TrangThai, cc.NgayXacNhan, cc.AdminXacNhanID
                                     FROM ChamCong cc
                                     JOIN Users u ON cc.UserID = u.ID
                                     WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(hoTen))
                        query += " AND u.HoTen LIKE @HoTen";
                    if (!string.IsNullOrWhiteSpace(trangThai) && trangThai != "Tất cả")
                        query += " AND cc.TrangThai = @TrangThai";
                    if (ngayChamCong.HasValue)
                        query += " AND DATE(cc.NgayChamCong) = @NgayChamCong";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(hoTen))
                        cmd.Parameters.AddWithValue("@HoTen", "%" + hoTen + "%");
                    if (!string.IsNullOrWhiteSpace(trangThai) && trangThai != "Tất cả")
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    if (ngayChamCong.HasValue)
                        cmd.Parameters.AddWithValue("@NgayChamCong", ngayChamCong.Value.ToString("yyyy-MM-dd"));

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error searching ChamCong: " + ex.Message);
                }
            }
            return dt;
        }

    }
}