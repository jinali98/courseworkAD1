using courseworkAD1.BusinessObjects;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseworkAD1.DAL
{
    public class ProductDAL
    {
        public DialogResult createNewProduct(ProductBO obj)
        {
            try
            {
                string cmd = "Insert into Products values ('" + (obj.ProductId) + "','" + obj.ProductName + "')";

                dbConnection con = new dbConnection();
                con.createAndUpdate(cmd);
                return MessageBox.Show("Successfully Added");

            }
            catch
            {
                throw;
            }

        }

        public DialogResult updateProduct(ProductBO obj)
        {
            try
            {
                string cmd = "UPDATE Products set productName = '" + obj.ProductName + "' WHERE productid = '" + (obj.ProductId) + "'";

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
            string cmd = "select * from Products";
            dbConnection con = new dbConnection();
            SqlDataAdapter adapter = con.readData(cmd, dt);
            adapter.Fill(dt);

        }

        public DialogResult deleteProduct(ProductBO obj)
        {
            try
            {
                string cmd = "DELETE from Products WHERE productid=('" + (obj.ProductId) + "')";

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
