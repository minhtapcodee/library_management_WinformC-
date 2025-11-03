using System.Data;
using MySql.Data.MySqlClient;

namespace QUANLYTHUVIENC3.DAL
{
    public class PhanQuyenDAL
    {
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=quanlythuvien;User ID=root;Password=minh123;SslMode=none";

        public DataTable GetUsersWithPagination(int page, int pageSize)
        {
            int offset = (page - 1) * pageSize;
            string query = @"
SELECT ID, Username, Role, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email
FROM Users
LIMIT @PageSize OFFSET @Offset";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    command.Parameters.AddWithValue("@Offset", offset);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Console.WriteLine($"GetUsersWithPagination: Page={page}, PageSize={pageSize}, Rows={dt.Rows.Count}");
                        return dt;
                    }
                }
            }
        }

        public int GetTotalUserCount()
        {
            string query = "SELECT COUNT(*) FROM Users";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int total = Convert.ToInt32(command.ExecuteScalar());
                    Console.WriteLine($"GetTotalUserCount: Total={total}");
                    return total;
                }
            }
        }

        public DataTable SearchUsersWithPagination(string keyword, int page, int pageSize)
        {
            int offset = (page - 1) * pageSize;
            string query = @"
SELECT ID, Username, Role, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email
FROM Users
WHERE Username LIKE @Keyword
OR Role LIKE @Keyword
OR HoTen LIKE @Keyword
OR GioiTinh LIKE @Keyword
OR DiaChi LIKE @Keyword
OR SDT LIKE @Keyword
OR Email LIKE @Keyword
LIMIT @PageSize OFFSET @Offset";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    command.Parameters.AddWithValue("@Offset", offset);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Console.WriteLine($"SearchUsersWithPagination: Keyword={keyword}, Page={page}, PageSize={pageSize}, Rows={dt.Rows.Count}");
                        return dt;
                    }
                }
            }
        }

        public int GetTotalUserCountWithSearch(string keyword)
        {
            string query = @"
SELECT COUNT(*)
FROM Users
WHERE Username LIKE @Keyword
OR Role LIKE @Keyword
OR HoTen LIKE @Keyword
OR GioiTinh LIKE @Keyword
OR DiaChi LIKE @Keyword
OR SDT LIKE @Keyword
OR Email LIKE @Keyword";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    int total = Convert.ToInt32(command.ExecuteScalar());
                    Console.WriteLine($"GetTotalUserCountWithSearch: Keyword={keyword}, Total={total}");
                    return total;
                }
            }
        }

        public DataTable FilterUsersWithPagination(string role, string keyword, int page, int pageSize)
        {
            int offset = (page - 1) * pageSize;
            string query = @"
SELECT ID, Username, Role, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email
FROM Users
WHERE (Username LIKE @Keyword
OR Role LIKE @Keyword
OR HoTen LIKE @Keyword
OR GioiTinh LIKE @Keyword
OR DiaChi LIKE @Keyword
OR SDT LIKE @Keyword
OR Email LIKE @Keyword)
AND (@Role IS NULL OR Role = @Role)
LIMIT @PageSize OFFSET @Offset";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    command.Parameters.AddWithValue("@Role", string.IsNullOrEmpty(role) ? (object)DBNull.Value : role);
                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    command.Parameters.AddWithValue("@Offset", offset);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Console.WriteLine($"FilterUsersWithPagination: Role={role}, Keyword={keyword}, Page={page}, PageSize={pageSize}, Rows={dt.Rows.Count}");
                        return dt;
                    }
                }
            }
        }

        public int GetTotalUserCountWithFilter(string role, string keyword)
        {
            string query = @"
SELECT COUNT(*)
FROM Users
WHERE (Username LIKE @Keyword
OR Role LIKE @Keyword
OR HoTen LIKE @Keyword
OR GioiTinh LIKE @Keyword
OR DiaChi LIKE @Keyword
OR SDT LIKE @Keyword
OR Email LIKE @Keyword)
AND (@Role IS NULL OR Role = @Role)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    command.Parameters.AddWithValue("@Role", string.IsNullOrEmpty(role) ? (object)DBNull.Value : role);
                    int total = Convert.ToInt32(command.ExecuteScalar());
                    Console.WriteLine($"GetTotalUserCountWithFilter: Role={role}, Keyword={keyword}, Total={total}");
                    return total;
                }
            }
        }

        // Cập nhật Role của người dùng
        public bool UpdateUserRole(int userId, string newRole)
        {
            string query = "UPDATE Users SET Role = @NewRole WHERE ID = @UserId";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewRole", newRole);
                    command.Parameters.AddWithValue("@UserId", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"UpdateUserRole: UserId={userId}, NewRole={newRole}, RowsAffected={rowsAffected}");
                    return rowsAffected > 0;
                }
            }
        }
    }
}