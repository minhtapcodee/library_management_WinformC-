using QUANLYTHUVIENC3.DAL;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace QUANLYTHUVIENC3.BLL
{
    public class DocGiaBLL
    {
        private readonly DocGiaDAL dal = new DocGiaDAL();

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhone(string sdt)
        {
            if (string.IsNullOrWhiteSpace(sdt)) return false;
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(sdt, pattern);
        }

        private bool IsValidNgaySinh(DateTime ngaySinh)
        {
            DateTime minDate = new DateTime(1900, 1, 1);
            return ngaySinh <= DateTime.Now && ngaySinh >= minDate;
        }

        private bool IsUsernameOrEmailExists(string username, string email, int? excludeId = null)
        {
            DataTable dt = dal.SearchDocGia(username, "", "");
            foreach (DataRow row in dt.Rows)
            {
                if ((excludeId == null || Convert.ToInt32(row["ID"]) != excludeId) &&
                    (row["Username"].ToString().Equals(username, StringComparison.OrdinalIgnoreCase) ||
                     row["Email"].ToString().Equals(email, StringComparison.OrdinalIgnoreCase)))
                {
                    return true;
                }
            }
            return false;
        }

        public DataTable GetAllDocGia()
        {
            try
            {
                return dal.GetAllDocGia();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách độc giả: {ex.Message}", ex);
            }
        }

        public DataTable GetDocGiaByMaDocGia(string maDocGia)
        {
            if (!int.TryParse(maDocGia, out _))
            {
                throw new ArgumentException("Mã độc giả phải là một số nguyên hợp lệ.");
            }

            try
            {
                return dal.GetDocGiaByMaDocGia(maDocGia);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin độc giả: {ex.Message}", ex);
            }
        }

        public bool AddDocGia(string username, string password, string hoTen, string gioiTinh,
            DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(gioiTinh) ||
                string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Tất cả các trường thông tin đều bắt buộc.");
            }

            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Email không hợp lệ.");
            }
            if (!IsValidPhone(sdt))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ.");
            }
            if (!IsValidNgaySinh(ngaySinh))
            {
                throw new ArgumentException("Ngày sinh không hợp lệ.");
            }

            if (IsUsernameOrEmailExists(username, email))
            {
                throw new ArgumentException("Username hoặc email đã tồn tại.");
            }

            try
            {
                return dal.AddDocGia(username, password, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm độc giả: {ex.Message}", ex);
            }
        }

        public bool UpdateDocGia(int id, string username, string password, string hoTen, string gioiTinh,
            DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID độc giả không hợp lệ.");
            }
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(gioiTinh) ||
                string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Tất cả các trường thông tin đều bắt buộc.");
            }

            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Email không hợp lệ.");
            }
            if (!IsValidPhone(sdt))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ.");
            }
            if (!IsValidNgaySinh(ngaySinh))
            {
                throw new ArgumentException("Ngày sinh không hợp lệ.");
            }

            if (IsUsernameOrEmailExists(username, email, id))
            {
                throw new ArgumentException("Username hoặc email đã tồn tại.");
            }

            try
            {
                return dal.UpdateDocGia(id, username, password, hoTen, gioiTinh, ngaySinh, diaChi, sdt, email);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật độc giả: {ex.Message}", ex);
            }
        }

        public bool DeleteDocGia(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID độc giả không hợp lệ.");
            }

            try
            {
                return dal.DeleteDocGia(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa độc giả: {ex.Message}", ex);
            }
        }

        public bool HasUnreturnedBooks(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID độc giả không hợp lệ.");
            }

            try
            {
                return dal.HasUnreturnedBooks(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi kiểm tra sách chưa trả: {ex.Message}", ex);
            }
        }

        public DataTable SearchDocGia(string keyword, string gioiTinh, string trangThai)
        {
            try
            {
                return dal.SearchDocGia(keyword, gioiTinh, trangThai);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm độc giả: {ex.Message}", ex);
            }
        }

        public int DemTongDocGia()
        {
            try
            {
                return dal.DemTongDocGia();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đếm tổng số độc giả: {ex.Message}", ex);
            }
        }
    }
}