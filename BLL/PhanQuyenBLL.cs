using System.Data;
using QUANLYTHUVIENC3.DAL;

namespace QUANLYTHUVIENC3.BLL
{
    public class PhanQuyenBLL
    {
        private PhanQuyenDAL dal = new PhanQuyenDAL();

        public DataTable GetUsersWithPagination(int page, int pageSize)
        {
            return dal.GetUsersWithPagination(page, pageSize);
        }

        public int GetTotalUserCount()
        {
            return dal.GetTotalUserCount();
        }

        public DataTable SearchUsersWithPagination(string keyword, int page, int pageSize)
        {
            return dal.SearchUsersWithPagination(keyword, page, pageSize);
        }

        public int GetTotalUserCountWithSearch(string keyword)
        {
            return dal.GetTotalUserCountWithSearch(keyword);
        }

        public DataTable FilterUsersWithPagination(string role, string keyword, int page, int pageSize)
        {
            return dal.FilterUsersWithPagination(role, keyword, page, pageSize);
        }

        public int GetTotalUserCountWithFilter(string role, string keyword)
        {
            return dal.GetTotalUserCountWithFilter(role, keyword);
        }

        public bool UpdateUserRole(int userId, string newRole)
        {
            return dal.UpdateUserRole(userId, newRole);
        }
    }
}