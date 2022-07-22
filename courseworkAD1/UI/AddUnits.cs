using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace courseworkAD1.UI
{
    public partial class AddUnits : Form
    {
        public AddUnits()
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

        // this method set all the text fields to empty strings
        private void resetFields()
        {
            txtDriverName.Text = "";
            txtAssistantName.Text = "";
            txtLorryNumber.Text = "";
            txtContainerNumber.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add a new unit
            try
            {
                Random number = new Random();
                string driverName = txtDriverName.Text;
                string assistantName = txtAssistantName.Text;
                int lorryNumber = Convert.ToInt32(txtLorryNumber.Text);
                int containerNumber = Convert.ToInt32(txtContainerNumber.Text);
                string unitId = number.Next(0, 100000).ToString() + "UNIT";

                // check if any text fields are empty 
                if (string.IsNullOrEmpty(driverName) || string.IsNullOrEmpty(assistantName) || string.IsNullOrEmpty(txtLorryNumber.Text) || string.IsNullOrEmpty(txtContainerNumber.Text))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                // create an instance of unitsBO and set values
                UnitsBO unitsBO = new UnitsBO();
                unitsBO.DriverName = driverName;
                unitsBO.AssistantName = assistantName;
                unitsBO.LorryNumber = lorryNumber;
                unitsBO.ContainerNumber = containerNumber;
                unitsBO.Unitid = unitId;

                // send data to create a new unit
                UnitsBLL unitsBLL = new UnitsBLL();
                unitsBLL.createNewUnit(unitsBO);

                // after creating a unit reset the field values
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

        private void AddUnits_Load(object sender, EventArgs e)
        {
            addStyles();
        }
    }
}
