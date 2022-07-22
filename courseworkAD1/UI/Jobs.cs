using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class Jobs : Form
    {
        public Jobs()
        {
            InitializeComponent();
        }

        // get lists of jobs and add to the data grid view 
        private void displayData()
        {
            DataTable dt = new DataTable();
            JobBLL jobBLL = new JobBLL();
            jobBLL.viewListOfJobs(dt);
            dgvJobs.DataSource = dt;

        }

        // admin user can enter the Job id and click on decline buttton to decline a Job
        private void btnDecline_Click(object sender, EventArgs e)
        {
            try
            {
                string jobid = txtJobId.Text;
                if (string.IsNullOrEmpty(jobid))
                {
                    MessageBox.Show("Please fill the input field");
                    return;
                }
                // when declining a job update the jobStatus
                JobBO jobBO = new JobBO();
                jobBO.JobId = jobid;
                jobBO.JobStatus = "declined";
                JobBLL jobBLL = new JobBLL();
                jobBLL.updateJobStatus(jobBO);

                txtJobId.Text = "";
                displayData();
            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }

        // user can enter the jobid and go accept a job
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string jobid = txtJobId.Text;
                if (string.IsNullOrEmpty(jobid))
                {
                    MessageBox.Show("Please fill the input field");
                    return;
                }

                txtJobId.Text = "";
                this.Hide();
                // close current form and open acceptJob form and pass the selected jobid to that form
                AcceptJob acceptJob = new AcceptJob(jobid);
                acceptJob.Show();
            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
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

        private void Jobs_Load(object sender, EventArgs e)
        {
            addStyles();
            try
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
                displayData();

            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }
        // if any job is completed admin can change the jobStatus to completed
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            try
            {
                string jobid = txtJobId.Text;
                if (string.IsNullOrEmpty(jobid))
                {
                    MessageBox.Show("Please fill the input field");
                    return;
                }

                JobBO jobBO = new JobBO();
                jobBO.JobId = jobid;
                jobBO.JobStatus = "completed";
                JobBLL jobBLL = new JobBLL();
                jobBLL.updateJobStatus(jobBO);

                txtJobId.Text = "";
                displayData();

            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }

        // admin can click on this button and view all the details of any job
        private void btnView_Click(object sender, EventArgs e)
        {
            string jobid = txtJobId.Text;
            if (string.IsNullOrEmpty(jobid))
            {
                MessageBox.Show("Please fill the input field");
                return;
            }

            this.Hide();
            // pass the entered job id to the next form
            SingleJobView singleJobView = new SingleJobView(jobid);
            singleJobView.Show();
        }

        private void btnProductsTb_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.productsTab();
        }
        private void btnHomeTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.homeTab();
        }


        private void btnUnitsTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.unitsTab();
        }
    }
}
