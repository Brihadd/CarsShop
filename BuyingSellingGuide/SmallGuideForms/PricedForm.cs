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

namespace BuyingSellingGuide.SmallGuideForms
{
    public partial class PricedForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        int carId;
        Car car;
        public PricedForm(int carId)
        {
            InitializeComponent();
            this.carId = carId;
        }

        private void PricedForm_Load(object sender, EventArgs e)
        {
            car = context.Cars.Where(x => x.Id == carId).First();
            Client client = context.Clients.Where(x => x.Id == car.ClientId).First();
            label2.Text = client.Name + " " + client.Surname + " " + "(" + client.Id + ")";
            label3.Text = car.Make;
            label5.Text = car.Model;
            label7.Text = car.RequaredPrice.ToString();
            label9.Text = car.BuyPrice.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            car.DealState = DealState.Refused;
            context.SaveChanges();
            CarHistory();
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CarHistory()
        {
            History history = new History();
            Client client = context.Clients.Where(x => x.Id == car.ClientId).First();
            history.CarId = car.Id;
            history.ClientId = car.ClientId;
            history.ClientName = client.Name;
            history.ClientSurname = client.Surname;
            history.CarMake = car.Make;
            history.CarModel = car.Model;
            history.CarRegNumber = car.CarRegNumber;
            history.DealTime = DateTime.Now;
            history.DealState = car.DealState;
            context.Historys.Add(history);
            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car.DealState = DealState.Bought;
            context.SaveChanges();
            CarHistory();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
