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
    public partial class SearchForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        int historyId;
        int clientId;
        public SearchForm(int historyId)
        {
            InitializeComponent();
            this.historyId = historyId; 
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
         var history = context.Histories.Where(x => x.Id == historyId).First();
         var client = context.Clients.Where(x => x.Id == history.ClientId).First();
         clientId = client.Id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchClientForm searchClientForm = new SearchClientForm(clientId);
            searchClientForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchCarForm searchCarForm = new SearchCarForm(historyId);
            searchCarForm.ShowDialog();
        }
    }
}
