using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = txtProduct.Text.ToLower();

                if (string.IsNullOrEmpty(productName))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                Random number = new Random();
                ProductBO productBO = new ProductBO();
                productBO.ProductName = productName;
                productBO.ProductId = number.Next(0, 100000).ToString() + "PROD";

                ProductBLL productBLL = new ProductBLL();
                productBLL.createNewProduct(productBO);

                txtProduct.Text = "";

            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtProduct.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbProduct_Click(object sender, EventArgs e)
        {

        }

        private void regHeadingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
