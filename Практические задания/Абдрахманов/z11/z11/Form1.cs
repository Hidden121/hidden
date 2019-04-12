using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Delimostna3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(Vvodtexta.Text);
                if (a % 3 == 0) { MessageBox.Show("Делится на 3"); }

                else
                {
                    MessageBox.Show("Не делится на 3");
                }
            }
            catch 
            {
                MessageBox.Show("Вы забыли ввести число");
            }


        }

        private void Delimostna2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(Vvodtexta.Text);
                if (a % 2 == 0) { MessageBox.Show("Делится на 2"); }

                else
                {
                    MessageBox.Show("Не делится на 2");
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }
        }

        private void Delimostna5_Click(object sender, EventArgs e)
        {
           try
            {
                int a = int.Parse(Vvodtexta.Text);
                if (a % 5 == 0) { MessageBox.Show("Делится на 5"); }

                else
                {
                    MessageBox.Show("Не делится на 5");
                }
            }
            catch 
            {
                MessageBox.Show("Вы забыли ввести число");
            }
        }
        private void Dalee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();

        }
    }
}
