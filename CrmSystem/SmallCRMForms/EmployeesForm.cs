using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmSystem.SmallCRMForms
{
    public partial class EmployeesForm : Form

    {
        DatabaseContext context;
        private static EmployeesForm _instance;
        public static EmployeesForm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new EmployeesForm();
            }

            return _instance;
        }
        public EmployeesForm()
        {
            InitializeComponent();
        


        }
        private void RefreshGrid()
        {
            context = new DatabaseContext();
            employeeBindingSource.DataSource = context.Employees.Where(x => x.Deleted == false).ToList();

        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width;
            RefreshGrid();
            var employees = context.Employees.ToList();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeesForm addEmployeeForm = new AddEmployeesForm();
            addEmployeeForm.ShowDialog();

            if (addEmployeeForm.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                employeeBindingSource.DataSource = context.Employees.ToList();
               

            }
            else
            {
                employeeBindingSource.DataSource = context.Employees.Where(x => x.Deleted == false).ToList();
            }
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empliyeeId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            EditEployeesForm editEployeesForm = new EditEployeesForm(empliyeeId);
            editEployeesForm.ShowDialog();

            if (editEployeesForm.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this employee?",
                    "Deletion", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    var idToRemove = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    var employeeToRemove = context.Employees.Where(x => x.Id == idToRemove).First();
                    employeeToRemove.Deleted = true;
                    context.SaveChanges();
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    /// todo: log exception
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EmployeesForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width;
           
        }
    }
}
