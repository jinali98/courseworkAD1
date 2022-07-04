using System;
using System.Windows.Forms;
using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
namespace courseworkAD1.UI
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = txtProduct.Text;
                string productId = txtProductId.Text;

                ProductBO productBO = new ProductBO();
                productBO.ProductName = productName;
                productBO.ProductId = productId;

                ProductBLL productBLL = new ProductBLL();
                productBLL.updateProduct(productBO);

                txtProduct.Text = "";
                txtProductId.Text = "";

            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtProduct.Text = "";
            txtProductId.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }
    }
}
