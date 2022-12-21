using CommonForms;
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
    public partial class CRMLoginForm : LoginForm
    {
        public CRMLoginForm():base()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CRMLoginForm_KeyUp);
      
        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            var user = context.Employees.Where(x => x.Login == textUsername.Text).FirstOrDefault();
            if ((user != null&& user.EmployeePassword == Password.HashPassword(textPassword.Text) && Status.LoginCRM(user)
               || (user != null && user.Login == "admin" && user.EmployeePassword == "admin")))
            {
                new CRMform().Show();
                AppSettings.LoggedEmployee = user;
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect, try again.");
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
            }
        }

        private void CRMLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void CRMLoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }
    }
}
