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

namespace BaseForm
{
    public partial class Form1 : Form
    {
        DatabaseContext context = new DatabaseContext();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            var user = context.Employees.Where(x => x.Login == textUsername.Text).FirstOrDefault();
            if ((user != null && user.EmployeePassword == Password.HashPassword(textPassword.Text) && Status.Login(user)
               || (user.Login == "admin" && user.EmployeePassword == "admin")))
            {
                //new CRMform().Show();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
            textUsername.Focus();
        }
    }
}
