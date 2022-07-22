using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void addStyles()
        {
            this.BackColor = Color.FromArgb(51, 0, 102);
            this.Size = new Size(800, 600);

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Color.AntiqueWhite;
                    ((Label)c).FlatStyle = FlatStyle.Flat;
                    ((Label)c).Font = new Font(Label.DefaultFont, FontStyle.Bold);

                }
            }

            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.Beige;
                button.Font = new Font(Button.DefaultFont, FontStyle.Bold);
                button.ForeColor = Color.Black;
                button.FlatStyle = FlatStyle.Flat;
                button.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // convert the value in to lowercase before stroing in d db
                string productName = txtProduct.Text.ToLower();

                // if the fields are empty throw an error msg.
                if (string.IsNullOrEmpty(productName))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                // create an instance of Random class to create a random number 
                Random number = new Random();
                // create an instance of ProductBo and set values 
                ProductBO productBO = new ProductBO();
                productBO.ProductName = productName;
                productBO.ProductId = number.Next(0, 100000).ToString() + "PROD";

                ProductBLL productBLL = new ProductBLL();
                // call method to send productBo instance to productBLL
                productBLL.createNewProduct(productBO);

                txtProduct.Text = "";

            }
            catch
            {
                // if there's any other error cathced thorw an error 
                MessageBox.Show("Error Occurred");
            }
        }

        // to cancel the process
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtProduct.Text = "";
        }

        // go back to the product page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            addStyles();
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
