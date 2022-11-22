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
    public partial class ChangePasswordForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((AppSettings.LoggedEmployee.EmployeePassword==Password.HashPassword(textBox1.Text))||AppSettings.LoggedEmployee.EmployeePassword=="admin")
            {
                var employee = context.Employees.Where(x => x.Id == AppSettings.LoggedEmployee.Id).First();
                if (!Validation.Validation.LengthValidation(textBox2.Text, "Password range must be between 3 and 50 characters!")) return;
                else employee.EmployeePassword = Password.HashPassword(textBox2.Text);
                context.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("An old password is wrong!");
                return;
            }
        }
    }
}
