﻿using Models;
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
    public partial class AddClientsForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        public AddClientsForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (!Validation.Validation.Name(textBox1.Text, "Incorrect name!")) return;
            else client.Name = textBox1.Text;
            if (!Validation.Validation.Name(textBox2.Text, "Incorrect surname!")) return;
            else client.Surname = textBox2.Text;
            var alreadyRegisteredEmail = context.Clients.Where(x => x.Email == textBox4.Text).FirstOrDefault();
            if (alreadyRegisteredEmail != null)
            {
                MessageBox.Show("The Client with this email is already registered!");
                return;
            }
            if (!Validation.Validation.Email(textBox4.Text, "Incorrect email!")) return;
            else client.Email = textBox4.Text;
            if (!Validation.Validation.BirthDate(dateTimePicker1.Value.Date, "Incorrect birth date!")) return;
            else client.BirthDate = dateTimePicker1.Value.Date;
            context.Clients.Add(client);
            context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
