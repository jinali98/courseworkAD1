using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace courseworkAD1.UI

{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count * 4;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }
        private void displayData()
        {
            DataTable dt = new DataTable();
            ProductBLL productBLL = new ProductBLL();
            productBLL.viewAllProducts(dt);
            dgvProducts.DataSource = dt;
            sizeDGV(dgvProducts);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string productId = txtProductId.Text;

                if (string.IsNullOrEmpty(productId))
                {
                    MessageBox.Show("Please fill the input field");
                    return;
                }

                ProductBO productBO = new ProductBO();
                productBO.ProductId = productId;

                ProductBLL productBLL = new ProductBLL();
                productBLL.deleteProduct(productBO);

                txtProductId.Text = "";

                displayData();
            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Show();
        }

        private void btnHomeTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.homeTab();
        }

        private void btnJobsTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.jobsTab();
        }

        private void btnCustomersTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.customersTab();
        }

        private void btnUnitsTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.unitsTab();
        }
    }
}
