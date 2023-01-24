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
    public partial class BSGForm : Form
    {
        public BSGForm()
        {
            InitializeComponent();
        }

        private void buyingGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Status.BGEntryRights(AppSettings.LoggedEmployee))
            {
                BuyingGuideForm buyingGuideForm = BuyingGuideForm.GetInstance();
                buyingGuideForm.MdiParent = this;
                buyingGuideForm.WindowState = FormWindowState.Maximized;
                buyingGuideForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access rights.");
            }
        }

        private void sellingGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Status.SGEntryRights(AppSettings.LoggedEmployee))
            {
                SellingGuideForm sellingGuideForm = SellingGuideForm.GetInstance();
                sellingGuideForm.MdiParent = this;
                sellingGuideForm.WindowState = FormWindowState.Maximized;
                sellingGuideForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access rights.");
            }
        }

        private void BSGForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BSGForm_Load(object sender, EventArgs e)
        {
            this.Text = "User: " + AppSettings.LoggedEmployee.Name + " " + AppSettings.LoggedEmployee.Surname;
        }
    }
}
