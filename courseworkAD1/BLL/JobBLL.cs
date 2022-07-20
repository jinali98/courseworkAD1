using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseworkAD1.BusinessObjects;
using courseworkAD1.DAL;
using System.Data;
using System.Windows.Forms;

namespace courseworkAD1.BLL
{
    public class JobBLL
    {
        public DialogResult createNewJob(JobBO obj)
        {

            try
            {
                JobDAL jobDAL = new JobDAL();
                return jobDAL.createNewJob(obj);
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
    }
}
