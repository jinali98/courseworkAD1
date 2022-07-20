using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using courseworkAD1.UI;
using System;
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
                UserBO obj = new UserBO();
                obj.Userid = userid;
                obj.Email = email;
                obj.Password = password;
                obj.Type = userType;

                UserBLL userBLL = new UserBLL();
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
    }
}
