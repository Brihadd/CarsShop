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
using CrmSystem.Validation;

namespace CrmSystem.SmallCRMForms
{
    public partial class AddEmployeesForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        public AddEmployeesForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            int ifAdmin;
           if (Status.AdminRighs(AppSettings.LoggedEmployee))
            {
                 ifAdmin = 0;
            }
           else
            {
                 ifAdmin = 1;
            }

           for(int i =ifAdmin;i<UserStatusList.AdminList.Count;i++)
            {
                comboBox1.Items.Add(UserStatusList.AdminList[i].ToString());
            }
            comboBox1.Text=UserStatusList.AdminList[UserStatusList.AdminList.Count-1].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            var alreadyRegisteredLogin = context.Employees.Where(x => x.Login == textBox3.Text).FirstOrDefault();
            if (alreadyRegisteredLogin != null)
            {
                MessageBox.Show("An employee with this login is already registered!");
                return;
            }
            if (!Validation.Validation.LengthValidation(textBox3.Text, "Login range must be between 3 and 50 characters!")) return;
            else employee.Login = textBox3.Text;
            if (!Validation.Validation.LengthValidation(textBox7.Text, "Password range must be between 3 and 50 characters!")) return;
            else employee.EmployeePassword= Password.HashPassword(textBox7.Text);
            if (!Validation.Validation.Name(textBox1.Text, "Incorrect name!")) return;
            else employee.Name = textBox1.Text;
            if (!Validation.Validation.Name(textBox2.Text, "Incorrect surname!")) return;
            else employee.Surname = textBox2.Text;
            employee.UserStatus=(UserStatus)Enum.Parse(typeof(UserStatus), comboBox1.Text);
            var alreadyRegisteredEmail = context.Employees.Where(x => x.Email == textBox4.Text).FirstOrDefault();
            if (alreadyRegisteredEmail != null)
            {
                MessageBox.Show("An employee with this email is already registered!");
                return;
            }
            if (!Validation.Validation.Email(textBox4.Text, "Incorrect email!")) return;
            else employee.Email = textBox4.Text;
            if (!Validation.Validation.BirthDate(dateTimePicker1.Value.Date, "Incorrect birth date!")) return;
            else employee.BirthDate = dateTimePicker1.Value.Date;
            employee.Deleted = false;
            context.Employees.Add(employee);
            context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

      
    }
}
