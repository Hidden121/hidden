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
    public partial class Form2 : Form
    {
        int k;
        public Form2()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            switch (k)
            {
                case 0: Photo.ImageLocation = "30.png"; break;
                case 1: Photo.ImageLocation = "31.png"; break;
                case 2: Photo.ImageLocation = "30.png"; break;
                case 3: Photo.ImageLocation = "31.png"; break;
                default: k = 0; break;
            }
            k++;
            if (Photo.Left > Width) Photo.Left = -Photo.Width;
            Photo.Left = Photo.Left + 6;
        }

        private void переходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
