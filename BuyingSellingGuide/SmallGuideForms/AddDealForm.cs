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

namespace BuyingSellingGuide.SmallGuideForms
{
    public partial class AddDealForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        public AddDealForm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private void AddDealForm_Load(object sender, EventArgs e)
        {
            var clients=context.Clients.ToList();
            for (int i = 0; i < clients.Count; i++)
            {
                string name= clients[i].Name+" "+clients[i].Surname + " " + "(" +clients[i].Id+")";
                comboBox1.Items.Add(name);
            }
            comboBox1.Text = clients[0].Name + " " + clients[0].Surname + " " + "(" + clients[0].Id + ")";
            for (int i = 0; i < CarEnumToList.FuelList.Count; i++)
            {
                comboBox2.Items.Add(CarEnumToList.FuelList[i].ToString());
            }
            comboBox2.Text = CarEnumToList.FuelList[CarEnumToList.FuelList.Count - 1].ToString();
            for (int i = 0; i < CarEnumToList.ConditionList.Count; i++)
            {
                comboBox3.Items.Add(CarEnumToList.ConditionList[i].ToString());
            }
            comboBox3.Text = CarEnumToList.ConditionList[CarEnumToList.ConditionList.Count - 1].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.RequaredPrice = 0;
            car.ClientId = int.Parse(comboBox1.Text.Split('(', ')')[1]);
            if (!Validation.CarValidation.LengthValidation(textBox1.Text, "Incorrect make!")) return;
            else car.Make = textBox1.Text;
            if (!Validation.CarValidation.LengthValidation(textBox2.Text, "Incorrect model!")) return;
            else car.Model = textBox2.Text;
            if (!Validation.CarValidation.CarRegNum(textBox3.Text, "Incorrect car registration number!")) return;
            else car.CarRegNumber = textBox3.Text;
            if (!Validation.CarValidation.Year(dateTimePicker1.Value.Year, "Incorrect year!")) return;
            else car.CarYear = dateTimePicker1.Value.Year;
            car.Fuel = (Fuel)Enum.Parse(typeof(Fuel), comboBox2.Text);
            if (!double.TryParse(textBox5.Text, out var kilometers))
            {
                MessageBox.Show("Incorrect kilometers!");
                return;
            }
            else if (kilometers <= 0)
            {
                MessageBox.Show("Incorrect kilometers!");
                return;
            }
            else car.Kilometers = kilometers;
            car.Condition= (Condition)Enum.Parse(typeof(Condition), comboBox3.Text);
            car.DealState = DealState.New;
            if (!Validation.CarValidation.LengthValidation(textBox6.Text, "Incorrect engine name!")) return;
            else car.EngineName = textBox6.Text;
            if (!double.TryParse(textBox7.Text, out var enginePower))
            {
                MessageBox.Show("Incorrect engine power!");
                return;
            }
            else if (enginePower <= 0)
            {
                MessageBox.Show("Incorrect engine power!");
                return;
            }
            else car.EnginePower= enginePower;
            if (!double.TryParse(textBox8.Text, out var engineVolume))
            {
                MessageBox.Show("Incorrect engine volume!");
                return;
            }
            else if (engineVolume <= 0)
            {
                MessageBox.Show("Incorrect engine volume!");
                return;
            }
            else car.EngineVolume= engineVolume;

            if(checkBox1.Checked==true)
            {
                car.IsLuxury = true;
            }
            else
            {
                car.IsLuxury= false;
            }
            car.LastBuyerName = AppSettings.LoggedEmployee.Name + " " + AppSettings.LoggedEmployee.Surname;
            context.Cars.Add(car);
            context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
