using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class CreateJob : Form
    {

        // public varibles which can be accssible from all the methods in the form
        public string currentId = "";
        public string currentEmail = "";
        public string currentType = "";
        public CreateJob(string userid, string email, string type)
        {
            InitializeComponent();
            currentId = userid;
            currentEmail = email;
            currentType = type;
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

        private void CreateJob_Load(object sender, EventArgs e)
        {
            addStyles();
            // fetch all the procucts from the db and add those to the combo box - drop down
            DataTable dt = new DataTable();
            ProductBLL productBLL = new ProductBLL();
            productBLL.viewAllProducts(dt);
            comboProducts.ValueMember = "productid";
            comboProducts.DisplayMember = "productName";
            comboProducts.DataSource = dt;
        }

        private void resetFields()
        {
            txtDropOff.Text = "";
            txtNoOfLoads.Text = "";
            txtNumber.Text = "";
            txtPickup.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        // navigate back to the user dashboard
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard userDashboard = new UserDashboard(currentId, currentEmail, currentType);
            userDashboard.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // crate an instance of Random class
                Random number = new Random();

                string dropOff = txtDropOff.Text;
                int noOfLoads = Convert.ToInt32(txtNoOfLoads.Text);
                string contactNumber = txtNumber.Text;
                string pickup = txtPickup.Text;
                string productid = comboProducts.SelectedValue.ToString();
                string productname = comboProducts.Text;

                // create an instance of JobBO and set values
                JobBO jobBO = new JobBO();
                jobBO.ProductId = productid;
                jobBO.ProductName = productname;
                jobBO.ContactNumber = contactNumber;
                jobBO.DropOffLocation = dropOff;
                jobBO.PickupLocation = pickup;
                jobBO.NumberOfLoads = noOfLoads;
                jobBO.Date = DateTime.UtcNow;
                jobBO.JobStatus = "placed";
                jobBO.Userid = currentId;

                JobBLL jobBLL = new JobBLL();
                // as user can enter number of loads from the product they selected 
                // create a Job for each procut load
                int numberOfJobs = 0;
                while (numberOfJobs < noOfLoads)
                {
                    string jobid = number.Next(0, 100000).ToString() + "JOB";
                    jobBO.JobId = jobid;

                    jobBLL.createNewJob(jobBO);
                    numberOfJobs++;
                }

                MessageBox.Show(noOfLoads + " Jobs has created Successfully.");

                resetFields();
            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }
    }
}
