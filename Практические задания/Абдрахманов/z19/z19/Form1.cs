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
    public partial class Form1 : Form
    {

        int dx = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (Photo.Left > Width) Photo.Left = -Photo.Width;
            Photo.Left = Photo.Left + 1;

            if (Photo2.Left > Width) Photo2.Left = -Photo2.Width;
            Photo2.Left = Photo2.Left - dx;
            
            if (Photo2.Left < -120)
            {
                Photo2.Left = 300;
            }

        }

        private void переходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
