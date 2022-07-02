using courseworkAD1.BusinessObjects;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                string cmd = "SELECT * FROM Users WHERE email='" + obj.Email + "' AND password='" + obj.Password + "'";

                dbConnection con = new dbConnection();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = con.readData(cmd, dt);

                adapter.Fill(dt);
                return dt;


            }
            catch
            {
                throw;
            }
        }

    }
}
