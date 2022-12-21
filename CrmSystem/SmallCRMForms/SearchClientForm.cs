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
    public partial class SearchClientForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        int clientId;
        public SearchClientForm(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }

        private void SesrchClientForm_Load(object sender, EventArgs e)
        {
            var client=context.Clients.Where(x=> x.Id == clientId).First();
            label3.Text=client.Name;
            label5.Text = client.Surname;
            label7.Text = client.Email;
            label9.Text = client.BirthDate.ToShortDateString();

        }
    }
}
