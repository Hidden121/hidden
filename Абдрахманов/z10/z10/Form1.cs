using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z10
{
    public partial class Form1 : Form
    {
        string num_pict;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num_pict = domainUpDown1.Text;
            Photo.ImageLocation = num_pict + ".jpg";

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            num_pict = domainUpDown1.Text;
            Photo.ImageLocation = num_pict + ".jpg";

        }

        private void наВесьРисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Photo.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void вернутьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Photo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void Vpered_Click(object sender, EventArgs e)
        {
            int n;
            if (num_pict != "4")
            {
                n = int.Parse(num_pict);
                n++;
                num_pict = n.ToString();
                Photo.ImageLocation = num_pict + ".jpg";
            }
            else
            {
                num_pict = "1";
                Photo.ImageLocation = num_pict + ".jpg";
            }

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            int n;
            if (num_pict != "1")
            {
                n = int.Parse(num_pict);
                n--;
                num_pict = n.ToString();
                Photo.ImageLocation = num_pict + ".jpg";
            }
            else
            {
                num_pict = "4";
                Photo.ImageLocation = num_pict + ".jpg";
            }
        }

        private void SlaidShow_Click(object sender, EventArgs e)
        {
            Time.Enabled = true;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(num_pict);
            if (n == 4)	//если был 4-й рисунок, начинаем сначала
            { n = 0; }
            n++;
            num_pict = n.ToString();
            Photo.ImageLocation = num_pict + ".jpg";

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Time.Enabled = false;
        }

        private void сменитьРисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            num_pict = rand.Next ;
            Photo.ImageLocation = num_pict + ".jpg";
        }
    }
}
