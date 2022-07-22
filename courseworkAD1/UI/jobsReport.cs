using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class jobsReport : Form
    {
        public string jobStatus;
        public jobsReport(string status)
        {
            InitializeComponent();
            jobStatus = status;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();

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

        private void jobsReport_Load(object sender, EventArgs e)
        {
            // when the form load get a list of jobs matches the job status
            addStyles();
            try
            {
                DataTable dt = new DataTable();

                JobBLL jobBLL = new JobBLL();
                JobBO jobBO = new JobBO();
                jobBO.JobStatus = jobStatus;
                jobBLL.getJobByJobStatus(dt, jobBO);
                dgvJobs.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }
    }
}
