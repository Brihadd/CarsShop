using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pricing.PricingSmallForms
{
    public partial class PricingForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        public PricingForm()
        {
            InitializeComponent();
        }

        private void PricingForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            context = new DatabaseContext();
            if (checkBox1.Checked == true)
            {
                carBindingSource.DataSource = context.Cars.Where(x => (x.DealState == DealState.ForPricing) && (x.IsLuxury == true)).ToList();
            }
            else
            {
                carBindingSource.DataSource = context.Cars.Where(x => (x.DealState == DealState.ForPricing) && (x.IsLuxury == false)).ToList();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void Enter()
        {
            var carId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var selectedCar = context.Cars.Where(x => x.Id == carId).FirstOrDefault();
            SelectedCarForm selectedCarForm = new SelectedCarForm(carId);
            selectedCarForm.ShowDialog();
            if (selectedCarForm.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (Status.LPEntryRights(AppSettings.LoggedEmployee))
                {
                    Enter(); 
                }
                else
                {
                    MessageBox.Show("You do not have access rights.");
                }
            }
            else
            {
                Enter();
            }

        }
    }
}
