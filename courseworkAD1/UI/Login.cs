using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtRegPassword.Text;
                string email = txtRegEmail.Text;

                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                UserBO obj = new UserBO();
                obj.Email = email;
                obj.Password = password;

                UserBLL userBLL = new UserBLL();
                Boolean isTrue = userBLL.verifyUserWhenLogin(obj);

                if (isTrue)
                {
                    MessageBox.Show("Loggedin");
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }
    }
}
