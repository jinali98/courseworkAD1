using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseworkAD1.DAL;
using System.Windows.Forms;
using courseworkAD1.BusinessObjects;

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
    }
}
