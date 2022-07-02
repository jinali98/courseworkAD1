using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using courseworkAD1.BusinessObjects;
using courseworkAD1.BLL;

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
                string userid = Guid.NewGuid().ToString();
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
            } catch
            {
                MessageBox.Show("Error Occurred");
            }
            


            
        }
    }
}
