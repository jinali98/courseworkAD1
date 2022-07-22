using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace courseworkAD1.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string useridCurrentUser = "";
        string emailCurrentUser = "";
        string typeCurrentUser = "";


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtRegPassword.Text;
                string email = txtRegEmail.Text;
                // if the fields are empty send the error msg
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                UserBO obj = new UserBO();
                obj.Email = email;
                obj.Password = password;

                // check whether the user credentails are correct
                UserBLL userBLL = new UserBLL();
                DataTable dt = userBLL.verifyUserWhenLogin(obj);
                CurrentUserBO cuObj = new CurrentUserBO();

                // check the user type. if the user type is admin re direct to the admin dashbaord 
                if (dt.Rows[0][3].ToString() == "admin")
                {
                     useridCurrentUser = dt.Rows[0][0].ToString();
                     emailCurrentUser = dt.Rows[0][1].ToString();
                     typeCurrentUser = dt.Rows[0][3].ToString();
                    this.Hide();
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                // if the user type is user re direct to the user to the dashboard
                else if (dt.Rows[0][3].ToString() == "user")
                {
                    useridCurrentUser = dt.Rows[0][0].ToString();
                    emailCurrentUser = dt.Rows[0][1].ToString();
                    typeCurrentUser = dt.Rows[0][3].ToString();
                    UserDashboard userDashboard = new UserDashboard(useridCurrentUser, emailCurrentUser, typeCurrentUser);
                    
                    userDashboard.Show();
                    this.Hide();
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

        // redirect to the registration form
        private void btnRegConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
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

        private void Login_Load(object sender, EventArgs e)
        {
           addStyles();
        }
    }
}
