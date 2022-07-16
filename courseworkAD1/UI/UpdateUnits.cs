using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Windows.Forms;


namespace courseworkAD1.UI
{
    public partial class UpdateUnits : Form
    {
        public UpdateUnits()
        {
            InitializeComponent();
        }

        private void UpdateUnits_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                string unitId = txtUnitId.Text;

                if (string.IsNullOrEmpty(unitId))
                {
                    MessageBox.Show("Please fill the input field");
                    return;
                }

                UnitsBO unitsBO = new UnitsBO();
                unitsBO.Unitid = unitId;
                DataTable dt = new DataTable();

                UnitsBLL unitsBLL = new UnitsBLL();
                unitsBLL.viewASignleUnit(unitsBO, dt);



                foreach (DataRow dr in dt.Rows)
                {

                    txtDriverName.Text = (dr["driverName"].ToString());
                    txtLorryNumber.Text = (dr["lorryNumber"].ToString());
                    txtContainerNumber.Text = (dr["containerNumber"].ToString());
                    txtAssistantName.Text = (dr["assistantName"].ToString());

                }

            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string unitId = txtUnitId.Text;
            string driverName = txtDriverName.Text;
            int lorryNumber = Convert.ToInt32(txtLorryNumber.Text);
            int containerNumber = Convert.ToInt32(txtContainerNumber.Text);
            string assistantName = txtAssistantName.Text;

            if (string.IsNullOrEmpty(driverName) || string.IsNullOrEmpty(assistantName) || string.IsNullOrEmpty(txtLorryNumber.Text) || string.IsNullOrEmpty(txtContainerNumber.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            UnitsBO unitsBO = new UnitsBO();
            unitsBO.Unitid = unitId;
            unitsBO.DriverName = driverName;
            unitsBO.LorryNumber = lorryNumber;
            unitsBO.AssistantName = assistantName;
            unitsBO.ContainerNumber = containerNumber;

            UnitsBLL unitsBLL = new UnitsBLL();
            unitsBLL.updateUnit(unitsBO);

            txtUnitId.Text = "";
            txtDriverName.Text = "";
            txtAssistantName.Text = "";
            txtLorryNumber.Text = "";
            txtContainerNumber.Text = "";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUnitId.Text = "";
            txtDriverName.Text = "";
            txtAssistantName.Text = "";
            txtLorryNumber.Text = "";
            txtContainerNumber.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Units units = new Units();
            units.Show();
        }
    }
}
