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
            this.Width = textUsername.Width*2;
            this.Height = textUsername.Height*14;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            ClickButton(sender, e);
        }

        private void textUsername_KeyDown(object sender, KeyEventArgs e)
        {
            ClickButton(sender,e);
        }
        public void ClickButton(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            ClickButton(sender, e);
        }

  
    }
}
