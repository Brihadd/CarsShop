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

namespace Pricing.PricingSmallForms
{
    public partial class CarImageForm : Form
    {
        Bitmap img;
        public CarImageForm(Bitmap img)
        {
            InitializeComponent();
            this.img = img; 
        }

        private void CarImageForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image=img;
            pictureBox1.Image = img;
            pictureBox1.Width = img.Width;
            pictureBox1.Height = img.Height;
            this.Width = pictureBox1.Width;
            this.Height = pictureBox1.Height;
        }

        private void CarImageForm_Resize(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
        }
    }
}
