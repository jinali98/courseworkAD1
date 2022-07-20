using courseworkAD1.BLL;
using System;
using System.Data;
using System.Windows.Forms;
using courseworkAD1.BusinessObjects;

namespace courseworkAD1.UI
{
    public partial class CreateJob : Form
    {
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

        private void CreateJob_Load(object sender, EventArgs e)
        {
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
                Random number = new Random();

                string dropOff = txtDropOff.Text;
                int noOfLoads = Convert.ToInt32(txtNoOfLoads.Text);
                string contactNumber = txtNumber.Text;
                string pickup = txtPickup.Text;
                string jobid = number.Next(0, 100000).ToString() + "JOB";
                string productid = comboProducts.ValueMember;
                string productname = comboProducts.DisplayMember;

                JobBO jobBO = new JobBO();
                jobBO.ProductId = productid;
                jobBO.ProductName = productname;
                jobBO.ContactNumber = contactNumber;
                jobBO.DropOffLocation = dropOff;
                jobBO.PickupLocation = pickup;
                jobBO.NumberOfLoads = (noOfLoads);
                jobBO.Date = DateTime.UtcNow;
                jobBO.JobId = jobid;
                jobBO.JobStatus = "placed";
                jobBO.Userid = currentId;

                JobBLL jobBLL = new JobBLL();
                jobBLL.createNewJob(jobBO);


                resetFields();
            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }
    }
}
