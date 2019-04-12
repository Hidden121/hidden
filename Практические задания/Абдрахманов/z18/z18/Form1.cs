using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Photo_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Photo.Width = 10;
            
            }

        private void Time1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (Photo.Width < 50)
                Photo.Width = Photo.Width + 1; //увеличение размера звезды
            else
            {    //уменьшение и помещение в новое положение
                Photo.Width = 10;
                Photo.Top = rand.Next(0, Height);
                Photo.Left = rand.Next(0, Width);
            }
            if (Photo2.Width < 50)
                Photo2.Width = Photo2.Width + 1; //увеличение размера звезды
            else
            {    //уменьшение и помещение в новое положение
                Photo2.Width = 10;
                Photo2.Top = rand.Next(0, Height);
                Photo2.Left = rand.Next(0, Width);
            }
            if (Photo3.Width < 50)
                Photo3.Width = Photo3.Width + 1; //увеличение размера звезды
            else
            {    //уменьшение и помещение в новое положение
                Photo3.Width = 10;
                Photo3.Top = rand.Next(0, Height);
                Photo3.Left = rand.Next(0, Width);
            }
            if (Photo4.Width < 50)
                Photo4.Width = Photo4.Width + 1; //увеличение размера звезды
            else
            {    //уменьшение и помещение в новое положение
                Photo4.Width = 10;
                Photo4.Top = rand.Next(0, Height);
                Photo4.Left = rand.Next(0, Width);
            }
            if (Photo5.Width < 50)
                Photo5.Width = Photo5.Width + 1; //увеличение размера звезды
            else
            {    //уменьшение и помещение в новое положение
                Photo5.Width = 10;
                Photo5.Top = rand.Next(0, Height);
                Photo5.Left = rand.Next(0, Width);
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
