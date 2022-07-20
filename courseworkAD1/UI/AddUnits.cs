using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Windows.Forms;


namespace courseworkAD1.UI
{
    public partial class AddUnits : Form
    {
        public AddUnits()
        {
            InitializeComponent();
        }

        private void resetFields()
        {
            txtDriverName.Text = "";
            txtAssistantName.Text = "";
            txtLorryNumber.Text = "";
            txtContainerNumber.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Random number = new Random();
                string driverName = txtDriverName.Text;
                string assistantName = txtAssistantName.Text;
                int lorryNumber = Convert.ToInt32(txtLorryNumber.Text);
                int containerNumber = Convert.ToInt32(txtContainerNumber.Text);
                string unitId = number.Next(0, 100000).ToString() + "UNIT";

                if (string.IsNullOrEmpty(driverName) || string.IsNullOrEmpty(assistantName) || string.IsNullOrEmpty(txtLorryNumber.Text) || string.IsNullOrEmpty(txtContainerNumber.Text))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                UnitsBO unitsBO = new UnitsBO();
                unitsBO.DriverName = driverName;
                unitsBO.AssistantName = assistantName;
                unitsBO.LorryNumber = lorryNumber;
                unitsBO.ContainerNumber = containerNumber;
                unitsBO.Unitid = unitId;

                UnitsBLL unitsBLL = new UnitsBLL();
                unitsBLL.createNewUnit(unitsBO);

                resetFields();


            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            resetFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Units units = new Units();
            units.Show();
        }
    }
}
