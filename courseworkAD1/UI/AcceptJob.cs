using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class AcceptJob : Form
    {
        // job id and user id stores the user's user id and selected job id.
        // this can be accessible from other methods in the class
        public string jobid = "";
        public string userid = "";
        public AcceptJob(string jobID)
        {
            InitializeComponent();
            jobid = jobID;
        }

        // this method has the styles for this form
        private void addStyles()
        {
            // add a back ground color
            this.BackColor = Color.FromArgb(51, 0, 102);
            // set height and width of the form
            this.Size = new Size(800, 600);

            // all the labes in the form control will assign similar styles
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    // add styles to the label text
                    ((Label)c).ForeColor = Color.AntiqueWhite;
                    ((Label)c).FlatStyle = FlatStyle.Flat;
                    ((Label)c).Font = new Font(Label.DefaultFont, FontStyle.Bold);

                }
            }

            // all the buttons in the windows form will have similar styles
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.Beige;
                button.Font = new Font(Button.DefaultFont, FontStyle.Bold);
                button.ForeColor = Color.Black;
                button.FlatStyle = FlatStyle.Flat;
                button.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void AcceptJob_Load(object sender, EventArgs e)
        {
            // when the form load it will call the addStyles method to add defined styles to the form
            addStyles();

            // creating a new data table instance unitsBll instance 
            DataTable dt = new DataTable();
            UnitsBLL unitsBLL = new UnitsBLL();
            // each time form get loaded call the viewAllUnits method to get the updated list of data
            unitsBLL.viewAllUnits(dt);
            // assign unit data to the drop down menu - combo box
            comboUnitId.ValueMember = "unitid";
            comboUnitId.DisplayMember = "unitid";
            comboUnitId.DataSource = dt;

            // use the jobid to fetch the userid of the user who created the job and assign that value to the 
            // uuserid varible
            DataTable dataTable = new DataTable();
            JobBLL jobBLL = new JobBLL();
            JobBO jobBO = new JobBO();
            jobBO.JobId = jobid;
            jobBLL.getJobByJobId(dataTable, jobBO);

            userid = dataTable.Rows[0][9].ToString();

            lbJobId.Text = jobid;

        }

        // hide the current form and display the Jobs form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jobs jobs = new Jobs();
            jobs.Show();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                // assign a unit and create a new load 
                Random number = new Random();
                LoadBO loadBO = new LoadBO();
                loadBO.Loadid = number.Next(0, 100000).ToString() + "LOAD";
                loadBO.Unitid = comboUnitId.Text;
                loadBO.Jobid = jobid;
                loadBO.Userid = userid;

                LoadBLL loadBLL = new LoadBLL();
                loadBLL.createANewLoad(loadBO);

                // update the job status after assigning a unit to a job
                JobBO jobBO = new JobBO();
                jobBO.JobId = jobid;
                jobBO.JobStatus = "accepted";
                JobBLL jobBLL = new JobBLL();
                jobBLL.updateJobStatus(jobBO);

            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }
    }
}
