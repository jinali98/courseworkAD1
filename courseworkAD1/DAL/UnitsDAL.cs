using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace courseworkAD1.DAL
{
    internal class UnitsDAL
    {
        public DialogResult createNewUnit(UnitsBO obj)
        {
            try
            {
                string cmd = "Insert into Units values ('" + (obj.Unitid) + "','" + obj.DriverName + "','" + obj.AssistantName + "','" + obj.LorryNumber + "','" + obj.ContainerNumber + "')";

                dbConnection con = new dbConnection();
                con.createAndUpdate(cmd);
                return MessageBox.Show("Successfully Added");

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
                string cmd = "UPDATE Units set driverName = '" + obj.DriverName + "' WHERE unitid = '" + (obj.Unitid) + "'";

                dbConnection con = new dbConnection();
                con.createAndUpdate(cmd);
                return MessageBox.Show("Successfully Updated");

            }
            catch
            {
                throw;
            }

        }

        public void viewData(DataTable dt)
        {
            string cmd = "select * from Units";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }

        public void viewAUnit(UnitsBO obj, DataTable dt)
        {
            string cmd = "select * from Units WHERE unitid=('" + (obj.Unitid) + "')";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["driverName"].ToString());
            }

        }


        public DialogResult deleteUnit(UnitsBO obj)
        {
            try
            {
                string cmd = "DELETE from Units WHERE unitid=('" + (obj.Unitid) + "')";

                dbConnection con = new dbConnection();
                con.deleteData(cmd);
                return MessageBox.Show("Successfully Removed");

            }
            catch
            {
                throw;
            }

        }
    }
}
