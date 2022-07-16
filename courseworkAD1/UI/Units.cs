using courseworkAD1.BLL;
using courseworkAD1.BusinessObjects;
using System;
using System.Data;
using System.Drawing;
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

        private void btnCustomersTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.customersTab();
        }

        private void btnProductsTb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.productsTab();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUnits addUnits = new AddUnits();
            addUnits.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void Units_Load(object sender, EventArgs e)
        {
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
