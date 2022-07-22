using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using courseworkAD1.UI;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace courseworkAD1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Random number = new Random();
            
                string userid = number.Next(0, 100000).ToString()+"USER";
                string userType = "user";
                string password = txtRegPassword.Text;
                string conPassword = txtConfirmPassword.Text;
                string email = txtRegEmail.Text;

                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(conPassword) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please fill all the fields to complete Registration process");
                    return;
                }
                // check the password length
                if(password.Length < 8)
                { 
                    MessageBox.Show("Password Should be Min 8 char long");
                    return;
                }
                UserBO obj = new UserBO();
                obj.Userid = userid;
                obj.Email = email;
                obj.Password = password;
                obj.Type = userType;

                // check wther the user email exists
                UserBLL userBLL = new UserBLL();
                DataTable dt = userBLL.verifyUserWhenRegistering(obj);
                if ((dt?.Rows?.Count ?? 0) > 0)
                {
                    MessageBox.Show("User Exist");
                    return;
                }


                    userBLL.saveNewUser(obj);

                

                this.Hide();
                UserDashboard userDashboard = new UserDashboard(userid, email, userType);
                userDashboard.Show();
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }




        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login login = new Login();
            login.Show();


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

        private void Registration_Load(object sender, EventArgs e)
        {
            addStyles();
        }
    }
}
