using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using courseworkAD1.BusinessObjects;

namespace courseworkAD1.DAL
{
    public class UserDAL
    {
        public DialogResult createUser(UserBO obj) 
        {
            try
            {
                string cmd = "Insert into Users values ('" + (obj.Userid) + "','" + obj.Email + "','" + obj.Password + "','" + obj.Type + "')";

                dbConnection con = new dbConnection();
                con.createAndUpdate(cmd);
                return MessageBox.Show("Successfully Registered");

            } catch
            {
                throw;
            }
           
        }

    }
}
