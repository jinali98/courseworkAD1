using System;
using System.Drawing;
using System.Linq;
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
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            addStyles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }
    }
}
