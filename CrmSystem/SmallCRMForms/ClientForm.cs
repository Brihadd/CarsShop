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
    public partial class ClientForm : Form
    {
        DatabaseContext context;
        private static ClientForm _instance;
        public static ClientForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ClientForm();
            }

            return _instance;
        }
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width;
            RefreshGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientsForm addClientForm = new AddClientsForm();
            addClientForm.ShowDialog();

            if (addClientForm.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }
        private void RefreshGrid()
        {
            context = new DatabaseContext();
            clientBindingSource.DataSource = context.Clients.ToList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            EditClientsForm editClientsForm = new EditClientsForm(clientId);
            editClientsForm.ShowDialog();

            if (editClientsForm.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void ClientForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width;

        }
    }
}
