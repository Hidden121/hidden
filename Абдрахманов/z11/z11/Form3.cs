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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Result_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                int a = int.Parse(Vivod.Text);      // Прочитали первое число    
                if (a == 6)
                {
                    sum++;
                    Vivod.BackColor = Color.Green;
                }
                else
                {
                    Vivod.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }
            try
            {
                int b = int.Parse(Vivod2.Text);    // Прочитали второе число          
                if (b == 10)
                {
                    sum++;
                    Vivod2.BackColor = Color.Green;
                }
                else
                {
                    Vivod2.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }
            try
            {
                int c = int.Parse(Vivod3.Text);    // Прочитали второе число          
                if (c == 42)
                {
                    sum++;
                    Vivod3.BackColor = Color.Green;
                }
                else
                {
                    Vivod3.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }
            try
            {
                int d = int.Parse(Vivod4.Text);    // Прочитали второе число          
                if (d == 20)
                {
                    sum++;
                    Vivod4.BackColor = Color.Green;
                }
                else
                {
                    Vivod4.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }
            try
            {
                int v = int.Parse(Vivod5.Text);    // Прочитали второе число          
                if (v == 54)
                {
                    sum++;
                    Vivod5.BackColor = Color.Green;
                }
                else
                {
                    Vivod5.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }

            try
            {
                int f = int.Parse(Vivod6.Text);    // Прочитали второе число          
                if (f == 32)
                {
                    sum++;
                    Vivod6.BackColor = Color.Green;
                }
                else
                {
                    Vivod6.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }
            try
            {
                int j = int.Parse(Vivod7.Text);    // Прочитали второе число          
                if (j == 63)
                {
                    sum++;
                    Vivod7.BackColor = Color.Green;
                }
                else
                {
                    Vivod7.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }
            try
            {
                int t = int.Parse(Vivod8.Text);    // Прочитали второе число          
                if (t == 9)
                {
                    sum++;
                    Vivod8.BackColor = Color.Green;
                }
                else
                {
                    Vivod8.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }

        }
    }
}
