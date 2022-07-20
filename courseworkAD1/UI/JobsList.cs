using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseworkAD1.BLL;

using System.Windows.Forms;
using courseworkAD1.BusinessObjects;

namespace courseworkAD1.UI
{
    public partial class JobsList : Form
    {
        public string currentId = "";
        public string currentEmail = "";
        public string currentType = "";
        public JobsList(string userid, string email, string type)
        {
            InitializeComponent();
            currentId = userid;
            currentEmail = email;
            currentType = type;
        }

        private void JobsList_Load(object sender, EventArgs e)
        {
            try
            {
                JobBLL jobBLL = new JobBLL();
                JobBO jobBO = new JobBO();
                DataTable dt = new DataTable();
                jobBO.Userid = currentId;
                jobBLL.viewListOfJobsByUser(dt,jobBO);
                dgvJobs.DataSource = dt;
                
            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard userDashboard = new UserDashboard(currentId, currentEmail, currentType);
            userDashboard.Show();
        }
    }
}
