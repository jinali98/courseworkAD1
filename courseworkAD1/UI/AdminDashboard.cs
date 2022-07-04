using System;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnProductsTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.productsTab();
        }
    }
}
