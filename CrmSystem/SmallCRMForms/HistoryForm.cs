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

namespace CrmSystem.SmallCRMForms
{
    public partial class HistoryForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        private static HistoryForm _instance;
        public static HistoryForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new HistoryForm();
            }

            return _instance;
        }
        public HistoryForm()
        {
            InitializeComponent();
        }

   
        private void RefreshGrid()
        {
           context = new DatabaseContext();
           historyBindingSource.DataSource = context.Histories.Where(x => x.DealTime.Year == DateTime.Today.Year &&
           x.DealTime.Month == DateTime.Today.Month && x.DealTime.Day == DateTime.Today.Day).ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var historyId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var history = context.Histories.Where(x => x.Id == historyId).First();
            if(history.DealState==DealState.Sold)
            {
                SoldCarSearchForm soldCarSearchForm = new SoldCarSearchForm(historyId);
                soldCarSearchForm.ShowDialog();
            }
            else
            {
                SearchForm searchForm = new SearchForm(historyId);
                searchForm.ShowDialog();
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if(comboBox1.SelectedIndex == 0)historyBindingSource.DataSource=context.Histories.Where(x=>x.CarId.ToString().Contains(textBox1.Text)).ToList();
           else if(comboBox1.SelectedIndex==1) historyBindingSource.DataSource = context.Histories.Where(x => x.ClientId.ToString().Contains(textBox1.Text)).ToList();
           else if (comboBox1.SelectedIndex == 2) historyBindingSource.DataSource = context.Histories.Where(x => x.ClientName.Contains(textBox1.Text)).ToList();
           else if (comboBox1.SelectedIndex == 3) historyBindingSource.DataSource = context.Histories.Where(x => x.ClientSurname.Contains(textBox1.Text)).ToList();
           else if (comboBox1.SelectedIndex == 4) historyBindingSource.DataSource = context.Histories.Where(x => x.CarMake.Contains(textBox1.Text)).ToList();
           else if (comboBox1.SelectedIndex == 5) historyBindingSource.DataSource = context.Histories.Where(x => x.CarModel.Contains(textBox1.Text)).ToList();
           else if (comboBox1.SelectedIndex == 6) historyBindingSource.DataSource = context.Histories.Where(x => x.CarRegNumber.Contains(textBox1.Text)).ToList();
           else if (comboBox1.SelectedIndex == 7) historyBindingSource.DataSource = context.Histories.Where(x => x.DealTime.ToString().Contains(textBox1.Text)).ToList();
           else if (comboBox1.SelectedIndex == 8) historyBindingSource.DataSource = context.Histories.AsEnumerable().Where(x => x.DealState.ToString().ToLower().Contains(textBox1.Text.ToLower())).ToList(); 
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            comboBox1.SelectedIndex = 1;
            dataGridView1.Columns[7].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}
