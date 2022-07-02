using courseworkAD1.BusinessObjects;
using courseworkAD1.DAL;
using System;
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

        public bool verifyUserWhenLogin(UserBO obj)
        {
            try
            {
                UserDAL userDA = new UserDAL();
                DataTable dt = userDA.verifyUserWhenLogin(obj);
                Console.WriteLine(dt.Rows[0]);

                if (dt.Rows[0][3].ToString() == "user" || dt.Rows[0][3].ToString() == "admin")
                {
                    CurrentUserBO cuObj = new CurrentUserBO();
                    cuObj.UseridCurrentUser = dt.Rows[0][0].ToString();
                    cuObj.EmailCurrentUser = dt.Rows[0][1].ToString();
                    cuObj.TypeCurrentUser = dt.Rows[0][3].ToString();
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
