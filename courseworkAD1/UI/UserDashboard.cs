using System;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class UserDashboard : Form
    {
        public string currentId = "";
        public string currentEmail = "";
        public string currentType = "";

        public UserDashboard(string currentid, string email, string type)
        {
            InitializeComponent();
            currentId = currentid;
            currentEmail = email;
            currentType = type;
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {

            CreateJob createJob = new CreateJob(currentId, currentEmail, currentType);
            createJob.Show();
            this.Hide();
        }

        private void btnViewJobs_Click(object sender, EventArgs e)
        {
            JobsList jobsList = new JobsList(currentId, currentEmail, currentType);
            jobsList.Show();
            this.Hide();
        }
    }
}
