using CrmSystem.SmallCRMForms;
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

namespace CrmSystem
{
    public partial class CRMform : Form
    {
        public CRMform()
        {
            
            InitializeComponent();
        }


        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Status.EntryRights(AppSettings.LoggedEmployee))
            {
                EmployeesForm employeesForm = EmployeesForm.GetInstance();
                employeesForm.MdiParent = this;
                employeesForm.WindowState = FormWindowState.Maximized;
                employeesForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access rights.");
            }    
        }

        private void cliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = ClientForm.GetInstance();
            clientForm.MdiParent = this;
            clientForm.WindowState = FormWindowState.Maximized;
            clientForm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        private void histiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = HistoryForm.GetInstance();
            historyForm.MdiParent = this;
            historyForm.WindowState = FormWindowState.Maximized;
            historyForm.Show();
        }
    }
}
