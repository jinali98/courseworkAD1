using courseworkAD1.BusinessObjects;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseworkAD1.DAL
{
    public class LoadDAL
    {
        public DialogResult createNewJob(LoadBO obj)
        {
            try
            {
                string cmd = "Insert into Loads values ('" + (obj.Loadid) + "','" + obj.Userid + "','" + obj.Jobid + "','" + obj.Unitid + "')";

                dbConnection con = new dbConnection();
                con.createAndUpdate(cmd);
                return MessageBox.Show("Successfully Added");

            }
            catch
            {
                throw;
            }

        }
        public void viewData(DataTable dt)
        {
            string cmd = "select * from Loads";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }

        public void viewLoadsByUserid(DataTable dt, LoadBO obj)
        {
            string cmd = "SELECT * from Loads WHERE userid = '" + (obj.Userid) + "'";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }

        public void viewLoadByJobId(DataTable dt, LoadBO obj)
        {
            string cmd = "SELECT * from Loads WHERE jobid = '" + (obj.Jobid) + "'";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }
    }
}
