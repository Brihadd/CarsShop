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

namespace Pricing.PricingSmallForms
{
    public partial class SelectedCarForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        int carId;
        Car car;
        public SelectedCarForm(int carId)
        {
            InitializeComponent();
            this.carId = carId;
        }

        private void Pictures()
        {
            var imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Add(imageColumn);
            // You need to write the path to the "Img" folder fromb the BuyingSellingGuide
            string path = @"C:\\Users\\Admin3\\OneDrive\\Рабочий стол\\Домашка\\play\\CarsShop\\BuyingSellingGuide\\bin\\Debug\\net5.0-windows\\";
            for (int i = 0; i < System.IO.Directory.GetFiles($"{path}Img\\{carId}\\").Length; i++)
            {
                dataGridView1.Rows.Add();
                FileStream img = File.OpenRead(System.IO.Directory.GetFiles($"{path}Img\\{carId}\\")[i]);
                dataGridView1.Rows[i].Cells[0].Value = new Bitmap(img);
                img.Close();
            }
        }
        private void SelectedCarForm_Load(object sender, EventArgs e)
        {
            Pictures();
            car = context.Cars.Where(x => x.Id == carId).First();
            Client client = context.Clients.Where(x=>x.Id==car.ClientId).First();
            label17.Text= client.Name + " " + client.Surname + " " + "(" + client.Id + ")";
            label18.Text = car.Make;
            label19.Text = car.Model;
            label20.Text = car.CarRegNumber;
            label21.Text = car.CarYear.ToString();
            label22.Text = car.Fuel.ToString();
            if(car.IsLuxury==true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            checkBox1.Enabled = false;
            richTextBox1.Text = car.Comment;
            label24.Text = car.Kilometers.ToString();
            label25.Text=car.Condition.ToString();
            label26.Text = car.EngineName.ToString();
            label27.Text = car.EnginePower.ToString();
            label28.Text = car.EngineVolume.ToString();
            label29.Text = car.RequaredPrice.ToString();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Bitmap selectedImg = (Bitmap)dataGridView1.CurrentRow.Cells[0].Value;
            CarImageForm carImagsForm = new CarImageForm(selectedImg);
            carImagsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            car.Comment = richTextBox1.Text;
            car.DealState = DealState.NotEnoughInformation;
            context.SaveChanges();
            CarHistory();
            this.DialogResult = DialogResult.OK;
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


        private void button1_Click(object sender, EventArgs e)
        {
            car.Comment = richTextBox1.Text;
            car.DealState = DealState.Priced;
            if (!decimal.TryParse(textBox9.Text, out var buyPrice))
            {
                MessageBox.Show("Incorrect buy price!");
                return;
            }
            else if (buyPrice <=0)
            {
                MessageBox.Show("Incorrect buy price!");
                return;
            }
            else car.BuyPrice= buyPrice;
            context.SaveChanges();
            CarHistory();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var clientId = car.ClientId;
            HistoryForm historyForm = new HistoryForm(clientId);
            historyForm.ShowDialog();
        }
    }
}
