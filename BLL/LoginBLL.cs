using QUANLYTHUVIENC3.DAL;

namespace QUANLYTHUVIENC3.BLL
{
    public class LoginResult
    {
       
            public string UserId { get; set; } = ""; // Default to empty string to avoid null
            public string Role { get; set; } = "";   // Default to empty string to avoid null
        
    }

    public class LoginBLL
    {
        private LoginDAL loginDAL = new LoginDAL();

        public string CheckLogin(string username, string password)
        {
            return loginDAL.GetUserRole(username, password);
        }

        public string GetMaDocGia(string username, string password)
        {
            return loginDAL.GetMaDocGia(username, password);
        }

        public LoginResult CheckLoginWithId(string username, string password)
        {
            return loginDAL.CheckLogin(username, password);
        }
    }
}