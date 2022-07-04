using courseworkAD1.BusinessObjects;
using courseworkAD1.DAL;
using System.Data;
using System.Windows.Forms;

namespace courseworkAD1.BLL
{
    public class UserBLL
    {
        public DialogResult saveNewUser(UserBO obj)
        {
            try
            {
                UserDAL userDA = new UserDAL();
                return userDA.createUser(obj);
            }
            catch
            {
                throw;
            }
        }

        public DataTable verifyUserWhenLogin(UserBO obj)
        {
            try
            {
                UserDAL userDA = new UserDAL();
                DataTable dt = userDA.verifyUserWhenLogin(obj);
                return dt;
            }
            catch
            {
                throw;
            }
        }
    }
}
