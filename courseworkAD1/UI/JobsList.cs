﻿using System;
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
        public JobsList(string userid, string email = "", string type = "")
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

        private void JobsList_Load(object sender, EventArgs e)
        {
            // when the form load get the latest list of jobs and display using a data grid view
            addStyles();
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
