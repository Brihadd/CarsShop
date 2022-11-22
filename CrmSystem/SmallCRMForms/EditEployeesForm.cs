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
    public partial class EditEployeesForm : Form
    {
        int employeeId;
        Employee employee;
        DatabaseContext context = new DatabaseContext();
        public EditEployeesForm(int id)
        {
            InitializeComponent();
            employeeId = id;
        }
        public void ComboBoxLoad()
        {
            int IfAdmin;
            if (Status.AdminRighs(AppSettings.LoggedEmployee))
            {
                IfAdmin = 0;
            }
            else
            {
                IfAdmin = 1;
            }

            for (int i = IfAdmin; i < UserStatusList.AdminList.Count; i++)
            {
                comboBox1.Items.Add(UserStatusList.AdminList[i].ToString());
            }
        }

        private void EditEployeesForm_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();
            employee = context.Employees.Where(x => x.Id == employeeId).First();
            textBox1.Text = employee.Name;
            textBox2.Text = employee.Surname;
            comboBox1.Text=employee.UserStatus.ToString();
            textBox4.Text = employee.Email;
            textBox3.Text = employee.Login;
            dateTimePicker1.Value = employee.BirthDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alreadyRegisteredLogin = context.Employees.Where(x => x.Login == textBox3.Text).FirstOrDefault();
            if (!(alreadyRegisteredLogin == null || employee.Login == textBox3.Text))
            {
                MessageBox.Show("An employee with this login is already registered!");
                return;
            }
            if (!Validation.Validation.LengthValidation(textBox3.Text, "Login range must be between 3 and 50 characters!")) return;
            else employee.Login = textBox3.Text;
            if (!Validation.Validation.Name(textBox1.Text, "Incorrect name!")) return;
            else employee.Name = textBox1.Text;
            if (!Validation.Validation.Name(textBox2.Text, "Incorrect surname!")) return;
            else employee.Surname = textBox2.Text;
            employee.UserStatus = (UserStatus)Enum.Parse(typeof(UserStatus), comboBox1.Text);
             var alreadyRegisteredEmail = context.Employees.Where(x => x.Email == textBox4.Text).FirstOrDefault();
            if (!(alreadyRegisteredEmail == null || employee.Email == textBox4.Text))
            {
                MessageBox.Show("An employee with this email is already registered!");
                return;
            }
            if (!Validation.Validation.Email(textBox4.Text, "Incorrect email!")) return;
            else employee.Email = textBox4.Text;
            if (!Validation.Validation.BirthDate(dateTimePicker1.Value.Date, "Incorrect birth date!")) return;
            else employee.BirthDate = dateTimePicker1.Value.Date;
            employee.Deleted = false;
            context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
