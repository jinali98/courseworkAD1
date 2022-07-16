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
    public class UnitsBLL
    {
        UnitsDAL unitsDAL = new UnitsDAL();
        public DialogResult createNewUnit(UnitsBO obj)
        {
            try
            {
                return unitsDAL.createNewUnit(obj);
            }
            catch
            {
                throw;
            }
        }
        public DialogResult updateUnit(UnitsBO obj)
        {

            try
            {
                return unitsDAL.updateUnit(obj);
            }
            catch
            {
                throw;
            }
        }
        public DialogResult deleteUnit(UnitsBO obj)
        {

            try
            {
                return unitsDAL.deleteUnit(obj);
            }
            catch
            {
                throw;
            }

        }

        public void viewASignleUnit(UnitsBO obj, DataTable dt)
        {

            try
            {
                 unitsDAL.viewAUnit(obj, dt);

            }
            catch
            {
                throw;
            }

        }

        public void viewAllUnits(DataTable dt)
        {
            try
            {
                unitsDAL.viewData(dt);

            }
            catch
            {
                throw;
            }
        }
    }
}
