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

                ProductBO productBO = new ProductBO();
                productBO.ProductName = productName;
                productBO.ProductId = Guid.NewGuid().ToString();

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
    }
}
