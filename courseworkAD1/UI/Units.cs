using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace courseworkAD1.UI
{
    public partial class Units : Form
    {
        public Units()
        {
            InitializeComponent();
        }
        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count * 4;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }
        // get a list of units from d db
        private void displayData()
        {
            DataTable dt = new DataTable();
            UnitsBLL unitsBLL = new UnitsBLL();
            unitsBLL.viewAllUnits(dt);
            dgvUnits.DataSource = dt;
            sizeDGV(dgvUnits);

        }

        private void btnHomeTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.homeTab();
        }

        private void btnJobsTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.jobsTab();
        }

        private void btnProductsTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.productsTab();
        }

        // redirect user to the  add units form 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUnits addUnits = new AddUnits();
            addUnits.Show();
        }

        // get the unit id and remove that unit from the db
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string unitId = txtUnitId.Text;
                // send an error if the field is empty
                if (string.IsNullOrEmpty(unitId))
                {
                    MessageBox.Show("Please fill the input field");
                    return;
                }

                UnitsBO unitsBO = new UnitsBO();
                unitsBO.Unitid = unitId;

                UnitsBLL unitsBLL = new UnitsBLL();
                unitsBLL.deleteUnit(unitsBO);

                txtUnitId.Text = "";

                displayData();
            }
            catch
            {
                MessageBox.Show("Error Occurred");

            }
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

        private void Units_Load(object sender, EventArgs e)
        {
            addStyles();
            displayData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            this.Hide();
            UpdateUnits updateUnits = new UpdateUnits();
            updateUnits.Show();


        }

    }
}
