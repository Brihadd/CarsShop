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
            pictureBox1.Image = img;
        }
    }
}
