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
    public partial class Form3 : Form
    {
        int k;
        public Form3()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            switch (k)
            {
                case 0: Photo.ImageLocation = "6.png"; break;
                case 1: Photo.ImageLocation = "7.png"; break;
                case 2: Photo.ImageLocation = "6.png"; break;
                case 3: Photo.ImageLocation = "7.png"; break;
                default: k = 0; break;
            }
            k++;
            if (Photo.Left > Width) Photo.Left = -Photo.Width;
            Photo.Left = Photo.Left + 6;
        }

        private void переходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }
    }
}
