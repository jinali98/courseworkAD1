using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
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
                DataTable dt = userBLL.verifyUserWhenLogin(obj);
                CurrentUserBO cuObj = new CurrentUserBO();


                if (dt.Rows[0][3].ToString() == "admin")
                {
                    cuObj.UseridCurrentUser = dt.Rows[0][0].ToString();
                    cuObj.EmailCurrentUser = dt.Rows[0][1].ToString();
                    cuObj.TypeCurrentUser = dt.Rows[0][3].ToString();
                    this.Hide();
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                else if (dt.Rows[0][3].ToString() == "user")
                {
                    cuObj.UseridCurrentUser = dt.Rows[0][0].ToString();
                    cuObj.EmailCurrentUser = dt.Rows[0][1].ToString();
                    cuObj.TypeCurrentUser = dt.Rows[0][3].ToString();
                    this.Hide();
                    UserDashboard userDashboard = new UserDashboard();
                    userDashboard.Show();
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

        private void btnRegConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
