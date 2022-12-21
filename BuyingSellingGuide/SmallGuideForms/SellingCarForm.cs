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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BuyingSellingGuide.SmallGuideForms
{
    public partial class SellingCarForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        int carId;
        Car car;
        public SellingCarForm(int carId)
        {
            InitializeComponent();
            this.carId = carId;
        }
        private void SellingCarForm_Load(object sender, EventArgs e)
        {
       
            var clients = context.Clients.ToList();
            for (int i = 0; i < clients.Count; i++)
            {
                string name = clients[i].Name + " " + clients[i].Surname + " " + "(" + clients[i].Id + ")";
                comboBox1.Items.Add(name);
            }
            comboBox1.Text = clients[0].Name + " " + clients[0].Surname + " " + "(" + clients[0].Id + ")";
            GetPictures();
            car = context.Cars.Where(x => x.Id == carId).First();
            Client client = context.Clients.Where(x => x.Id == car.ClientId).First();
            label18.Text = car.Make;
            label19.Text = car.Model;
            label20.Text = car.CarRegNumber;
            label21.Text = car.CarYear.ToString();
            label22.Text = car.Fuel.ToString();
            label30.Text = car.LastBuyerName;
            label32.Text = car.LastPricerName;

            if (car.IsLuxury == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            checkBox1.Enabled = false;
            label24.Text = car.Kilometers.ToString();
            label25.Text = car.Condition.ToString();
            label26.Text = car.EngineName.ToString();
            label27.Text = car.EnginePower.ToString();
            label28.Text = car.EngineVolume.ToString();
            label17.Text = car.BuyPrice.ToString();
        }
        private void GetPictures()
        {
            var imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Add(imageColumn);
            for (int i = 0; i < System.IO.Directory.GetFiles($"Img\\{carId}\\").Length; i++)
            {
                dataGridView1.Rows.Add();
                FileStream img = File.OpenRead(System.IO.Directory.GetFiles($"Img\\{carId}\\")[i]);
                dataGridView1.Rows[i].Cells[0].Value = new Bitmap(img);
                img.Close();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PriceCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car.DealState = DealState.Sold;
            car.SellPrice = decimal.Parse(label17.Text);
            car.ClientCarBuyerId= int.Parse(comboBox1.Text.Split('(', ')')[1]);
            car.DealState=DealState.Sold;
            car.Discount = (int)numericUpDown1.Value;
            car.LastSallerName = AppSettings.LoggedEmployee.Name + " " + AppSettings.LoggedEmployee.Surname;
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
            context.Histories.Add(history);
            context.SaveChanges();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Bitmap selectedImg = (Bitmap)dataGridView1.CurrentRow.Cells[0].Value;
            CarImagesForm carImagesForm = new CarImagesForm(selectedImg);
            carImagesForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PriceCount();
        }
        private void PriceCount()
        {
            if (!decimal.TryParse(textBox1.Text, out var price))
            {
                MessageBox.Show("Incorrect  price!");
                return;
            }
            else if (price < 0)
            {
                MessageBox.Show("Incorrect  price!");
                return;
            }
            else
            {
                label17.Text = (price - (price / 100) * (int)numericUpDown1.Value).ToString();
            }
        }
    }
}
