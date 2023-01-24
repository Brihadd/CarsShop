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
    public partial class HistoryForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        int clientId;
        int historyId;
        public HistoryForm(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;   
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            historyBindingSource.DataSource = context.Histories.Where(x=>x.ClientId==clientId).ToList();  
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var historyId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var history = context.Histories.Where(x => x.Id == historyId).First();
            if (history.DealState == DealState.Sold)
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

        private void HistoryForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width;
            dataGridView1.Height = this.Height;
        }
    }
}
