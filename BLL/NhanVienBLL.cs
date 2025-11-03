using System.Data;
using QUANLYTHUVIENC3.DAL;

namespace QUANLYTHUVIENC3.BLL
{
    public class NhanvienBLL
    {
        NhanvienDAL dal = new NhanvienDAL();

        public DataTable GetNhanVienList()
        {
            return dal.GetNhanVienList();
        }

        public DataTable SearchNhanVien(string keyword)
        {
            return dal.SearchNhanVien(keyword);
        }

        public DataTable FilterByGioiTinh(string gioiTinh)
        {
            return dal.FilterByGioiTinh(gioiTinh);
        }

        public void DeleteNhanVien(int id)
        {
            dal.DeleteNhanVien(id);
        }

        public void AddNhanVien(string hoTen, string username, string password, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            dal.AddNhanVien(hoTen, username, password, gioiTinh, ngaySinh, diaChi, sdt, email);
        }

        public void UpdateNhanVien(int id, string hoTen, string username, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            dal.UpdateNhanVien(id, hoTen, username, gioiTinh, ngaySinh, diaChi, sdt, email);
        }
    }
}