using System;
using MySql.Data.MySqlClient;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.DAL
{
    public class LoginDAL
    {
        private string connectionString = "Server = 127.0.0.1; Port = 3306; Database = quanlythuvien; User ID = root; Password = minh123; SslMode = none;";

        public string GetUserRole(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                 conn.Open();
                string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public string GetMaDocGia(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Users WHERE Username = @username AND Password = @password AND Role = 'Độc giả'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public LoginResult CheckLogin(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID, Role FROM Users WHERE Username = @username AND Password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new LoginResult
                                {
                                    UserId = reader["ID"].ToString(),
                                    Role = reader["Role"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Database error during login: " + ex.Message);
                }
                return new LoginResult { Role = "", UserId = "" };
            }
        }
    }
}