using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace CommonForms
{
    public partial class LoginForm : Form
    {
        protected DatabaseContext context = new DatabaseContext();
        
        public LoginForm()
        {
    
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
            textUsername.Focus();
        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         textPassword.PasswordChar = '*';
            this.Width = 350;
            this.Height = 330;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
