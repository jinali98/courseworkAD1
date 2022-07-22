using courseworkAD1.BusinessObjects;
using courseworkAD1.DAL;
using System.Data;
using System.Windows.Forms;

namespace courseworkAD1.BLL
{
    public class LoadBLL
    {
        public DialogResult createANewLoad(LoadBO obj)
        {

            try
            {
                LoadDAL loadDAL = new LoadDAL();
                return loadDAL.createNewJob(obj);
            }
            catch
            {
                throw;
            }
        }
        public void viewListOfLoads(DataTable dt)
        {
            try
            {
                LoadDAL loadDAL = new LoadDAL();
                loadDAL.viewData(dt);

            }
            catch
            {
                throw;
            }
        }

        public void viewListOfLoadsByUser(DataTable dt, LoadBO obj)
        {
            try
            {
                LoadDAL loadDAL = new LoadDAL();
                loadDAL.viewLoadsByUserid(dt, obj);

            }
            catch
            {
                throw;
            }
        }
        public void getLoadByJobId(DataTable dt, LoadBO obj)
        {
            try
            {
                LoadDAL loadDAL = new LoadDAL();
                loadDAL.viewLoadByJobId(dt, obj);

            }
            catch
            {
                throw;
            }
        }
    }
}
