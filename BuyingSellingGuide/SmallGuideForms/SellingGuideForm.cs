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
    public partial class SellingGuideForm : Form
    {
        DatabaseContext context;
        private static SellingGuideForm _instance;
        public static SellingGuideForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new SellingGuideForm();
            }

            return _instance;
        }
        public SellingGuideForm()
        {
            InitializeComponent();
        }

        private void SellingGuideForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            context = new DatabaseContext();
            if (checkBox1.Checked == true)
            {
                carBindingSource.DataSource = context.Cars.Where(x => (x.DealState == DealState.Bought) && (x.IsLuxury == true)).ToList();
            }
            else
            {
                carBindingSource.DataSource = context.Cars.Where(x => (x.DealState == DealState.Bought) && (x.IsLuxury == false)).ToList();
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var carId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SellingCarForm sellingCarForm = new SellingCarForm(carId);
            sellingCarForm.ShowDialog();
            if (sellingCarForm.DialogResult == DialogResult.OK)
                {
                    RefreshGrid();
                }
  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void SellingGuideForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width;
        }
    }
}
