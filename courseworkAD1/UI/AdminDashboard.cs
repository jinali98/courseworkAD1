using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        // user click on any nav button to navigate to another form 
        private void btnProductsTb_Click(object sender, EventArgs e)
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

        private void btnJobsTb_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.jobsTab();
        }


        private void btnUnitsTb_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.unitsTab();

        }

        // to navigate to another form and view a report of all the accepted jobs
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobsReport acceptedJobs = new jobsReport("accepted");
            acceptedJobs.Show();
        }

        // to navigate to another form and view a report of all the declined jobs
        private void btndecline_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobsReport acceptedJobs = new jobsReport("declined");
            acceptedJobs.Show();
        }
        // to navigate to another form and view a report of all the completed jobs
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobsReport acceptedJobs = new jobsReport("completed");
            acceptedJobs.Show();
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
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            addStyles();
        }

        // this will close the widnows form application and end the process
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // user will be re directed to the login  form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
