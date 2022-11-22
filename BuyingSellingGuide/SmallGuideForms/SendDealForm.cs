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
    public partial class SendDealForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        int carId;
        int carImages;
        Car car;
        int picturesCounter;
        Client client;
        public SendDealForm(int cartId)
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
            this.carId = cartId;
        }
        private bool DealInfo()
        {
            if (!Validation.CarValidation.LengthValidation(textBox1.Text, "Incorrect make!")) return false;
            else car.Make = textBox1.Text;
            if (!Validation.CarValidation.LengthValidation(textBox2.Text, "Incorrect model!")) return false;
            else car.Model = textBox2.Text;
            if (!Validation.CarValidation.CarRegNum(textBox3.Text, "Incorrect car registration number!")) return false;
            else car.CarRegNumber = textBox3.Text;
            if (!Validation.CarValidation.Year(dateTimePicker1.Value.Year, "Incorrect year!")) return false;
            else car.CarYear = dateTimePicker1.Value.Year;
            car.Fuel = (Fuel)Enum.Parse(typeof(Fuel), comboBox2.Text);
            if (!double.TryParse(textBox5.Text, out var kilometers))
            {
                MessageBox.Show("Incorrect kilometers!");
                return false;
            }
            else if (kilometers <= 0)
            {
                MessageBox.Show("Incorrect kilometers!");
                return false;
            }
            else car.Kilometers = kilometers;
            car.Condition = (Condition)Enum.Parse(typeof(Condition), comboBox3.Text);
            car.DealState = DealState.New;
            if (!Validation.CarValidation.LengthValidation(textBox6.Text, "Incorrect engine name!")) return false;
            else car.EngineName = textBox6.Text;
            if (!double.TryParse(textBox7.Text, out var enginePower))
            {
                MessageBox.Show("Incorrect engine power!");
                return false;
            }
            else if (enginePower <= 0)
            {
                MessageBox.Show("Incorrect engine power!");
                return false;
            }
            else car.EnginePower = enginePower;
            if (!double.TryParse(textBox8.Text, out var engineVolume))
            {
                MessageBox.Show("Incorrect engine volume!");
                return false;
            }
            else if (engineVolume <= 0)
            {
                MessageBox.Show("Incorrect  engine volume!");
                return false;
            }
            else car.EngineVolume = engineVolume;
            if (!decimal.TryParse(textBox10.Text, out var requaredPrice))
            {
                MessageBox.Show("Incorrect requared price!");
                return false;
            }
            else if (requaredPrice <= 0)
            {
                MessageBox.Show("Incorrect requared price!");
                return false;
            }
            else car.RequaredPrice= requaredPrice;
            car.Comment = richTextBox1.Text;
            if (checkBox1.Checked == true)
            {
                car.IsLuxury = true;
            }
            else
            {
                car.IsLuxury = false;
            }
            car.Comment = richTextBox1.Text;
            return true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
         
            if (DealInfo() == true)
            {
                context.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void Pictures()
        {

            dataGridView1.Rows.Clear();
            for (int i = 0; i < System.IO.Directory.GetFiles($"Img\\{carId}\\").Length; i++)
            {
                dataGridView1.Rows.Add();
                FileStream img = File.OpenRead(System.IO.Directory.GetFiles($"Img\\{carId}\\")[i]);
                dataGridView1.Rows[i].Cells[0].Value = new Bitmap(img);
                img.Close();
                picturesCounter++;
            }
            
        }
        private void SendDealForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName($"Img\\{carId}\\"));
            var imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Add(imageColumn);
            Pictures();
            ComboBoxLoad();
            car = context.Cars.Where(x => x.Id == carId).First();
            textBox1.Text = car.Make;
            textBox2.Text = car.Model;
            textBox3.Text = car.CarRegNumber;
            dateTimePicker1.Value = DateTime.ParseExact(car.CarYear.ToString(), "yyyy", null);
            comboBox2.Text = car.Fuel.ToString();
            textBox5.Text = car.Kilometers.ToString();
            comboBox3.Text = car.Condition.ToString();
            textBox6.Text = car.EngineName;
            textBox7.Text = car.EnginePower.ToString();
            textBox8.Text = car.EngineVolume.ToString();
            richTextBox1.Text = car.Comment;
            if (car.IsLuxury == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }



        }
        private void ComboBoxLoad()
        {
            var clients = context.Clients.ToList();
            for (int i = 0; i < clients.Count; i++)
            {
                string name = clients[i].Name + " " + clients[i].Surname + " " + "(" + clients[i].Id + ")";
                comboBox1.Items.Add(name);
            }
            car = context.Cars.Where(x => x.Id == carId).First();
            client = context.Clients.Where(x => x.Id == car.ClientId).First();
            comboBox1.Text = client.Name + " " + client.Surname + " " + "(" + client.Id + ")";
            comboBox1.Enabled = false;
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
        private void CarHistory()
        {
            History history = new History();
            history.CarId = car.Id;
            history.ClientId = car.ClientId;
            history.ClientName = client.Name;
            history.ClientSurname = client.Surname;
            history.CarMake = car.Make;
            history.CarModel = car.Model;
            history.CarRegNumber = car.CarRegNumber;
            history.DealTime=DateTime.Now;
            history.DealState = car.DealState;
            context.Historys.Add(history);
            context.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (DealInfo() == true)
            {
                carImages = System.IO.Directory.GetFiles($"Img\\{carId}\\").Length;
                if (carImages < 2)
                {
                    MessageBox.Show("You must load at least 2 car images!");
                    return;
                }
                car.DealState = DealState.ForPricing;
                context.SaveChanges();
                CarHistory();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)| *.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox9.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName($"Img\\{carId}\\"));
            string fileName= textBox9.Text.Split('\\').Last();
            if (File.Exists($"Img\\{carId}\\{fileName}")==true)
            {
                MessageBox.Show("Image with this name is already existing in this folder!");
                return;
            }
            File.Copy(textBox9.Text, Path.Combine($"Img\\{carId}", Path.GetFileName(textBox9.Text)),false);
            label13.Text = "Image file saved successfully!";
            Pictures();

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Bitmap selectedImg =(Bitmap) dataGridView1.CurrentRow.Cells[0].Value;
            CarImagesForm carImagesForm = new CarImagesForm(selectedImg);
            carImagesForm.ShowDialog();
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this picture?",
                    "Deletion", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    int row = (int)dataGridView1.CurrentCell.RowIndex;
                    string fileName = System.IO.Directory.GetFiles($"Img\\{carId}\\")[row];
                    picturesCounter--;
                    if (File.Exists(fileName))
                    {
                        try
                        {
                            dataGridView1.Rows.RemoveAt(row);
                            File.Delete(fileName);
                           
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("The deletion failed: {0}", ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Specified file doesn't exist");
                    }
                }
                catch (Exception ex)
                {
                    /// todo: log exception
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
