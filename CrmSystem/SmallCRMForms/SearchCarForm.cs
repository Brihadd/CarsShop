﻿using Models;
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

namespace CrmSystem.SmallCRMForms
{
    public partial class SearchCarForm : Form
    {
        DatabaseContext context = new DatabaseContext();
        int historyId;
        int carId;
        public SearchCarForm( int histiryId)
        {
            InitializeComponent();
            this.historyId = histiryId;
        }

        private void GetPictures()
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
        private void SearchCarForm_Load(object sender, EventArgs e)
        {
            var history = context.Histories.Where(x => x.Id == historyId).First();
            carId = history.CarId;
            GetPictures();
            var car = context.Cars.Where(x => x.Id == carId).First();
            label18.Text = car.Make;
            label19.Text = car.Model;
            label20.Text = car.CarRegNumber;
            label21.Text = car.CarYear.ToString();
            label22.Text = car.Fuel.ToString();
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
            label29.Text = car.RequaredPrice.ToString();
            label23.Text = car.BuyPrice.ToString();
            label13.Text = car.Discount.ToString();
            label31.Text = car.SellPrice.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Bitmap selectedImg = (Bitmap)dataGridView1.CurrentRow.Cells[0].Value;
            CarImageForm carImagsForm = new CarImageForm(selectedImg);
            carImagsForm.ShowDialog();
        }
    }
}
