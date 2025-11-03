using MySql.Data.MySqlClient;

namespace QUANLYTHUVIENC3.DAL
{
    public class DatabaseConnection
    {
        private string connectionString = "SERVER=LOCALHOST;DATABASE=QuanLyThuVien;UID=root;PASSWORD=minh123;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}