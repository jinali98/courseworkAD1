using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace courseworkAD1.UI

{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 102);
            this.Size = new Size(800, 600);

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Color.AntiqueWhite;
                    ((Label)c).FlatStyle = FlatStyle.Flat;
                    ((Label)c).Font = new Font(Label.DefaultFont, FontStyle.Bold );

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

        // modify data grid view 
        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count * 4;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }
        // get the list of products and display in a data grid view
        private void displayData()
        {
            DataTable dt = new DataTable();
            ProductBLL productBLL = new ProductBLL();
            productBLL.viewAllProducts(dt);
            dgvProducts.DataSource = dt;
            sizeDGV(dgvProducts);

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

        // redirect to the add product form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            addStyles();
            displayData();
        }

       // admin user can enter a product id and delete a product
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

        private void btnUnitsTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.unitsTab();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
