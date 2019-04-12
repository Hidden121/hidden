using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z19
{
    public partial class Form4 : Form
    {
        int k;
        public Form4()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            switch (k)
            {
                case 0: Photo.ImageLocation = "8.png"; break;
                case 1: Photo.ImageLocation = "9.png"; break;
                case 2: Photo.ImageLocation = "10.png"; break;
                case 3: Photo.ImageLocation = "11.png"; break;
                case 4: Photo.ImageLocation = "12.png"; break;
                case 5: Photo.ImageLocation = "13.png"; break;
                default: k = 0; break;
            }
            k++;

        }

        private void переходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }
    }
}
