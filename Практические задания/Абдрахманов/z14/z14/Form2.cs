using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z14
{
    public partial class Form2 : Form
    {
        int[] Mas1 = new int[15];
        int[] Mas2 = new int[15];
        int[] Mas3 = new int[15];
        int i2 = 0;
        int i3 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Generirovat_Click(object sender, EventArgs e)
        {
            Info.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                Mas1[i] = rand.Next(-10, 10);
                Info.Items.Add(Mas1[i]);
            }
        }

        private void Razdelit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (Mas1[i] > 0)
                {
                    i2++; Mas2[i2] = Mas1[i];
                    Info2.Items.Add(Mas2[i2]);
                }
                else if (Mas1[i] < 0)
                {
                    i3++; Mas2[i3] = Mas1[i];
                    Info3.Items.Add(Mas2[i3]);
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
     }
  }
