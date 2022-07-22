using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace courseworkAD1.UI
{
    public partial class SingleJobView : Form
    {
        public string jobId;

        public SingleJobView(string jobid)
        {
            InitializeComponent();
            jobId = jobid;
           
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


        private void SingleJobView_Load(object sender, EventArgs e)
        {
            // on load the form get the job data and display
            addStyles();
            try
            {
                DataTable dtJob = new DataTable();
                DataTable dtLoad = new DataTable();
                DataTable dtUnit = new DataTable();


                // get the job data using the job id
                JobBO jobBO = new JobBO();
                jobBO.JobId = jobId;
                JobBLL jobBLL = new JobBLL();
                jobBLL.getJobByJobId(dtJob, jobBO);
                // get the assigend load data 
                LoadBO loadBO = new LoadBO();
                loadBO.Jobid = jobId;
                LoadBLL loadBLL = new LoadBLL();
                loadBLL.getLoadByJobId(dtLoad, loadBO);
                // check if there's a load assign. only if fetch adn display those data
                if ((dtLoad?.Rows?.Count ?? 0) > 0)
                {
                    // if the job has assigned a load get the associate unit details 
                    string unitid = dtLoad.Rows[0][3].ToString();
                    UnitsBO unitsBO = new UnitsBO();
                    unitsBO.Unitid = unitid;

                    UnitsBLL unitsBLL = new UnitsBLL();
                    unitsBLL.viewASignleUnit(unitsBO, dtUnit);

                    string driverName = dtUnit.Rows[0][1].ToString();
                    string assistantName = dtUnit.Rows[0][2].ToString();
                    string lorryNumber = dtUnit.Rows[0][3].ToString();
                    string containerNumber = dtUnit.Rows[0][4].ToString();

                    txtdriver.Text = driverName;
                    txtassistant.Text = assistantName;
                    txtlorry.Text = lorryNumber;
                    txtcontainer.Text = containerNumber;
                }

                string pickup = dtJob.Rows[0][1].ToString();
                string dropOff = dtJob.Rows[0][2].ToString();
                string productName = dtJob.Rows[0][4].ToString();
                string jobStatus = dtJob.Rows[0][6].ToString();
                string createdDate = dtJob.Rows[0][7].ToString();
                string contactNumber = dtJob.Rows[0][8].ToString();
                string userid = dtJob.Rows[0][9].ToString();

                txtjobid.Text = jobId;
                txtcontact.Text = contactNumber;
                txtdate.Text = createdDate;
                txtdropoff.Text = dropOff;
                txtpickup.Text = pickup;
                txtproduct.Text = productName;
                txtstatus.Text = jobStatus;
                txtuserid.Text = userid;

            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
                this.Hide();
                Jobs jobs = new Jobs();
                jobs.Show();
            
        }
    }
}
