using courseworkAD1.BusinessObjects;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseworkAD1.DAL
{
    public class JobDAL
    {
        public void createNewJob(JobBO obj)
        {
            try
            {
                string cmd = "Insert into Job values ('" + (obj.JobId) + "','" + obj.PickupLocation + "','" + obj.DropOffLocation + "','" + obj.NumberOfLoads + "','" + obj.ProductName + "','" + obj.ProductId + "','" + obj.JobStatus + "','" + obj.Date + "','" + obj.ContactNumber + "','" + obj.Userid + "')";

                dbConnection con = new dbConnection();
                
                con.createAndUpdate(cmd);
            }
            catch
            {
                throw;
            }

        }

        public DialogResult updateJobStatus(JobBO obj)
        {
            try
            {
                string cmd = "UPDATE Job set jobStatus = '" + obj.JobStatus + "' WHERE jobId = '" + (obj.JobId) + "'";

                dbConnection con = new dbConnection();
                con.createAndUpdate(cmd);
                
                return MessageBox.Show("Successfully Updated the Job Status");

            }
            catch
            {
                throw;
            }

        }

        public void viewData(DataTable dt)
        {
            string cmd = "select * from Job";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }

        public void viewJobsByUserid(DataTable dt, JobBO obj)
        {
            string cmd = "SELECT * from Job WHERE userid = '" + (obj.Userid) + "'";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }

        public void viewJobByJobId(DataTable dt, JobBO obj)
        {
            string cmd = "SELECT * from Job WHERE jobId = '" + (obj.JobId) + "'";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }
        public void viewJobByJobsByStatus(DataTable dt, JobBO obj)
        {
            string cmd = "SELECT * from Job WHERE jobStatus = '" + (obj.JobStatus) + "'";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }

    }
}
