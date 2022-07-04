using courseworkAD1.BusinessObjects;
using courseworkAD1.DAL;
using System.Data;
using System.Windows.Forms;

namespace courseworkAD1.BLL
{
    public class ProductBLL
    {
        public DialogResult createNewProduct(ProductBO obj)
        {

            try
            {
                ProductDAL productDAL = new ProductDAL();
                return productDAL.createNewProduct(obj);
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
                ProductDAL productDAL = new ProductDAL();
                return productDAL.updateProduct(obj);
            }
            catch
            {
                throw;
            }
        }
        public DialogResult deleteProduct(ProductBO obj) {

            try
            {
                ProductDAL productDAL = new ProductDAL();
                return productDAL.deleteProduct(obj);
            }
            catch
            {
                throw;
            }

        }

        public void viewAllProducts(DataTable dt)
        {
            try
            {
                ProductDAL productDAL = new ProductDAL();
                productDAL.viewData(dt);

            }
            catch
            {
                throw;
            }
        }
    }
}
