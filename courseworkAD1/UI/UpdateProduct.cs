using System;
using System.Drawing;
using System.Linq;
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

        // update the product details
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
        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            addStyles();
        }
    }
}
