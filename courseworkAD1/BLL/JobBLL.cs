using courseworkAD1.BusinessObjects;
using courseworkAD1.DAL;
using System.Data;
using System.Windows.Forms;

namespace courseworkAD1.BLL
{
    public class JobBLL
    {
        public void createNewJob(JobBO obj)
        {

            try
            {
                JobDAL jobDAL = new JobDAL();
                jobDAL.createNewJob(obj);
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
                JobDAL jobDAL = new JobDAL();
                return jobDAL.updateJobStatus(obj);
            }
            catch
            {
                throw;
            }
        }


        public void viewListOfJobs(DataTable dt)
        {
            try
            {
                JobDAL jobDAL = new JobDAL();
                jobDAL.viewData(dt);

            }
            catch
            {
                throw;
            }
        }

        public void viewListOfJobsByUser(DataTable dt, JobBO obj)
        {
            try
            {
                JobDAL jobDAL = new JobDAL();
                jobDAL.viewJobsByUserid(dt, obj);

            }
            catch
            {
                throw;
            }
        }
        public void getJobByJobId(DataTable dt, JobBO obj)
        {
            try
            {
                JobDAL jobDAL = new JobDAL();
                jobDAL.viewJobByJobId(dt, obj);

            }
            catch
            {
                throw;
            }
        }

        public void getJobByJobStatus(DataTable dt, JobBO obj)
        {
            try
            {
                JobDAL jobDAL = new JobDAL();
                jobDAL.viewJobByJobsByStatus(dt, obj);

            }
            catch
            {
                throw;
            }
        }
    }
}
