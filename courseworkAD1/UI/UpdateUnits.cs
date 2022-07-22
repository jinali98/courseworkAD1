using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace courseworkAD1.UI
{
    public partial class UpdateUnits : Form
    {
        public UpdateUnits()
        {
            InitializeComponent();
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
        private void UpdateUnits_Load(object sender, EventArgs e)
        {
            addStyles();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // user can give the unit id and get the unit data
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


                // display units data in the form
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
            // user can provide values and update the unit
            string unitId = txtUnitId.Text;
            string driverName = txtDriverName.Text;
            int lorryNumber = Convert.ToInt32(txtLorryNumber.Text);
            int containerNumber = Convert.ToInt32(txtContainerNumber.Text);
            string assistantName = txtAssistantName.Text;

            // send an error if any field is empty
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
