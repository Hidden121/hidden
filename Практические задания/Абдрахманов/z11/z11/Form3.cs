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
                a = int.Parse(Vivod2.Text);    // Прочитали второе число          
                if (a == 10)
                {
                    sum++;
                    Vivod2.BackColor = Color.Green;
                }
                else
                {
                    Vivod2.BackColor = Color.Red;
                }
                a = int.Parse(Vivod3.Text);    // Прочитали второе число          
                if (a == 42)
                {
                    sum++;
                    Vivod3.BackColor = Color.Green;
                }
                else
                {
                    Vivod3.BackColor = Color.Red;
                }
                a = int.Parse(Vivod4.Text);    // Прочитали второе число          
                if (a == 20)
                {
                    sum++;
                    Vivod4.BackColor = Color.Green;
                }
                else
                {
                    Vivod4.BackColor = Color.Red;
                }
                a = int.Parse(Vivod5.Text);    // Прочитали второе число          
                if (a == 54)
                {
                    sum++;
                    Vivod5.BackColor = Color.Green;
                }
                else
                {
                    Vivod5.BackColor = Color.Red;
                }
                a = int.Parse(Vivod6.Text);    // Прочитали второе число          
                if (a == 32)
                {
                    sum++;
                    Vivod6.BackColor = Color.Green;
                }
                else
                {
                    Vivod6.BackColor = Color.Red;
                }
                a = int.Parse(Vivod7.Text);    // Прочитали второе число          
                if (a == 63)
                {
                    sum++;
                    Vivod7.BackColor = Color.Green;
                }
                else
                {
                    Vivod7.BackColor = Color.Red;
                }
                a = int.Parse(Vivod8.Text);    // Прочитали второе число          
                if ( a == 9)
                {
                    sum++;
                    Vivod8.BackColor = Color.Green;
                }
                else
                {
                    Vivod8.BackColor = Color.Red;
                }
                MessageBox.Show(sum.ToString());

                switch (sum)
                {
                    case 8: MessageBox.Show("отлично "); break;
                    case 7: MessageBox.Show("хорошо "); break;
                    case 6: MessageBox.Show("хорошо "); break;
                    case 5: MessageBox.Show("удовлетворительно "); break;
                    case 4: MessageBox.Show("удовлетворительно "); break;
                    default: MessageBox.Show("плохо "); break;

                }

            }
            catch
            {
                MessageBox.Show("Вы забыли ввести число");
            }

        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }
    }
}
