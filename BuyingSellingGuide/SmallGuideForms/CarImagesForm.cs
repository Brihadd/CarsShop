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
    public partial class CarImagesForm : Form
    {
        Bitmap img;
        public CarImagesForm(Bitmap bmp)
        {
            InitializeComponent();
            img = bmp;
        }

        private void CarImagesForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
            pictureBox1.Width = img.Width;
            pictureBox1.Height = img.Height;
            this.Width = pictureBox1.Width;
            this.Height = pictureBox1.Height;
        }

        private void CarImagesForm_Resize(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height= this.Height;

        }
    }
}
