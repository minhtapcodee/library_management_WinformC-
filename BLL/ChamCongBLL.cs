using System;
using System.Data;
using QUANLYTHUVIENC3.DAL;

namespace QUANLYTHUVIENC3.BLL
{
    public class ChamCongBLL
    {
        private ChamCongDAL chamCongDAL = new ChamCongDAL();

        public DataTable GetChamCongData(int userId, string role)
        {
            try
            {
                return chamCongDAL.GetChamCongByUser(userId, role);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }

        public void AddChamCong(int userId, DateTime ngayChamCong, string gioVao, string gioRa, string hinhAnh, string ghiChu, DateTime? ngayXacNhan)
        {
            try
            {
                // NgayXacNhan will be NULL by default in DAL, ignoring any input value here
                chamCongDAL.AddChamCong(userId, ngayChamCong, gioVao, gioRa, hinhAnh, ghiChu, null);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL: " + ex.Message);
            }
        }
    }
}