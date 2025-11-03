using System;
using System.Data;
using QUANLYTHUVIENC3.DAL;

namespace QUANLYTHUVIENC3.BLL
{
    public class NgayCongAdminBLL
    {
        private NgayCongAdminDAL ngayCongAdminDAL = new NgayCongAdminDAL();

        public DataTable GetAllChamCong()
        {
            try
            {
                return ngayCongAdminDAL.GetAllChamCong();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }

        public DataTable GetChamCongByTrangThai(string trangThai)
        {
            try
            {
                return ngayCongAdminDAL.GetChamCongByTrangThai(trangThai);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }

        public DataTable GetChamCongByFilters(string trangThai, DateTime? ngayChamCong)
        {
            try
            {
                return ngayCongAdminDAL.GetChamCongByFilters(trangThai, ngayChamCong);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }

        public void UpdateChamCong(int chamCongId, string gioVao, string gioRa, string ghiChu, string trangThai, DateTime? ngayXacNhan)
        {
            try
            {
                ngayCongAdminDAL.UpdateChamCong(chamCongId, gioVao, gioRa, ghiChu, trangThai, ngayXacNhan);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }
        public DataTable GetChamCongByDate(DateTime date)
        {
            try
            {
                return ngayCongAdminDAL.GetChamCongByDate(date);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }

        public DataTable GetNhanVienKhongChamCong(DateTime date)
        {
            try
            {
                return ngayCongAdminDAL.GetNhanVienKhongChamCong(date);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }
        public DataTable SearchChamCong(string hoTen, string trangThai, DateTime? ngayChamCong)
        {
            try
            {
                return ngayCongAdminDAL.SearchChamCong(hoTen, trangThai, ngayChamCong);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }
    }
}