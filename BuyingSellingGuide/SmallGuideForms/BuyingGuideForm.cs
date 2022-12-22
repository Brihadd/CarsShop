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

namespace BuyingSellingGuide.SmallGuideForms
{
    public partial class BuyingGuideForm : Form
    {
        DatabaseContext context=new DatabaseContext();
        private static BuyingGuideForm _instance;
        public static BuyingGuideForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new BuyingGuideForm();
            }

            return _instance;
        }
        public BuyingGuideForm()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            context = new DatabaseContext();
            if (comboBox1.SelectedIndex == 0)
            {
                carBindingSource.DataSource = context.Cars.Where(x => x.DealState == DealState.New).ToList();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                carBindingSource.DataSource = context.Cars.Where(x => x.DealState == DealState.ForPricing).ToList();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                carBindingSource.DataSource = context.Cars.Where(x => x.DealState == DealState.NotEnoughInformation).ToList();
            }
            else
            {
                carBindingSource.DataSource = context.Cars.Where(x => x.DealState == DealState.Priced).ToList();
            }
        }

        private void BuyingGuideForm_Load(object sender, EventArgs e)
        {
            
            RefreshGrid();
            for (int i = 0; i < 4; i++)
            {
                comboBox1.Items.Add(CarEnumToList.DealStateList[i].ToString());
            }
            comboBox1.Text = CarEnumToList.DealStateList[0].ToString();
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clients = context.Clients.FirstOrDefault();
            if (clients == null)
            {
                MessageBox.Show("You cannot create a deal because there are no clients in the database");
            }
            else
            {
                AddDealForm addDealForm = new AddDealForm();
                addDealForm.ShowDialog();

                if (addDealForm.DialogResult == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var carId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var selectedCar = context.Cars.Where(x => x.Id == carId).FirstOrDefault();
            if ((selectedCar.DealState == DealState.New)||(selectedCar.DealState == DealState.NotEnoughInformation))
            {
                SendDealForm sendDealForm = new SendDealForm(carId);
                sendDealForm.ShowDialog();

                if (sendDealForm.DialogResult == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            else if (selectedCar.DealState == DealState.ForPricing)
            {
                MessageBox.Show("Car is on pricing!");
            }
            else if (selectedCar.DealState == DealState.Priced)
            {
                PricedForm pricedForm = new PricedForm(carId);
                pricedForm.ShowDialog();

                if (pricedForm.DialogResult == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var idToRemove = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var dealToRemove = context.Cars.Where(x => x.Id == idToRemove).First();
            if (dealToRemove.DealState == DealState.New)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this deal?",
                        "Deletion", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        context.Cars.Remove(dealToRemove);
                        context.SaveChanges();
                        RefreshGrid();
                    }
                    catch (Exception ex)
                    {
                        /// todo: log exception
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("You can delete deal only with deal state new!");
                return;
            }
        }
    }
}
